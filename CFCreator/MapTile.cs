using System;
using System.Drawing;


namespace CFCreator
{
    public struct TileID
    {
        public TileID(int i, int j, int k, int l)
        {
            I = i;
            J = j;
            K = k;
            L = l;
        }
        public int I { get; }
        public int J { get; }
        public int K { get; }
        public int L { get; }

        public override string ToString() => $"{I},{J},{K},{L}";
    }
    public class MapTile
    {
        private static Color[] myColors = new Color[] { Color.White, Color.Green };

        private bool _NeedsUpdate = true;
        ///<summary>
        ///This will reduce the number of drawing iterations
        ///</summary>
        public bool NeedsUpdate
        //will throw public flag for updating then turn false
        {
            get
            {
                if (_NeedsUpdate)
                {
                    //if private update returns true, then set public to true and turn private to false
                    _NeedsUpdate = false;
                    return true;
                }
                return false;
            }
        }

        private Rectangle _Rectangle;
        public Rectangle Rectangle
        {
            get { return _Rectangle; }
        }

        private Color _Color = myColors[0];
        public Color Color
        {
            get { return _Color; }
        }

        private bool _LastHighlight;
        private bool _Highlight;
        public bool Highlight
        {
            get { return _Highlight; }
            set
            {
                _Highlight = value;
                if (_LastHighlight != _Highlight)
                ///<summary>
                ///just a little extra funcitonality to flip the update flag
                ///... as a treat
                /// </summary>
                {
                    _NeedsUpdate = true;
                    _LastHighlight = _Highlight;
                }
            }
        }

        private TileID _ID;
        public TileID ID
        {
            get { return _ID; }
        }
        public MapTile(Rectangle rectangle, TileID id)
        {           
            _Rectangle = rectangle;
            _ID = id;
        }

        public void ChangeColor()
        {
            int colorIdx = Array.IndexOf(myColors, _Color);
            _Color = colorIdx < myColors.Length - 1 ? myColors[colorIdx + 1] : myColors[0];
            _NeedsUpdate = true;
        }
    }
}
