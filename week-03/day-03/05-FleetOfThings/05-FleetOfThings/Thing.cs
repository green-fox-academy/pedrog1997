using System;
using System.Collections.Generic;
using System.Text;

namespace _05_FleetOfThings
{
    class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }

        public bool IsCompleted()
        {
            return Completed;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
