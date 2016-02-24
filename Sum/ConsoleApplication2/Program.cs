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
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine();
                Console.Write(x.ToString().PadLeft(4) + ": ");
                for (int y = 1; y <= 10; y++)
                {
                    Console.Write((y * x).ToString().PadLeft(3) + " ");
                }
            }
        }
    }
}
