using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace XC_Common
{
    public static class DUTMath
    {       
        public static PointF GetDUTLocation(double XOffset, double YOffset, int DutX, int DutY, double XSpacing, double YSpacing, double Theta)
        {
            PointF DUTLocation = new PointF();

            // If we assume an orthagonal plane, then we can just calculate the point using offsets.
            DUTLocation = new PointF(Convert.ToInt32(DutX * XSpacing + XOffset), Convert.ToInt32(DutY * YSpacing + YOffset));

            // If we need to include theta, then things get tricky.
            if (Theta != 0)
            {
                // The center is the upper left device coordinate (0,0). That device coordinate is 
                // specified in the XOffset and YOffset parameters.
                PointF CenterPoint = new PointF((float)XOffset, (float)YOffset);
                DUTLocation = RotatePoint(DUTLocation, CenterPoint, Theta);
            }

            return DUTLocation;
        }

        //Based on https://stackoverflow.com/questions/13695317/rotate-a-point-around-another-point
        static PointF RotatePoint(PointF pointToRotate, PointF centerPoint, double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            return new PointF
            {
                X =
                    (float)
                    (cosTheta * (pointToRotate.X - centerPoint.X) -
                    sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X),
                Y =
                    (float)
                    (sinTheta * (pointToRotate.X - centerPoint.X) +
                    cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y)
            };
        }

    }
}
