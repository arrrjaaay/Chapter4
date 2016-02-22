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
            string a = "a";
            string e = "e";
            string i = "i";
            string o = "o";
            string u = "u";
            string capa = "A";
            string cape = "E";
            string capi = "I";
            string capo = "O";
            string capu = "U";

            Console.WriteLine("Enter a vowel.");
            input = Console.ReadLine();

            while (input == a || input == e || input == i || input == o || input == u ||
                   input == capa || input == cape || input == capi || input == capo || input == capu)
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
