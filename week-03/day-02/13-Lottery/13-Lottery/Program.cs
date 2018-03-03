using System;
using System.Collections.Generic;
using System.IO;

namespace _13_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Lottery("lottery.txt");
            Console.Read();
        }

        static string[,] Get5Values(string path)
        {
            string[] lotteryText = File.ReadAllLines(path);
            string[,] lotteryData = new string[lotteryText.Length, 5];

            int k = 11;

            for (int i = 0; i < lotteryText.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    lotteryData[i, j] = lotteryText[i].Split(';')[k];
                    k++;
                }
                k = 11;
            }

            return lotteryData;
        }

        static Dictionary<string, int> CountOcurrences(string[,] lotteryData)
        {
            Dictionary<string, int> winningNumbers = new Dictionary<string, int>();

            for (int i = 0; i < lotteryData.GetLength(0); i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (winningNumbers.ContainsKey(lotteryData[i, j]))
                    {
                        winningNumbers[lotteryData[i, j]] += 1;
                    }
                    else
                    {
                        winningNumbers.Add(lotteryData[i, j], 1);
                    }
                }
            }
            return winningNumbers;
        }

        static void GreatestFive(Dictionary<string, int> winningNumbers)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < winningNumbers.Count; j++)
                {

                }
            }
        }
    }
}
