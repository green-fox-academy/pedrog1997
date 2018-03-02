using System;
using System.IO;

namespace _10_ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] text = File.ReadAllLines("reversedLines.txt");
            string[] newText = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                newText[i] = ReverseLine(text[i]);
            }
            File.WriteAllLines("correctText.txt", newText);
        }

        static string ReverseLine(string line)
        {
            string newLine = string.Empty;
            for (int i = line.Length - 1; i >= 0; i--)
            {
                newLine += line[i];
            }
            return newLine;
        }
    }
}
