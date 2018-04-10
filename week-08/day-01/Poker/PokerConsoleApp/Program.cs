using System;
using System.Collections.Generic;

namespace PokerConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hand highCardHand = new Hand
            {
                PokerHand = new List<Card>
            {
                new Card(5,'S'),
                new Card(9, 'H'),
                new Card(7, 'S'),
                new Card(6, 'C'),
                new Card(12, 'C')
            }
            };
            Hand straightHand = new Hand
            {
                PokerHand = new List<Card>
            {
                new Card(5,'S'),
                new Card(9, 'H'),
                new Card(7, 'S'),
                new Card(6, 'C'),
                new Card(8, 'C')
            }
            };
            Hand flushHand = new Hand
            {
                PokerHand = new List<Card>
            {
                new Card(5, 'H'),
                new Card(8, 'H'),
                new Card(2, 'H'),
                new Card(9, 'H'),
                new Card(13, 'H')
            }
            };
            Hand straightFlushHand = new Hand
            {
                PokerHand = new List<Card>
            {
                new Card(5,'S'),
                new Card(9, 'S'),
                new Card(7, 'S'),
                new Card(6, 'S'),
                new Card(8, 'S')
            }
            };

            string smt = CompareTwoHands(straightFlushHand, straightHand);
        }

        public static string CompareTwoHands(Hand player1, Hand player2)
        {
            if (player1.Rank > player2.Rank)
            {
                return "Player2 wins!!";
            }
            else if (player1.Rank < player2.Rank)
            {
                return "Player1 wins!!";
            }
            else
            {
                return "Maybe draw";
            }
        }
    }
}
