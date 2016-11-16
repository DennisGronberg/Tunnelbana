using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKata2
{
    public class Exit
    {
        public int ExitID { get; set; }
        public string ExitName { get; set; }
        public List<Barrier> Barriers { get; set; }
        public virtual Station Station { get; set; }
    }
}
