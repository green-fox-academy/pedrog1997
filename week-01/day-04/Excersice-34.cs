using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these

            int sum = 0;
            double average = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input a number");
                sum += int.Parse(Console.ReadLine());
            }

            average = sum / 10.00;

            Console.WriteLine("Sum: " + sum + ", Average: " + average);

            Console.Read();

        }
    }
}