using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int guess = -1;

            Console.WriteLine("guess my number (1-100)");
            while (guess != number)
            {
                Console.Write("what is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher.");
                }
                else if (guess == number){
                    Console.WriteLine("Correct!");
                }
            }
        }
    }
}
