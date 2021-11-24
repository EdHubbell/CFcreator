using System;

namespace XferPrintLib.Configuration
{
    public class FailedToParseXferPrintConfig : Exception
    {
        public FailedToParseXferPrintConfig(string message) : base(message) {}
    }
}