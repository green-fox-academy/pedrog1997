using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int denominator = int.Parse(Console.ReadLine());
            Division(denominator);
        }

        static void Division(int denominator)
        {
            try
            {
                int result = 10 / denominator;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException divisionByZero)
            {
                Console.Error.WriteLine("fail");
            }
            finally
            {
                Console.Read();
            }
        }
    }
}