using System;

namespace _11_Refactorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Refactorio(number));

            Console.Read();
        }

        static int Refactorio(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Refactorio(number - 1);
            }
        }
    }
}
