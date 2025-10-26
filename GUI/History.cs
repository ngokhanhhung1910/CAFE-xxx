using System;
using System.Collections.Generic; // <-- Thêm
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.Models;
using System.Diagnostics;
using QuestPDF.Fluent;      // <-- Thêm
using QuestPDF.Infrastructure; // <-- Thêm

namespace GUI
{
    public partial class History : Form
    {
        LichSuHoaDonBUS lichSuHoaDonBUS = new LichSuHoaDonBUS();

        private List<LichSuHoaDon> currentHistoryList;

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            try
            {
                currentHistoryList = lichSuHoaDonBUS.LayTatCaLichSuHoaDon();

                dgvHistory.DataSource = currentHistoryList;
                
                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử: " + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvHistory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dgvHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistory.ColumnHeadersHeight = 50;

            dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            dgvHistory.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            dgvHistory.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            dgvHistory.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            dgvHistory.RowHeadersVisible = false;

            dgvHistory.ScrollBars = ScrollBars.Vertical;
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Code cũ của bạn
        }

        // --- HÀM XUẤT PDF ĐÃ SỬA ---
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            if (currentHistoryList == null || currentHistoryList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu lịch sử để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // SỬA LỖI: Truyền (currentHistoryList) vào hàm khởi tạo
                var document = new HistoryDocument(currentHistoryList);

                string filePath = "LichSuHoaDon.pdf";
                document.GeneratePdf(filePath);

                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                MessageBox.Show("Xuất file 'LichSuHoaDon.pdf' thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hiệu ứng hover cho button
        private void btnExportPDF_MouseEnter(object sender, EventArgs e)
        {
            btnExportPDF.BackColor = System.Drawing.Color.FromArgb(39, 174, 96); 
            btnExportPDF.Cursor = Cursors.Hand;
        }

        private void btnExportPDF_MouseLeave(object sender, EventArgs e)
        {
            btnExportPDF.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); 
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}