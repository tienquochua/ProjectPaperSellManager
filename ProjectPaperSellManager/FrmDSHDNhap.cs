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
    public partial class FrmDSHDNhap : Form
    {
        string strConn;
        CoSoDuLieu objCSDL;
        DataTable bangDSHDNhap;
        int dongHienTai;
        public FrmDSHDNhap()
        {
            InitializeComponent();
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            objCSDL = new CoSoDuLieu(strConn);
        }

        private void FrmDSHDNhap_Load(object sender, EventArgs e)
        {
            bangDSHDNhap = objCSDL.DocDuLieu("SELECT NhapHang.MaNhap, ChiTietNhap.MaMH, NhaCungCap.TenNCC, ChiTietNhap.SoLuong, MatHang.DonGiaNhap, ChiTietNhap.SoLuong*MatHang.DonGiaNhap as ThanhTien FROM ChiTietNhap, MatHang, NhapHang, NhaCungCap where ChiTietNhap.MaMH=MatHang.MaMH and NhapHang.MaNhap=ChiTietNhap.MaNhap and NhaCungCap.MaNCC=NhapHang.MaNCC");
            dataGridView1.DataSource = bangDSHDNhap;
        }

        private void FrmDSHDNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }
    }
}
