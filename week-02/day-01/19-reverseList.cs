using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = { 3, 4, 5, 6, 7 };
            int[] copy = new int[5];
            aj.CopyTo(copy, 0);

            for (int i = 0; i < aj.Length; i++)
            {
                aj[i] = copy[4 - i];
            }

            for (int i = 0; i < aj.Length; i++)
            {
                Console.WriteLine(aj[i]);
            }

            Console.ReadLine();
        }
    }
}