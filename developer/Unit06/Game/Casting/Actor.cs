using System;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    /// space.
    /// </para>
    /// </summary>
    public class Actor
    {
        private string _text = "";
        private int _fontSize = 15;
        private Color _color = Constants.WHITE;
        private Point _position = new Point(0, 0);
        private Point _velocity = new Point(0, 0);

        public Actor()
        {
        }

        public Color GetColor()
        {
            return _color;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public string GetText()
        {
            return _text;
        }

        public Point GetVelocity()
        {
            return _velocity;
        }

        public virtual void MoveNext()
        {
            int x = ((_position.GetX() + _velocity.GetX()) + Constants.MAX_X) % Constants.MAX_X;
            int y = ((_position.GetY() + _velocity.GetY()) + Constants.MAX_Y) % Constants.MAX_Y;
            _position = new Point(x, y);
        }
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this._color = color;
        }
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this._fontSize = fontSize;
        }

        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this._position = position;
        }

        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this._text = text;
        }

        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this._velocity = velocity;
        }

    }
}