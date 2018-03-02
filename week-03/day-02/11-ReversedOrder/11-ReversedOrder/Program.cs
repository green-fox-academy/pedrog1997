using System;
using System.IO;

namespace _11_ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllLines("correctText.txt", ReversedOrder("reversedOrder.txt"));
        }

        static string[] ReversedOrder(string path)
        {
            string[] text = File.ReadAllLines(path);
            string[] newText = new string[text.Length];
            int j = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                newText[j] = text[i];
                j++;
            }

            return newText;
        }
    }
}
