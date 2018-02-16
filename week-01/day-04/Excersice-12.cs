using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            double depth = 50;
            double length = 45;
            double height = 65;
            // Surface Area: 600
            // Volume: 1000
            double surfaceA = (height * length * 4) + (height * depth * 2);
            double volume = depth * height * length;

            Console.WriteLine("Surface Area: " + surfaceA);
            Console.WriteLine("Volume: " + volume);
            Console.Read();
        }
    }
}