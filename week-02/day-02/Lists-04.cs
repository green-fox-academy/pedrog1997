using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Console.WriteLine(Sweets(list));
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
            Console.Read();
        }

        public static string Sweets(List<object> list)
        {
            list[1] = "Croissant";
            list[3] = "Ice Cream";
            string listString = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                listString += list[i] + ", ";
            }
            return listString;
        }
    }
}