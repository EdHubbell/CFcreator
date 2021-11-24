using System;
using System.Collections.Specialized;
using System.IO;
using System.Xml.Serialization;
using XferPrintLib.Utility;
using XferPrintLib.Utility.Log;

namespace XferPrintLib.Configuration
{


    // TO ADD NEW PARAMETERS TO THE RECIPE
    // 1. Add the new parameters as a Public Property to one of the 6 Recipe Classes below, Declare the type and set a default value.  (IF UNSURE THEN COPY A VARIABLE WITH SIMILAR DATA TYPE AND CHANGE THE NAME)
    // 2. Add the new parameters to the SerializedXferPrintProcessRecipeSchema.xsd Schema. Found in XMLConfigFile Project. Be sure to add to the same class as this file.  (IF UNSURE THEN COPY A VARIABLE WITH SIMILAR DATA TYPE AND CHANGE THE NAME)
    // 3. Re-Save SerializedXferPrintProcessRecipeSchema.xsd as an embedded resource to XMLConfigFile
    // 1. Double Click on My Project under XMLConfigFile
    // 2. Click on Resources and use the drop-down arrow to ensure Files are selected in the top left (In side Resources Window, Next to "Application")
    // 3. Select SerializedXferPrintProcessRecipeSchema and then Click Remove Resource
    // 4. Click Add Resource and Select the updated SerializedXferPrintProcessRecipeSchema.xsd file to add.


    [Serializable]
    [XmlRoot("ProcessParameters")]
    public class XferPrintRecipe : XMLBaseObject
    {

        public RecipeParameters Recipe;
        public SourceParameters Source;
        public TargetParameters Target;
        public StampParameters Stamp;
        public CleanParameters Clean;
        public MetrologyParameters Metrology;
        public static StringCollection RecipeValMessages;
        public static bool ProcessRecipeLoaded;
        public static string PatternDirectory = @"C:\XferPrint\Patterns";
        public static string RecipeDirectory = @"C:\Autofile\ProcessRecipes";

