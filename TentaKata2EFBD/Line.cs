using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKata2
{
    public class Line
    {
        public int LineID { get; set; }
        public string LineName { get; set; }
        public List<Station> Stations { get; set; }
    }
}
