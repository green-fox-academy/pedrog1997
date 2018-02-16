using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            Console.WriteLine("How many chickens do you have?");
            int numChickens = int.Parse(Console.ReadLine());
            Console.WriteLine("How many pigs do you have?");
            int numPigs = int.Parse(Console.ReadLine());

            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer

            int legs = numChickens * 2 + numPigs * 4;

            // It should print how many legs all the animals have

            Console.WriteLine("All the animals have " + legs + " legs");
            Console.ReadLine();
        }
    }
}