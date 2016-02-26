using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 20; n++)
            {
                Console.WriteLine("The integer value is {0} and the squared value is {1}.", n, n * n);
            }
        }
    }
}
