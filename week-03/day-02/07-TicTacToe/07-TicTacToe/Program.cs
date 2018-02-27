using System;
using System.IO;

namespace _07_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TicTacToe("winnerX.txt"));

            Console.Read();
        }

        static string TicTacToe(string fileName)
        {
            try
            {
                string[] linesTicTacToe = File.ReadAllLines(fileName);
                char[] firstLine = linesTicTacToe[0].ToCharArray();
                char[] secondLine = linesTicTacToe[1].ToCharArray();
                char[] thirdLine = linesTicTacToe[2].ToCharArray();

                string winner;

                if (firstLine[0] == firstLine[1] && firstLine[1] == firstLine[2])
                {
                    winner = firstLine[0].ToString();
                }
                else if (secondLine[0] == secondLine[1] && secondLine[1] == secondLine[2])
                {
                    winner = secondLine[0].ToString();
                }
                else if (thirdLine[0] == thirdLine[1] && thirdLine[1] == thirdLine[2])
                {
                    winner = thirdLine[0].ToString();
                }
                else if (firstLine[0] == secondLine[0] && secondLine[0] == thirdLine[0])
                {
                    winner = thirdLine[0].ToString();
                }
                else if (firstLine[1] == secondLine[1] && secondLine[1] == thirdLine[1])
                {
                    winner = thirdLine[1].ToString();
                }
                else if (firstLine[2] == secondLine[2] && secondLine[2] == thirdLine[2])
                {
                    winner = thirdLine[2].ToString();
                }
                else if (firstLine[0] == secondLine[1] && secondLine[1] == thirdLine[2])
                {
                    winner = firstLine[0].ToString();
                }
                else if(firstLine[2] == secondLine[1] && secondLine[1] == thirdLine[0])
                {
                    winner = thirdLine[0].ToString();
                }
                else
                {
                    winner = "draw";
                }
                return winner;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return "";
            }
        }
    }
}
