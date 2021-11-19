using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using Logger = XferPrintLib.Utility.Log.Logger;

namespace XferPrintLib.Configuration
{
    public class XferPrintConfigValidator
    {
        private StringCollection collMessages = new StringCollection();

        private void ConfigValidatorHandler(object sender, ValidationEventArgs e)
        {
            Logger.WriteEventLog($"{e.Severity.ToString()}: XML Validation: ", e.Message);
            string test = $"{e.Severity.ToString()}: XML Validation: {e.Message}";
            if (e.Severity == XmlSeverityType.Error)
            {
                Debug.Write("ERROR: XML Validation: " + e.Message);
                collMessages.Add("XML: " + e.Message);
            }
        }

        public StringCollection ValFromDoc( string xdPath)
        {
            try
            {
                var xd = new XmlDocument();
                xd.Load(xdPath);
                var schemas = new XmlSchemaSet();
                collMessages.Clear();

                schemas.Add("", "XferPrintConfigSchema.xsd");
                xd.Schemas.Add(schemas);

                xd.Validate(ConfigValidatorHandler);

                return collMessages;
            }
            catch (Exception ex)
            {
                throw new FailedToParseXferPrintConfig(ex.Message);
            }

        }
    }
}
