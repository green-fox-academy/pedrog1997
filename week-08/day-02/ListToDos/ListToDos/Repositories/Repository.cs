using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListToDos.Repositories
{
    public class Repository
    {
        private DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }
    }
}
