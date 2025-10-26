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
using BUS;
using DAL.Models;

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

                try
                {
                    // Lấy dữ liệu lịch sử từ database
                    LichSuHoaDonBUS lichSuHoaDonBUS = new LichSuHoaDonBUS();
                    List<LichSuHoaDon> historyList = lichSuHoaDonBUS.LayTatCaLichSuHoaDon();

                    if (historyList == null || historyList.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất PDF.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Tạo document với dữ liệu
                    var document = new HistoryDocument(historyList);

                    // Tạo file PDF
                    string filePath = "baocao.pdf";
                    document.GeneratePdf(filePath);

                    // Mở file PDF
                    try
                    {
                        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tự động mở file PDF. Lỗi: " + ex.Message);
                    }

                    MessageBox.Show("Đã xuất file 'baocao.pdf' thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // ... (các code khác trong Form Main của bạn) ...
        }
    }


