using System;
using System.Linq;

namespace Linq_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyOfNumbersQuery = from x in n
                                     group x by x into frequency
                                     orderby frequency.Count() descending
                                     select new { number = frequency.Key, f = frequency.Count() };

            Console.WriteLine("Query: ");
            foreach (var frequency in frequencyOfNumbersQuery)
            {
                Console.WriteLine($"Number: {frequency.number} frequency: {frequency.f}");
            }

            var frequencyOfNumbersMethod = n.GroupBy(x => x).OrderByDescending(x => x.Count());

            Console.WriteLine("Method: ");
            foreach (var frequency in frequencyOfNumbersMethod)
            {
                Console.WriteLine($"Number: {frequency.Key} frequency: {frequency.Count()}");
            }

            Console.Read();
        }
    }
}
