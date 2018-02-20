using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(girls, boys));

            Console.Read();
        }

        public static string MakingMatches(List<string> girls, List<string> boys)
        {
            var matchList = new List<string>();
            for (int i = 0; i < girls.Count; i++)
            {
                matchList.Add(girls[i]);
                matchList.Add(boys[i]);
            }
            string matchListString = "";
            foreach (var name in matchList)
            {
                matchListString += name + ", ";
            }
            matchListString = matchListString.Remove(matchListString.Length - 2);
            matchListString += ".";

            return matchListString;
        }
    }
}