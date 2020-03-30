using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TETS
{
    [Table("Serv")]
    public class TSComputer
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CoolingType { get; set; }
        public int Weight { get; set; }

        public virtual TSServer Server { get; set; }
    }
}
