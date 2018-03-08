using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Comparator
{
    class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(Domino other)
        {
            return Values[1].CompareTo(other.Values[0]);
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
