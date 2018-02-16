using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a pyramid

            Console.WriteLine("Input the height of the piramid");
            int height = int.Parse(Console.ReadLine());
            string line = "*";
            string space = "";
            int numOfSpaces = height - 1;

            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < numOfSpaces; k++)
                {
                    space += " ";
                }
                Console.WriteLine(space + line);
                line = "*" + line + "*";
                space = "";
                numOfSpaces--;

            }
            Console.Read();
        }
    }
}