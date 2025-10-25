using System.Data.Entity;
using DAL.Models; // <-- Thêm dòng này

namespace DAL.Models // Đảm bảo namespace là DAL.Models
{
    public class DbcontextContext : DbContext
    {
        // Tên chuỗi kết nối (sẽ tạo ở Bước 4)
        public DbcontextContext() : base("LICHSUHOADON") { } 
        
        public DbSet<LichSuHoaDon> LichSuHoaDon { get; set;}

        // --- THÊM DÒNG NÀY ĐỂ KHAI BÁO BẢNG TÀI KHOẢN ---
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
    }
}