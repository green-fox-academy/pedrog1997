using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.

            Console.WriteLine("Guess the number !");

            int number = 35;
            int guess = 0;

            while (guess != number)
            {
                guess = int.Parse(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("You found the number: 32");
                }
                else if (guess > number)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else
                {
                    Console.WriteLine("The stored number is higher");
                }
            }

            Console.Read();

        }
    }
}