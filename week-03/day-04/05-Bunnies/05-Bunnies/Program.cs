using System;

namespace _05_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of bunnies:");
            int numberOfBunnies = int.Parse(Console.ReadLine());

            Console.WriteLine(BunniesEars(numberOfBunnies));

            Console.Read();
        }

        static int BunniesEars(int numberOfBunnies)
        {
            if (numberOfBunnies == 1)
            {
                return 2;
            }
            else
            {
                return 2 + BunniesEars(numberOfBunnies - 1);
            }
        }
    }
}
