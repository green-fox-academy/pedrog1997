using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the Armstrong number");
            string stringArmstrongNumber = Console.ReadLine();

            var listArmstrong = new List<Char>();

            for (int i = 0; i < stringArmstrongNumber.Length; i++)
            {
                listArmstrong.Add(stringArmstrongNumber[i]);
            }

            double armstrongNumber = 0;

            for (int i = 0; i < listArmstrong.Count; i++)
            {
                armstrongNumber += Math.Pow((int)Char.GetNumericValue(listArmstrong[i]), listArmstrong.Count);
            }

            if (Convert.ToString(armstrongNumber) == stringArmstrongNumber)
            {
                Console.WriteLine("The " + stringArmstrongNumber + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("The " + stringArmstrongNumber + " is not an Armstrong number.");
            }

            Console.Read();
        }
    }
}