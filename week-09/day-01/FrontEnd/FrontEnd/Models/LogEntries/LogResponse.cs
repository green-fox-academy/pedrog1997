using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models.LogEntries
{
    public class LogResponse
    {
        public List<Log> Logs { get; set; }
        public int EntryCount { get; set; }
    }
}
