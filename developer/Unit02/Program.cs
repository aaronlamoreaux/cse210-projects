using System;

namespace Unit02
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 300;
            int win = 0;
            while (win != 1) {
                int number = 0;
                int number2 = 0;

                number = nextCard();
                Console.WriteLine($"The card is: {number}");
               
                Console.Write("higher or lower? ");
                string choice = Console.ReadLine();
                
                number2 = nextCard();
                Console.WriteLine($"Next card: {number2}");

                if (choice == "higher" && number2 > number) {
                    points = correctGuess(points);
                } else if (choice == "higher" && number2 < number) {
                    points = inccorrectGuess(points);
                } else if (choice == "lower" && number2 < number) {
                    points = correctGuess(points);
                } else if (choice == "lower" && number2 > number) {
                    points = inccorrectGuess(points);
                }

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
        public static int nextCard(){
           Random card = new Random();
           int value = card.Next(1,13);
           return value;
        }

        public static int correctGuess(int x) {
            int y = x + 100;
            Console.WriteLine("You called right.");
            Console.WriteLine("You earned 100 points!");
            Console.WriteLine($"Your score is: {y}");
            return y;
        }

        public static int inccorrectGuess(int x){
            int y = x - 75;
            Console.WriteLine("You called wrong.");
            Console.WriteLine("You lost 75 points.");
            Console.WriteLine($"Your score is: {y}");
            return y;
        }

    }
}
