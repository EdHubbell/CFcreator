using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NLog;
using XC_Common;

namespace XC_Database
{
    public static class XProbe_Tasks
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void TestTask(string connectionString)
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                XMLInputParameters xmlIn = new XMLInputParameters();
                xmlIn.Upsert("Task", "Test");

                XmlDocument xDoc = SQLUtil.GetXmlDocFromStoredProcedure(connectionString, "XProbeTask", xmlIn);
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

        public static void UpsertTileProbeDataTask(string connectionString, TileMeasurementXML tileMeasurementXML )
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                              
                XMLInputParameters xmlIn = new XMLInputParameters();
                xmlIn.Upsert("Task", "UpsertTileMeasurementXML");
                xmlIn.InsertRawXML (tileMeasurementXML.AsXMLString());

                XmlDocument xDoc = SQLUtil.GetXmlDocFromStoredProcedure(connectionString, "XProbeTask", xmlIn);
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

    }

    //private void ProcessXMLOutputFiles(XmlDocument doc)
    //{
    //    int iFileCount = 1;

    //    try
    //    {
    //        logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

    //        //XMLOutputFilePaths  XMLOutputFileContents
    //        XmlElement root = doc.DocumentElement;
    //        XmlNode outputFilesNode = root.SelectSingleNode("OutputFiles"); // You can also use XPath here

    //        foreach (XmlNode outputFileNode in outputFilesNode)
    //        {
    //            if (outputFileNode.Name == "OutputFile")
    //            {
    //                Guid g = Guid.NewGuid();
    //                string fileName = g + ".xml";

    //                // MessageBox.Show(filePathNode.InnerText);
    //                // MessageBox.Show(outputFileContents.InnerXml);
    //                XmlDocument xmlOutputDoc = new XmlDocument();
    //                xmlOutputDoc.LoadXml(outputFileNode.InnerXml);
    //                xmlOutputDoc.Save(programConfig.OutputXMLFilePath + @"\" + fileName);
    //            }

    //        }

    //    }

    //    catch (Exception ex)
    //    {
    //        logger.Error(ex);
    //    }

    //    finally
    //    {
    //        logger.Info("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
    //    }


    //}

    //private void ProcessXMLMessages(XmlDocument doc)
    //{
    //    string messageText = "";
    //    string messageTitle = "";
    //    string messageType = "";

    //    try
    //    {
    //        logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

    //        //XMLOutputFilePaths  XMLOutputFileContents
    //        XmlElement root = doc.DocumentElement;
    //        XmlNode uiMessageNode = root.SelectSingleNode("UIMessage"); // You can also use XPath here

    //        foreach (XmlNode uiMessageSubNode in uiMessageNode)
    //        {
    //            switch (uiMessageSubNode.Name.ToUpper())
    //            {
    //                case "MESSAGETEXT":
    //                    messageText = uiMessageSubNode.InnerText;
    //                    break;
    //                case "MESSAGETITLE":
    //                    messageTitle = uiMessageSubNode.InnerText;
    //                    break;
    //                case "MESSAGETYPE":
    //                    messageType = uiMessageSubNode.InnerText;
    //                    break;
    //                default:
    //                    break;
    //            }
    //        }


    //        if (messageText.Length > 0)
    //        {
    //            if (messageType.ToUpper() == "STATUS")
    //            {
    //                lblStatus.Text = messageText;
    //            }
    //            else
    //            {
    //                if (messageTitle.Length == 0)
    //                {
    //                    messageTitle = "UIMessage from Database";
    //                }
    //                MessageBox.Show(messageText, messageTitle);
    //            }
    //        }



    //    }

    //    catch (Exception ex)
    //    {
    //        logger.Error(ex);
    //    }

    //    finally
    //    {
    //        logger.Info("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
    //    }


    //}

}
