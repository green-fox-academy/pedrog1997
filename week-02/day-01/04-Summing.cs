using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer

            Console.WriteLine("Give a parameter");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(input));

            Console.Read();
        }

        static int Sum(int limit)
        {
            int total = 0;
            for (int i = 0; i <= limit; i++)
            {
                total += i;
            }
            return total;
        }
    }
}