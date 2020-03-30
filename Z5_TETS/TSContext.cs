using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TETS
{
    public class TSContext : DbContext
    {
        public DbSet<TSComputer> Computers { get; set; }
        public DbSet<TSServer> Servers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TSComputer>()
                .HasRequired(e => e.Server)
                .WithRequiredDependent(e => e.Computer);
        }
    }
}
