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

            while (input == "a" || input == "e" || input == "i" || input == "o" || input == "u"
                || input == "A" || input == "E" || input == "I" || input == "O" || input == "U")
            {
                Console.WriteLine("OK.");
                Console.WriteLine("Enter a vowel.");
                input = Console.ReadLine();
                // until the character entered is not a vowel
                // it will repeat the loop
            }
            Console.WriteLine("Error: '{0}' entered not a vowel.", input);
        }
    }
}
