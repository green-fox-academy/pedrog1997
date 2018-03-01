using System;

namespace _08_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter(5);

            Console.WriteLine(counter.Integer);

            Console.Read();
        }
    }
}
