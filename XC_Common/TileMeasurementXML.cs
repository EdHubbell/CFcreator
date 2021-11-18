using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NLog;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;

namespace XC_Common
{

    [Serializable]
    [XmlRoot("TileMeasurementXML")]
    public class TileMeasurementXML : XMLBaseObject
    {
        [XmlAttribute]
        public int TileX = 99;
        [XmlAttribute]
        public int TileY = 99;
        [XmlAttribute]
        public string PatternSetupName;

        // Probably best not to store the filename and the filepath in the actual file itself. That creates a link that breaks every time a file is moved on a drive.
        // We do fill those parameters when parsing, tho, so we can send them up to the database, where knowing a file's origin may be useful.
        // So they aren't set to XmlIgnore. Setting them up as elements will make people wonder. Which may be how you got here. 
        [XmlElement]
        public string FilePath = string.Empty;
        [XmlElement]
        public string FileName = string.Empty;

        public DUTMeasurementsXML DUTMeasurementsXML = new DUTMeasurementsXML();

        public TileMeasurementXML()
        {
        }

        public TileMeasurementXML(int TileX, int TileY, string PatternSetupName)
        {
            this.TileX = TileX;
            this.TileY = TileY;
            this.PatternSetupName = PatternSetupName;
        }

        public void ExportToCSV(string filePath, string fileName)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath + fileName))
                {
                    file.WriteLine("Row,Col,Lv,Cx,Cy,DW,Active,Threshold,Vf");
                    foreach (DUTMeasurementXML oDut in DUTMeasurementsXML)
                    {
                        file.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", oDut.DutY, oDut.DutX, oDut.Lum, oDut.Cx, oDut.Cy, oDut.DW, oDut.Active, oDut.Threshold, oDut.Vf));
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }


        public static TileMeasurementXML Load(string fileFullPath)
        {
            TileMeasurementXML tileMeasurementXML = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TileMeasurementXML));

                using (StreamReader reader = new StreamReader(fileFullPath))
                {
                    tileMeasurementXML = (TileMeasurementXML)serializer.Deserialize(reader);
                    reader.Close();
                }

                string fileName = fileFullPath.Substring(fileFullPath.LastIndexOf(@"\") + 1);
                string filePath = fileFullPath.Substring(0, fileFullPath.LastIndexOf(@"\") + 1);
                tileMeasurementXML.FileName = fileName;
                tileMeasurementXML.FilePath = filePath;

                // We also need to get the tile row and column from the filename at this time. 
                // It isn't elegant, but the R and C are encoded in the filename because we don't
                // really have a better way to send this value to the Radiant TrueTest software. 
                // So we send it encoded in the serial number prior to running the sequence. 
                // Perhaps we'll figure out a better way to do that, but this should work well for now. 
                ParseRowColFromFileName(tileMeasurementXML);


            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

            return tileMeasurementXML;
        }


        private static void ParseRowColFromFileName(TileMeasurementXML tileMeasurementXML)
        {
            // regex to find the _Rxx_Cyy_ string in the filename. Should also pick up negative values. 
            string regexRowCol = @"_R[-]?\d{2}_C[-]?\d{2}_";
            Match match = Regex.Match(tileMeasurementXML.FileName, regexRowCol);
            if (match.Success)
            {
                int index = match.Index;

                // Get to the starting R and eliminate the trailing underscore
                string rcString = tileMeasurementXML.FileName.Substring(index + 1, match.Length - 2);
                // Get down to the digits after the R and the C.
                string rString = rcString.Substring(1, rcString.IndexOf("_") - 1);
                string cString = rcString.Substring(rcString.IndexOf("C") + 1);

                int iRow = int.Parse(rString);
                int iCol = int.Parse(cString);

                // Getting these values into the object means that they'll be parsed into the database. 
                tileMeasurementXML.TileX = iCol;
                tileMeasurementXML.TileY = iRow;
            }

        }

        public static TileMeasurementXML Load(string filePath, string fileName)
        {
            return Load(filePath + fileName);
        }

        public override void Save(string filePath, string fileName)
        {
            // Override so we can populate the FilePath and FileName attributes.
            this.FilePath = filePath;
            this.FileName = fileName;
            base.Save(filePath, fileName);
        }

    }

}

