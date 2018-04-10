using NUnit.Framework;
using PokerConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerTests
{
    [TestFixture]
    class TestMain
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

        [Test]
        public void Test_CompareTwoHands()
        {
            Assert.AreEqual("Player1 wins!!", 
                Program.CompareTwoHands(straightFlushHand, straightHand));
        }
    }
}
