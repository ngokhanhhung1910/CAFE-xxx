using DAL.Models; // <-- Quan trọng
using System.Linq;

namespace DAL
{
    public class TaiKhoanDAL
    {
        // Khởi tạo DbContext
        private readonly DbcontextContext db = new DbcontextContext();

        // Hàm tìm tài khoản theo Tên đăng nhập
        public TaiKhoan GetByUsername(string username)
        {
            return db.TaiKhoans.FirstOrDefault(tk => tk.Username == username);
        }

        // Hàm thêm một tài khoản mới
        public void Add(TaiKhoan taiKhoan)
        {
            db.TaiKhoans.Add(taiKhoan);
            db.SaveChanges(); // Lưu thay đổi vào CSDL
        }
    }
}