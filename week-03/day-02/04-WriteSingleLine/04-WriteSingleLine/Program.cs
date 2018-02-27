using System;
using System.IO;

namespace _04_WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "my-file.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Pedro Gómez de la Garza");
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Unable to write on file.");
            }

            Console.Read();
        }
    }
}
