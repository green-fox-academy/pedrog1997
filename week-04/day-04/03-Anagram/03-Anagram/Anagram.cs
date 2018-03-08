using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Anagram
{
    public class Anagram
    {
        public bool IsAnagram(string word1, string word2)
        {
            if (word1.Length >= word2.Length)
            {
                word1 = word1.ToLower();
                word2 = word2.ToLower();
            }
            else
            {
                string wordSwitch = word2;
                word2 = word1.ToLower();
                word1 = wordSwitch.ToLower();
            }
            bool found = false;

            for (int i = 0; i < word1.Length; i++)
            {
                found = false;

                for (int j = 0; j < word2.Length; j++)
                {
                    if (word1[i] == word2[j])
                    {
                        word2 = word2.Remove(j, 1);
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    return false;
                }
            }
            return found;
        }
    }
}
