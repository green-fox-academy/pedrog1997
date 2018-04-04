using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Greeting
    {
        static private int counter = 0;

        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting()
        {
        }

        public Greeting(string content)
        {
            Content = content;
            Id = ++counter;
        }
    }
}
