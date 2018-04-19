using System;
using System.Collections.Generic;

namespace ExampleExam.Models
{
    public partial class Spaceship
    {
        private int _maxCapacity;

        public int Id { get; set; }
        public int MaxCapacity
        {
            get
            {
                return _maxCapacity;
            }
            set
            {
                _maxCapacity = value;
            }
        }
        public string Planet { get; set; }
        public int Utilization { get; set; }
    }
}
