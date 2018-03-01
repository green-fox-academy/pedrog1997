using System;

namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input word: ");
            string word = Console.ReadLine();

            Console.WriteLine(ConvertXToY(word));

            Console.Read();
        }

        static string ConvertXToY(string word)
        {
            if (word.Length == 1)
            {
                if (word == "x")
                {
                    return "y";
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
                    return word = "y" + ConvertXToY(word.Substring(1));
                }
                else
                {
                    return word = word[0] + ConvertXToY(word.Substring(1));
                }
            }
        }
    }
}
