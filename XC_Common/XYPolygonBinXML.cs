using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XC_Common
{
    [Serializable]
    [XmlRoot("XYPolygonBinXML")]
    public class XYPolygonBinXML
    {
        [XmlAttribute]
        public double x1;
        [XmlAttribute]
        public double y1;
        [XmlAttribute]
        public double x2;
        [XmlAttribute]
        public double y2;
        [XmlAttribute]
        public double x3;
        [XmlAttribute]
        public double y3;
        [XmlAttribute]
        public double x4;
        [XmlAttribute]
        public double y4;
    }
}
