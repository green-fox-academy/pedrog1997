using NUnit.Framework;
using PokerConsoleApp;
using System.Collections.Generic;

namespace Poker
{
    [TestFixture]
    public class TestHand
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
        Hand royalFlushHand = new Hand
        {
            PokerHand = new List<Card>
            {
                new Card(14, 'D'),
                new Card(10, 'D'),
                new Card(13, 'D'),
                new Card(11, 'D'),
                new Card(12, 'D')
            }
        };

        [Test]
        public void Test_IsStraight()
        {
            Assert.IsTrue(straightHand.IsStraight());
        }

        [Test]
        public  void Test_IsStraight_False()
        {
            Assert.IsFalse(highCardHand.IsStraight());
        }

        [Test]
        public void Test_IsFlush()
        {
            Assert.IsTrue(flushHand.IsFlush());
        }

        [Test]
        public void Test_IsFlush_False()
        {
            Assert.IsFalse(straightHand.IsFlush());
        }

        [Test]
        public void Test_IsStraightFlush()
        {
            Assert.IsTrue(straightFlushHand.IsStraightFlush());
        }

        [Test]
        public void Test_IsStraightFlush_False()
        {
            Assert.IsFalse(flushHand.IsStraightFlush());
        }

        [Test]
        public void Test_IsRoyalFlush()
        {
            Assert.IsTrue(royalFlushHand.IsRoyalFlush());
        }

        [Test]
        public void Test_IsRoyalFlush_False()
        {
            Assert.IsFalse(flushHand.IsRoyalFlush());
        }
    }
}
