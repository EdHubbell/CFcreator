using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XferPrintLib.Configuration
{
    [Serializable]
    [XmlRoot("ProcessParameters")]
    public class SourceParameters : XMLBaseObject
    {
        [Browsable(false)]
        public double SourceXOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double SourceYOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double SourceZOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double SourceAlpha { get; set; } = 999d;
        [Browsable(false)]
        public double SourceBeta { get; set; } = 999d;
        [Browsable(false)]
        public double SourceFocusHeight { get; set; } = 0d;
        [Browsable(false)]
        public int SourceXClusters { get; set; } = 999;
        [Browsable(false)]
        public int SourceYClusters { get; set; } = 999;
        [Browsable(false)]
        public double SourceXClusterPitch { get; set; } = 9d;
        [Browsable(false)]
        public double SourceYClusterPitch { get; set; } = 9d;
        [Browsable(false)]
        public int SourceXChiplets { get; set; } = 999;
        [Browsable(false)]
        public int SourceYChiplets { get; set; } = 999;
        
        private double _sourceXChipletPitch = 0.07d;
        [Browsable(false)]
        public double SourceXChipletPitch {
            get
            {
                return _sourceXChipletPitch;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("SourceXChipletPitch can never be zero");
                }

                _sourceXChipletPitch = value;
            }
        }

        private double _sourceYChipletPitch = 0.05d;

        [Browsable(false)]
        public double SourceYChipletPitch
        {
            get
            {
                return _sourceYChipletPitch;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("SourceYChipletPitch can never be zero");
                }

                _sourceYChipletPitch = value;
            }
        }
        [Browsable(false)]
        public double PatternSourceAcceptThreshold { get; set; } = 0.3d;
        [Browsable(false)]
        public double PatternSourceAngleLow { get; set; } = -3;
        [Browsable(false)]
        public double PatternSourceAngleHigh { get; set; } = 3d;
        [Browsable(false)]
        public double PatternSourceOffsetX { get; set; } = 0d;
        [Browsable(false)]
        public double PatternSourceOffsetY { get; set; } = 0d;
        [Browsable(false)]
        public double PatternSourceScaleXLow { get; set; } = 0.9d;
        [Browsable(false)]
        public double PatternSourceScaleXHigh { get; set; } = 1.1d;
        [Browsable(false)]
        public double PatternSourceScaleYLow { get; set; } = 0.9d;
        [Browsable(false)]
        public double PatternSourceScaleYHigh { get; set; } = 1.1d;
        [Browsable(false)]
        public string PatternSourceFilename { get; set; } = @"C:\XferPrint\Patterns\MetroTestSource.vpp";
        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source Origin X CAD Position")]
        public double SourceR1C1XPosWafer { get; set; } = -10;
        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source Origin X CAD Position")]
        public double SourceR1C1YPosWafer { get; set; } = 0d;
        [Browsable(false)]
        public double SourceR1C1XPosGlobal { get; set; } = -10;
        [Browsable(false)]
        public double SourceR1C1YPosGlobal { get; set; } = 0d;
        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source A X CAD Position")]
        public double SourceAXPosWafer { get; set; } = 999d;
        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source A Y CAD Position")]
        public double SourceAYPosWafer { get; set; } = 999d;
        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source B X CAD Position")]
        public double SourceBXPosWafer { get; set; } = 999d;
        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source B Y CAD Position")]
        public double SourceBYPosWafer { get; set; } = 999d;
        [Browsable(false)]
        public double SourceAXPosGlobal { get; set; } = 999d;
        [Browsable(false)]
        public double SourceAYPosGlobal { get; set; } = 999d;
        [Browsable(false)]
        public double SourceBXPosGlobal { get; set; } = 999d;
        [Browsable(false)]
        public double SourceBYPosGlobal { get; set; } = 999d;
        [Browsable(false)]
        public int SourceVisionIllumHi { get; set; } = 50;
        [Browsable(false)]
        public int SourceVisionIllumLo { get; set; } = 10;
        [Browsable(false)]
        public double SourceVisionExposureHi { get; set; } = 10d;
        [Browsable(false)]
        public double SourceVisionExposureLo { get; set; } = 1d;
        [Browsable(false)]
        public double SourceVisionContrastHi { get; set; } = 0.5d;
        [Browsable(false)]
        public double SourceVisionContrastLo { get; set; } = 0.5d;
        [Browsable(false)]
        public double SourceVisionBrightnessHi { get; set; } = 0.1d;
        [Browsable(false)]
        public double SourceVisionBrightnessLo { get; set; } = 0.1d;
        [Browsable(false)]
        public double SourcePeelSpeed { get; set; } = 10d;
        [Browsable(false)]
        public double SourceZODSpeed { get; set; } = 0.005d;
        [Browsable(false)]
        public double SourceShearX { get; set; } = 0d;
        [Browsable(false)]
        public double SourceShearY { get; set; } = 0d;
        [Browsable(false)]
        public double SourceShearSpeed { get; set; } = 0d;
        [Browsable(false)]
        public double SourceShearDuration { get; set; } = 1d;
        [Browsable(false)]
        public double PrePickDuration { get; set; } = 1d;
        [Browsable(false)]
        public double PickAcceleration { get; set; } = 0.7d;
        [Browsable(false)]
        public double SourceZOD { get; set; } = 0.001d;
        [Browsable(false)]
        public double PickAlignGap { get; set; } = 0d;
        [Browsable(false)]
        public double PickTransferGap { get; set; } = 0d;
        [Browsable(false)]
        public string SourceRegPatternFilename { get; set; } = @"C:\XferPrint\Patterns\TestRegTarget2.vpp";
        [Browsable(false)]
        public double ContrastThreshold { get; set; } = 10d;
        [Browsable(false)]
        public double SourceThetaXPosition { get; set; } = 999d;
        [Browsable(false)]
        public double SourceThetaYPosition { get; set; } = 999d;
        [Browsable(false)]
        public string SourceRegPatternFilenameLo { get; set; } = @"C:\XferPrint\Patterns\TestTarget4_wMask.vpp";
        [Browsable(false)]
        public string SourceTBlockFilename { get; set; } = @"C:\XferPrint\Patterns\TB_Beta.vpp";
        [Browsable(false)]
        [XmlIgnore]
        public bool SourceTBlockInUse { get; set; } = false;
        [Browsable(false)]
        [XmlElement("SourceTBlockInUse")]
        public string SourceTBlock_Ser
        {
            get
            {
                return Convert.ToString(SourceTBlockInUse);
            }

            set
            {
                if (value.Equals("True"))
                {
                    SourceTBlockInUse = true;
                }
                else if (value.Equals("False"))
                {
                    SourceTBlockInUse = false;
                }
                else
                {
                    SourceTBlockInUse = XmlConvert.ToBoolean(value);
                    // SourceTBlockInUse = str2bool(Value)
                }
            }
        }

        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source A Lomag X CAD Position")]
        public double SourceAXPosWaferLo { get; set; } = 999d;
        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source A LoMag Y CAD Position")]
        public double SourceAYPosWaferLo { get; set; } = 999d;
        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source B LoMag X CAD Position")]
        public double SourceBXPosWaferLo { get; set; } = 999d;
        [Category("Source")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Source B LoMag Y CAD Position")]
        public double SourceBYPosWaferLo { get; set; } = 999d;
        [Browsable(false)]
        public int SourceXRegions { get; set; } = 1;
        [Browsable(false)]
        public int SourceYRegions { get; set; } = 1;
        [Browsable(false)]
        public double SourceXRegionsPitch { get; set; } = 1d;
        [Browsable(false)]
        public double SourceYRegionsPitch { get; set; } = 1d;
        [Browsable(false)]
        public string SourceAlignPatternFilename { get; set; } = @"C:\XferPrint\Patterns\testPat_Source_3.vpp";
        [Browsable(false)]
        public double SourceAlignOffsetX { get; set; } = 0d;
        [Browsable(false)]
        public double SourceAlignOffsetY { get; set; } = 0d;
        [Browsable(false)]
        public double SourceAutoFineThreshold { get; set; } = 0.0008d;
        [Browsable(false)]
        public double SourceAutoRotateThreshold { get; set; } = 0.0005d;
        [Browsable(false)]
        public double ZSourceDelta { get; set; } = 0.1d;
        [Browsable(false)]
        public int SourceSearchRegionWidth { get; set; } = 100; // Source Search Region Custom X value
        [Browsable(false)]
        public int SourceSearchRegionHeight { get; set; } = 100; // Source Search Region Custom Y value
        [Browsable(false)]
        public double PickAssistDistance { get; set; } = 0.001d;
        [Browsable(false)]
        public int PickAssistFreq { get; set; } = 1;
        [Browsable(false)]
        public int PickAssistCycles { get; set; } = 1;
        [Browsable(false)]
        public bool UsePickAssist { get; set; } = false;
        [Browsable(false)]
        public string SourceAlignTBlockFilename { get; set; } = @"C:\XferPrint\Patterns\TB_Beta.vpp";
        [Browsable(false)]
        public bool SourceAlignTBlockInUse { get; set; } = false;
        [Browsable(false)]
        public double HS_ScanSpeed { get; set; } = AppConfiguration.PrConfig.XYSpeedF;
        [Browsable(false)]
        public int HS_ScanDirection { get; set; } = (int)XferPrintLib.HSPathAlgorithms.X;
        [Browsable(false)]
        public double HS_ScanStep { get; set; } = 15d;
        [Browsable(false)]
        public double HS_FocusHeight { get; set; } = 0d;
        [Browsable(false)]
        public double HS_FocusHeightOffset { get; set; } = 0d;
        [Browsable(false)]
        public double HS_ZOrigin { get; set; } = 0d;
        [Browsable(false)]
        public double HS_ZOrigin_WorkingHeight { get; set; } = -0.1d;
        [Browsable(false)]
        [XmlIgnore]
        public bool AutoSourceRegion_Enable { get; set; } = true;
        [Browsable(false)]
        [XmlElement("AutoSourceRegion_Enable")]
        public string SourceRegion_Ser
        {
            get
            {
                return Convert.ToString(AutoSourceRegion_Enable);
            }

            set
            {
                if (value.Equals("True"))
                {
                    AutoSourceRegion_Enable = true;
                }
                else if (value.Equals("False"))
                {
                    AutoSourceRegion_Enable = false;
                }
                else
                {
                    AutoSourceRegion_Enable = XmlConvert.ToBoolean(value);
                    // SourceRegionEnable = str2bool(Value)
                }
            }
        }

        public static SourceParameters Load(string RecipePath)
        {
            SourceParameters oXferPrintRecipe = null;
            try
            {
                // logger.Debug("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name)
                var serializer = new XmlSerializer(typeof(SourceParameters));

                // Could do some handling here, but I don't think it buys us much. There are .UnknownNode, .UnknownElement, and a few other .Unknown methods.
                // AddHandler serializer.UnknownNode

                var reader = new StreamReader(RecipePath);
                oXferPrintRecipe = (SourceParameters)serializer.Deserialize(reader);
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