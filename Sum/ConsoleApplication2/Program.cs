using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("         ");
            for (int z = 1; z <= 10; z++)
            {
                Console.Write(z.ToString().PadLeft(5) + ": ");
            }
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine();
                Console.Write(x.ToString().PadLeft(6) + ": ");
                for (int y = 1; y <= 10; y++)
                {
                    Console.Write((y * x).ToString().PadLeft(6) + " ");
                }
            }
       }
    }
}
