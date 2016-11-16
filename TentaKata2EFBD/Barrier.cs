using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKata2EF
{
    public class Barrier
    {
        public int BarrierID { get; set; }
        public string BarrierName { get; set; }
        public virtual Exit Exit { get; set; }
    }
}
