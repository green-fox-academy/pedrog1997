using System;
using System.IO;

namespace _09_Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "duplicated-chars.txt";
            Console.WriteLine(Decryption(fileName));

            

            Console.Read();
        }

        static string Decryption(string fileName)
        {
            string[] linesOfFile = File.ReadAllLines(fileName);

            for (int i = 0; i < linesOfFile.Length; i++)
            {
                for (int j = 1; j < linesOfFile[i].Length; j++)
                {
                    if (linesOfFile[i][j] == linesOfFile[i][j-1])
                    {
                        linesOfFile[i] = linesOfFile[i].Remove(j, 1);
                        j--;
                    }

            string decrypted = "";
            for (int i = 0; i < linesOfFile.Length; i++)
            {
                decrypted += linesOfFile[i] + "\n";
            }
            return decrypted;
        }
    }
}
