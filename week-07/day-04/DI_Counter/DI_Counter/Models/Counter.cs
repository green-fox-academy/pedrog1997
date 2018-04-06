using DI_Counter.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Counter.Models 
{
    public class Counter : ICounter
    {
        public int Number { get; set; }

        public void IncreaseNumber()
        {
            Number++;
        }
    }
}
