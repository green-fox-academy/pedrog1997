using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("Enter the distance in kilometers");
            int distanceKm = int.Parse(Console.ReadLine());
            double distanceMiles = 1.60934 * distanceKm;
            Console.WriteLine("The distance in miles is " + distanceMiles);
            Console.Read();
        }
    }
}