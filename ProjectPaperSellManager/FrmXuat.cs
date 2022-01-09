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
using System.Data.SqlClient;

namespace ProjectPaperSellManager
{
    public partial class FrmXuat : Form
    {
        string strConn;
        CoSoDuLieu objCSDL;
        DataTable bangXuat, bangCTXuat, bangNV, bangMH;
        int dongHienTai;
        public FrmXuat()
        {
            InitializeComponent();
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            objCSDL = new CoSoDuLieu(strConn);
            txtMaHD.MaxLength = 10;
            txtSL.MaxLength = 10;
        }

        private void FrmXuat_Load(object sender, EventArgs e)
        {
            bangXuat = objCSDL.DocDuLieu("SELECT * FROM XuatHang");
            dataGridView2.DataSource = bangXuat;
            
            bangCTXuat = objCSDL.DocDuLieu("SELECT MaHD, MaMH, SoLuong FROM ChiTietXuat");
            dataGridView1.DataSource = bangCTXuat;

            bangNV = objCSDL.DocDuLieu("SELECT * FROM NhanVien");
            cbbNV.DataSource = bangNV;
            cbbNV.DisplayMember = "TenNV";
            cbbNV.ValueMember = "MaNV";
            cbbNV.SelectedIndex = -1;

            bangMH = objCSDL.DocDuLieu("SELECT * FROM MatHang");
            cbbMaHang.DataSource = bangMH;
            cbbMaHang.DisplayMember = "TenHang";
            cbbMaHang.ValueMember = "MaMH";
            cbbMaHang.SelectedIndex = -1;
            cbbMaHang.Enabled = false;
            txtSL.Enabled = false;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        void DuaDuLieuVaoBangXuat()
        {
            DataRow dataRow = bangXuat.NewRow();
            dataRow[0] = txtMaHD.Text;
            dataRow[1] = cbbNV.SelectedValue.ToString();
            dataRow[2] = dateTimePicker1.Text;
            bangXuat.Rows.Add(dataRow);
        }
        void DuaDuLieuVaoBangCTXuat()
        {
            DataRow dataRow = bangCTXuat.NewRow();
            dataRow[0] = txtMaHD.Text;
            dataRow[1] = cbbMaHang.SelectedValue.ToString();
            dataRow[2] = txtSL.Text;
            bangCTXuat.Rows.Add(dataRow);
        }
        void DuaThongTinRaControl()
        {
            DataRow dataRow = bangCTXuat.Rows[dongHienTai];
            txtMaHD.Text = dataRow[0].ToString();
            cbbMaHang.SelectedValue = dataRow[1].ToString();
            txtSL.Text = dataRow[2].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbMaHang.Text == "" || txtSL.Text == "")
                    MessageBox.Show("Chọn mặt hàng và nhập số lượng");
                else
                {
                    DuaDuLieuVaoBangCTXuat();
                    dataGridView1.DataSource = bangCTXuat;
                    objCSDL.CapNhatDuLieu(bangXuat, "SELECT * FROM XuatHang");
                    objCSDL.CapNhatDuLieu(bangCTXuat, "SELECT MaHD,MaMH,SoLuong FROM ChiTietXuat");
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(SqlException))
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Trùng");
                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                    }
                }
                else
                {
                    throw ex;
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                bangCTXuat.Rows[dongHienTai].Delete();
                dataGridView1.DataSource = bangCTXuat;
            }
        }
        public void DuaThongTinDaCapNhatVaoDataRow()
        {
            DataRow dataRow = bangCTXuat.Rows[dongHienTai];
            dataRow[0] = txtMaHD.Text;
            dataRow[1] = cbbMaHang.SelectedValue.ToString();
            dataRow[2] = txtSL.Text;           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DuaThongTinDaCapNhatVaoDataRow();
            dataGridView1.DataSource = bangCTXuat;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            objCSDL.CapNhatDuLieu(bangXuat, "SELECT * FROM XuatHang");
            objCSDL.CapNhatDuLieu(bangCTXuat, "SELECT MaHD, MaMH, SoLuong FROM ChiTietXuat"); 
            MessageBox.Show("Cập nhật thành công");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dongHienTai = dataGridView1.CurrentRow.Index;
            DuaThongTinRaControl();
            cbbNV.SelectedIndex = -1;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || cbbNV.Text == "")
                MessageBox.Show("Nhập mã và chọn nhân viên");
            else
            {
                DuaDuLieuVaoBangXuat();
                dataGridView2.DataSource = bangXuat;
                
                btnBatDau.Enabled = false;
                txtMaHD.Enabled = false;
                cbbNV.Enabled = false;
                dateTimePicker1.Enabled = false;

                cbbMaHang.Enabled = true;
                txtSL.Enabled = true;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtSL.Clear();
            cbbMaHang.SelectedIndex = -1;
            cbbNV.SelectedIndex = -1;
            
            btnBatDau.Enabled = true;
            txtMaHD.Enabled = true;
            cbbNV.Enabled = true;

            cbbMaHang.Enabled = false;
            txtSL.Enabled = false;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void cbbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSL.Clear();
        }

        private void FrmXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void txtMaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ và số");
                e.Handled = true;
            }
        }

        private void cbbNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số");
                e.Handled = true;
            }
        }

    }
}
