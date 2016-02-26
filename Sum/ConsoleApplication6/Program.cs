using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double num; // Declare the variables.

            Console.WriteLine("Enter your pay rate.");
            input = Console.ReadLine();
            num = Convert.ToDouble(input); // Enter a number

            while (num < 5.65 || num > 49.99)
            {
                Console.WriteLine("Enter your pay rate.");
                input = Console.ReadLine();
                num = Convert.ToDouble(input);
            }
            Console.WriteLine("Error");
        }
    }
}
