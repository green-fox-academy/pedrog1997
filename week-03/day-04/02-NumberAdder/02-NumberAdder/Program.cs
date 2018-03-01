using System;

namespace _02_NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input for number adder: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberAdder(n));

            Console.Read();
        }

        static int NumberAdder(int n)
        {
            int sum = n;
            if (n == 1)
            {
                return 1;
            }
            else
            {
            sum += NumberAdder(n - 1);
            return sum;
            }
        }
    }
}
