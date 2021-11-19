using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Principal;


namespace XC_Database
{
    public class SQLUtil
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private const string SQL_EXCEPTION = "SQL Exception";


        public static DataRowCollection ExecQuery(string strSQL, SqlConnection SqlConn, ref SQLParameters dbParameters, bool ReturnSecondDataSetAsDRC, string DataSetTableName = null, int TimeoutInSeconds = -1)
        {
            string strSQLCommand = String.Empty;
            string strSQLErrorCommand = String.Empty;

            System.Data.SqlClient.SqlCommand oSQLCommand = null;
            System.Data.SqlClient.SqlDataAdapter oSQLDataAdapter = null;
            DataSet oInnerDataSet = new DataSet();
            DataRowCollection theDataRowCollection = null;

            try
            {
                strSQLErrorCommand = "";

                oSQLCommand = new System.Data.SqlClient.SqlCommand();
                oSQLCommand.CommandText = strSQL;

                if (TimeoutInSeconds != -1)
                {
                    oSQLCommand.CommandTimeout = TimeoutInSeconds;
                }

                if (dbParameters != null)
                {
                    dbParameters.AddParametersToSQLCommand(ref oSQLCommand, ref strSQLCommand);
                    strSQLCommand = strSQL + "\r\n" + strSQLCommand;
                    oSQLCommand.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    oSQLCommand.CommandType = CommandType.Text;
                }

                if (SqlConn.State != ConnectionState.Open)
                    SqlConn.Open();

                oSQLCommand.Connection = SqlConn;

                //Use a SQL Adapter to get a database
                oSQLDataAdapter = new System.Data.SqlClient.SqlDataAdapter(oSQLCommand);
                //Save when the transaction started
                DateTime dteStartTime = DateTime.Now;

                try
                {
                    oSQLDataAdapter.Fill(oInnerDataSet);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    strSQLErrorCommand = strSQLCommand;
                    throw new System.Exception(string.Format("{0} \r\n{1} on SQL:\r\n{2}", ex.Message, SQL_EXCEPTION, strSQL));
                }

                //if (oDataSet != null)
                //{
                //    if (DataSetTableName == null)
                //    {
                //        oDataSet = oInnerDataSet;
                //    }
                //    else
                //    {
                //        DataTableReader reader = new DataTableReader(oInnerDataSet.Tables[0]);
                //        oDataSet.Tables[DataSetTableName].Load(reader);
                //    }
                //}

                //Return a data row collection
                // If blReturnRecords Then
                if ((oInnerDataSet.Tables.Count == 0))
                {
                    //Throw New DataException("No data returned for SQL " & strSQL & ".")
                }
                else
                {
                    if ((ReturnSecondDataSetAsDRC == true) && (oInnerDataSet.Tables.Count == 2))
                    {
                        theDataRowCollection = oInnerDataSet.Tables[1].Rows;
                    }
                    else if ((ReturnSecondDataSetAsDRC == true) && (oInnerDataSet.Tables.Count < 2))
                    {
                        theDataRowCollection = null;
                    }
                    else
                    {
                        theDataRowCollection = oInnerDataSet.Tables[0].Rows;
                    }
                }

            }
            catch (Exception ex)
            {
                strSQLErrorCommand = strSQLCommand;
                throw;

            }
            finally
            {
                if ((oSQLCommand != null))
                {
                    oSQLCommand.Dispose();
                    oSQLCommand = null;
                }

                if ((oSQLDataAdapter != null))
                {
                    oSQLDataAdapter.Dispose();
                    oSQLDataAdapter = null;
                }

                if ((oInnerDataSet != null))
                {
                    oInnerDataSet.Dispose();
                    oInnerDataSet = null;
                }
            }
            return theDataRowCollection;

        }

        public static XmlDocument GetXmlDocFromStoredProcedure(string connectionString, string storedProcedureName, XMLInputParameters xmlInputParameters)
        {
            XmlDocument xDoc = new XmlDocument();

            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                string xmlResponse = SQLUtil.ExecuteXMLStoredProcedure(connectionString, storedProcedureName, xmlInputParameters);

                xDoc.LoadXml(xmlResponse);

            }

            catch (Exception ex)
            {
                logger.Error(ex);
            }

            finally
            {
                logger.Info("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }

            return xDoc;

        }


        public static string ExecuteXMLStoredProcedure(string connectionString, string storedProcedureName, XMLInputParameters xmlInputParameters)
        {

            SQLParameters oSQLParameters = null;
            DataRowCollection tDRC = null;
            string sReturnMessage = "ERROR";

            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                // There is no need to write the xmlInputParameters to the trace log - This is done by the stored procedure.

                using (SqlConnection oSqlConn = new SqlConnection(connectionString))
                {
                    oSQLParameters = new SQLParameters();
                    oSQLParameters.AddParameter("@XMLInputParameters", xmlInputParameters.ToString(), ParameterDirection.Input, SqlDbType.Xml);
                    oSQLParameters.AddParameter("@XMLOutputParameters", sReturnMessage, ParameterDirection.Output, SqlDbType.Xml, 4000);


                    tDRC = SQLUtil.ExecQuery(storedProcedureName, oSqlConn, ref oSQLParameters, false);

                    //(string.Format("{0}.{1}", MethodBase.GetCurrentMethod().ReflectedType, MethodBase.GetCurrentMethod().Name), string.Format("@XMLOutputParameters = {0}", clsSQLParameters.Item("@XMLOutputParameters").Value.ToString()), false, 1);

                    sReturnMessage = oSQLParameters["@XMLOutputParameters"].Value.ToString();

                }

            }

            catch (Exception ex)
            {
                logger.Error(ex);
                sReturnMessage = ex.Message;
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }


            return sReturnMessage;
        }

