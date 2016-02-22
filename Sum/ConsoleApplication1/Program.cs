using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string input; // Declare the variables.

            Console.WriteLine("Enter a vowel.");
            input = Console.ReadLine();

            while (input == "A" || "a")
            {
                Console.WriteLine("Enter a vowel.");
                input = Console.ReadLine();

                // until the character entered is not a vowel
                // it will repeat the loop
            }
        }
    }
}
