using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using XferPrintLib.Utility.Log;

namespace XferPrintLib.Configuration
{
    public class XferPrintConfigReader : XferXmlReader<XferPrintConfig>
    {
        public XferPrintConfigReader() : base("XferPrintConfigSchema.xsd")
        {
        }
    }

    public class XferPrintRecipeReader : XferXmlReader<XferPrintRecipe>
    {
        public XferPrintRecipeReader() : base("SerializedXferPrintProcessRecipeSchema.xsd")
        {
        }
    }
    public class XferXmlReaderResult<T>
    {
        public StringCollection Errors { get; set; }
        public T Object { get; set; }
    }

    public class XferXmlReader<T>
    {
        private StringCollection collMessages = new StringCollection();
        private readonly string _xsdFilePath;

        public XferXmlReader(string xsdFilePath)
        {
            _xsdFilePath = xsdFilePath;
        }

        public XferXmlReaderResult<T> Read(string xdPath)
        {
            return new XferXmlReaderResult<T>
            {
                Errors = ValFromDoc(xdPath),
                Object = ReadObject(xdPath)
            };
        }

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

        public StringCollection ValFromDoc(string xdPath)
        {
            try
            {
                var xd = new XmlDocument();
                xd.Load(xdPath);
                var schemas = new XmlSchemaSet();
                collMessages.Clear();

                schemas.Add("", _xsdFilePath);
                xd.Schemas.Add(schemas);

                xd.Validate(ConfigValidatorHandler);

                return collMessages;
            }
            catch (Exception ex)
            {
                throw new FailedToParseXferPrintConfig(ex.Message);
            }

        }

        public T ReadObject(string RecipePath)
        {
            T oConfig;
            try
            {
                var serializer = new XmlSerializer(typeof(T));

                var reader = new StreamReader(RecipePath);
                oConfig = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                return default(T);
            }
            finally
            {
                // logger.Debug("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name)
            }

            return oConfig;
        }
    }
}
