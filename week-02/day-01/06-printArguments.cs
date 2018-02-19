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

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Printer(name, age);

            Console.ReadLine();
        }

        static void Printer(string name, string age)
        {
            Console.WriteLine("you are " + name + " and you are " + age + " years old");
        }
    }
}