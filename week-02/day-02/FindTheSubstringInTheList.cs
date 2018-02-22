using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a string and a list of string as a parameter
            //  Returns the index of the string in the list where the first string is part of
            //  Only need to find the first occurence and return the index of that
            //  Returns `-1` if the string is not part any of the strings in the list

            //  Example
            string[] searchArr = { "this", "is", "what", "I'm", "searching", "in" };

            Console.WriteLine(SubstrList("ching", searchArr));
            //  should print: `4`
            Console.WriteLine(SubstrList("not", searchArr));
            //  should print: `-1`  
            Console.Read();
        }

        public static string SubstrList(string wordToFind, string[] arrayToSearch)
        {
            string print = string.Empty;

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i].Contains(wordToFind))
                {
                    print = Convert.ToString(i);
                    break;
                }
                else
                {
                    print = "-1";
                }
            }
            return print;
        }
    }
}