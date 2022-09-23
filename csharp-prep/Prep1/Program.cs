using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your first name? ");
            string firstname = Console.ReadLine();

            Console.Write("what is your last name? ");
            string lastname = Console.ReadLine();

            Console.WriteLine($"your name is {lastname}, {firstname} {lastname}");
        }
    }
}
