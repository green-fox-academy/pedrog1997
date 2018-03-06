using System;
using System.Collections.Generic;
using System.Text;

namespace _11_SharpieSet
{
    class SharpieSet
    {
        private List<Sharpie> sharpies = new List<Sharpie>();

        public int CountUsable()
        {
            int count = 0;
            foreach (var sharpie in sharpies)
            {
                if (sharpie.GetInkAmount() > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void RemoveTrash()
        {
            for (int i = 0; i < sharpies.Count; i++)
            {
                if (sharpies[i].GetInkAmount() <= 0)
                {
                    sharpies.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
