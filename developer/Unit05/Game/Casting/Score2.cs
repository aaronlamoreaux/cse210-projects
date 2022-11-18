using System;


namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A tasty item that snakes like to eat.</para>
    /// <para>
    /// The responsibility of Food is to select a random position and points that it's worth.
    /// </para>
    /// </summary>
    public class Score2 : Actor
    {
        private int _points = 0;
        private Point _position = new Point(0, 0);

        /// <summary>
        /// Constructs a new instance of an Food.
        /// </summary>
        public Score2()
        {
            AddPoints(0);
            NewPosition(_position);
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points)
        {
            this._points += points;
            SetText($"Score: {this._points}");
        }
        
        public void NewPosition(Point position) {
            int x = Constants.MAX_X / 2 + 373;
            int y = Constants.MAX_Y;
            position = new Point(x,y);
            this.SetPosition(position);
        }
    }
}