using System;
using NLog;

namespace XferPrintLib.Utility.Log
{
    public class Logger
    {
        private static DateTime _lastEvent = DateTime.Now;
        private static readonly NLog.Logger EventLogger = LogManager.GetCurrentClassLogger();

        public static void WriteEventLog(string strtext, string strval)
        {
            TimeSpan eventTimeDelta = DateTime.Now.Subtract(_lastEvent);
            _lastEvent = DateTime.Now;
            EventLogger.Debug($"({eventTimeDelta.TotalSeconds:0.0})  {strtext}   {strval}");
        }
    }
}
