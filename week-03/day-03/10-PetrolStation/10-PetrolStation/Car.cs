using System;
using System.Collections.Generic;
using System.Text;

namespace _10_PetrolStation
{
    class Car
    {
        private int gasAmount;
        private int capacity;

        public Car()
        {
            gasAmount = 0;
            capacity = 100;
        }

        public void SetGasAmount(int gasAmount)
        {
            this.gasAmount = gasAmount;
        }

        public int GetCapacity()
        {
            return capacity;
        }

        public int GetGasAmount()
        {
            return gasAmount;
        }
    }
}
