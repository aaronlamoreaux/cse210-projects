using System;

namespace Unit02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assigns values to required variables.
            int points = 300;
            int win = 0;
            int number = 0;
            int number2 = 0;

            //Game starts.
            while (win != 1) {

                
                //Gets first number.
                number = nextCard();
                Console.WriteLine($"The card is: {number}");
               
                //Gets User inputs
                Console.Write("higher or lower? ");
                string choice = Console.ReadLine();
                
                //Gets second number.
                number2 = nextCard();
                Console.WriteLine($"Next card: {number2}");

                //Resovles whether the user got or lost points.
                if (choice == "higher" && number2 > number) {
                    points = correctGuess(points);
                } else if (choice == "higher" && number2 < number) {
                    points = inccorrectGuess(points);
                } else if (choice == "lower" && number2 < number) {
                    points = correctGuess(points);
                } else if (choice == "lower" && number2 > number) {
                    points = inccorrectGuess(points);
                }

                //Asks if User wants to play agian and/or ends the loop.
                if (points != 0) {
                    Console.Write("Play again? (Y/N) ");
                    string choice2 = Console.ReadLine();

                    if (choice2 == "N" || choice2 == "n") {
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for playing.");
                        Console.WriteLine("Game over.");
                        win++;
                    }

                    Console.WriteLine("");
                } else if (points >= 0) {
                    Console.WriteLine("Your points reached 0. You lose.");
                    Console.WriteLine("Game over.");
                    win++;
                }

            } 
       

        }

        //Function to generate card numbers.
        public static int nextCard(){
            Random card = new Random();
            int value = card.Next(1,13);
            return value;
        }

        //Function to add 100 points to user's score if user guessed higher or lower correctly.
        public static int correctGuess(int x) {
            int y = x + 100;
            Console.WriteLine("You called right.");
            Console.WriteLine("You earned 100 points!");
            Console.WriteLine($"Your score is: {y}");
            return y;
        }

        //Function to subtract 75 points to user's score if user guessed higher or lower incorrectly.
        public static int inccorrectGuess(int x){
            int y = x - 75;
            Console.WriteLine("You called wrong.");
            Console.WriteLine("You lost 75 points.");
            Console.WriteLine($"Your score is: {y}");
            return y;
        }

    }
}
