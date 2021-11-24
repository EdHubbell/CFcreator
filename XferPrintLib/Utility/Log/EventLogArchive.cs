using System;

namespace XferPrintLib.Utility.Log
{
    public class EventLogArchive
    {
        public delegate void CopyCaller(string tstamp);

        public delegate void DeleteCaller();

        public void EventLogCopy(string tstamp)
        {
            string filename = @"C:\XferPrint\Data\Log\EventLog.txt";
            string newfilename = @"C:\XferPrint\Data\Log\EventLog" + tstamp + ".txt";
            // Archive file to timestamped file
            try
            {
                System.IO.File.Copy(filename, newfilename);
            }
            catch (Exception ex)
            {
                Logger.WriteEventLog("ERROR: Exception in EventLogCopy: ", ex.Message);
            }
        }

        public void EventLogDelete()
        {
            // Delete original file (then starts anew)
            try
            {
                System.IO.File.Delete(@"C:\XferPrint\Data\Log\EventLog.txt");
            }
            catch (Exception ex)
            {
                Logger.WriteEventLog("ERROR: Exception in EventLogDelete: ", ex.Message);
            }
        }
    }

}