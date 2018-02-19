using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IsAnagram("anagram", "nagaram");

            Console.Read();
        }

        public static void IsAnagram(string word1, string word2)
        {
            bool anagrams = true;
            if (word1.Length != word2.Length) 
            {
                Console.WriteLine("The words are not anagrams");
            }
            else
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    for (int j = 0; j < word2.Length; j++)
                    {
                        if (word1[i] == word2[j])
                        {
                            word2 = " " + word2.Remove(j,1);
                            break;
                        }
                        else
                        {
                            if (j == word1.Length - 1)
                            {
                                Console.WriteLine("The words are not anagrams");
                                anagrams = false;
                                break;
                            }
                        }
                    }
                    if (anagrams == false)
                    {
                        break;
                    }
                }
                if (anagrams == true)
                {
                    Console.WriteLine("The words are anagrams");
                }
            }
        }
    }
}