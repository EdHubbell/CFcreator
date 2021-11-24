using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Xml.Serialization;
using NLog;
using System.Windows.Forms.Design;


namespace XferPrintLib.Configuration
{
    [Serializable]
    [XmlRoot("config")]
    public class XferPrintConfig : XMLBaseObject
    {
        /*TODO Need to add check for exceptions in the static functions I have removed the following
                My.MyProject.Forms.FormMain.lblStatus.Text = "ERROR: Please view the logs for more information.";
                My.MyProject.Forms.FormMain.StatusPanel.BackColor = System.Drawing.Color.Red;
         */

        public static float ConvertTxPosition_DegToMM(float Value3)
        {
            // Used for absolute moves
            // Value3 in degrees
            // PrConfig.TxOrigin = mycontroller.Parameters.Axes("Tx").Motion.Home.HomeOffset
            try
            {
                return (float)(Value3 / AppConfiguration.PrConfig.TxDegPerMM + AppConfiguration.PrConfig.TxOrigin);
            }
            catch (Exception ex)
            {

                XferPrintLib.Utility.Log.Logger.WriteEventLog("ERROR: Exception in ConverTxtoMM: ", ex.Message);
                return 0f;
            }
        }

        public static double ConvertTyPosition_DegToMM(float Value3)
        {
            // Used for absolute moves
            // Value3 in degrees
            try
            {
                return AppConfiguration.PrConfig.TyOrigin - Value3 / AppConfiguration.PrConfig.TyDegPerMM;
            }
            catch (Exception ex)
            {
                XferPrintLib.Utility.Log.Logger.WriteEventLog("ERROR: Exception in ConverTytoMM: ", ex.Message);
                return 0d;
            }
        }

        public static double ConvertTxPosition_MMToDeg(float Value4)
        {
            // Used for position display
            // Value4 in mm
            // Right hand rule for +/-
            try
            {
                return (Value4 - AppConfiguration.PrConfig.TxOrigin) * AppConfiguration.PrConfig.TxDegPerMM;
            }
            catch (Exception ex)
            {
                XferPrintLib.Utility.Log.Logger.WriteEventLog("ERROR: Exception in ConverTxtoDeg: ", ex.Message);
                return 0d;
            }
        }

        public static double ConvertTyPosition_MMToDeg(float Value4)
        {
            // Used for position display
            // Value4 in mm
            // right hand rule for +/-
            try
            {
                return (AppConfiguration.PrConfig.TyOrigin - Value4) * AppConfiguration.PrConfig.TyDegPerMM;
            }
            catch (Exception ex)
            {
                XferPrintLib.Utility.Log.Logger.WriteEventLog("ERROR: Exception in ConverTytoDeg: ", ex.Message);
                return 0d;
            }
        }

        // ? Add property for comment at top of view - to be seen in editor -- for example SW version ,etc.
        [Browsable(false)]
        public string ConfigComment { get; set; } = "Configuration Comment";
        [Category("General")]
        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("Printer Configuration Name")]
        [Description("The printer name")]
        public string Printer { get; set; } = "DEV"; // Name or Serial number of equipment
        [Browsable(false)]
        public int NbA3200Axes { get; set; } = 9; // Nine axis for Fortuna, four for despina
        [Browsable(false)]
        public int IndexAxis { get; set; } = 0; // Zero or one based list
        [Browsable(false)]
        public bool FA_PTO { get; set; } = false; // Factory Automation - Peer Tool Orchestrator SW present and enabled
        [Browsable(false)]
        public bool FA_PTO_SIM { get; set; } = false; // PTO used in simulated server mode
        [Browsable(false)]
        public bool IO_PLC { get; set; } = false; // PLC HW present and used for I/O
        [Browsable(false)]
        public bool IO_PLC_SIM { get; set; } = false;  // PLC is simulated
        [Browsable(false)]
        public bool EFEM_Present { get; set; } = false; // Robot wafer HW present and enabled
        [Browsable(false)]
        public bool IO_NPAQ { get; set; } = true; // I/O on the NPAQ will be used
        [Browsable(false)]
        public bool HiCamTriggerCable { get; set; } = true; // Presence of the hi mag trigger cable
        [Browsable(false)]
        public bool LoCamTriggerCable { get; set; } = false; // presence of the lo mag trigger cable
        [Browsable(false)]
        public int IO_Axis { get; set; } = 0; // A3200 axis number used for I/O hub
        [Browsable(false)]
        public bool Zoom { get; set; } = false; // Dual optics installed (Argos printer)
        [Browsable(false)]
        public int NbCameras { get; set; } = 2; // Number of cameras installed
        [Browsable(false)]
        public int NbIllumCh { get; set; } = 2; // Number of illuminator channels installed

