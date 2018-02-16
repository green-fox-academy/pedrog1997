using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            Console.WriteLine("Enter 5 integers. Press enter everytime.");
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int int3 = int.Parse(Console.ReadLine());
            int int4 = int.Parse(Console.ReadLine());
            int int5 = int.Parse(Console.ReadLine());
            // then it should print the sum and the average of these numbers like:

            int sum = int1 + int2 + int3 + int4 + int5;
            double average = sum / 5;

            // Sum: 22, Average: 4.4

            Console.WriteLine("Sum: " + sum + ", Average: " + average);
            Console.ReadLine();
        }
    }
}