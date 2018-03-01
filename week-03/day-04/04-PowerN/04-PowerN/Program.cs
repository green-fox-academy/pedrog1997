using System;

namespace _04_PowerN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input base:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Input exponent:");
            int exponent = int.Parse(Console.ReadLine());

            Console.WriteLine(PowerN(number, exponent));

            Console.Read();
        }

        static int PowerN(int number, int exponent)
        {
            if (exponent == 1)
            {
                return number;
            }
            else
            {
                return number *= PowerN(number, exponent - 1);
            }
        }
    }
}
