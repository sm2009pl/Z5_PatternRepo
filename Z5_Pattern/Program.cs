using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Computers.Add(new Laptop()
            { Price = 1000, Description = "Std laptop", Weight = 16 });
            tph.SaveChanges();

            var tpt = new TPTContext();
            tpt.Computers.Add(new Laptop()
            { Price = 1000, Description = "Std laptop", Weight = 16 });
            tpt.SaveChanges();

            var tpc = new TPCContext();
            tpc.Computers.Add(new Laptop()
            { Price = 1000, Description = "Std laptop", Weight = 16 });
            tpc.SaveChanges();

            Console.WriteLine("Ready");

        }
    }
}
