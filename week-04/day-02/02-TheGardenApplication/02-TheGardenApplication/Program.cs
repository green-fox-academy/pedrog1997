using System;
using System.Collections.Generic;

namespace _02_TheGardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>()
            {
                new Flower("yellow"),
                new Flower("blue"),
                new Tree("purple"),
                new Tree("orange")
            };

            var garden = new Garden(plants);

            garden.WaterPlants(40);
            garden.WaterPlants(70);

            Console.Read();
        }
    }
}
