using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your grade percentage? ");
            string userInput = Console.ReadLine();
            int percentage = int.Parse(userInput);
            string letter = "";
            
            if (percentage >= 90)
            {
               letter = "A";
            }
            else if (percentage >= 80 && percentage < 90)
           {
               letter = "B";
            }
            else if (percentage >= 70 && percentage < 80)
            {
               letter = "C";
            }
            else if (percentage >= 60 && percentage < 70)
            {
               letter = "D";
            }
            else
            {
               letter = "F";
            }

            Console.WriteLine($"Your grade is: {letter}");

            if (percentage >= 70)
            {
                Console.WriteLine("you're passing.");
            }
            else 
            {
                Console.WriteLine("you're failing.");
            }
            
        }
    }
}
