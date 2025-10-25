using DAL;
using DAL.Models; // <-- Quan trọng
using System;

namespace BUS
{
    public class TaiKhoanBUS
    {
        // Khởi tạo lớp DAL
        private readonly TaiKhoanDAL dal = new TaiKhoanDAL();

        // Hàm kiểm tra đăng nhập
        public bool CheckLogin(string username, string password)
        {
            var taiKhoan = dal.GetByUsername(username);

            if (taiKhoan != null)
            {
                // TODO: Nên mã hóa mật khẩu. Tạm thời kiểm tra mật khẩu thường
                return taiKhoan.Password == password;
            }
            return false; // Không tìm thấy tài khoản
        }

        // Hàm đăng ký
        public bool Register(string username, string password)
        {
            // Kiểm tra xem tên đăng nhập đã tồn tại chưa
            var existing = dal.GetByUsername(username);
            if (existing != null)
            {
                return false; // Đăng ký thất bại vì tên đã tồn tại
            }

            var newTaiKhoan = new TaiKhoan
            {
                Username = username,
                Password = password // TODO: Nên mã hóa (hash) mật khẩu
            };

            // Gọi DAL để thêm vào CSDL
            dal.Add(newTaiKhoan);
            return true; // Đăng ký thành công
        }
    }
}