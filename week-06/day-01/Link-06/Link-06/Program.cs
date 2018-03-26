using System;
using System.Linq;

namespace Link_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string longWord = "megszentségteleníthetetlenségeskedéseitekért";

            var frecuencyOfLettersQuery = from letter in longWord.ToCharArray()
                                          group letter by letter into letters
                                          orderby letters.Count() descending
                                          select new { letter = letters.Key, frecuency = letters.Count() };
            Console.WriteLine("Query syntax: ");
            foreach (var letter in frecuencyOfLettersQuery)
            {
                Console.WriteLine($"Letter: {letter.letter} Frecuency: {letter.frecuency}");
            }

            var frecuencyOfLettersMethod = longWord.ToCharArray().GroupBy(letter => letter).OrderByDescending(letter => letter.Count());

            Console.WriteLine("Method syntax: ");
            foreach (var letter in frecuencyOfLettersMethod)
            {
                Console.WriteLine($"Letter: {letter.Key} Frecuency: {letter.Count()}");
            }

            Console.Read();
        }
    }
}
