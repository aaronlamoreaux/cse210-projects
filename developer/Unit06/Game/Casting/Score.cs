using System;


namespace Unit06.Game.Casting {
    public class Score : Actor {
        private int _points = 0;
        private Point _position = new Point(0, 0);

        public Score() {
            AddPoints(0);
            NewPosition(_position);
        }

        public void AddPoints(int points) {
            this._points += points;
            SetText($"Score: {this._points}");
        }
        
        public void NewPosition(Point position) {
            int x = Constants.MAX_X;
            int y = Constants.MAX_Y;
            position = new Point(x,y);
            this.SetPosition(position);
        }
    }
}