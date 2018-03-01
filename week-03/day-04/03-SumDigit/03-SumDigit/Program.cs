using System;

namespace _03_SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input for sum of all digits: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(SumDigit(n));

            Console.Read();
        }

        static int SumDigit(int n)
        {
            if (n % 10 == n)
            {
                return n;
            }
            else
            {
                return (n % 10) + SumDigit(n / 10);
            }
        }
    }
}
