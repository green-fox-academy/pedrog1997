using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a square

            Console.WriteLine("Input the length of the side of the square ");
            int side = int.Parse(Console.ReadLine());
            int numSpace = side - 2;
            string symbol = "";
            string space = "";

            for (int i = 0; i < numSpace; i++)
            {
                space += " ";
            }

            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < side; k++)
                {
                    symbol += "%";
                }
                Console.WriteLine(symbol);
                symbol = "";
                if (i == 0)
                {
                    for (int k = 0; k < side - 2; k++)
                    {
                        Console.WriteLine("%" + space + "%");
                    }
                }
                
            }

            Console.Read();
        }
    }
}