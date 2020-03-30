using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TETS
{
    class ESContext : DbContext
    {
        public DbSet<ESComputer> Computers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ESComputer>().Map(map =>
            {
                map.Properties(prop => new
                {
                    prop.CoolingType,
                    prop.Description
                });
                map.ToTable("PolaTekstowe");
            });
            modelBuilder.Entity<ESComputer>().Map(map =>
            {
                map.Properties(prop => new
                {
                    prop.Id,
                    prop.Price,
                    prop.Weight
                });
                map.ToTable("PolaLiczbowe");
            });
        }
    }
}
