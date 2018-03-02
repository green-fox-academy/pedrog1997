using System;
using System.Text;
using System.IO;

namespace _12_EncodedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllLines("correctText.txt", DecodeLines("encodedLines.txt"));
        }

        static string[] DecodeLines(string path)
        {
            string[] encodedText = File.ReadAllLines(path);
            string[] decodedText = new string[encodedText.Length];

            for (int i = 0; i < encodedText.Length; i++)
            {
                byte[] byteEncodedText = Encoding.ASCII.GetBytes(encodedText[i]);
                byte[] byteDecodedText = new byte[byteEncodedText.Length];
                for (int j = 0; j < byteEncodedText.Length; j++)
                {
                    if (byteEncodedText[j] != 32)
                    {
                        byteDecodedText[j] = (byte)(byteEncodedText[j] - 1);
                    }
                }
                decodedText[i] = Encoding.ASCII.GetString(byteDecodedText);
            }

            return decodedText;
        }
    }
}
