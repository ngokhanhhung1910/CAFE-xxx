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
            for (int i = 1; i <= 21; i++)
            {
                comboBox1.Items.Add(i);
            }
        }
        private bool isRed = false; // biến lưu trạng thái màu hiện tại

        private void ButtonSeat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // xác định nút nào được nhấn

            if (btn.BackColor != Color.Red)
            {
                btn.BackColor = Color.Red; // đổi sang đỏ
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = SystemColors.Control; // trở về mặc định
                btn.ForeColor = Color.Black;
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
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn số ghế trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soGhe = comboBox1.SelectedItem.ToString();

            // Kiểm tra xem ghế này đã có trong danh sách chưa
            bool daTonTai = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["soghe"].Value != null && row.Cells["soghe"].Value.ToString() == soGhe)
                {
                    daTonTai = true;
                    break;
                }
            }

            if (daTonTai)
            {
                MessageBox.Show($"Ghế số {soGhe} đã được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thêm dòng mới vào DataGridView

            int stt = dataGridView1.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow) + 1;
            dataGridView1.Rows.Add(stt, soGhe);
        }
    }
}
