using System;
using System.Collections.Generic;
using System.Text;

namespace PokerConsoleApp
{
    public class Card : IComparable<Card>
    {
        private int _number;
        private char _suit;

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value; 
            }
        }
        public char Suit
        {
            get
            {
                return _suit;
            }
            set
            {
                _suit = value;
            }
        }

        public Card(int number, char suit)
        {
            _number = number;
            _suit = suit;
        }

        public int CompareTo(Card otherCard)
        {
            return _number.CompareTo(otherCard.Number);
        }
    }
}
