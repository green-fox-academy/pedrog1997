using System;
using System.Linq;

namespace Linq_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var avgOddNumbersQuery = (from x in n
                                 where x % 2 != 0
                                 select x)
                                 .Average();

            var avgOddNumbersMethod = n.Where(x => x % 2 != 0).Average();

            Console.WriteLine("With Query: " + avgOddNumbersQuery);
            Console.WriteLine("With Method: " + avgOddNumbersMethod);

            Console.Read();
            
        }
    }
}
