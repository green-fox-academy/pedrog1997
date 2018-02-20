using System;
using System.Text;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(ReverseF(reversed));

            Console.Read();
        }
        public static string ReverseF(string stringToReverse)
        {
            StringBuilder sentence = new StringBuilder();

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                sentence.Append(stringToReverse[i]);
            }

            stringToReverse = sentence.ToString();
            return stringToReverse;
        }
    }
}