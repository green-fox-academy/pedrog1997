using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for a number and prints the multiplication table with that number
            double number = double.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + " * 15 = " + (i + 1) * 15);
            }
            Console.Read();
        }
    }
}