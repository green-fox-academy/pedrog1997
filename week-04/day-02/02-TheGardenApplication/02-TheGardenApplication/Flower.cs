using System;
using System.Collections.Generic;
using System.Text;

namespace _02_TheGardenApplication
{
    class Flower : Plant
    {
        public Flower(string color) : base(color)
        {
            name = "flower";
        }

        public override void AbsorbWater(double waterToAbsorb)
        {
            waterAmount = 0.75 * waterToAbsorb;
        }

        protected override bool DoYouNeedWater()
        {
            return waterAmount < 5;
        }
    }
}
