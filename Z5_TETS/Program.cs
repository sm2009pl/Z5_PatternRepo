using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TETS
{
    class Program
    {
        static void Main(string[] args)
        {
            var es = new ESContext();
            es.Computers.Add(new ESComputer()
            { Description = "Normal laptop", CoolingType = "Air", Weight = 2, Price = 1500 });
            es.SaveChanges();

            var ts = new TSContext();
            ts.Computers.Add(new TSComputer()
            {
                Description = "Normal laptop",
                CoolingType = "Air",
                Weight = 2,
                Price = 1500,
                Server = new TSServer() { Bandwidth = 1000 }
            });

            Console.WriteLine("Ready");
        }
    }
}
