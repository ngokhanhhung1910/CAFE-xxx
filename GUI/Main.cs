using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.Diagnostics;
namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void LoadFormDrinksManagementToPanel(Form form)
        {
            pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnDrinksManagement_Click(object sender, EventArgs e)
        {
            LoadFormDrinksManagementToPanel(new DrinksManagement());
        }

        private void LoadFormHomePageToPanel(Form form)
        {
            pnlMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            form.Show();
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            LoadFormHomePageToPanel(new DangNhap());
        }

        private void LoadOderManagementToPanel(Form form)
        {
            pnlMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            LoadOderManagementToPanel(new OrderManagement());

        }

        private void LoadHistoryToPanel(Form form)
        {
            pnlMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LoadHistoryToPanel(new History());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
            private void btnExportPDF_Click(object sender, EventArgs e)
            {
                // --- BẮT BUỘC: Đặt giấy phép (miễn phí) cho QuestPDF ---
                // Bạn chỉ cần gọi dòng này MỘT LẦN duy nhất khi chạy chương trình
                // Bạn có thể đặt nó ở hàm Main() trong Program.cs
                QuestPDF.Settings.License = LicenseType.Community;
                // ----------------------------------------------------

                // 1. Tạo một đối tượng tài liệu
                // (Nếu bạn có hàm khởi tạo, hãy truyền dữ liệu vào đây)
                // ví dụ: var document = new MyDocument("Tên User ABC");
                var document = new MyDocument();

                // 2. Tạo file PDF
                string filePath = "baocao.pdf";
                document.GeneratePdf(filePath);

                // 3. (Tùy chọn) Tự động mở file PDF vừa tạo
                try
                {
                    // Mở file bằng trình xem PDF mặc định của Windows
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tự động mở file PDF. Lỗi: " + ex.Message);
                }

                MessageBox.Show("Đã xuất file 'baocao.pdf' thành công!");
            }

            // ... (các code khác trong Form Main của bạn) ...
        }
    }


