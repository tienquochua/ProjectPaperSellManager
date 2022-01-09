using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPaperSellManager
{
    public partial class FrmThemHang : Form
    {
        internal ThemHang objThemHang { get; set; }
        public FrmThemHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            objThemHang = new ThemHang(txtMaHang.Text, txtTenHang.Text, int.Parse(txtDGNhap.Text), int.Parse(txtDGBan.Text), txtKT.Text, int.Parse(txtDL.Text), int.Parse(txtSL.Text));
            Close();
        }
    }
}
