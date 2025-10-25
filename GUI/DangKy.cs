using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using CAFE.BUS; // <-- Khi nào dùng CSDL thật thì mở dòng này

// Đổi namespace thành "GUI" để khớp với Program.cs và DangNhap.cs
namespace GUI
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 1. Kiểm tra thông tin đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Tên đăng ký và Mật khẩu.",
                                "Đăng ký thất bại",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 2. GỌI HÀM ĐĂNG KÝ TỪ LỚP AccountService
                //    (Đây là phần code đã được sửa)
                bool success = AccountService.Register(username, password);


                // 3. Xử lý kết quả trả về
                if (success)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Đăng ký thành công, đóng form này
                    this.Close();
                }
                else
                {
                    // Đăng ký thất bại (do tên đăng nhập đã tồn tại)
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Vui lòng chọn tên khác.",
                                    "Đăng ký thất bại",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng ký: " + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}