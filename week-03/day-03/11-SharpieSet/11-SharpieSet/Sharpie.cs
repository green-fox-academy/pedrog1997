using System;
using System.Collections.Generic;
using System.Text;

namespace _11_SharpieSet
{
    class Sharpie
    {
        private string color;
        private float width;
        private float inkAmount = 100f;

        public Sharpie(string color, float width)
        {
            this.color = color;
            this.width = width;
            Console.WriteLine("Your sharpie has an ink amount value of " + inkAmount);
        }

        public void SetSharpie(float inkAmount)
        {
            this.inkAmount = inkAmount;
        }

        public void Use()
        {
            inkAmount--;
            Console.WriteLine("After use, your sharpie has an ink amount value of " + inkAmount);
        }

        public float GetInkAmount()
        {
            return inkAmount;
        }
    }
}
