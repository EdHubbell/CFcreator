﻿using System;

namespace XferPrintLib
{


    public struct sXYd
    {
        public double X;
        public double Y;
    }

    public struct sXYAd
    {
        public double X;
        public double Y;
        public double A;
    }

    public struct sXYASCd
    {
        public double X;
        public double Y;
        public double A;
        public double S;
        public double C;
    }
    public struct TargetSourceAlignmentResults
    {
        public double X;
        public double Y;
        public double A;
        public double TargetS;
        public double TargetC;
        public double SourceS;
        public double SourceC;
    }
    public struct sXYi
    {
        public int X;
        public int Y;
    }

    public struct sLH
    {
        public double Low;
        public double High;
    }

    public struct sXYZd
    {
        public double X;
        public double Y;
        public double Z;
    }

    public struct sRCI
    {
        public int Row;
        public int Column;
        public int Index;
    }

    public struct sRCRCI
    {
        public int RegionRow;
        public int RegionCol;
        public int Row;
        public int Column;
        public int Index;
    }


    public struct sDTP
    {
        public string ProcessRecipePath;
        public sSource Source;
        // Public Stamp As sStamp
        public sTarget Target;
        // Public Clean As sClean
        public sMetrology Metrology;
        public string CycleFilePath;
        public bool CycleFileValid;
        public sRecipe Recipe;
        public string Note;
    }

    public struct sMetrology
    {
        public double Mag;
        public sXYd FieldOfView; // in mm
        public sXYi NbOfImages;
        public sXYd ImagePitch; // in mm
        public MetroSubType MetroSubsType; // Source or Target
        public MetroRunType MetroRunType; // single field or batch-cycle
        public MetroPRType MetroPRType; // two-image position or count only
        public MetroFrameType MetroFrameType; // ContinuousGrab or Triggered
        public sXYi NbOfChipletsInFOV;
        public sXYd ViewPosition;
        public string CycleFilePath;
        public sXYd BatchOffset;
        public int MetroUserCountInImage;
        public int MetroUserTotalCount;
    }

    public struct sRecipe
    {
        public double ZClearanceHeight;
        public DateTime StartTime; // Actually used as a start time for one print
        public DateTime FinishTime; // one print finish time
        public DateTime RecipeStartTime; // used for duration of recipe (all lines/prints of cycle file)
        public TimeSpan RecipeElapsedTime; // 
        public int NbofPrints;
    }

    public struct sSource
    {
        public sXYd CalculatedXYWaferOrigin;
        public string WaferNum; // used for Semprius database generated serial number
        public string WaferSN; // used for MES serial number - generated by process engineers - is alias for database
        public sXYd UserOriginGMUPos;
        public sRCRCI UserOriginGMU;
        public sXYd CustomNavOrigin;  // 19JAN2016 for navigation wrt CAD wafer layout
        public double FocusHeight;
    }

    public struct sTarget
    {

        // 19JAN11 Adding User Vars for Blind save of 1,1 position
        public sXYd UserOriginPos;
        public sRCI UserOriginCoord;
        public sRCI UserRegionCoord;  // 25MAR11
        public sXYd CustomNavOrigin; // 19JAN2016 for navigation wrt CAD wafer layout
        public sXYd CalculatedXYWaferOrigin;

        // Recipe Parameters
        public string WaferNum;
        public string WaferSN;
        public double FocusHeight;
    }

    public struct sStamp
    {
        public sPatternFileParams RegistrationMarks;
        public sXYZd Origin;
        public sXYi NbPosts;
        public sXYd PostsPitch;
        public double Beta;
        public sXYd RegPosA;
        public sXYd RegPosB;
        public double ZSave; // position of Z stage during save stamp origin
    }

    public struct sPatternFileParams
    {
        public string PatternFileName;
        public string PatternFileNameLo;
        public string TBlockFilename;
        public bool TBlockInUse;
        public sXYd Offset;
        public double AcceptThreshold;
        public sLH Angle;
        public sLH ScaleX;
        public sLH ScaleY;
    }
}