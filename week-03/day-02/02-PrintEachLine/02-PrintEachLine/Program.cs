using System;
using System.IO;

namespace _02_PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            try
            {
                string[] fileLines = File.ReadAllLines("my-files.txt");
                foreach (var lines in fileLines)
                {
                    Console.WriteLine(lines);
                }
            }
            catch (Exception error)
            {
                Console.Error.WriteLine("Unable to read file.");
            }

            Console.Read();
        }
    }
}
