using System;

namespace XferPrintLib.Utility
{
    public class PointHelper
    {
        public static double RotateXCoord(double x, double y, double th)
        {
            return x * Math.Cos(Math.PI / 180d * th) - y * Math.Sin(Math.PI / 180d * th);
        }

        public static double RotateYCoord(double x, double y, double th)
        {
            return x * Math.Sin(Math.PI / 180d * th) + y * Math.Cos(Math.PI / 180d * th);
        }
    }
}
