using System;
using System.Collections.Generic;
using System.Text;

namespace _02_TheGardenApplication
{
    abstract class Plant
    {
        public string name;

        protected string color;
        protected double waterAmount;

        public bool NeedsWater
        {
            get
            {
                return DoYouNeedWater();
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
        }

        public Plant(string color)
        {
            this.color = color;
        }

        protected abstract bool DoYouNeedWater();

        public abstract void AbsorbWater(double waterToAbsorb);
    }
}
