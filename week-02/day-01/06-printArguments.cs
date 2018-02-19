using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters


            Printer("first");
            Printer("first", "second");
            Printer("first", "second", "third", "fourh");

            Console.ReadLine();
        }

        public static void Printer(params string[] messages)
        {
            for (int i = 0; i < messages.Length; i++)
            {
                Console.Write(messages[i] + " ");
            }
            Console.WriteLine();
        }
    }
}