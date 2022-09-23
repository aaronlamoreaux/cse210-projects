using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {       
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            int number = -1;
            int sum = 0;
            float average = 0;
            int largest = 0;

            while (number !=0)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                numbers.Add(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
                average = sum/(numbers.Count - 1);
                if (largest < numbers[i])
                {
                    largest = numbers[i];
                } 
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}
