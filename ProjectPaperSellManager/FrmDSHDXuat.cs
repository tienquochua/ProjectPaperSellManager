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
    public partial class FrmDSHDXuat : Form
    {
        string strConn;
        CoSoDuLieu objCSDL;
        DataTable bangDSHDXuat;
        int dongHienTai;
        public FrmDSHDXuat()
        {
            InitializeComponent();
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            objCSDL = new CoSoDuLieu(strConn);
        }

        private void FrmDSHDXuat_Load(object sender, EventArgs e)
        {
            bangDSHDXuat = objCSDL.DocDuLieu("SELECT XuatHang.MaHD, ChiTietXuat.MaMH, NhanVien.TenNV, ChiTietXuat.SoLuong, MatHang.DonGiaBan, ChiTietXuat.SoLuong*MatHang.DonGiaBan as ThanhTien FROM ChiTietXuat, MatHang, XuatHang, NhanVien where ChiTietXuat.MaMH=MatHang.MaMH and XuatHang.MaHD=ChiTietXuat.MaHD and NhanVien.MaNV=XuatHang.MaNV");
            dataGridView1.DataSource = bangDSHDXuat;

        }

        private void FrmDSHDXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }
    }
}
