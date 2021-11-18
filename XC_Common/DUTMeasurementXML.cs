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

namespace XC_Common
{
    [Serializable]
    [XmlRoot("DUTMeasurementXML")]
    public class DUTMeasurementXML
    {
        [XmlAttribute]
        public int DutX;
        [XmlAttribute]
        public int DutY;
        [XmlAttribute]
        public double Cx;
        [XmlAttribute]
        public double Cy;
        [XmlAttribute]
        public double DW;
        [XmlAttribute]
        public double Lum;
        [XmlAttribute]
        public bool Active;
        [XmlAttribute]
        public double Threshold;
        [XmlAttribute]
        public double Vf;

        public DUTMeasurementXML()
        {
        }


        public DUTMeasurementXML(int DutX, int DutY, double CX, double CY, double Lum, double DW, bool Active, double Threshold, double Vf)
        {
            this.DutX = DutX;
            this.DutY = DutY;
            this.Cx = CX;
            this.Cy = CY;
            this.Lum = Lum;
            this.DW = DW;
            this.Active = Active;
            this.Threshold = Threshold;
            this.Vf = Vf;
        }

    }


    [Serializable]
    [XmlRoot("DUTMeasurementsXML")]
    public class DUTMeasurementsXML : List<DUTMeasurementXML>
    {
        public DUTMeasurementsXML()
        {
        }
    }
}
