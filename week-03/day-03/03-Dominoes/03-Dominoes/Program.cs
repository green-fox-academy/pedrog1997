using System;
using System.Collections.Generic;

namespace _03_Dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            int[] currentDomino = new int[2];
            List<Domino> orderedDominoes = new List<Domino>();
            orderedDominoes.Add(dominoes[0]);

            currentDomino = dominoes[0].GetValues();

            for (int i = 0; i < dominoes.Count - 1; i++)
            {
                for (int j = 1; j < dominoes.Count; j++)
                {
                    if (dominoes[j].GetValues()[0] == currentDomino[1])
                    {
                        orderedDominoes.Add(dominoes[j]);
                        currentDomino = dominoes[j].GetValues();
                    }
                }
            }

            string orderedDominoString = string.Empty;

            for (int i = 0; i < orderedDominoes.Count; i++)
            {
                orderedDominoString += $"[{orderedDominoes[i].GetValues()[0]}, {orderedDominoes[i].GetValues()[1]}], ";
            }

            Console.WriteLine(orderedDominoString);
            Console.Read();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}