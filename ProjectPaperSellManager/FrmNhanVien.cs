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
    public partial class FrmNhanVien : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.PaperSellMngConnectionString);
        string strConn;
        CoSoDuLieu objCSDL;
        DataTable bangNV;
        int dongHienTai;
        public FrmNhanVien()
        {
            InitializeComponent();
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            objCSDL = new CoSoDuLieu(strConn);

            bangNV = objCSDL.DocDuLieu("SELECT * FROM NhanVien");
            cbbTimKiem.DataSource = bangNV;
            cbbTimKiem.DisplayMember = "TenNV";
            cbbTimKiem.ValueMember = "MaNV";
            cbbTimKiem.SelectedIndex = -1;

            txtSDTNV.MaxLength = 12;
            txtMaNV.MaxLength = 10;
            txtTenNV.MaxLength = 25;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            bangNV = objCSDL.DocDuLieu("SELECT * FROM NhanVien");
            dataGridView1.DataSource = bangNV;
        }
        void DuaDuLieuVaoBangNV()
        {
            DataRow dataRow = bangNV.NewRow();
            dataRow[0] = txtMaNV.Text;
            dataRow[1] = txtTenNV.Text;
            dataRow[2] = txtSDTNV.Text;
            bangNV.Rows.Add(dataRow);
        }
        void DuaThongTinRaControl()
        {
            DataRow dataRow = bangNV.Rows[dongHienTai];
            txtMaNV.Text = dataRow[0].ToString();
            txtTenNV.Text = dataRow[1].ToString();
            txtSDTNV.Text = dataRow[2].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSDTNV.Text == "")
                MessageBox.Show("Nhập đầy đủ thông tin để tiếp tục");
            else
            {
                DuaDuLieuVaoBangNV();
                dataGridView1.DataSource = bangNV;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            objCSDL.CapNhatDuLieu(bangNV, "SELECT * FROM NhanVien");
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                bangNV.Rows[dongHienTai].Delete();
                dataGridView1.DataSource = bangNV;
                //btnXoa.Enabled = false;
                //btnCapNhat.Enabled = false;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dongHienTai = dataGridView1.CurrentRow.Index;
            DuaThongTinRaControl();
        }
        public void DuaThongTinDaCapNhatVaoDataRow()
        {
            DataRow dataRow = bangNV.Rows[dongHienTai];
            dataRow[0] = txtMaNV.Text;
            dataRow[1] = txtTenNV.Text;
            dataRow[2] = txtSDTNV.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DuaThongTinDaCapNhatVaoDataRow();
            dataGridView1.DataSource = bangNV;
        }

        private void btnXoaTxtBox_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDTNV.Clear();
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)|| char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ");
                e.Handled = true;
            }
        }

        private void FrmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số");
                e.Handled = true;
            }
            
     
 
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ và số");
                e.Handled = true;
            }
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from nv in dc.NhanViens
                        where nv.TenNV == cbbTimKiem.Text
                        select nv;
            dataGridView1.DataSource = query;
        }
    }
}
