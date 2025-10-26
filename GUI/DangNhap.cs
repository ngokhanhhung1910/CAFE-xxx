using BUS; // <-- Quan trọng: Để sử dụng TaiKhoanBUS
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangNhap : Form
    {
        // Khởi tạo lớp BUS
        private readonly TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập và Mật khẩu.",
                                "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool loginSuccess = taiKhoanBUS.CheckLogin(username, password);

                if (loginSuccess)
                {
                    Main frmMain = new Main();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác.",
                                    "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy frmDangKy = new DangKy();
            frmDangKy.ShowDialog();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}