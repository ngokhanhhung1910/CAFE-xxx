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
using DAL.Models;

namespace GUI
{
    public partial class History : Form
    {
        LichSuHoaDonBUS lichSuHoaDonBUS = new LichSuHoaDonBUS();
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            dgvHistory.DataSource = lichSuHoaDonBUS.LayTatCaLichSuHoaDon();
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
