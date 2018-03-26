using System;
using System.Linq;

namespace Link_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Pedro Gómez de la Garza";

            var capitalLettersQuery = from letter in name.ToCharArray()
                                      where letter >= 'A' && letter <= 'Z'
                                      select letter;

            Console.WriteLine("Query Syntax");
            foreach (var capitalLetter in capitalLettersQuery)
            {
                Console.WriteLine(capitalLetter);
            }

            var capitalLettersMethod = name.ToCharArray().Where(letter => letter >= 'A' && letter <= 'Z');

            Console.WriteLine("Method Syntax");
            foreach (var capitalLetter in capitalLettersMethod)
            {
                Console.WriteLine(capitalLetter);
            }

            Console.Read();
        }
    }
}
