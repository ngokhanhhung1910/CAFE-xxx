using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();

        }
        private List<string> danhSachBanDaChon = new List<string>();

        private void ButtonSeat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor != Color.Red)
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;

                // Thêm bàn vào danh sách
                if (!danhSachBanDaChon.Contains(btn.Text))
                    danhSachBanDaChon.Add(btn.Text);
            }
            else
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = Color.Black;

                // Xóa bàn khỏi danh sách
                danhSachBanDaChon.Remove(btn.Text);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            if (danhSachBanDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một bàn trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu tạm từ DrinksManagement
            var orderList = TemporaryOrderStorage.CurrentOrder;
            decimal tongTien = TemporaryOrderStorage.TongTien;

            if (orderList == null || orderList.Count == 0)
            {
                MessageBox.Show("Chưa có đơn đồ uống nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuongBan = danhSachBanDaChon.Count;
            string soBan = string.Join(", ", danhSachBanDaChon); // ví dụ: "Bàn 1, Bàn 2, Bàn 3"

            // Lưu vào cơ sở dữ liệu
            LichSuHoaDonBUS lichSuHoaDonBUS = new LichSuHoaDonBUS();
            foreach (var item in orderList)
            {
                lichSuHoaDonBUS.LuuLichSu(
                    item.TenCaPhe,
                    item.SoLuong,
                    item.DonGia,
                    item.ThanhTien,
                    tongTien,
                    soLuongBan, // Thêm số lượng bàn
                    soBan       // Thêm danh sách bàn
                );
            }

            MessageBox.Show("Thanh toán thành công và đã lưu vào lịch sử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset dữ liệu sau khi lưu
            danhSachBanDaChon.Clear();
            TemporaryOrderStorage.CurrentOrder.Clear();
            TemporaryOrderStorage.TongTien = 0;

            // Làm mới form hoặc chuyển về form chính
            this.Close();
        }

    }
}
