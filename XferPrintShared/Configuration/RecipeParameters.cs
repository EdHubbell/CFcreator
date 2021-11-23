using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace XferPrintLib.Configuration
{
    [Serializable]
    [XmlRoot("ProcessParameters")]
    // Inherits XferPrintRecipe
    // ? Add property for comment at top of view - to be seen in editor -- for example SW version ,etc.
    public class RecipeParameters : XMLBaseObject
    {
        [Browsable(false)]
        public string Name { get; set; } = "DefaultRecipe";
        [Browsable(false)]
        public string Comment { get; set; } = "Comment";
        [Browsable(false)]
        public double RecipeXYSpeed { get; set; } = 2d;
        [Browsable(false)]
        public double RecipeThetaSpeed { get; set; } = 0.2d;
        [Browsable(false)]
        public double RecipeZSpeed { get; set; } = 2d;
        [Browsable(false)]
        public double RecipeZClearanceHeight { get; set; } = 0d;
        [Browsable(false)]
        public short RecipeAutoCleanEnable { get; set; } = 0;
        [Browsable(false)]
        public short RecipeSimCycleEnable { get; set; } = 0;
        [Browsable(false)]
        public short RecipeSourceAlignEnable { get; set; } = 0;
        [Browsable(false)]
        public short RecipeAutoAlignEnable { get; set; } = 0;
        [Browsable(false)]
        public bool RecipeAutoAlignDeselectEnable { get; set; } = false;
        [Browsable(false)]
        public bool RecipeSourceAlign_AutoChipEnable { get; set; } = false;
        [Browsable(false)]
        public bool RecipeAutoAlign_autoChipEnable { get; set; } = false;
        [Browsable(false)]
        public bool RecipeSourceAlign_NoAssistEnable { get; set; } = false;
        [Browsable(false)]
        public bool RecipeAutoAlign_NoAssistEnable { get; set; } = false;
        [Browsable(false)]
        public bool RecipeSourceSingleAutoChipEnable { get; set; } = true;
        [Browsable(false)]
        public bool RecipeSourceAutoRotationEnable { get; set; } = false;
        [Browsable(false)]
        public bool RecipeAutoRotationEnable { get; set; } = false;
        [Browsable(false)]
        public bool RecipeSingleAutoChipEnable { get; set; } = true;
        [Browsable(false)]
        public short RecipeHeatedTarget { get; set; } = 0;
        [Browsable(false)]
        public double Version { get; set; } = 8.1d;
        [Browsable(false)]
        public short RecipePostPrintMetroEnable { get; set; } = 0;
        [Browsable(false)]
        public short PostPrintMetroFrequency { get; set; } = 1;
        [Browsable(false)]
        public short PickUpMetroFrequency { get; set; } = 1;
        [Browsable(false)]
        public short RecipePickUpMetroEnabled { get; set; } = 0;
        [Browsable(false)]
        public short SourceAlignFrequency { get; set; } = 1;
        [Browsable(false)]
        public int SearchRegionXOrigin { get; set; } = 0;
        [Browsable(false)]
        public int SearchRegionYOrigin { get; set; } = 0;
        [Browsable(false)]
        public int SearchRegionWidth { get; set; } = 200;
        [Browsable(false)]
        public int SearchRegionHeight { get; set; } = 100;
        [Browsable(false)]
        public int Alignment_Row_Column { get; set; } = 1;
        [Browsable(false)]
        public short Alignment_Ver_Hor { get; set; } = 0;
        [Browsable(false)]
        public short Alignment_EWC_TBC { get; set; } = 1;
        [Browsable(false)]
        public bool UseSpiralSearch { get; set; } = false;
        [Browsable(false)]
        public bool UseRegAutoFocus { get; set; } = false;
        [Browsable(false)]
        public bool UsePostTracking { get; set; } = false;

        public static RecipeParameters Load(string RecipePath)
        {
            RecipeParameters oXferPrintRecipe = null;
            try
            {
                // logger.Debug("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name)
                var serializer = new XmlSerializer(typeof(RecipeParameters));

                // Could do some handling here, but I don't think it buys us much. There are .UnknownNode, .UnknownElement, and a few other .Unknown methods.
                // AddHandler serializer.UnknownNode

                var reader = new StreamReader(RecipePath);
                oXferPrintRecipe = (RecipeParameters)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            // logger.[Error](ex)
            finally
            {
                // logger.Debug("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name)
            }

            return oXferPrintRecipe;
        }
    }
}