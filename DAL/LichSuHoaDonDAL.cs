using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;


namespace DAL
{
    public class  LichSuHoaDonDAL
    {
        private readonly DbcontextContext db = new DbcontextContext();

        public void LuuLichSuHoaDon(LichSuHoaDon lichSuHoaDon)
        {
            db.LichSuHoaDon.Add(lichSuHoaDon);
            db.SaveChanges();
        }

        public List<LichSuHoaDon> LayTatCaLichSuHoaDon()
        {
            return db.LichSuHoaDon.OrderByDescending(x => x.TenCaPhe).ToList();
        }
    }
}
