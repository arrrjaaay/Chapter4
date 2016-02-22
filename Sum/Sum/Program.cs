using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num, total; // Declare the variables.

            Console.WriteLine("Enter a number from 0 to 999.");
            total = 0;
            input = Console.ReadLine();
            num = Convert.ToInt32(input); // Enter a number
            
            while(num < 999)
            {
                total += num;
                Console.WriteLine("Enter a number from 0 to 999.");
                input = Console.ReadLine();
                num = Convert.ToInt32(input);
                
                // until the number that is entered is 999
                // it will repeat the loop
            }

            Console.WriteLine("The total of the numbers you entered was {0}.", total);
        }
    }
}
