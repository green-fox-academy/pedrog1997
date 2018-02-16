using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            Console.WriteLine("Number of girls that attended to the party");
            int numGirls = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of boys that attended to the party");
            int numBoys = int.Parse(Console.ReadLine());
            int total = numBoys + numGirls;

            if (numGirls == numBoys && total > 20)
            {
                Console.WriteLine("The party is excellent");
            }
            else if (total > 20 && numBoys != numGirls && numGirls!= 0)
            {
                Console.WriteLine("Quite cool party");
            }
            else if (total < 20 && numGirls != 0)
            {
                Console.WriteLine("Average party...");
            }
            else
            {
                Console.WriteLine("Sausage party");
            }

            Console.ReadLine();
        }
    }
}