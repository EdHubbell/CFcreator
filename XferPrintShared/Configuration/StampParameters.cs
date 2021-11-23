using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace XferPrintLib.Configuration
{
    [Serializable]
    [XmlRoot("ProcessParameters")]
    public class StampParameters : XMLBaseObject
    {
        [Browsable(false)]
        public double StampXOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double StampYOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double StampZOrigin { get; set; } = 999d;
        [Browsable(false)]
        public double StampTHXOrigin { get; set; } = 0d;
        [Browsable(false)]
        public double StampTHYOrigin { get; set; } = 0d;
        [Browsable(false)]
        public double ZSave { get; set; } = 999d;
        [Browsable(false)]
        public double StampBeta { get; set; } = 999d;
        [Browsable(false)]
        public int StampXPosts { get; set; } = 2;
        [Browsable(false)]
        public int StampYPosts { get; set; } = 2;
        [Browsable(false)]
        public double StampXPostPitch { get; set; } = 0.35d;
        [Browsable(false)]
        public double StampYPostPitch { get; set; } = 0.25d;
        [Browsable(false)]
        public double StampAXPosition { get; set; } = 999d;
        [Browsable(false)]
        public double StampAYPosition { get; set; } = 999d;
        [Browsable(false)]
        public double StampBXPosition { get; set; } = 999d;
        [Browsable(false)]
        public double StampBYPosition { get; set; } = 999d;
        [Browsable(false)]
        public string StampRegPatternFilename { get; set; } = @"C:\XferPrint\Patterns\testPat_Source_2.vpp";

        public static StampParameters Load(string RecipePath)
        {
            StampParameters oXferPrintRecipe = null;
            try
            {
                // logger.Debug("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name)
                var serializer = new XmlSerializer(typeof(StampParameters));

                // Could do some handling here, but I don't think it buys us much. There are .UnknownNode, .UnknownElement, and a few other .Unknown methods.
                // AddHandler serializer.UnknownNode

                var reader = new StreamReader(RecipePath);
                oXferPrintRecipe = (StampParameters)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            // logger.[Error](ex)
            finally
            {
                // logger.Debug("exiting  {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name)
            }

            return oXferPrintRecipe;
        }

        public sXYd GetPostPos(int i, int j)
        {
            sXYd GetPostPosRet = default;
            if (i < StampXPosts & j < StampYPosts)
            {
                GetPostPosRet.X = StampXOrigin + i * StampXPostPitch;
                GetPostPosRet.Y = StampYOrigin + j * StampYPostPitch;
            }

            return GetPostPosRet;
        }
    }
}