        public bool Load(string RecipePath )
        {
            try
            {
                return ProcessRecipeReaderHelper.ImportSerializedRecipe(RecipePath);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        // End Class

        public sXYi GMUCount()
        {
            sXYi GMUCountRet = default;
            GMUCountRet.X = (int)Math.Round((double)(Stamp.StampXPostPitch / Source.SourceXChipletPitch));
            GMUCountRet.Y = (int)Math.Round((double)(Stamp.StampYPostPitch / Source.SourceYChipletPitch));
            

            return GMUCountRet;
        }

        public sXYd ConvertsDTPIndexToCoordinates(int index)
        {
            if (index == 0)
            {
                throw new ArgumentOutOfRangeException(
                    "ConvertsDTPIndexToCoordinates failed because Chip index was zero");
            }
            sXYd displacement;
            displacement.X = (index - 1) % GMUCount().X * Source.SourceXChipletPitch;
            displacement.Y = (index - 1) / GMUCount().X * Source.SourceYChipletPitch;

            return displacement;
        }

        public sXYd GetCleanPos(int R, int C, int I)
        {
            sXYd GetCleanPosRet;
            GetCleanPosRet.X = CalculateInitialCleanPosition(R, C).X + ConvertsDTPIndexToCoordinates(I).X;
            GetCleanPosRet.Y = CalculateInitialCleanPosition(R, C).Y + ConvertsDTPIndexToCoordinates(I).Y;

            // calc rotation
            double dx = PointHelper.RotateXCoord(GetCleanPosRet.X, GetCleanPosRet.Y, Source.SourceAlpha);
            double dy = PointHelper.RotateYCoord(GetCleanPosRet.X, GetCleanPosRet.Y, Source.SourceAlpha);
            // offset "backwards" for observer
            GetCleanPosRet.X = Clean.CleanXOrigin - dx;
            GetCleanPosRet.Y = Clean.CleanYOrigin - dy;
            return GetCleanPosRet;
        }

        public sXYd CalculateInitialCleanPosition(int R, int C)
        {
            if (R == 0)
            {
                throw new ArgumentOutOfRangeException("CalculateInitialCleanPosition failed because R is zero");
            }

            if (C == 0)
            {
                throw new ArgumentOutOfRangeException("CalculateInitialCleanPosition failed because C is zero");
            }
            sXYd GetCleanPosRet;
            if (CleanParameters.SavedCleaningLocation == SavedCleaningLocationType.Legacy)
            {
                GetCleanPosRet.X = (C - 1) * (Stamp.StampXPosts * Stamp.StampXPostPitch);
                GetCleanPosRet.Y = (R - 1) * (Stamp.StampYPosts * Stamp.StampYPostPitch);
            }
            else
            {
                // calc Clean position from origin and size of stamp
                GetCleanPosRet.X = (C - 1) * (Stamp.StampXPosts * Stamp.StampXPostPitch) +
                                   (Stamp.StampXPosts * Stamp.StampXPostPitch) / 2;
                GetCleanPosRet.Y = (R - 1) * (Stamp.StampYPosts * Stamp.StampYPostPitch) +
                                   (Stamp.StampYPosts * Stamp.StampYPostPitch) / 2;
            }

            return GetCleanPosRet;
        }


        public sXYd GetPrintPos(int clusterRow, int clusterColumn, int row, int column, int subRow, int subColumn )
        {
            sXYd GetPrintPosRet = default;
            try
            {
                GetPrintPosRet.X = (clusterColumn - 1) * Target.TargetXClusterPitch + 
                                   (column - 1) * Target.TargetXPrintPitch + 
                                   (subColumn - 1) * Stamp.StampXPostPitch;
                GetPrintPosRet.Y = (clusterRow - 1) * Target.TargetYClusterPitch + 
                                   (row - 1) * Target.TargetYPrintPitch + 
                                   (subRow - 1) * Stamp.StampYPostPitch;

                // calc rotation
                double dx = PointHelper.RotateXCoord(GetPrintPosRet.X, GetPrintPosRet.Y, Target.TargetAlpha);
                double dy = PointHelper.RotateYCoord(GetPrintPosRet.X, GetPrintPosRet.Y, Target.TargetAlpha);
                // offset "backwards" for observer
                GetPrintPosRet.X = Target.TargetR1C1XPosGlobal - dx;
                GetPrintPosRet.Y = Target.TargetR1C1YPosGlobal - dy;
            }
            catch (Exception ex)
            {
            }

            return GetPrintPosRet;
        }

        public sXYd GetGMU_R1C1I1Pos(sDTP commonFunctionsAndVarsDTP)
        {
            sXYd GetGMU_R1C1I1PosRet = default;
            double dx, dy;
            try
            {
                // Add location by appropriate cluster pitch
                dx = (commonFunctionsAndVarsDTP.Source.UserOriginGMU.RegionCol - 1) * Source.SourceXRegionsPitch + 
                     (commonFunctionsAndVarsDTP.Source.UserOriginGMU.Column - 1) * Source.SourceXClusterPitch;
                dy = (commonFunctionsAndVarsDTP.Source.UserOriginGMU.RegionRow - 1) * Source.SourceYRegionsPitch + 
                     (commonFunctionsAndVarsDTP.Source.UserOriginGMU.Row - 1) * Source.SourceYClusterPitch;

                // add location by appropriate chiplet pitch
                // calculate row number (n) and column (m) of index

                var displacement = ConvertsDTPIndexToCoordinates(commonFunctionsAndVarsDTP.Source.UserOriginGMU.Index);

                dx = dx + displacement.X;
                dy = dy + displacement.Y;
                // --"reverse" rotate
                GetGMU_R1C1I1PosRet.X = commonFunctionsAndVarsDTP.Source.UserOriginGMUPos.X + PointHelper.RotateXCoord(dx, dy, Source.SourceAlpha);
                GetGMU_R1C1I1PosRet.Y = commonFunctionsAndVarsDTP.Source.UserOriginGMUPos.Y + PointHelper.RotateYCoord(dx, dy, Source.SourceAlpha);
            }
            catch (Exception ex)
            {
                Logger.WriteEventLog("ERROR: Exception in GetGMU111 position: ", ex.Message);
            }

            return GetGMU_R1C1I1PosRet;
        }

        public sXYd GetGMUPos(int RR, int RC, int R, int C, int I)
        {
            sXYd GetGMUPosRet = default;
            try
            {
                // 19JAN11 Change R1C1Pos from function call (Get) to variable

                // calc GMU position
                GetGMUPosRet.X = (RC - 1) * Source.SourceXRegionsPitch + (C - 1) * Source.SourceXClusterPitch;
                GetGMUPosRet.Y = (RR - 1) * Source.SourceYRegionsPitch + (R - 1) * Source.SourceYClusterPitch;

                GetGMUPosRet.X = GetGMUPosRet.X + ConvertsDTPIndexToCoordinates(I).X;
                GetGMUPosRet.Y = GetGMUPosRet.Y + ConvertsDTPIndexToCoordinates(I).Y;

                // calc rotation
                double dx = PointHelper.RotateXCoord(GetGMUPosRet.X, GetGMUPosRet.Y, Source.SourceAlpha);
                double dy = PointHelper.RotateYCoord(GetGMUPosRet.X, GetGMUPosRet.Y, Source.SourceAlpha);
                // offset "backwards" for observer
                GetGMUPosRet.X = Source.SourceR1C1XPosGlobal - dx;
                GetGMUPosRet.Y = Source.SourceR1C1YPosGlobal - dy;
            }
            catch (Exception ex)
            {
                Logger.WriteEventLog("ERROR: Exception in GetGMUPos: ", ex.Message);
            }

            return GetGMUPosRet;
        }

    }

}