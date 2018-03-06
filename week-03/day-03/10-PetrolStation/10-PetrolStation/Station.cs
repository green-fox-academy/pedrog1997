using System;
using System.Collections.Generic;
using System.Text;

namespace _10_PetrolStation
{
    class Station
    {
        private int gasAmount = 1000;

        public void Refill(Car car)
        {
            car.SetGasAmount(car.GetCapacity());
            gasAmount -= car.GetGasAmount();
        }
    }
}
