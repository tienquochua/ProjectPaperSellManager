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
    public partial class FrmNCC : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.PaperSellMngConnectionString);
        string strConn;
        CoSoDuLieu objCSDL;
        DataTable bangNCC;
        int dongHienTai;
        public FrmNCC()
        {
            InitializeComponent();
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            objCSDL = new CoSoDuLieu(strConn);
            txtMaNCC.MaxLength = 10;
            txtSDTNCC.MaxLength = 12;
            txtTenNCC.MaxLength = 25;

            bangNCC = objCSDL.DocDuLieu("SELECT * FROM NhaCungCap");
            cbbTimKiem.DataSource = bangNCC;
            cbbTimKiem.DisplayMember = "TenNCC";
            cbbTimKiem.ValueMember = "MaNCC";
            cbbTimKiem.SelectedIndex = -1;
        }

        private void FrmNCC_Load(object sender, EventArgs e)
        {
            bangNCC = objCSDL.DocDuLieu("SELECT * FROM NhaCungCap");
            dataGridView1.DataSource = bangNCC;
        }
        void DuaDuLieuVaoBangNCC()
        {
            DataRow dataRow = bangNCC.NewRow();
            dataRow[0] = txtMaNCC.Text;
            dataRow[1] = txtTenNCC.Text;
            dataRow[2] = txtSDTNCC.Text;
            bangNCC.Rows.Add(dataRow);
        }
        void DuaThongTinRaControl()
        {
            DataRow dataRow = bangNCC.Rows[dongHienTai];
            txtMaNCC.Text = dataRow[0].ToString();
            txtTenNCC.Text = dataRow[1].ToString();
            txtSDTNCC.Text = dataRow[2].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtSDTNCC.Text == "")
                MessageBox.Show("Nhập đầy đủ thông tin để tiếp tục");
            else
            {
                DuaDuLieuVaoBangNCC();
                dataGridView1.DataSource = bangNCC;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            objCSDL.CapNhatDuLieu(bangNCC, "SELECT * FROM NhaCungCap");
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                bangNCC.Rows[dongHienTai].Delete();
                dataGridView1.DataSource = bangNCC;
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
            DataRow dataRow = bangNCC.Rows[dongHienTai];
            dataRow[0] = txtMaNCC.Text;
            dataRow[1] = txtTenNCC.Text;
            dataRow[2] = txtSDTNCC.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DuaThongTinDaCapNhatVaoDataRow();
            dataGridView1.DataSource = bangNCC;
        }

        private void btnXoaTxtBox_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSDTNCC.Clear();
        }

        private void FrmNCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ và số");
                e.Handled = true;
            }
        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ và số");
                e.Handled = true;
            }
        }

        private void txtSDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số");
                e.Handled = true;
            }
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from ncc in dc.NhaCungCaps
                        where ncc.TenNCC == cbbTimKiem.Text
                        select ncc;
            dataGridView1.DataSource = query;
        }

    }
}
