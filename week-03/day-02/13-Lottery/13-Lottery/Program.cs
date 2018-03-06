using System;
using System.Collections.Generic;
using System.IO;

namespace _13_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] lotteryData = Get5Values("lottery.txt");
            Dictionary<int, int> winningNumbers = CountOcurrences(lotteryData);
            List<int> highest5 = HighestFive(winningNumbers);

            Console.WriteLine("The most common numbers in lottery are:");
            foreach (var number in highest5)
            {
                Console.WriteLine(number);
            }

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

        static Dictionary<int, int> CountOcurrences(string[,] lotteryData)
        {
            Dictionary<int, int> winningNumbers = new Dictionary<int, int>();

            for (int i = 0; i < lotteryData.GetLength(0); i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (winningNumbers.ContainsKey(Convert.ToInt32(lotteryData[i, j])))
                    {
                        winningNumbers[Convert.ToInt32(lotteryData[i, j])] += 1;
                    }
                    else
                    {
                        winningNumbers.Add(Convert.ToInt32(lotteryData[i, j]), 1);
                    }
                }
            }
            return winningNumbers;
        }

        static List<int> HighestFive(Dictionary<int, int> winningNumbers)
        {
            int actualHighest = 1;
            List<int> highest5 = new List<int>();

            for (int j = 0; j < 5; j++)
            {
                for (int i = 1; i < 90; i++)
                {
                    if (!highest5.Contains(i))
                    {
                        if (winningNumbers[actualHighest] < winningNumbers[i])
                        {
                            actualHighest = i;
                        }
                    }
                }

                highest5.Add(actualHighest);
                actualHighest = 1;
            }

            return highest5;
        }
    }
}
