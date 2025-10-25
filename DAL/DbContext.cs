using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;

namespace DAL.Models
{
    public class DbcontextContext : DbContext
    {
        public DbcontextContext() : base("LICHSUHOADON") { }
        public DbSet<LichSuHoaDon> LichSuHoaDon { get; set;}
    }
}
