using System;
using System.Collections.Generic;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int squared = SquareNumber(number);
            DisplayResult(name, squared);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("what is your name? ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptUserNumber()
        {
            Console.Write("what is your favorite number? ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int result = number * number;
            return result; 
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
    }
}
