using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SearchPalindrome("dog goat dad duck doodle never"));

            Console.Read();
        }

        static bool IsThisAPalindrome(string word)
        {
            string reverseWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }
            if (reverseWord.Equals(word, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string SearchPalindrome(string palindrome)
        {
            palindrome = palindrome.ToLower();
            string check;
            string solutions = string.Empty;

            for (int i = 0; i < palindrome.Length - 1; i++)
            {
                for (int j = i+1; j < palindrome.Length; j++)
                {
                    if (palindrome[i].Equals(palindrome[j]))
                    {
                        check = palindrome.Substring(i, j - i + 1);
                        if (IsThisAPalindrome(check))
                        {
                            solutions += check + ", ";
                        }
                    }
                }
            }
            return solutions;
        }
    }
}