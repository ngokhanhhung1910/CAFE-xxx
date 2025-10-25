using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI // <-- Đảm bảo đúng namespace "GUI" của bạn
{
    // Lớp tĩnh này hoạt động như một CSDL "giả"
    // để lưu tài khoản tạm thời.
    public static class AccountService
    {
        // Dùng Dictionary để lưu <TênĐăngNhập, MậtKhẩu>
        private static Dictionary<string, string> accounts = new Dictionary<string, string>();

        // Khối khởi tạo tĩnh, chạy 1 lần duy nhất khi chương trình bắt đầu
        static AccountService()
        {
            // Thêm một tài khoản "admin" mặc định
            accounts.Add("admin", "123");
        }

        /// <summary>
        /// Hàm kiểm tra đăng nhập
        /// </summary>
        public static bool CheckLogin(string username, string password)
        {
            // 1. Kiểm tra xem username có tồn tại không
            if (accounts.ContainsKey(username))
            {
                // 2. Nếu có, kiểm tra xem mật khẩu có khớp không
                return accounts[username] == password;
            }
            // 3. Nếu username không tồn tại, trả về false
            return false;
        }

        /// <summary>
        /// Hàm đăng ký tài khoản mới
        /// </summary>
        public static bool Register(string username, string password)
        {
            // 1. Kiểm tra xem username đã tồn tại chưa
            if (accounts.ContainsKey(username))
            {
                return false; // Đăng ký thất bại vì tên đã tồn tại
            }

            // 2. Nếu chưa, thêm tài khoản mới vào
            accounts.Add(username, password);
            return true; // Đăng ký thành công
        }
    }
}