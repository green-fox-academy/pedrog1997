using System;
using System.Collections.Generic;
using System.Text;

namespace _02_TheGardenApplication
{
    class Tree : Plant
    {
        public Tree(string color) : base(color)
        {
            name = "tree";
        }

        public override void AbsorbWater(double waterToAbsorb)
        {
            waterAmount = 0.4 * waterToAbsorb;
        }

        protected override bool DoYouNeedWater()
        {
            return waterAmount < 10;
        }
    }
}
