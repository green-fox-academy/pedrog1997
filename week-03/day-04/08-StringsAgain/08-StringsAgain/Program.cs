using System;

namespace _08_StringsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Word");
            string word = Console.ReadLine();

            Console.WriteLine(RemoveX(word));

            Console.Read();
        }

        static string RemoveX(string word)
        {
            if (word.Length == 1)
            {
                if (word == "x")
                {
                    return string.Empty;
                }
                else
                {
                    return word;
                }
            }
            else
            {
                if (word[0] == 'x')
                {
                    return RemoveX(word.Substring(1));
                }
                else
                {
                    return word[0] + RemoveX(word.Substring(1));
                }
            }
        }
    }
}
