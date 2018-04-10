using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerConsoleApp
{
    public class Hand
    {
        private List<Card> _pokerHand;
        private int _rank;

        public List<Card> PokerHand
        {
            get
            {
                return _pokerHand;
            }
            set
            {
                _pokerHand = value;
            }
        }
        public int Rank
        {
            get
            {
                if (IsStraightFlush())
                {
                    _rank = 2;
                    return _rank;
                }
                else if (IsFlush())
                {
                    _rank = 5;
                    return _rank;
                }
                else if (IsStraight())
                {
                    _rank = 6;
                    return _rank;
                }
                return 0;
            }
            set
            {
                _rank = value;
            }
        }

        public bool IsRoyalFlush()
        {
            if (!IsStraightFlush())
            {
                return false;
            }

            if (_pokerHand.Any(x => x.Number == 10) && _pokerHand.Any(x => x.Number == 14))
            {
                return true;
            }
            return false;
        }

        public bool IsStraightFlush()
        {
            if (!IsFlush())
            {
                return false;
            }

            if (!IsStraight())
            {
                return false;
            }

            return true;
        }

        //public bool IsPoker()
        //{
        //    _pokerHand.GroupBy(x => x.Number, )
        //}

        public bool IsFlush()
        {
            char suit = _pokerHand[0].Suit;

            for (int i = 1; i < _pokerHand.Count; i++)
            {
                if (_pokerHand[i].Suit != suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight()
        {
            _pokerHand.Sort();

            for (int i = 0; i < _pokerHand.Count - 1; i++)
            {
                if (_pokerHand[i + 1].Number != _pokerHand[i].Number + 1)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
