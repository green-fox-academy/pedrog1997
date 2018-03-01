using System;

namespace _06_BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of bunnies:");
            int numberOfBfunnies = int.Parse(Console.ReadLine());
            Console.WriteLine(MutatedBunnies(numberOfBfunnies));

            Console.Read();
        }

        static int MutatedBunnies(int numberOfBunnies)
        {
            if (numberOfBunnies == 1)
            {
                return 2;
            }
            else
            {
                if (numberOfBunnies % 2 == 0)
                {
                    return 3 + MutatedBunnies(numberOfBunnies - 1);
                }
                else
                {
                    return 2 + MutatedBunnies(numberOfBunnies - 1);
                }
            }
        }
    }
}
