using DI_GreetSomeone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_GreetSomeone.Models
{
    public class Person : INameable
    {
        public string Name { get; set; }
    }
}
