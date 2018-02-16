using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one

            Console.WriteLine("Input first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            double num2 = double.Parse(Console.ReadLine());
            if (num1 >= num2)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for (double i = num1; i < num2; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();

        }
    }
}