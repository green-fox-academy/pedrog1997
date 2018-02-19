using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePalindrome("greenfox"));

            Console.Read();
        }

        public static string CreatePalindrome(string word)
        {
            for (int i = word.Length - 1; i >= 0 ; i--)
            {
                word = word + word[i];
            }
            return word;
        }
    }
}