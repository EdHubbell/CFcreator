using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CFCreator
{
    public partial class WaferMap : UserControl
    {
        public WaferMap()
        {
            InitializeComponent();
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseEnter += PictureBox_MouseEnter;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseLeave += PictureBox_MouseLeave;
            pictureBox.BackgroundImage = new Bitmap(1000, 1000);
            pictureBox.Image = new Bitmap(1000, 1000);

        }

        public List<MapTile> MapTileList = new List<MapTile>();
        //rawClickedTiles is the pre-sorted list
        public List<TileID> rawClickedTiles = new List<TileID>();
        public List<TileID> OrderClickedTiles = new List<TileID>();
        public List<TileID> ClickedTiles = new List<TileID>();
        private RectangleF InfoRectangle;
        public Size RegGridSize = new Size(10, 10);
        public Size ClustGridSize = new Size(10, 10);
        public Size TotGridSize
        {
            get {
                return new Size
                   (
                      RegGridSize.Width * ClustGridSize.Width, 
                      RegGridSize.Height * ClustGridSize.Height
                   );
                 }
        }



        ///<summary>
        ///Toggle the highlight param for the tile under the cursor
        /// </summary>
        /// <param name="position"></param>
        /// <param name="pbx"></param>
        private void HighlightMapTile(Point position, PictureBox pbx)
        {
            Point zoomPos = ZoomMousePos(position, pbx);
            MapTileList.ForEach(x => x.Highlight = x.Rectangle.Contains(zoomPos));
            DrawTiles(pbx);
        }
        ///<summary>
        ///change the color of the tile under the cursor
        /// </summary>
        /// <param name="click"></param>
        /// <param name="pbx"></param>
        /// <param name="waitForExit"></param>

        public void ClickMapTile(Point click, PictureBox pbx, bool waitForExit = false)
        {

            Point zoomClick = ZoomMousePos(click, pbx);
            foreach (MapTile tile in MapTileList.Where(x => x.Rectangle.Contains(zoomClick)))
            {
                if (tile.Rectangle.Contains(zoomClick))
                {
                    if (waitForExit && tile.Highlight)
                        return;
                    tile.ChangeColor();

                    //adds or removes tile from ClickedTiles.  if ClickOrderCheckBox isn't checked, the list will be cleared and recompiled
                    if (tile.Color == Color.Green)
                    {
                        OrderClickedTiles.Add(tile.ID);
                    }
                    else
                    {
                        OrderClickedTiles.Remove(tile.ID);
                    }
                  
                }
            }
            DrawTiles(pbx);
        }

        public void DrawTiles(PictureBox pbx)
        {
            //for timing how long a process takes
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            Bitmap bitmap = (Bitmap)pbx.BackgroundImage.Clone();
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                //Clear last tile
                g.FillRectangle(new SolidBrush(SystemColors.Control), InfoRectangle);

                MapTile tileUnderCursor = null;
                foreach (MapTile tile in MapTileList.Where(x => x.NeedsUpdate || x.Highlight))
                {
                    if (tile.Highlight)
                    {

                        //cell will always be highlighted when it changes color
                        g.FillRectangle(new SolidBrush(tile.Color), tile.Rectangle);
                        g.FillRectangle(new SolidBrush(Color.FromArgb(90, Color.Black)), tile.Rectangle);
                        tileUnderCursor = tile;
                    }
                    else
                    {
                        //look for previously highlighted cells
                        double A = bitmap.GetPixel(tile.Rectangle.X, tile.Rectangle.Y).A;
                        if (A != 100)
                            g.FillRectangle(new SolidBrush(tile.Color), tile.Rectangle);
                        // A=100 is the color value for highlighted
                    }
                }

                // display for cursor position in wafer coordinates
                if (tileUnderCursor != null)
                {
                    //These options help with text drawing
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    //Draw new text for tile location
                    string location = tileUnderCursor.ID.ToString();
                    Font font = new Font("Tahoma", 25);
                    SizeF size = g.MeasureString(location, font);
                    InfoRectangle = new RectangleF(bitmap.Width - size.Width * 1.1f, size.Height * 1.1f, size.Width, size.Height);
                    g.DrawString(location, font, Brushes.Black, InfoRectangle);
                }

            }
            //updates background image to be the highlighted and colored tiles
            pbx.BackgroundImage = bitmap;

            //Output the time for this method's duration
            sw.Stop();
            //Debug.WriteLine(sw.Elapsed);
        }


        /// <summary>
        /// Copy paste method for adjusting mouse pos to pictureBox set to Zoom
        /// </summary>
        /// <param name="click"></param>
        /// <param name="form"></param>
        /// <returns></returns>
        public static Point ZoomMousePos(Point click, PictureBox pbx)
        {
            float BackgroundImageAspect = pbx.BackgroundImage.Width / (float)pbx.BackgroundImage.Height;
            float controlAspect = pbx.Width / (float)pbx.Height;
            PointF pos = new PointF(click.X, click.Y);
            if (BackgroundImageAspect > controlAspect)
            {
                float ratioWidth = pbx.BackgroundImage.Width / (float)pbx.Width;
                pos.X *= ratioWidth;
                float scale = pbx.Width / (float)pbx.BackgroundImage.Width;
                float displayHeight = scale * pbx.BackgroundImage.Height;
                float diffHeight = pbx.Height - displayHeight;
                diffHeight /= 2;
                pos.Y -= diffHeight;
                pos.Y /= scale;
            }
            else
            {
                float ratioHeight = pbx.BackgroundImage.Height / (float)pbx.Height;
                pos.Y *= ratioHeight;
                float scale = pbx.Height / (float)pbx.BackgroundImage.Height;
                float displayWidth = scale * pbx.BackgroundImage.Width;
                float diffWidth = pbx.Width - displayWidth;
                diffWidth /= 2;
                pos.X -= diffWidth;
                pos.X /= scale;
            }
            return new Point((int)pos.X, (int)pos.Y);
        }




        #region mouseEvents

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        /// <summary>
        /// Resets Cursor to default arror when leaving pictureBox
        /// </summary>
        {
            Cursor = Cursors.Default;
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        /// <summary>
        /// Changes cursor to cross when inside pictureBox
        /// </summary>
        {
            Cursor = Cursors.Cross;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        /// <summary>
        /// Event for moving mouse over square.
        /// Contains if statement to handle holding down left mouse button.
        /// </summary>
        {
            if (e.Button == MouseButtons.Left)
                ClickMapTile(e.Location, (PictureBox)sender, waitForExit: true);
                HighlightMapTile(e.Location, (PictureBox)sender);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        /// <summary>
        /// Handles mouse click over square
        /// </summary>
        {
            ClickMapTile(e.Location, (PictureBox)sender);
        }

        #endregion
    }
}
