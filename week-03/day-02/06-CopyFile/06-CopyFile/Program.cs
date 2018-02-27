using System;
using System.IO;

namespace _06_CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileToCopy = "fileToCopy.txt";
            string destinationFile = "destinationFile.txt";

            CopyFile(fileToCopy, destinationFile);
        }

        static bool CopyFile(string fileToCopy, string destinationFile)
        {
            try
            {
                string[] arrayFileToCopy = File.ReadAllLines(fileToCopy);
                File.WriteAllLines(destinationFile, arrayFileToCopy);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Read();
                return false;
            }
        }
    }
}
