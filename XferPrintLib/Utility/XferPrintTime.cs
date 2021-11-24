using System;

namespace XferPrintLib.Utility
{
    public class XferPrintTime
    {
        public static string GetTimeStamp()
        {
            return GetTimeStamp(DateTime.Now);
        }
        public static string GetTimeStamp(DateTime value)
        {
            return value.ToString("MM-dd-yyyy_HH-mm-ss");
        }
    }
}
