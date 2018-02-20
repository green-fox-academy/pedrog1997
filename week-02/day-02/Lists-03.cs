using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
            Console.Read();
        }

        public static string AppendA(List<string> animals)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animals[i] += "a";
            }
            string listWithA = "";
            foreach (var animal in animals)
            {
                listWithA += animal + ", ";
            }
            listWithA = listWithA.Remove(listWithA.Length - 2);
            return listWithA;
        }
    }
}