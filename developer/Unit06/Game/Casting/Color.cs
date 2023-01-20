using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    public class Color
    {
        private int _red = 0;
        private int _green = 0;
        private int _blue = 0;
        private int _alpha = 255;

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        public int GetAlpha()
        {
            return _alpha;
        }

        public int GetBlue()
        {
            return _blue;
        }

        public int GetGreen()
        {
            return _green;
        }

        public int GetRed()
        {
            return _red;
        }

    }
}