using System;
using System.Linq;

namespace Link_09
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'P', 'e', 'd', 'r', 'o' };

            var lettersToWord = string.Join("", letters);

            Console.WriteLine("Query syntax");
            Console.WriteLine(lettersToWord);

            Console.Read();
        }
    }
}
