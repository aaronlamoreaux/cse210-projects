using System;
using System.Collections.Generic;
using System.Data;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the cycle1 
    /// collides with the cycle2, or the cycle1 collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool _isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (_isGameOver == false)
            {
                HandleSegmentCollisions(cast);
                HandleTailGrowth(cast);
                HandleGameOver(cast);
            }
        }
        /// <summary>
        /// Sets the game over flag if the cycle1 collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            Cycle1 cycle1 = (Cycle1)cast.GetFirstActor("cycle1");
            Actor head1 = cycle1.GetHead();
            List<Actor> segments1 = cycle1.GetBody();

            Cycle2 cycle2 = (Cycle2)cast.GetFirstActor("cycle2");
            Actor head2 = cycle2.GetHead();
            List<Actor> segments2 = cycle2.GetBody();

            Score score = (Score)cast.GetFirstActor("score");
            Score2 score2 = (Score2)cast.GetFirstActor("score2");

            int points = 10;

            foreach (Actor segment in segments1) {
                foreach (Actor segment2 in segments2) {
                    if (head2.GetPosition().Equals(segment.GetPosition()) || head2.GetPosition().Equals(segment2.GetPosition())) 
                    {
                        score.AddPoints(points);
                        _isGameOver = true;
                    }
                    else if (head1.GetPosition().Equals(segment2.GetPosition()) || head1.GetPosition().Equals(segment.GetPosition())) 
                    {
                        score2.AddPoints(points);
                        _isGameOver = true;
                    }
                }
            }
        }

        private void HandleTailGrowth(Cast cast)
        {
            Cycle1 cycle1 = (Cycle1)cast.GetFirstActor("cycle1");
            List<Actor> segments1 = cycle1.GetSegments();

            Cycle2 cycle2 = (Cycle2)cast.GetFirstActor("cycle2");
            List<Actor> segments2 = cycle2.GetSegments();

            if (segments2.Count == segments1.Count) 
            {
                cycle2.GrowTail(1);
            }

            if (segments2.Count > segments1.Count) 
            {
                cycle1.GrowTail(1);
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (_isGameOver == true)
            {
                Cycle1 cycle1 = (Cycle1)cast.GetFirstActor("cycle1");
                List<Actor> segments1 = cycle1.GetSegments();
               
                Cycle2 cycle2 = (Cycle2)cast.GetFirstActor("cycle2");
                List<Actor> segments2 = cycle2.GetSegments();

                // create a "game over" message
                int x = Constants.MAX_X / 2 - 50;
                int y = Constants.MAX_Y / 2 - 25;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                message.SetColor(Constants.RED);
                cast.AddActor("messages", message);

                // make everything white
                foreach (Actor segment in segments1)
                {
                    segment.SetColor(Constants.WHITE);
                }
                
                foreach (Actor segment in segments2)
                {
                    segment.SetColor(Constants.WHITE);
                }
            }
        }

    }
}