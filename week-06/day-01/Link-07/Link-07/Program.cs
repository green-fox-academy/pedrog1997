using System;
using System.Linq;

namespace Link_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var wordsStartAEndIQuery = from word in cities
                                  where word.StartsWith('A') && word.EndsWith('I')
                                  select word;

            Console.WriteLine("Query Syntax: ");
            foreach (var word in wordsStartAEndIQuery)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Method Syntax:");
            var wordsStartAEndIMethod = cities.Where(word => word.StartsWith('A') && word.EndsWith('I'));
            foreach (var word in wordsStartAEndIMethod)
            {
                Console.WriteLine(word);
            }

            Console.Read();
        }
    }
}
