using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            string name = "Pedro Gómez de la Garza";
            int age = 20;
            double height = 1.75;
            bool married = false;

            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("I'm " + age + " years old.");
            Console.WriteLine("I'm " + height + " tall.");
            Console.WriteLine("The anwer to the question if I am married is " + married);
            Console.Read();
        }
    }
}
