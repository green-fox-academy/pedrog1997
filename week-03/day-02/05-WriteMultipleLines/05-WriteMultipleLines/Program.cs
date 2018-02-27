using System;
using System.IO;

namespace _05_WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            WriteLines(path, "pear", 5);

        }

        static void WriteLines(string path, string word, int numberOfLines)
        {
            try
            {
                string[] wordArray = new string[numberOfLines];
                for (int i = 0; i < wordArray.Length; i++)
                {
                    wordArray[i] = word;
                }
                File.WriteAllLines(path, wordArray);
            }
            catch (Exception e)
            {

            }
        }
    }
}
