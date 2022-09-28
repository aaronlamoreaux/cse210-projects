using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Die> _dice = new List<Die>();
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 0;
        int _highScore = 0;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            for (int i = 0; i < 5; i++)
            {
                Die die = new Die();
                _dice.Add(die);
            }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            Console.WriteLine("Let the Game begin!");
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Roll dice? [y/n] ");
            string rollDice = Console.ReadLine();
            _isPlaying = (rollDice == "y");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            _score = 0;
            foreach (Die die in _dice)
            {
                die.Roll();
                _score += die.points;
            }
            _totalScore += _score;

        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                Console.WriteLine("Game Over.");
                return;
            }

            string values = "";
            foreach (Die die in _dice)
            {
                values += $"{die.value} ";
            }

            Console.WriteLine($"You rolled: {values}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_score > 0);

            if (_score == 0) {
                Console.WriteLine("You did not roll a 5 or a 1.");
                Console.WriteLine("Game over.");
                Console.WriteLine ($"your final score is: {_totalScore}");
                Console.WriteLine ("play again to see it you can beat it!");
            }
        }
    }
}


