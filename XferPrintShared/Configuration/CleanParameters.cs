using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace XferPrintLib.Configuration
{
    [Serializable]
    [XmlRoot("ProcessParameters")]
    public class CleanParameters : XMLBaseObject
    {
        public static SavedCleaningLocationType SavedCleaningLocation = SavedCleaningLocationType.Automated;

        [Browsable(false)]
        public double CleanXOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double CleanYOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double CleanZOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double CleanFocusHeight { get; set; } = 0d;
        [Browsable(false)]
        public double CleanPeelSpeed { get; set; } = 0.005d;
        [Browsable(false)]
        public double CleanZODSpeed { get; set; } = 0.005d;
        [Browsable(false)]
        public double CleanShearX { get; set; } = 0.02d;
        [Browsable(false)]
        public double CleanShearY { get; set; } = 0.02d;
        [Browsable(false)]
        public double CleanShearSpeed { get; set; } = 0.02d;
        [Browsable(false)]
        public double CleanShearDuration { get; set; } = 5d;
        [Browsable(false)]
        public double CleanZOD { get; set; } = 0.001d;
        [Browsable(false)]
        public double CleanThetaXPosition { get; set; } = 0d;
        [Browsable(false)]
        public double CleanThetaYPosition { get; set; } = 0d;
        [Browsable(false)]
        public double HS_ZOrigin { get; set; } = 0d;
        [Browsable(false)]
        public double HS_ZOrigin_WorkingHeight { get; set; } = -0.1d;
        [Browsable(false)]
        public double HS_FocusHeight { get; set; } = 0d;
        [Browsable(false)]
        public double HS_ScanSpeed { get; set; } = AppConfiguration.PrConfig.XYSpeedF;
        [Browsable(false)]
        public int HS_ScanDirection { get; set; } = (int)XferPrintLib.HSPathAlgorithms.X;
        [Browsable(false)]
        public double HS_ScanStep { get; set; } = 15d;
        [Browsable(false)]
        public int AutoCleanFreq { get; set; } = 1;

        public static CleanParameters Load(string RecipePath)
        {
            CleanParameters oXferPrintRecipe = null;
            try
            {
                var serializer = new XmlSerializer(typeof(CleanParameters));

                var reader = new StreamReader(RecipePath);
                oXferPrintRecipe = (CleanParameters)serializer.Deserialize(reader);
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