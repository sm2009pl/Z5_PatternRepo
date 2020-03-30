using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TETS
{
    [Table("Comp")]
    public class TSServer
    {
        public int ServerId { get; set; }
        public int ComputerId { get; set; }
        public int Bandwidth { get; set; }
        public virtual TSComputer Computer { get; set; }
    }
}
