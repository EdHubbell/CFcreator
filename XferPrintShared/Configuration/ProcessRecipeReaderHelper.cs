using System;
using System.IO;
using System.Xml.Serialization;

namespace XferPrintLib.Configuration
{
    public class ProcessRecipeReaderHelper
    {
        public static XferPrintRecipe LoadRecipe(string RecipePath)
        {
            XferPrintRecipe oXferPrintRecipe = null;
            try
            {
                var serializer = new XmlSerializer(typeof(XferPrintRecipe));

                var reader = new StreamReader(RecipePath);
                oXferPrintRecipe = (XferPrintRecipe)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // logger.Debug("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name)
            }

            return oXferPrintRecipe;
        }

        /// <summary>
        /// Operator is selecting a Process Recipe to combine with the currently loaded Process Recipe
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        public static bool ImportSerializedRecipe(string FilePath)
        {
            try
            {
                AppConfiguration.XferRecipe = LoadRecipe(FilePath);
                if (AppConfiguration.XferRecipe is object && AppConfiguration.XferRecipe.Target is object && AppConfiguration.XferRecipe.Source is object && AppConfiguration.XferRecipe.Stamp is object && AppConfiguration.XferRecipe.Recipe is object && AppConfiguration.XferRecipe.Metrology is object && AppConfiguration.XferRecipe.Clean is object)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
