using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Counter
{
    class Counter
    {
        private int _integer = 0;

        public int Integer
        {
            get
            {
                return _integer;
            }
            set
            {
                value = _integer;
            }
        }

        public Counter() { }

        public Counter (int integer)
        {
            _integer = integer;
        }

    }
}
