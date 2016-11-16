using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKata2EFBD
{
    public class Station
    {
        public int StationID { get; set; }
        public string StationName { get; set; }
        public List<Exit> Exits { get; set; }
        public virtual Line Line { get; set; }
    }
}
