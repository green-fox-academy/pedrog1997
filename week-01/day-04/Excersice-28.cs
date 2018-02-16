using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a triangle
            Console.WriteLine("Input the height of the triangle");
            int height = int.Parse(Console.ReadLine());
            string line = "";

            for (int i = 0; i < height; i++)
            {
                line += "*";
                Console.WriteLine(line);
            }

            Console.Read();
        }
    }
}