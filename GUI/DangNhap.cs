using System;
using System.Windows.Forms;

namespace GUI
{
    // Đảm bảo tên class là "DangNhap" và kế thừa từ "Form"
    public partial class DangNhap : Form
    {
        // Hàm khởi tạo, cũng đổi tên thành "DangNhap"
        public DangNhap()
        {
            InitializeComponent();
        }

        // Hàm xử lý sự kiện click nút Đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập và Mật khẩu.",
                                "Đăng nhập thất bại",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Gọi lớp dịch vụ tài khoản để kiểm tra
                bool loginSuccess = AccountService.CheckLogin(username, password);

                if (loginSuccess)
                {
                    // Đăng nhập thành công, mở form Main (form chính của bạn)
                    Main frmMain = new Main(); // Mở form Main của bạn
                    frmMain.Show();

                    // Ẩn form đăng nhập này đi
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác.",
                                    "Đăng nhập thất bại",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xử lý sự kiện click link Đăng ký
        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form Đăng Ký
            DangKy frmDangKy = new DangKy();
            frmDangKy.ShowDialog();
        }
    }
}