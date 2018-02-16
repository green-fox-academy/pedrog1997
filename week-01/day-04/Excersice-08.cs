using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("a: " + a + " and b: " + b);
            Console.Read();
        }
    }
}
