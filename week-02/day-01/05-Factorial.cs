using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            Console.WriteLine("Input number to factorize");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorio(userInput));

            Console.ReadLine();
        }

        static int Factorio(int numberToFactorize)
        {
            int counter = 1;
            for (int i = 1; i <= numberToFactorize; i++)
            {
                counter *= i;
            }
            return counter;
        }
    }
}