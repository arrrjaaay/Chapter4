using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            for (num = 1; num <= 50; num++)
            {
                sum = sum + num;
                Console.WriteLine("The sum of the last two numbers is {0}.", sum); 
            }
            Console.WriteLine("Final sum = {0}", sum);
        }
    }
}
