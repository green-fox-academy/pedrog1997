using System;
using System.Linq;

namespace Linq_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var squaredNumberMoreThan20Query = from x in n
                                          where x * x > 20
                                          select x;

            var squaredNumberMoreThan20Method = n.Where(x => x * x > 20);

            Console.WriteLine("Query Syntax ");
            foreach (var squaredNumber in squaredNumberMoreThan20Query)
            {
                Console.WriteLine(squaredNumber);
            }
            Console.WriteLine("Mwthod syntax ");
            foreach (var squaredNumber in squaredNumberMoreThan20Method)
            {
                Console.WriteLine(squaredNumber);
            }

            Console.Read();
        }
    }
}
