using System;

namespace _09_StringsAgainAndAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Word");
            string word = Console.ReadLine();

            Console.WriteLine(SeparateChars(word));

            Console.Read();
        }

        static string SeparateChars(string word)
        {
            if (word.Length == 2)
            {
                return word[0] + "*" + word[1];
            }
            else
            {
                return word[0] + "*" + SeparateChars(word.Substring(1));
            }
        }
    }
}
