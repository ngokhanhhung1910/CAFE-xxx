using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BUS
{
    public class LichSuHoaDonBUS
    {
        private readonly LichSuHoaDonDAL lichSuHoaDonDAL = new LichSuHoaDonDAL();

        public void LuuLichSu(String TenCaPhe, int SoLuong, decimal DonGia, decimal ThanhTien, decimal ThanhGia)
        {
            var lichSuHoaDon = new LichSuHoaDon
            {
                TenCaPhe = TenCaPhe,
                SoLuong = SoLuong,
                DonGia = DonGia,
                ThanhTien = ThanhTien,
                ThanhGia = ThanhGia
            };
            lichSuHoaDonDAL.LuuLichSuHoaDon(lichSuHoaDon);
        }
        public List<LichSuHoaDon> LayTatCaLichSuHoaDon()
        {
            return lichSuHoaDonDAL.LayTatCaLichSuHoaDon();
        }
    }
}
