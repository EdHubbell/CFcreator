using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XferPrintLib.Configuration
{
    [Serializable]
    [XmlRoot("ProcessParameters")]
    public class TargetParameters : XMLBaseObject
    {
        [Browsable(false)]
        public double TargetXOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double TargetYOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double TargetZOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double TargetAlpha { get; set; } = 999d;
        [Browsable(false)]
        public double TargetBeta { get; set; } = 999d;
        [Browsable(false)]
        public double TargetFocusHeight { get; set; } = 0d;
        [Browsable(false)]
        public int TargetXClusters { get; set; } = 999;
        [Browsable(false)]
        public int TargetYClusters { get; set; } = 999;
        [Browsable(false)]
        public double TargetXClusterPitch { get; set; } = 0.07d;
        [Browsable(false)]
        public double TargetYClusterPitch { get; set; } = 0.05d;
        [Browsable(false)]
        public int TargetXPrints { get; set; } = 999;
        [Browsable(false)]
        public int TargetYPrints { get; set; } = 999;
        [Browsable(false)]
        public double TargetXPrintPitch { get; set; } = 0.07d;
        [Browsable(false)]
        public double TargetYPrintPitch { get; set; } = 0.05d;
        [Browsable(false)]
        public double MetroMarksAcceptThreshold { get; set; } = 0.3d;
        [Browsable(false)]
        public double MetroMarksAngleLow { get; set; } = 999d;
        [Browsable(false)]
        public double MetroMarksAngleHigh { get; set; } = 999d;
        [Browsable(false)]
        public double MetroMarksOffsetX { get; set; } = 999d;
        [Browsable(false)]
        public double MetroMarksOffsetY { get; set; } = 999d;
        [Browsable(false)]
        public double MetroMarksScaleXLow { get; set; } = 999d;
        [Browsable(false)]
        public double MetroMarksScaleXHigh { get; set; } = 999d;
        [Browsable(false)]
        public double MetroMarksScaleYLow { get; set; } = 999d;
        [Browsable(false)]
        public double MetroMarksScaleYHigh { get; set; } = 999d;
        [Browsable(false)]
        public string MetroMarksFilename { get; set; } = @"C:\XferPrint\Patterns\MetroTestTarget.vpp";
        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target Origin X CAD Position")]
        public double TargetR1C1XPosWafer { get; set; } = 10d;
        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target Origin Y CAD Position")]
        public double TargetR1C1YPosWafer { get; set; } = 0d;
        [Browsable(false)]
        public double TargetR1C1XPosGlobal { get; set; } = 10d;
        [Browsable(false)]
        public double TargetR1C1YPosGlobal { get; set; } = 0d;
        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target A X CAD Position")]
        public double TargetAXPosWafer { get; set; } = 999d;
        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target A Y CAD Position")]
        public double TargetAYPosWafer { get; set; } = 999d;
        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target B X CAD Position")]
        public double TargetBXPosWafer { get; set; } = 999d;
        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target B Y CAD Position")]
        public double TargetBYPosWafer { get; set; } = 999d;
        [Browsable(false)]
        public double TargetAXPosGlobal { get; set; } = 999d;
        [Browsable(false)]
        public double TargetAYPosGlobal { get; set; } = 999d;
        [Browsable(false)]
        public double TargetBXPosGlobal { get; set; } = 999d;
        [Browsable(false)]
        public double TargetBYPosGlobal { get; set; } = 999d;
        [Browsable(false)]
        public int TargetVisionIllumHi { get; set; } = 50;
        [Browsable(false)]
        public int TargetVisionIllumLo { get; set; } = 10;
        [Browsable(false)]
        public double TargetVisionExposureHi { get; set; } = 10d;
        [Browsable(false)]
        public double TargetVisionExposureLo { get; set; } = 1d;
        [Browsable(false)]
        public double TargetVisionContrastHi { get; set; } = 0.05d;
        [Browsable(false)]
        public double TargetVisionContrastLo { get; set; } = 0.1d;
        [Browsable(false)]
        public double TargetVisionBrightnessHi { get; set; } = 0.1d;
        [Browsable(false)]
        public double TargetVisionBrightnessLo { get; set; } = 0.1d;
        [Browsable(false)]
        public double TargetPeelSpeed { get; set; } = 0.005d;
        [Browsable(false)]
        public double TargetZODSpeed { get; set; } = 0.005d;
        [Browsable(false)]
        public double TargetShearX { get; set; } = 0.001d;
        [Browsable(false)]
        public double TargetShearY { get; set; } = 0.001d;
        [Browsable(false)]
        public double TargetShearSpeed { get; set; } = 0.001d;
        [Browsable(false)]
        public double TargetShearDuration { get; set; } = 1d;
        [Browsable(false)]
        public double PreShearDuration { get; set; } = 1d;
        [Browsable(false)]
        public double TargetZOD { get; set; } = 0.0001d;
        [Browsable(false)]
        public double PostPrintRetract { get; set; } = 0.0001d;
        [Browsable(false)]
        public double PrintTransferGap { get; set; } = 0d;
        [Browsable(false)]
        public double PrintAccuracyXCorrection { get; set; } = 0d;
        [Browsable(false)]
        public double PrintAccuracyYCorrection { get; set; } = 0d;
        [Browsable(false)]
        public double PrintAccuracyThetaCorrection { get; set; } = 0d;
        [Browsable(false)]
        public string TargetRegPatternFilename { get; set; } = @"C:\XferPrint\Patterns\testPat_RegTarget_1.vpp";
        [Browsable(false)]
        public double AutoFineThreshold { get; set; } = 0.0005d;
        [Browsable(false)]
        public double ContrastThreshold { get; set; } = 10d;
        [Browsable(false)]
        public double TargetThetaXPosition { get; set; } = 999d;
        [Browsable(false)]
        public double TargetThetaYPosition { get; set; } = 999d;
        [Browsable(false)]
        public string TargetRegPatternFilenameLo { get; set; } = @"C:\XferPrint\Patterns\TestSource4_wMask.vpp";
        [Browsable(false)]
        [XmlIgnore]
        public bool TargetTBlockInUse { get; set; } = false;
        [Browsable(false)]
        [XmlElement("TargetTBlockInUse")]
        public string TargetTBlock_Ser
        {
            get
            {
                return Convert.ToString(TargetTBlockInUse);
            }

            set
            {
                if (value.Equals("True"))
                {
                    TargetTBlockInUse = true;
                }
                else if (value.Equals("False"))
                {
                    TargetTBlockInUse = false;
                }
                else
                {
                    TargetTBlockInUse = XmlConvert.ToBoolean(value);
                    // TargetTBlockInUse = str2bool(Value)
                }
            }
        }

        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target A LoMag X CAD Position")]
        public double TargetAXPosWaferLo { get; set; } = 999d;
        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target A LoMag Y CAD Position")]
        public double TargetAYPosWaferLo { get; set; } = 999d;
        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target B LoMag X CAD Position")]
        public double TargetBXPosWaferLo { get; set; } = 999d;
        [Category("Target")]
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Target B LoMag Y CAD Position")]
        public double TargetBYPosWaferLo { get; set; } = 999d;
        [Browsable(false)]
        public string TargetTBlockFilename { get; set; } = @"C:\XferPrint\Patterns\TB_Beta.vpp";
        [Browsable(false)]
        public double ZDelta { get; set; } = 0.1d;
        [Browsable(false)]
        public double AutoRotateThreshold { get; set; } = 0.0005d;
        [Browsable(false)]
        public double PrintAssistDistance { get; set; } = 0.001d;
        [Browsable(false)]
        public int PrintAssistFreq { get; set; } = 1;
        [Browsable(false)]
        public int PrintAssistCycles { get; set; } = 1;
        [Browsable(false)]
        public short PrintAssistDirection { get; set; } = (short)PrintAssistDir.Z;
        [Browsable(false)]
        public double ZPreContact { get; set; } = 0.001d;
        [Browsable(false)]
        public double XPreContact { get; set; } = 0.001d;
        [Browsable(false)]
        public double YPreContact { get; set; } = 0.001d;
        [Browsable(false)]
        public bool UsePreContact { get; set; } = false;
        [Browsable(false)]
        public bool UsePrintAssist { get; set; } = false;
        [Browsable(false)]
        public double XYPreContactSpeed { get; set; } = 0.001d;
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
        public bool AutoFocusEnable { get; set; } = false;

        public static TargetParameters Load(string RecipePath)
        {
            TargetParameters oXferPrintRecipe = null;
            try
            {
                // logger.Debug("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name)
                var serializer = new XmlSerializer(typeof(TargetParameters));

                // Could do some handling here, but I don't think it buys us much. There are .UnknownNode, .UnknownElement, and a few other .Unknown methods.
                // AddHandler serializer.UnknownNode

                var reader = new StreamReader(RecipePath);
                oXferPrintRecipe = (TargetParameters)serializer.Deserialize(reader);
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