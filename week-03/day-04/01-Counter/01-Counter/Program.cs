using System;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count down from: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CountDown(n));

            Console.Read();
        }

        static string CountDown(int n)
        {
            string countDown = string.Empty;
            if (n == 0)
            {
                return "0 ";
            }
            else
            {
                return countDown = n + " " + CountDown(n - 1);
            }
        }
    }
}
