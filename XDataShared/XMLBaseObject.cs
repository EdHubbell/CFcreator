using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using NLog;

namespace XDataShared
{
    public class XMLBaseObject
    {
        protected static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Rids us of the XML Declaration in the beginning and sets the encoding and indention for the XML.
        /// </summary>
        protected static XmlWriterSettings GetXmlWriterSettings()
        {
            XmlWriterSettings oXMLWriterSettings = new XmlWriterSettings();

            var _with1 = oXMLWriterSettings;
            _with1.Indent = true;
            //.IndentChars = (ControlChars.Tab) The default is 2 spaces - Let's stick with that.
            _with1.OmitXmlDeclaration = true;
            _with1.Encoding = System.Text.Encoding.UTF8;

            return oXMLWriterSettings;
        }


        /// <summary>
        /// Avoids the xmlns tags that are typically added when serializing a .NET object to XML
        /// </summary>
        protected static XmlSerializerNamespaces GetBlankXmlNamespaces()
        {
            XmlSerializerNamespaces blankXmlNamespaces = new XmlSerializerNamespaces();
            blankXmlNamespaces.Add(string.Empty, string.Empty);
            return blankXmlNamespaces;
        }


        public string AsXMLString()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, GetXmlWriterSettings()))
            {
                xmlSerializer.Serialize(writer, this, GetBlankXmlNamespaces());
                return stream.ToString();
            }
        }

        /// <summary>
        ///  Serialize the XML Object into a file.
        /// </summary>
        public virtual void Save(string filePath, string fileName)
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                // No need to check to see if the path already exists - CreateDirectory does that for us.
                Directory.CreateDirectory(filePath);

                XmlSerializer writer = new XmlSerializer(this.GetType());

                System.IO.StreamWriter file = new System.IO.StreamWriter(filePath + fileName);
                using (XmlWriter oXmlWriter = XmlWriter.Create(file, GetXmlWriterSettings()))
                {
                    writer.Serialize(oXmlWriter, this, GetBlankXmlNamespaces());
                }
                file.Close();
            }

            catch (Exception ex)
            {
                logger.Error(ex);
            }

            finally
            {
                logger.Info("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }


        public static T Load<T>(string filePath, string fileName)
        {
            T oDeserializedObject = default(T);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                StreamReader reader = new StreamReader(filePath + fileName);
                oDeserializedObject = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                return default(T);
            }
            finally
            {
            }

            return oDeserializedObject;
        }

    }
}
