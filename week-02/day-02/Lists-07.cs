using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(QuoteSwapp(list));
            // Expected output: "What I cannot create I do not understand." 
            Console.Read();
        }

        public static string QuoteSwapp(List<string> list)
        {
            string swap = list[2];
            list.Insert(2, list[5]);
            list.RemoveAt(3);
            list.Insert(5, swap);
            list.RemoveAt(6);
            string listString = "";

            for (int i = 0; i < list.Count; i++)
            {
                listString += list[i] + " ";
            }
            return listString;
        }
    }
}