using System;
using System.Linq;

namespace Linq_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squarredPositivesQuery = from x in n
                                         where x > 0
                                         select x * x;

            var squarredPositivesMethod = n.Where(x => x > 0).Select(x => x * x);

            Console.WriteLine("Query syntax: ");
            foreach (var squarredPositive in squarredPositivesQuery)
            {
                Console.WriteLine(squarredPositive);
            }
            Console.WriteLine("Method Syntax: ");
            foreach (var squarredPositive in squarredPositivesMethod)
            {
                Console.WriteLine(squarredPositive);
            }

            Console.Read();
        }
    }
}

