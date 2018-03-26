using System;
using System.Collections.Generic;
using System.Text;

namespace _04_CountLetters
{
    public class Counter
    {
        public Dictionary<char, int> CountLetters(string word)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (letters.ContainsKey(word[i]))
                {
                    letters[word[i]]++;
                }
                else
                {
                    letters.Add(word[i], 1);
                }
            }
            return letters;
        }
    }
}
