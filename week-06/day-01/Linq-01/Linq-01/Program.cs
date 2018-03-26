using System;
using System.Linq;

namespace Linq_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int[] evenNumberQuery = n.Where(x => x % 2 == 0).ToArray();

            var evenNumberMethod = from x in n
                                   where x % 2 == 0
                                   select x; 

            Console.WriteLine("Even numbers with Query: ");
            foreach (var evenNumber in evenNumberQuery)
            {
                Console.WriteLine(evenNumber);
            }
            Console.WriteLine("\n Even numbers with Method: ");
            foreach (var evenNumber in evenNumberMethod)
            {
                Console.WriteLine(evenNumber);
            }

            Console.Read();
        }
    }
}
