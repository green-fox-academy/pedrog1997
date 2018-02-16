using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a diamond

            Console.WriteLine("Input the height of the diamond ");
            int height = int.Parse(Console.ReadLine());
            int numSpaces = height / 2;
            int iteration = numSpaces + 1;
            int numStars;
            string space = "";
            string stars = "";

            for (; iteration <= height; iteration++)
            {
                numStars = iteration - numSpaces;
                for (int i = 0; i < numSpaces; i++)
                {
                    space += " ";
                }
                for (int i = 0; i < numStars; i++)
                {
                    stars += "*";
                }
                Console.WriteLine(space + stars);
                numSpaces--;
                space = "";
                stars = "";
            }

            iteration = height - 1;
            numSpaces = 0;

            for (; iteration >= height/2 ; iteration--)
            {
                numSpaces++;
                numStars = iteration - numSpaces;
                for (int i = 0; i < numSpaces; i++)
                {
                    space += " ";
                }
                for (int i = 0; i < numStars; i++)
                {
                    stars += "*";
                }
                Console.WriteLine(space + stars);
                space = "";
                stars = "";
            }

            Console.Read();
        }
    }
}