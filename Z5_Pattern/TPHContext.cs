using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_Pattern
{
    public class TPHContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
    }
}
