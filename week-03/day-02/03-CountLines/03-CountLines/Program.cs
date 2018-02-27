using System;
using System.IO;

namespace _03_CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "files.txt";

            Console.WriteLine(CountLines(fileName));

            Console.Read();
        }

        static int CountLines(string path)
        {
            try
            {
                string[] fileLines = File.ReadAllLines(path);
                return fileLines.Length;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
