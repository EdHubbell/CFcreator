using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XferPrintLib.Configuration
{
    [Serializable]
    [XmlRoot("ProcessParameters")]
    public class MetrologyParameters : XMLBaseObject
    {
        [Browsable(false)]
        public double MetrologyXOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double MetrologyYOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double MetrologyZOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double MetrologyAlpha { get; set; } = 999d;
        [Browsable(false)]
        public double MetrologyXYSpeed { get; set; } = 10d;
        [Browsable(false)]
        public double MetrologyZOpticsSpeed { get; set; } = 0.5d;
        [Browsable(false)]
        public double MetrologyFocusHeight { get; set; } = 0d;
        [Browsable(false)]
        public double MetroPassThreshold { get; set; } = 0.0015d;
        [Browsable(false)]
        public int MetroIllumHi { get; set; } = 19;
        [Browsable(false)]
        public double MetroExposureHi { get; set; } = 2d;
        [Browsable(false)]
        public double MetroContrastHi { get; set; } = 0.05d;
        [Browsable(false)]
        public int MetroIllumLo { get; set; } = 19;
        [Browsable(false)]
        public double MetroExposureLo { get; set; } = 2d;
        [Browsable(false)]
        public double MetroContrastLo { get; set; } = 0.05d;
        [Browsable(false)]
        [XmlIgnore]
        public bool MetroTBlockInUse { get; set; } = false;
        [Browsable(false)]
        [XmlElement("MetroTBlockInUse")]
        public string MetroTBlockInUse_Ser
        {
            get
            {
                return Convert.ToString(MetroTBlockInUse);
            }

            set
            {
                if (value.Equals("True"))
                {
                    MetroTBlockInUse = true;
                }
                else if (value.Equals("False"))
                {
                    MetroTBlockInUse = false;
                }
                else
                {
                    MetroTBlockInUse = XmlConvert.ToBoolean(value);
                }
            }
        }
        [Browsable(false)]
        public double MetroBrightnessHi { get; set; } = 0.5d;
        [Browsable(false)]
        public double MetroBrightnessLo { get; set; } = 0.5d;
        [Browsable(false)]
        public string MetroTBlockFilename { get; set; } = @"C:\XferPrint\Patterns\TB_Beta.vpp";
        [Browsable(false)]
        [XmlIgnore]
        public bool MetroEnableOffset { get; set; } = false;
        [Browsable(false)]
        [XmlElement("MetroEnableOffset")]
        public string MetroEnableOffset_Ser
        {
            get
            {
                return Convert.ToString(MetroEnableOffset);
            }

            set
            {
                if (value.Equals("True"))
                {
                    MetroEnableOffset = true;
                }
                else if (value.Equals("False"))
                {
                    MetroEnableOffset = false;
                }
                else
                {
                    MetroEnableOffset = XmlConvert.ToBoolean(value);
                }
            }
        }

        [Browsable(false)]
        public double MetroXOffset { get; set; } = 1d;
        [Browsable(false)]
        public double MetroZOffset { get; set; } = 1d;

        public static MetrologyParameters Load(string RecipePath)
        {
            MetrologyParameters oXferPrintRecipe = null;
            try
            {
                // logger.Debug("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name)
                var serializer = new XmlSerializer(typeof(MetrologyParameters));

                // Could do some handling here, but I don't think it buys us much. There are .UnknownNode, .UnknownElement, and a few other .Unknown methods.
                // AddHandler serializer.UnknownNode

                var reader = new StreamReader(RecipePath);
                oXferPrintRecipe = (MetrologyParameters)serializer.Deserialize(reader);
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