        // Warning - This EditorAttribute works just fine for ProcessRecipePath, as the FolderNameEditor returns paths without a trailing \. 
        // Typically ProcessRecipePath values are typically set without the trailing \. Some of the other path variables in this config file have the trailing \. *
        [Category("General")]
        [Browsable(true)]
        [DisplayName("Process Recipe File Directory")]
        [Description("Folder to save ProcessRecipes in.")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public string ProcessRecipePath { get; set; } = @"c:\AutoFile\Process Recipes"; // path for saving process recipes
        [Browsable(false)]
        public string LogFilePath { get; set; } = @"c:\XferPrint\Data\Log"; // Path for Event, Run, and results logs
        [Browsable(false)]
        public string A32ProgPath { get; set; } = @"c:\XferPrint\Programs\"; // Path for A3200 program scripts (.PGM files)
        [Browsable(false)]
        public string RunCognexPath { get; set; } = @"c:\XferPrint\Data\Images\Cognex\"; // Path for images used specifically for cognex init and samples, and calibration spaces
        [Browsable(false)]
        public string RunImagePath { get; set; } = @"c:\XferPrint\Data\Images"; // Default path for saving snapshots and start image
        [Browsable(false)]
        public string DefMetroImagePath { get; set; } = @"c:\XferPrint\Data\Metro"; // default directory for metrology if none is specified
        [Browsable(false)]
        public string TrigMetroPGMName { get; set; } = "METROLOGY-TRIGGERED-REV-A.PGM"; // name of the metrology script with camera triggering enabled
        [Browsable(false)]
        public string CyclePGMName { get; set; } = "####-STANDARD-REV-#.pgm"; // name of the standard recipe print script
        [Browsable(false)]
        public string MetroPGMName { get; set; } = "METROLOGY-SAMPLE-INLINE-REV-A.PGM"; // name of the metrology script WITHOUT camera triggering
        [Browsable(false)]
        public string StampMetroPGMName { get; set; } = "METROLOGY-STAMPTRIGGERED-REV-A.PGM"; // name of the metrology script for stamp measurement
        [Browsable(false)]
        public string PickOnlyPGMName { get; set; } = "MTP100-PICKONLY.PGM"; // name of the pick-only script
        [Browsable(false)]
        public string PrintOnlyPGMName { get; set; } = "MTP100-PRINTONLY.PGM"; // name of the print-only script
        [Browsable(false)]
        public string CleanOnlyPGMName { get; set; } = "MTP100-CLEANONLY.PGM"; // name of the clean-only script
        [Browsable(false)]
        public string RecentProcessRecipe { get; set; } = @"C:\Autofile\ProcessRecipes\ProjFileStarter.txt"; // name of the last used process recipe
        [Browsable(false)]
        public string RecentCycle { get; set; } = @"C:\Autofile\ProcessRecipes\CycleStarter.txt"; // 'name of the last used cycle file

        // Had to redefine the XML element name here because the dash isn't allowed in a variable name. 

        [XmlElement("XYSpeed-S")]
        [Browsable(false)]
        public double XYSpeedS { get; set; } = 0.05d; // Speeds for the X & Y axes
        [XmlElement("XYSpeed-M")]
        [Browsable(false)]
        public double XYSpeedM { get; set; } = 3d;
        [XmlElement("XYSpeed-F")]
        [Browsable(false)]
        public double XYSpeedF { get; set; } = 25d;
        [XmlElement("ZSpeed-S")]
        [Browsable(false)]
        public double ZSpeedS { get; set; } = 0.1d; // Speeds for the Z and Zc axes
        [XmlElement("ZSpeed-M")]
        [Browsable(false)]
        public double ZSpeedM { get; set; } = 0.5d;
        [XmlElement("ZSpeed-F")]
        [Browsable(false)]
        public double ZSpeedF { get; set; } = 1.5d;
        [XmlElement("RtySpeed-S")]
        [Browsable(false)]
        public double RtySpeedS { get; set; } = 0.1d; // rotation speeds for the Theta X-Y-Z stages
        [XmlElement("RtySpeed-M")]
        [Browsable(false)]
        public double RtySpeedM { get; set; } = 0.25d;
        [XmlElement("RtySpeed-F")]
        [Browsable(false)]
        public double RtySpeedF { get; set; } = 0.5d;
        [Browsable(false)]
        public double TxDegPerMM { get; set; } = 0.1082d; // conversion from linear encoder to angular position
        [Browsable(false)]
        public double TyDegPerMM { get; set; } = 0.4107d;
        [Browsable(false)]
        public double StampChangeX { get; set; } = 99d; // fixed location for exchanging stamps
        [Browsable(false)]
        public double StampChangeY { get; set; } = 99d;
        [Browsable(false)]
        public double StampChangeZ { get; set; } = -10;
        [Browsable(false)]
        public double StampChangeZo { get; set; } = -1;
        [Browsable(false)]
        public string IllumCOMPort { get; set; } = "192.168.1.10"; // IP address or COM port for illuminator controller
        [Browsable(false)]
        public string HeightSensorAttached { get; set; } = "True"; // IP address for confocal sensor controller
        [Browsable(false)]
        public string HeightSensorPort { get; set; } = "192.168.1.15"; // IP address for confocal sensor controller
        [Browsable(false)]
        public double HiCoaxDefIllum { get; set; } = 20d; // Default illumination values
        [Browsable(false)]
        public double LoCoaxDefIllum { get; set; } = 10d;
        [Browsable(false)]
        public double ShuttleX { get; set; } = 50d; // fixed incremental distance from high mag optic to low mag optic
        [Browsable(false)]
        public double ShuttleY { get; set; } = 150d;
        [Browsable(false)]
        public double ShuttleZ { get; set; } = 0d;
        [Browsable(false)]
        public double ZClrHeight { get; set; } = -10; // Z stage position that clears all substrate
        [Browsable(false)]
        public double HiCamPix { get; set; } = 5.2d; // pixels per micron for the cameras
        [Browsable(false)]
        public double LoCamPix { get; set; } = 0.7d;
        [Browsable(false)]
        public double HiCamExposure { get; set; } = 5d; // Default exposure values for the cameras
        [Browsable(false)]
        public double LoCamExposure { get; set; } = 1d;
        [Browsable(false)]
        public double HiCamContrast { get; set; } = 0.1d; // default contrast (gain) values for the cameras
        [Browsable(false)]
        public double LoCamContrast { get; set; } = 0.5d;
        [Browsable(false)]
        public double HiCamBrightness { get; set; } = 0.1d; // default brightness values for the cameras
        [Browsable(false)]
        public double LoCamBrightness { get; set; } = 0.1d;
        [Browsable(false)]
        public double TzOffset { get; set; } = 0d; // orthogonality correction for the Xc and Yc axes
        [Browsable(false)]
        public int SampleXAxis { get; set; } = 0; // number assignment for each axis on the A3200 controller
        [Browsable(false)]
        public int SampleYAxis { get; set; } = 1;
        [Browsable(false)]
        public int SampleZAxis { get; set; } = 3;
        [Browsable(false)]
        public int OpticsXAxis { get; set; } = 6;
        [Browsable(false)]
        public int OpticsYAxis { get; set; } = 4;
        [Browsable(false)]
        public int OpticsZAxis { get; set; } = 5;
        [Browsable(false)]
        public int RotaryTxAxis { get; set; } = 7;
        [Browsable(false)]
        public int RotaryTyAxis { get; set; } = 8;
        [Browsable(false)]
        public int RotaryTzAxis { get; set; } = 2;
        [Browsable(false)]
        public double ZSafetyHeight { get; set; } = -15; // Z stage position - below this value, X & Y speeds are clipped to "slow"
        [Browsable(false)]
        public double XYSafetyDist { get; set; } = 0.1d;
        [Browsable(false)]
        public float MaxStageRangeX { get; set; } = 99f; // max travel range for X and Y stages
        [Browsable(false)]
        public float MaxStageRangeY { get; set; } = 99f;
        [Browsable(false)]
        public double XYSpecialSpeed { get; set; } = 10d; // top speed for X and Y stages
        [Browsable(false)]
        public double AutoCoarse { get; set; } = 0.06d; // default errors when performing pattern recognition/alignment checks
        [Browsable(false)]
        public double AutoFine { get; set; } = 0.001d;
        [Browsable(false)]
        public double AccCorrectionX { get; set; } = 0d; // default accuracy (ortho) errors
        [Browsable(false)]
        public double AccCorrectionY { get; set; } = 0d;
        [Category("Load Position 1")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 1 Name")]
        [Description("Text to display for Load Position 1")]
        public string LoadPos1Name { get; set; } = "Load Source"; // user defined for set position
        [Category("Load Position 1")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 1 X Coordinate")]
        [Description("Load Position 1 X location - USE CAUTION WHEN ADJUSTING")]
        public double LoadPos1X { get; set; } = 5d;
        [Category("Load Position 1")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 1 Y Coordinate")]
        [Description("Load Position 1 Y location - USE CAUTION WHEN ADJUSTING")]
        public double LoadPos1Y { get; set; } = 5d;
        [Category("Load Position 1")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 1 Z Coordinate")]
        [Description("Load Position 1 Z location - USE CAUTION WHEN ADJUSTING")]
        public double LoadPos1Z { get; set; } = 0d;
        [Category("Load Position 1")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 1 Z Coordinate")]
        [Description("Load Position 1 Z location - USE CAUTION WHEN ADJUSTING")]
        public double LoadPos1ZOptics { get; set; } = 0d;
        [Category("Load Position 2")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 2 Name")]
        [Description("Text to display for Load Position 2")]
        public string LoadPos2Name { get; set; } = "Load Target"; // user defined for set position
        [Category("Load Position 2")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 2 X Coordinate")]
        [Description("Load Position 2 X location - USE CAUTION WHEN ADJUSTING")]
        public double LoadPos2X { get; set; } = 5d;
        [Category("Load Position 2")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 2 Y Coordinate")]
        [Description("Load Position 2 Y location - USE CAUTION WHEN ADJUSTING")]
        public double LoadPos2Y { get; set; } = 5d;
        [Category("Load Position 2")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 2 Z Coordinate")]
        [Description("Load Position 2 Z location - USE CAUTION WHEN ADJUSTING")]
        public double LoadPos2Z { get; set; } = 0d;
        [Category("Load Position 2")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Load Position 2 Z Optics Coordinate")]
        [Description("Load Position 2 Z Optics location - USE CAUTION WHEN ADJUSTING")]
        public double LoadPos2ZOptics { get; set; } = 0d;
        [Browsable(false)]
        public double OpticalStandardX { get; set; } = 5d;
        [Browsable(false)]
        public double OpticalStandardY { get; set; } = 5d;
        [Browsable(false)]
        public double OpticalStandardZ { get; set; } = -5;
        [Browsable(false)]
        public double OpticalStandardZc { get; set; } = -5;
        [Browsable(false)]
        public double TzCenterOfRotationX { get; set; } = 0d; // center of rotation coordinate for THZ axis in Xc,Yc frame
        [Browsable(false)]
        public double TzCenterOfRotationY { get; set; } = 0d;
        [Category("Wafer Origin Positions")]
        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("Source Wafer X Origin")]
        [Description("Source wafer origin X position")]
        public double SourceWaferOriginX { get; set; } = 5d; // fixed position of center of source chuck
        [Category("Wafer Origin Positions")]
        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("Source Wafer Y Origin")]
        [Description("Source wafer origin Y position")]
        public double SourceWaferOriginY { get; set; } = 5d;
        [Category("Wafer Origin Positions")]
        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("Target Wafer X Origin")]
        [Description("Target wafer origin X position")]
        public double TargetWaferOriginX { get; set; } = 5d; // fixed position of center of target chuck
        [Category("Wafer Origin Positions")]
        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("Target Wafer Y Origin")]
        [Description("Target wafer origin Y position")]
        public double TargetWaferOriginY { get; set; } = 5d;
        [Browsable(false)]
        public double CleanTapeReplacePosX { get; set; } = 5d; // fixed position for replacement (maintenance) of tape roll
        [Browsable(false)]
        public double CleanTapeReplacePosY { get; set; } = 5d;
        [Browsable(false)]
        public string OffsetLoMagPatternName { get; set; } = "NA"; // name of lo mag calibration pattern
        [Browsable(false)]
        public string OffsetHiMagPatternName { get; set; } = "NA"; // name of hi mag calibration pattern
        [Browsable(false)]
        public double CleanTapeIndexLength { get; set; } = 120d; // length of one tape roll index in mm
        [Browsable(false)]
        public double CleanTapeZoneLength { get; set; } = 100d; // length of Cleaning area in mm
        [Browsable(false)]
        public double CleanTapeZoneWidth { get; set; } = 90d; // width of Cleaning area in mm
        [Browsable(false)]
        public double CleanTapeLastUsedLength { get; set; } = 0d; // length of one tape that was last used in mm
        [Category("Cleaning Tape")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Cleaning Tape Indexing Mode")]
        [Description("Cleaning tape indexing at the beginning of a Print Recipe. Operator: Tape Indexing is controlled by an Operator. Production: Tape Indexing happens at the start of each Print Recipe.")]
        public ControlMode CleanTapeIndexMode { get; set; } = ControlMode.Operator; // length of one tape that was last used in mm
        [Browsable(false)]
        public double CleanTapeOriginX { get; set; } = 5d; // 'fixed position of corner of clean tape surface
        [Browsable(false)]
        public double CleanTapeOriginY { get; set; } = 5d;
        [Browsable(false)]
        public double HeightCalibValue { get; set; } = 2d; // value from height sensor when calibrated to a wafer surface
        [Browsable(false)]
        public double HeightCalibFocus { get; set; } = -10; // value of Zc encoder when focused at height cal position
        [Browsable(false)]
        public double HeightCalibContact { get; set; } = -10; // value of Z encoder when stamp makes level contact
        [Browsable(false)]
        public bool HeightFocusCalibrated { get; set; } = false; // height sensor is calibrated to focus
        [Browsable(false)]
        public bool HeightContactCalibrated { get; set; } = false; // height sensor is calibrated to stamp contact position
        [Browsable(false)]
        public double HeightSensePosX { get; set; } = 57d; // fixed incremental distance between optics and height sensor
        [Browsable(false)]
        public double HeightSensePosY { get; set; } = 177d;
        [Browsable(false)]
        public double StampRegFocusPosition { get; set; } = 999;
        [Browsable(false)]
        public bool HeaterPresent { get; set; } = false;
        [Browsable(false)]
        public int HeaterTime { get; set; } = 60; //Heater Timer in Minutes
        [Browsable(false)]
        public int HiMagIllumChannel { get; set; } = 1; // number assignments for illuminator channels
        [Browsable(false)]
        public int LoMagIllumChannel { get; set; } = 2;
        [Browsable(false)]
        public double TxOrigin { get; set; } = 0.0d;
        [Browsable(false)]
        public double TyOrigin { get; set; } = 0.0d;
        [Browsable(false)]
        public double StampZedUpperBound { get; set; } = 125d;
        [Browsable(false)]
        public double RollConstant { get; set; } = -1.2913d;
        [Browsable(false)]
        public double PitchConstant { get; set; } = -0.6833d;
        [Browsable(false)]
        public string ChuckConfig { get; set; } = "Fortuna";
        [Category("General")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Source Cluster Name")]
        [Description("UI Name for Source Cluster")]
        public string Name_SCluster { get; set; } = "Cluster";
        [Category("General")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Source Region Name")]
        [Description("UI Name for Source Regions")]
        public string Name_SRegion { get; set; } = "Regions";
        [Category("General")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Target Region Name")]
        [Description("UI Name for Target Regions")]
        public string Name_TCluster { get; set; } = "Regions";
        [Browsable(false)]
        public bool AdvancedParametersEnabled { get; set; } = false;
        [Category("Wafer Sizes")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Target Wafer Size")]
        [Description("Target wafer diameter (mm)")]
        public double TargetWaferSize { get; set; } = 200d;
        [Category("Wafer Sizes")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Source Wafer Size")]
        [Description("Source wafer diameter (mm)")]
        public double SourceWaferSize { get; set; } = 200d;
        [Category("General")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Camera Frame Iteration")]
        [Description("How many Camera frames are used during alignment")]
        public int CameraIteration { get; set; } = 1;
        [Browsable(false)]
        public bool IterationDelayActive { get; set; } = false;
        [Browsable(false)]
        public int IterationDelayMultiplier { get; set; } = 1;
        [Browsable(false)]
        public string StampSN { get; set; } = "STAMPSN"; // last loaded stamp serial number
        [Browsable(false)]
        public int StampCount { get; set; } = 0; // session count of currently loaded stamp
        [Browsable(false)]
        public int StampCountTotal { get; set; } = 0; // total lifetime count of currently loaded stamp
        [Browsable(false)]
        public double StampXOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double StampYOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double ZSave { get; set; } = 999d;
        [Browsable(false)]
        public double StampBeta { get; set; } = 999d;
        [Browsable(false)]
        public int StampXPosts { get; set; } = 2;
        [Browsable(false)]
        public int StampYPosts { get; set; } = 2;
        [Browsable(false)]
        public double StampTHXOrigin { get; set; } = 0d;
        [Browsable(false)]
        public double StampTHYOrigin { get; set; } = 0d;
        [Browsable(false)]
        public double StampXPostPitch { get; set; } = 0.35d;
        [Browsable(false)]
        public double StampYPostPitch { get; set; } = 0.25d;
        [Browsable(false)]
        public double StampAXPosition { get; set; } = 999d;
        [Browsable(false)]
        public double StampAYPosition { get; set; } = 999d;
        [Browsable(false)]
        public double StampBXPosition { get; set; } = 999d;
        [Browsable(false)]
        public double StampBYPosition { get; set; } = 999d;
        [Browsable(false)]
        public string StampRegPatternFilename { get; set; } = @"C:\XferPrint\Patterns\testPat_Source_2.vpp";
        [Browsable(false)]
        public double SourceThetaXPosition { get; set; } = 999d;
        [Browsable(false)]
        public double SourceThetaYPosition { get; set; } = 999d;
        [Browsable(false)]
        public double TargetThetaXPosition { get; set; } = 999d;
        [Browsable(false)]
        public double TargetThetaYPosition { get; set; } = 999d;
        [Browsable(false)]
        public double CleanThetaXPosition { get; set; } = 999d;        
        [Browsable(false)]
        public double CleanThetaYPosition { get; set; } = 999d;
        [Category("Loaded Stamp Parameters")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Keep Stamp Parameters")]
        [Description("Keep the currently loaded stamp parameters when changing recipe")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public bool KeepLoadedStamp { get; set; } = false;
        [Browsable(false)]
        public string HeightSensorXYRegPatternFilename { get; set; } = @"C:\XferPrint\Data\Images\Cognex\HeightSensorXYHiMag.vpp";
        [Browsable(false)]
        public string HeightSensorXYRegPatternFilenameLo { get; set; } = @"C:\XferPrint\Data\Images\Cognex\HeightSensorXYLoMag.vpp";
        [Browsable(false)]
        public double HeightSensorTargetZOffset { get; set; } = 0d;
        [Browsable(false)]
        public double HeightSensorSourceZOffset { get; set; } = 0d;
        [Browsable(false)]
        public double HeightSensorCleanZOffset { get; set; } = 0d;
        [Browsable(false)]
        public double HeightSensorFocusTargetZOffset { get; set; } = 0d;
        [Browsable(false)]
        public double HeightSensorFocusSourceZOffset { get; set; } = 0d;
        [Browsable(false)]
        public double HeightSensorFocusCleanZOffset { get; set; } = 0d;        
        [Category("HeightSensor")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("HeightSensor Extra-Slow Calibration Distance Coarse")]
        [Description("The Distance the Calibration scan will Travel")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public double HeightSensorCalDistanceCoarse_XSlow { get; set; } = 1d;
        [Category("HeightSensor")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("HeightSensor Fast Calibration Distance Coarse")]
        [Description("The Distance the Calibration scan will Travel")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public double HeightSensorCalDistanceCoarse_Slow { get; set; } = 3d;
        [Category("HeightSensor")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("HeightSensor Fast Calibration Distance Coarse")]
        [Description("The Distance the Calibration scan will Travel")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public double HeightSensorCalDistanceCoarse_Medium { get; set; } = 6d;
        [Category("HeightSensor")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("HeightSensor Fast Calibration Distance Coarse")]
        [Description("The Distance the Calibration scan will Travel")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public double HeightSensorCalDistanceCoarse_Fast { get; set; } = 12d;
        [Category("HeightSensor")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("HeightSensor Extra-Slow Calibration Distance Fine")]
        [Description("The Distance the Calibration scan will Travel")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public double HeightSensorCalDistanceFine_XSlow { get; set; } = 1d;
        [Category("HeightSensor")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("HeightSensor Slow Calibration Distance Fine")]
        [Description("The Distance the Calibration scan will Travel")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public double HeightSensorCalDistanceFine_Slow { get; set; } = 2d;
        [Category("HeightSensor")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("HeightSensor Medium Calibration Distance Fine")]
        [Description("The Distance the Calibration scan will Travel")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public double HeightSensorCalDistanceFine_Medium { get; set; } = 3d;
        [Category("HeightSensor")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("HeightSensor Fast Calibration Distance Fine")]
        [Description("The Distance the Calibration scan will Travel")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public double HeightSensorCalDistanceFine_Fast { get; set; } = 4d;
        [Browsable(false)]
        public double CleaningTapeZScanSize { get; set; } = 3d;
        [Category("General")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Transfer Log Directory")]
        [Description("Directory to export individual transfer XML data to")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public string LoggedTransferXMLPath { get; set; } = "";
        [Category("AutoFocus")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Registration AutoFocus Threshold")]
        [Description("Adjust the Pattern Recognition Score threshold that AutoFocus run if less than")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public double RegAutoFocusThreshold { get; set; } = 0.45d;
        [Category("SpiralSearch")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Spiral Search Step Count")]
        [Description("Adjust the number of steps that Spiral Search will move before moving to the next method of searching")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public int SpiralSearchMaxSteps { get; set; } = 25;

        public enum AutoFocusAreaOptions
        {
            Coarse = 10,
            Medium = 15,
            Fine = 20
        }

        [Category("AutoFocus")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("AutoFocus Area")]
        [Description("Coarse will divide the image into a 10x10 grid. Medium, 15x15. Fine, 20x20.")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public AutoFocusAreaOptions AutoFocusArea { get; set; } = AutoFocusAreaOptions.Medium;

        [Category("General")]
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Registration Delay")]
        [Description("Delay during Registration to allow confirmation of movement. (seconds)")]
        [Editor(typeof(System.Windows.Forms.Design.FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public double RegDelay { get; set; } = 0.1d;
        // Adding some examples here to illustrate more complex topics/concepts/etc.

        // Example of adding a new config item that always has an X and Y integer value. The 'New' here makes sure that the variable is instantiated, so it will write to the XML.
        // Public Property HeightSensePos As New XYInteger

        // Example of adding a new config item that always has an X and Y and Z double value in the attributes. No New here, so if the object stays null, it is never serialized to XML.
        // Public Property SomeTestPosition As XYZDouble

        // Array example
        // <XmlArray(ElementName:="SomeTestPositions")>
        // <XmlArrayItem(ElementName:="ATestPosition")>
        // Public Property SomeTestPositions As List(Of XYZDouble)


        // Public Property TestDefault As Double


        // Example of a value that doesn't get serialized to the XML file
        // <XmlIgnore>
        // Public Property DoNotWriteMeToXML As String = "not here"


        // Example of how NOT to prepare the XfrePrintConfig object to be able to handle previously existing data structures.
        // Exposing an array as a read-only property doesn't keep programmers from being able to assign values to items in that array. 
        // Well, it prevents them from assigning values. It just doesn't bother throwing an error.
        // <XmlIgnore>
        // Public ReadOnly Property XYSpeed() As Double()
        // Get
        // Dim SpeedArray() As Double = {XYSpeedS, XYSpeedM, XYSpeedF}
        // Return SpeedArray
        // End Get
        // End Property


        public enum Speeds
        {
            Slow = 0,
            Medium = 1,
            Fast = 2
        }
        // Better example - This version is a little safer in code. It won't allow commands like oInputConfig.XYSpeed(1) = 12, which the above syntax does allow.
        public double GetXYSpeed(Speeds eSpeed)
        {
            switch (eSpeed)
            {
                case Speeds.Slow:
                    {
                        return XYSpeedS;
                    }

                case Speeds.Medium:
                    {
                        return XYSpeedM;
                    }

                case Speeds.Fast:
                    {
                        return XYSpeedF;
                    }
            }

            return default;
        }

        public static XferPrintConfig Load(string configFileFullPath, ref Logger logger)
        {
            return Load("", configFileFullPath, ref logger);
        }

        public static XferPrintConfig Load(string configPath, string configFileName, ref Logger logger)
        {
            XferPrintConfig oXferPrintConfig = null;
            try
            {
                //logger.Debug("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                var serializer = new XmlSerializer(typeof(XferPrintConfig));

                // Could do some handling here, but I don't think it buys us much. There are .UnknownNode, .UnknownElement, and a few other .Unknown methods.
                // AddHandler serializer.UnknownNode

                var reader = new StreamReader(configPath + configFileName);
                oXferPrintConfig = (XferPrintConfig)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                //logger.Debug("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }

            return oXferPrintConfig;
        }
    }
}