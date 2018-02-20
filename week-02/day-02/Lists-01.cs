using System;
using System.Collections.Generic;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };

            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list.

            Console.WriteLine(PutSaturn(planetList));
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
            Console.Read();
        }

        public static string PutSaturn(List<string> allPlanets)
        {
            allPlanets.Add("Saturn");
            string correctList = "";
            foreach (var planet in allPlanets)
            {
                correctList += planet + ", ";
            }
            correctList = correctList.Remove(correctList.Length - 2);
            correctList += ".";
            return correctList;
        }
    }
}