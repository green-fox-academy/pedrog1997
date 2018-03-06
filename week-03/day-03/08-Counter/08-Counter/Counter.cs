using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Counter
{
    class Counter
    {
        private int integer = 0;
        private int initialValue = 0;

        public Counter()
        {
        }

        public Counter(int integer)
        {
            this.integer = integer;
            initialValue = integer;
        }

        public void Add(int number)
        {
            integer += number;
        }

        public void Add()
        {
            integer++;
        }

        public string Get()
        {
            return integer.ToString();
        }

        public void Reset()
        {
            integer = initialValue;
        }
    }
}
