using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes two strings as a parameter
            //  Returns the starting index where the second one is starting in the first one
            //  Returns `-1` if the second string is not in the first one

            //  Example:
            Console.WriteLine(Substr("this is what I'm searching in", "searching"));
            //  should print: `17`
            Console.WriteLine(Substr("this is what I'm searching in", "not"));
            //  should print: `-1`
            Console.Read();
        }

        static int Substr(string input, string q)
        {
            if (input.Contains(q))
            {
                return input.IndexOf(q);
            }
            else
            {
                return -1;
            }
        }
    }
}