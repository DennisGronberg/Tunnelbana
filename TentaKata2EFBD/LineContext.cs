using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TentaKata2EF
{
    public class LineContext : DbContext
    {
        public DbSet<Line> Lines { get; set; }
        public LineContext() : base("TentaKata2") { }
    }
}
