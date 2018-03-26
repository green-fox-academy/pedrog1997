using System;
using System.Collections.Generic;
using System.Linq;

namespace Link_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>
            {
                new Fox("Foxy", "pallida", "red"),
                new Fox("Greeny", "pallida", "green"),
                new Fox("Hoedy", "Macrotis", "red"),
                new Fox("Sisy", "Lagopus", "green"),
                new Fox("Toto", "pallida", "red")
            };

            var greenColorFoxesQuery = from fox in foxes
                                       where fox.Color == "green"
                                       select fox;
            Console.WriteLine("Query Syntax: Green Foxes");
            foreach (var greenFox in greenColorFoxesQuery)
            {
                Console.WriteLine(greenFox.Name);
            }

            var greenColorFoxesMethod = foxes.Where(fox => fox.Color == "green");
            Console.WriteLine("Method Syntax: Green Foxes");
            foreach (var fox in greenColorFoxesMethod)
            {
                Console.WriteLine(fox.Name);
            }

            var greenAndPallidaFoxesQuery = from fox in foxes
                                       where fox.Color == "green" && fox.Type == "pallida"
                                       select fox;
            Console.WriteLine("Query Syntax: Green and pallida foxes");
            foreach (var fox in greenAndPallidaFoxesQuery)
            {
                Console.WriteLine(fox.Name);
            }

            var greenAndPallidaFoxesMethod = foxes.Where(fox => fox.Color == "green" && fox.Type == "pallida");
            Console.WriteLine("Method Syntax: Green and pallida foxes");
            foreach (var fox in greenAndPallidaFoxesMethod)
            {
                Console.WriteLine(fox.Name);
            }

            Console.Read();
        }
    }
}
