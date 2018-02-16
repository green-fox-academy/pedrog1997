using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("% ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(" %");
                    }
                    Console.WriteLine();
                }
            }

            Console.Read();
        }
    }
}