        /// <summary>
        /// Used when you want a result set back from an XML Stored procedure. 
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="storedProcedureName"></param>
        /// <param name="task"></param>
        /// <param name="nodeName"></param>
        /// <param name="storedProcedureParameters"></param>
        /// <returns></returns>
        public static async Task<string> GetXMLNodeFromStoredProcedure(string connectionString, string storedProcedureName, string task, string nodeName, List<KeyValuePair<string, string>> storedProcedureParameters)
        {
            string sResponse = null;
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                XMLInputParameters xmlIn = new XMLInputParameters();
                xmlIn.Upsert("Task", task);

                if (storedProcedureParameters != null)
                {
                    foreach (KeyValuePair<string, string> queryParameter in storedProcedureParameters)
                    {
                        xmlIn.Upsert(queryParameter.Key, queryParameter.Value);
                    }
                }

                XmlDocument xDoc = SQLUtil.GetXmlDocFromStoredProcedure(connectionString, storedProcedureName, xmlIn);

                XmlNode oXMLNode = xDoc.SelectSingleNode("//XMLOutputParameters/" + nodeName);

                if (oXMLNode != null)
                {
                    sResponse = oXMLNode.OuterXml;
                }

            }

            catch (Exception ex)
            {
                logger.Error(ex);
            }

            finally
            {
                logger.Info("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return sResponse;
        }

        
        public async static Task<List<T>> GetTableRows<T>(string sConnectionString, string storedProcedureName, string taskName, string nodeName)
        {
            List<T> oRows = null;

            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                string sRows = await XC_Database.SQLUtil.GetXMLNodeFromStoredProcedure(sConnectionString, storedProcedureName, taskName, nodeName, null);

                XmlSerializer deserializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(nodeName));

                using (TextReader reader = new StringReader(sRows))
                {
                    oRows = (List<T>)deserializer.Deserialize(reader);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }

            return oRows;

        }

        public async static Task<T> InsertTableRow<T>(string sConnectionString, string serializedTAsXML, string storedProcedureName, string taskName, string nodeName)
        {
            T oReturn = default(T);

            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                XMLInputParameters xmlIn = new XMLInputParameters();
                xmlIn.Upsert("Task", taskName);
                xmlIn.InsertRawXML(serializedTAsXML);

                XmlDocument xDoc = SQLUtil.GetXmlDocFromStoredProcedure(sConnectionString, storedProcedureName, xmlIn);

                XmlNode oXMLNode = xDoc.SelectSingleNode("//XMLOutputParameters/" + nodeName);

                if (oXMLNode != null)
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(T), new XmlRootAttribute(nodeName));

                    using (TextReader reader = new StringReader(oXMLNode.OuterXml))
                    {
                        oReturn = (T)deserializer.Deserialize(reader);
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }

            return oReturn;
        }



    }




    public class XMLInputParameters
    {
        private Dictionary<string, string> moInputParameters = new Dictionary<string, string>();
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private List<string> rawXmlList = new List<string>();

        public XMLInputParameters()
        {
            // default parameters.
            moInputParameters.Add("ComputerName", System.Environment.MachineName);
            //moInputParameters.Add("UserName", WindowsIdentity.GetCurrent().Name);
            moInputParameters.Add("UserName", System.Environment.UserName);
        }

        /// <summary>
        /// Upsert - Update or (if it isn't there already) insert.
        /// </summary>
        public void Upsert(string sKey, string sValue)
        {
            try
            {
                if (moInputParameters.ContainsKey(sKey) == false)
                {
                    moInputParameters.Add(sKey, sValue);
                }
                else
                {
                    moInputParameters[sKey] = sValue;
                }
            }
            catch (Exception ex)
            {
                // Should be a rare error if we can't add it to the parameters because it already exists.
            }
        }

        public void InsertRawXML(string rawXml)
        {
            rawXmlList.Add(rawXml);
        }   

        public override string ToString()
        {
            string sReturn = string.Empty;

            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);


                using (StringWriter oXMLStringWriter = new StringWriter())
                {

                    XmlWriterSettings oXMLWriterSettings = new XmlWriterSettings();
                    oXMLWriterSettings.Indent = true;
                    oXMLWriterSettings.IndentChars = "\t"; // tab
                    oXMLWriterSettings.OmitXmlDeclaration = true;
                    oXMLWriterSettings.Encoding = System.Text.Encoding.UTF8;

                    // This allows for us to get rid of the xmlns tags that are added by default when serializing a .NET object to XML.
                    XmlSerializerNamespaces blankXmlNamespaces = new XmlSerializerNamespaces();
                    blankXmlNamespaces.Add(string.Empty, string.Empty);

                    using (XmlWriter oXMLWriter = XmlWriter.Create(oXMLStringWriter, oXMLWriterSettings))
                    {

                        oXMLWriter.WriteStartDocument();

                        oXMLWriter.WriteStartElement("XMLInputParameters");

                        foreach (string sKey in moInputParameters.Keys)
                        {
                            oXMLWriter.WriteElementString(sKey, moInputParameters[sKey]);
                        }

                        if (rawXmlList.Count > 0)
                        {
                            foreach (string rawXml in rawXmlList)
                            {
                                oXMLWriter.WriteRaw(rawXml);
                            }
                        }

                        oXMLWriter.WriteEndElement();
                        //XMLInputParameters

                        oXMLWriter.WriteEndDocument();

                    }

                    sReturn = oXMLStringWriter.ToString();

                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }

            return sReturn;

        }

    }
}




