using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProjectPaperSellManager
{
    public partial class Form1 : Form
    {
        string strConn;
        public Form1()
        {
            InitializeComponent();
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;           
        }

       

        private void matHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMatHang mh = new FrmMatHang();
            mh.ShowDialog();
            
        }

        private void hoaDonNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhap nh = new FrmNhap();
            nh.ShowDialog();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhanVien nv = new FrmNhanVien();
            nv.ShowDialog();
        }

        private void danhSachHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDSHDNhap dsnhap = new FrmDSHDNhap();
            dsnhap.ShowDialog();
        }

        private void nhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNCC ncc = new FrmNCC();
            ncc.ShowDialog();
        }

        private void hoaDonBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmXuat hd = new FrmXuat();
            hd.ShowDialog();
        }

        private void danhSachHoaDonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDSHDXuat hdx = new FrmDSHDXuat();
            hdx.ShowDialog();
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void themNguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDSNguoiDung nd = new FrmDSNguoiDung();
            nd.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }   
    }
}
