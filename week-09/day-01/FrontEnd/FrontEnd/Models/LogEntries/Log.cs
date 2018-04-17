using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models.LogEntries
{
    public class Log
    {
        public int LogId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string EndPoint { get; set; }
        public string Data { get; set; }
    }
}
