using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace CFCreator
{
    static class Functions
    {

        //initializes list of wafer maps
        public static List<WaferMap> WaferMaps = new List<WaferMap>();

        //string builder
        public static StringBuilder sb = new StringBuilder();

        ///<summary>
        ///Bool to check if rectangle is inside circle
        /// </summary>
        public static bool CheckRectInCircle(Rectangle rectangle, Point center, double radius)
        {
            Point[] corners = new Point[]
            {
                new Point(rectangle.Left, rectangle.Top),
                new Point(rectangle.Right, rectangle.Top),
                new Point(rectangle.Left, rectangle.Bottom),
                new Point(rectangle.Right, rectangle.Bottom)
            };

            bool inCircle = true;
            foreach (Point point in corners)
            {
                double dist = Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));
                if (dist > radius) inCircle = false;
            }
            return inCircle;
        }
        public static void CountTiles(CFCreatorForm form)
        {
            foreach (WaferMap Wafer in Functions.WaferMaps)
            {
                Wafer.ClickedTiles.Clear();
                foreach (MapTile tile in Wafer.MapTileList.Where(x => x.Color == Color.Green))
                {
                    Wafer.ClickedTiles.Add(new TileID(tile.ID.I, tile.ID.J, tile.ID.K, tile.ID.L));

                }
                
            }

        }
        public static void WriteCF(CFCreatorForm form)
        {
            int numlines = WaferMaps[0].ClickedTiles.Count();
            if (WaferMaps[1].ClickedTiles.Count() * CFCreatorForm.picksperfield < numlines)
            {
                Debug.WriteLine("insufficient picks to complete target");
            }
            else
            {
                string filepath;
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                savefile.FilterIndex = 2;
                savefile.RestoreDirectory = true;
                savefile.InitialDirectory = @"X:\";

                sb.Clear();
                sb.Append("UniqueID, Pick.WaferID, Pick.RegionRow, Pick.RegionColumn, Pick.Row, Pick.Column, Pick.Index, Place.WaferID, Place.RegionRow, Place.RegionColumn, Place.Row, Place.Column\r\n");
                int srcfield = 1;
                int pkindex = CFCreatorForm.startindex;
                
                for (int i = 1; i <= numlines; i++)
                {
                    if (pkindex > CFCreatorForm.picksperfield)
                    { 
                        srcfield++;
                        pkindex = 1;
                    }
                    string cfline = new string
                        (
                        i.ToString() + "," +
                        CFCreatorForm.sourceid + "," +
                        WaferMaps[1].ClickedTiles[srcfield-1].ToString() + "," +
                        pkindex + "," +
                        CFCreatorForm.targetid + "," +
                        WaferMaps[0].ClickedTiles[i-1].ToString() + "\r\n"
                        );
                    sb.Append(cfline);
                    pkindex++;
                }
                Debug.WriteLine(sb);
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    filepath = savefile.FileName;
                    File.WriteAllText(filepath, sb.ToString());
                }
            }

        }
    }
}
