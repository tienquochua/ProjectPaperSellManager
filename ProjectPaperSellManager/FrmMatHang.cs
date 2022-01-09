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

    public partial class FrmMatHang : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.PaperSellMngConnectionString);
        string strConn;
        CoSoDuLieu objCSDL;
        DataTable bangHang;
        int dongHienTai;
        public FrmMatHang()
        {
            InitializeComponent();
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            objCSDL = new CoSoDuLieu(strConn);

            bangHang = objCSDL.DocDuLieu("SELECT * FROM MatHang");
            cbbTimKiem.DataSource = bangHang;
            cbbTimKiem.DisplayMember = "TenHang";
            cbbTimKiem.ValueMember = "MaMH";
            cbbTimKiem.SelectedIndex = -1;

            txtDGBan.MaxLength = 15;
            txtDGNhap.MaxLength = 15;
            txtDL.MaxLength = 5;
            txtKT.MaxLength = 10;
            txtMaHang.MaxLength = 10;
            txtSL.MaxLength = 10;
            txtTenHang.MaxLength = 20;
        }

        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            bangHang = objCSDL.DocDuLieu("SELECT * FROM MatHang");
            dataGridView1.DataSource = bangHang;
        }
        void DuaDuLieuVaoBangHang()
        {
            DataRow dataRow = bangHang.NewRow();
            dataRow[0] = txtMaHang.Text;
            dataRow[1] = txtTenHang.Text;
            dataRow[2] = txtDGNhap.Text;
            dataRow[3] = txtDGBan.Text;
            dataRow[4] = txtKT.Text;
            dataRow[5] = txtDL.Text;
            dataRow[6] = txtSL.Text;
            bangHang.Rows.Add(dataRow);
        }
        void DuaThongTinRaControl()
        {
            DataRow dataRow = bangHang.Rows[dongHienTai];
            txtMaHang.Text = dataRow[0].ToString();
            txtTenHang.Text = dataRow[1].ToString();
            txtDGNhap.Text = dataRow[2].ToString();
            txtDGBan.Text = dataRow[3].ToString();
            txtKT.Text = dataRow[4].ToString();
            txtDL.Text = dataRow[5].ToString();
            txtSL.Text = dataRow[6].ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || txtDGBan.Text == "" || txtDGNhap.Text == "" || txtDL.Text == "" || txtKT.Text == "" || txtSL.Text == "")
                MessageBox.Show("Nhập đầy đủ thông tin để tiếp tục");
            else
            {
                DuaDuLieuVaoBangHang();
                dataGridView1.DataSource = bangHang;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            objCSDL.CapNhatDuLieu(bangHang, "SELECT * FROM MatHang");
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                bangHang.Rows[dongHienTai].Delete();
                dataGridView1.DataSource = bangHang;

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dongHienTai = dataGridView1.CurrentRow.Index;
            DuaThongTinRaControl();
        }
        public void DuaThongTinDaCapNhatVaoDataRow()
        {
            DataRow dataRow = bangHang.Rows[dongHienTai];
            dataRow[0] = txtMaHang.Text;
            dataRow[1] = txtTenHang.Text;
            dataRow[2] = txtDGNhap.Text;
            dataRow[3] = txtDGBan.Text;
            dataRow[4] = txtKT.Text;
            dataRow[5] = txtDL.Text;
            dataRow[6] = txtSL.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DuaThongTinDaCapNhatVaoDataRow();
            dataGridView1.DataSource = bangHang;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dongHienTai = dataGridView1.CurrentRow.Index;
                if (dongHienTai >= 0 && dongHienTai < dataGridView1.Rows.Count - 1)
                {
                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    btnCapNhat.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
        }

        private void btnXoaTxtBox_Click(object sender, EventArgs e)
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtDGBan.Clear();
            txtDGNhap.Clear();
            txtSL.Clear();
            txtDL.Clear();
            txtKT.Clear();
        }

        private void FrmMatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ và số");
                e.Handled = true;
            }
        }

        private void txtTenHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ và số");
                e.Handled = true;
            }
        }

        private void txtDGNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số");
                e.Handled = true;
            }
        }

        private void txtDGBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số");
                e.Handled = true;
            }
        }

        private void txtDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số");
                e.Handled = true;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số");
                e.Handled = true;
            }
        }

        private void txtKT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ và số");
                e.Handled = true;
            }
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from mh in dc.MatHangs
                        where mh.TenHang == cbbTimKiem.Text
                        select mh;
            dataGridView1.DataSource = query;
        }
    }
}
