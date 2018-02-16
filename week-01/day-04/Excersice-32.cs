using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a sqare with its diagonal

            Console.WriteLine("Input the length of the side of the square ");
            int side = int.Parse(Console.ReadLine());
            int numSpace1 = 0;
            int numSpace2 = side - 3;
            string space1 = "";
            string space2 = "";
            string firstLine = "";

            for (int i = 0; i < side; i++)
            {
                firstLine += "%";
            }
            Console.WriteLine(firstLine);

            for (int i = 0; i < side - 2; i++)
            {
                for (int j = 0; j < numSpace1; j++)
                {
                    space1 += " ";
                }

                for (int k = 0; k < numSpace2; k++)
                {
                    space2 += " ";
                }
                
                Console.WriteLine("%" + space1 + "%" + space2 + "%");
                numSpace1++;
                numSpace2--;
                space1 = "";
                space2 = "";
            }
            Console.WriteLine(firstLine);

            Console.Read();
        }
    }
}