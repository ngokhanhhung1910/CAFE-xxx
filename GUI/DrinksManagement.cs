using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class DrinksManagement : Form
    {
        public DrinksManagement()
        {
            InitializeComponent();
            // Thêm nhanh bằng code (chỉ dùng nếu bạn muốn)
        }

        private void btnChonCAFE1_Click(object sender, EventArgs e)
        {
            string colTenCaFe = lblCAFE1.Text;
            string GiaCAFE1 = lblGiaCAFE1.Text.Trim();
            GiaCAFE1 = GiaCAFE1.Replace("VND", "").Replace(",", "").Replace(".", "").Trim();
            decimal colDonGia = Convert.ToDecimal(GiaCAFE1);
            int colSoLuong = (int)nudCAFE1.Value;
            decimal colThanhTien = colDonGia * colSoLuong;

            dgvDrinksManagement.Rows.Add(colTenCaFe, colDonGia.ToString("N0"), colSoLuong, colThanhTien.ToString("N0"));

            TinhTongTien1();
        }

        private void TinhTongTien1()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvDrinksManagement.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (row.Cells["colThanhTien"].Value != null)
                    continue;
                string text = row.Cells["colThanhTien"].Value.ToString().Trim();
                text = text.Replace("N0", "").Replace(",", "");
                {
                    tongTien += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
                }
            }
            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        private void btnChonCAFE2_Click(object sender, EventArgs e)
        {
            string colTenCaFe2 = lblCAFE2.Text;
            string GiaCAFE2 = lblGiaCAFE2.Text.Trim();
            GiaCAFE2 = GiaCAFE2.Replace("VND", "").Replace(",", "").Trim();
            decimal colDonGia = Convert.ToDecimal(GiaCAFE2);
            int colSoLuong = (int)nudCAFE2.Value;
            decimal colThanhTien = colDonGia * colSoLuong;

            dgvDrinksManagement.Rows.Add(colTenCaFe2, colDonGia.ToString("N0"), colSoLuong, colThanhTien.ToString("N0"));

            TinhTongTien2();
        }

        private void TinhTongTien2()
        {
            decimal tongTien2 = 0;
            foreach (DataGridViewRow row in dgvDrinksManagement.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (row.Cells["colThanhTien"].Value != null)
                    continue;
                string text = row.Cells["colThanhTien"].Value.ToString().Trim();
                text = text.Replace("N0", "").Replace(",", "");
                {
                    tongTien2 += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
                }
            }
            txtTongTien.Text = tongTien2.ToString("N0") + " VND";
        }

        private void btnChonCAFE3_Click(object sender, EventArgs e)
        {
            string colTenCaFe3 = lblCAFE3.Text;
            string GiaCAFE3 = lblGiaCAFE3.Text.Trim();
            GiaCAFE3 = GiaCAFE3.Replace("VND", "").Replace(",", "").Trim();
            decimal colDonGia = Convert.ToDecimal(GiaCAFE3);
            int colSoLuong = (int)nudCAFE3.Value;
            decimal colThanhTien = colDonGia * colSoLuong;

            dgvDrinksManagement.Rows.Add(colTenCaFe3, colDonGia.ToString("N0"), colSoLuong, colThanhTien.ToString("N0"));

            TinhTongTien3();
        }

        private void TinhTongTien3()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvDrinksManagement.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (row.Cells["colThanhTien"].Value != null)
                    continue;
                string text = row.Cells["colThanhTien"].Value.ToString().Trim();
                text = text.Replace("N0", "").Replace(",", "");
                {
                    tongTien += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
                }
            }
            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        private void btnChonCAFE4_Click(object sender, EventArgs e)
        {
            string colTenCaFe4 = lblCAFE4.Text;
            string GiaCAFE4 = lblGiaCAFE4.Text.Trim();
            GiaCAFE4 = GiaCAFE4.Replace("VND", "").Replace(",", "").Trim();
            decimal colDonGia = Convert.ToDecimal(GiaCAFE4);
            int colSoLuong = (int)nudCAFE4.Value;
            decimal colThanhTien = colDonGia * colSoLuong;

            dgvDrinksManagement.Rows.Add(colTenCaFe4, colDonGia.ToString("N0"), colSoLuong, colThanhTien.ToString("N0"));

            TinhTongTien4();
        }

        private void TinhTongTien4()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvDrinksManagement.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (row.Cells["colThanhTien"].Value != null)
                    continue;
                string text = row.Cells["colThanhTien"].Value.ToString().Trim();
                text = text.Replace("N0", "").Replace(",", "");
                {
                    tongTien += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
                }
            }
            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        private void btnChonCAFE5_Click(object sender, EventArgs e)
        {
            string colTenCaFe5 = lblCAFE5.Text;
            string GiaCAFE5 = lblGiaCAFE5.Text.Trim();
            GiaCAFE5 = GiaCAFE5.Replace("VND", "").Replace(",", "").Trim();
            decimal colDonGia = Convert.ToDecimal(GiaCAFE5);
            int colSoLuong = (int)nudCAFE5.Value;
            decimal colThanhTien = colDonGia * colSoLuong;

            dgvDrinksManagement.Rows.Add(colTenCaFe5, colDonGia.ToString("N0"), colSoLuong, colThanhTien.ToString("N0"));

            TinhTongTien5();
        }

        private void TinhTongTien5()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvDrinksManagement.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (row.Cells["colThanhTien"].Value != null)
                    continue;
                string text = row.Cells["colThanhTien"].Value.ToString().Trim();
                text = text.Replace("N0", "").Replace(",", "");
                {
                    tongTien += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
                }
            }
            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            decimal tongTien = 0;
            List<OrderItem> tempOrder = new List<OrderItem>();

            foreach (DataGridViewRow row in dgvDrinksManagement.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["colDonGia"].Value != null && row.Cells["colSoLuong"].Value != null)
                {
                    decimal donGia = Convert.ToDecimal(row.Cells["colDonGia"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["colSoLuong"].Value);
                    decimal thanhTien = donGia * soLuong;
                    tongTien += thanhTien;

                    if (dgvDrinksManagement.Columns["colThanhTien"] != null)
                        row.Cells["colThanhTien"].Value = thanhTien.ToString("N0");

                    string tenCaPhe = row.Cells["colTenCaFe"].Value.ToString();

                    tempOrder.Add(new OrderItem
                    {
                        TenCaPhe = tenCaPhe,
                        SoLuong = soLuong,
                        DonGia = donGia,
                        ThanhTien = thanhTien
                    });
                }
            }

            txtTongTien.Text = tongTien.ToString("N0") + " VND";

            // Gán vào bộ nhớ tạm
            TemporaryOrderStorage.CurrentOrder = tempOrder;
            TemporaryOrderStorage.TongTien = tongTien;

            // Chuyển sang form OrderManagement
            OrderManagement orderForm = new OrderManagement();
            orderForm.Show();
            this.Hide(); // hoặc Close() nếu bạn muốn tắt form hiện tại
        }

        private void lblGiaCAFE5_Click(object sender, EventArgs e)
        {

        }

        private void lblGiaCAFE4_Click(object sender, EventArgs e)
        {

        }

        private void lblGiaCAFE1_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra có hàng nào được chọn chưa
            if (dgvDrinksManagement.CurrentRow == null || dgvDrinksManagement.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy hàng hiện tại
            DataGridViewRow selectedRow = dgvDrinksManagement.CurrentRow;

            // Lấy dữ liệu hiện tại
            string tenCaFe = selectedRow.Cells["colTenCaFe"].Value?.ToString();
            string donGiaStr = selectedRow.Cells["colDonGia"].Value?.ToString().Replace(",", "");
            string soLuongStr = selectedRow.Cells["colSoLuong"].Value?.ToString();

            decimal donGia;
            int soLuong;

            if (!decimal.TryParse(donGiaStr, out donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(soLuongStr, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị form nhỏ hoặc hộp thoại nhập thông tin sửa
            string newTenCaFe = Microsoft.VisualBasic.Interaction.InputBox("Tên cà phê:", "Sửa thông tin", tenCaFe);
            string newDonGiaStr = Microsoft.VisualBasic.Interaction.InputBox("Đơn giá:", "Sửa thông tin", donGia.ToString());
            string newSoLuongStr = Microsoft.VisualBasic.Interaction.InputBox("Số lượng:", "Sửa thông tin", soLuong.ToString());

            if (string.IsNullOrWhiteSpace(newTenCaFe) || string.IsNullOrWhiteSpace(newDonGiaStr) || string.IsNullOrWhiteSpace(newSoLuongStr))
                return;

            decimal newDonGia;
            int newSoLuong;

            if (!decimal.TryParse(newDonGiaStr, out newDonGia) || !int.TryParse(newSoLuongStr, out newSoLuong))
            {
                MessageBox.Show("Giá trị nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật lại hàng trong DataGridView
            decimal newThanhTien = newDonGia * newSoLuong;
            selectedRow.Cells["colTenCaFe"].Value = newTenCaFe;
            selectedRow.Cells["colDonGia"].Value = newDonGia.ToString("N0");
            selectedRow.Cells["colSoLuong"].Value = newSoLuong;
            selectedRow.Cells["colThanhTien"].Value = newThanhTien.ToString("N0");

            // Gọi lại hàm tính tổng tiền
            TinhTongTien1(); // hoặc TinhTongTien() chung nếu bạn muốn gộp lại

            MessageBox.Show("Đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dgvDrinksManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra có hàng nào được chọn chưa
            if (dgvDrinksManagement.CurrentRow == null || dgvDrinksManagement.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa hàng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Xóa hàng được chọn
                dgvDrinksManagement.Rows.Remove(dgvDrinksManagement.CurrentRow);

                // Cập nhật lại tổng tiền sau khi xóa
            }
        }

    }
}
    
