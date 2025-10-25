using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;


namespace DAL
{
    public class LichSuHoaDonDAL
    {
        private readonly DbcontextContext db = new DbcontextContext();

        public void LuuLichSuHoaDon(LichSuHoaDon lichSuHoaDon)
        {
            var TonTai = db.LichSuHoaDon.FirstOrDefault(x => x.TenCaPhe == lichSuHoaDon.TenCaPhe);
            if (TonTai != null)
            {
                TonTai.SoLuong += lichSuHoaDon.SoLuong;
                TonTai.ThanhTien += lichSuHoaDon.ThanhTien;

                db.Entry(TonTai).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                db.LichSuHoaDon.Add(lichSuHoaDon);

            }

            db.SaveChanges();
        }

        public List<LichSuHoaDon> LayTatCaLichSuHoaDon()
        {
            return db.LichSuHoaDon.OrderByDescending(x => x.TenCaPhe).ToList();
        }
    }
}

