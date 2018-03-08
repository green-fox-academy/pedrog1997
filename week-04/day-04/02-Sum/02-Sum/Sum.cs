using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Sum
{
    public class Sum
    {
        public int Summing(List<int> listOfIntegers)
        {
            int suma = 0;
            foreach (var integer in listOfIntegers)
            {
                suma += integer;
            }
            return suma;
        }
    }
}
