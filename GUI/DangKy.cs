using BUS; // <-- Quan trọng: Để sử dụng TaiKhoanBUS
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangKy : Form
    {
        private readonly TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public DangKy()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Tên đăng ký và Mật khẩu.",
                                "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool success = taiKhoanBUS.Register(username, password);

                if (success)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Vui lòng chọn tên khác.",
                                    "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}