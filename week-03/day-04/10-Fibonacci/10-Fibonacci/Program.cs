using System;

namespace _10_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nth position of the Fibonacci sequence");
            int nthFibonacci = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(nthFibonacci));

            Console.Read();
        }

        static int Fibonacci(int nthFibonacci)
        {
            if (nthFibonacci == 0)
            {
                return 0;
            }
            else if (nthFibonacci == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(nthFibonacci - 1) + Fibonacci(nthFibonacci - 2);
            }
        }
    }
}
