using FrontEnd.Models.LogEntries;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Database
{
    public class LogContext : DbContext
    {
        public LogContext(DbContextOptions<LogContext> options) : base(options)
        {
        }

        public DbSet<Log> Logs { get; set; }
    }
}
