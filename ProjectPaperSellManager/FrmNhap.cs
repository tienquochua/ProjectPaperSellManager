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
    public partial class FrmNhap : Form
    {
        string strConn;
        CoSoDuLieu objCSDL;
        DataTable bangNhap, bangCTNhap, bangNCC, bangMH;
        int dongHienTai;
        public FrmNhap()
        {
            InitializeComponent();
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            objCSDL = new CoSoDuLieu(strConn);
            txtMaNhap.MaxLength = 10;
            txtSL.MaxLength = 15;
        }

        private void FrmNhap_Load(object sender, EventArgs e)
        {
            bangNhap = objCSDL.DocDuLieu("SELECT * FROM NhapHang");
            dataGridView2.DataSource = bangNhap;

            bangCTNhap = objCSDL.DocDuLieu("SELECT MaNhap, MaMH, SoLuong FROM ChiTietNhap");
            dataGridView1.DataSource = bangCTNhap;
            
            bangNCC = objCSDL.DocDuLieu("SELECT * FROM NhaCungCap");
            cbbNCC.DataSource = bangNCC;
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";
            cbbNCC.SelectedIndex = -1;

            bangMH = objCSDL.DocDuLieu("SELECT * FROM MatHang");
            cbbMaHang.DataSource = bangMH;
            cbbMaHang.DisplayMember = "TenHang";
            cbbMaHang.ValueMember = "MaMH";
            cbbMaHang.SelectedIndex = -1;


            cbbMaHang.Enabled = false;
            txtSL.Enabled = false;
        }
        void DuaDuLieuVaoBangCTNhap()
        {
            DataRow dataRow = bangCTNhap.NewRow();
            dataRow[0] = txtMaNhap.Text;
            dataRow[1] = cbbMaHang.SelectedValue.ToString();
            dataRow[2] = txtSL.Text;
            bangCTNhap.Rows.Add(dataRow);
        }
        void DuaDuLieuVaoBangNhap()
        {
            DataRow dataRow = bangNhap.NewRow();
            dataRow[0] = txtMaNhap.Text;
            dataRow[1] = cbbNCC.SelectedValue.ToString(); 
            dataRow[2] = dateTimePicker1.Text;
            bangNhap.Rows.Add(dataRow);
        }
        void DuaThongTinRaControl()
        {
            DataRow dataRow = bangCTNhap.Rows[dongHienTai];
            txtMaNhap.Text = dataRow[0].ToString();
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
                    DuaDuLieuVaoBangCTNhap();
                    dataGridView1.DataSource = bangCTNhap;
                    objCSDL.CapNhatDuLieu(bangNhap, "SELECT * FROM NhapHang");
                    objCSDL.CapNhatDuLieu(bangCTNhap, "SELECT MaNhap,MaMH,SoLuong FROM ChiTietNhap");
                }
            }
            catch(Exception ex)
            {
                if(ex.GetType()==typeof(SqlException))
                {
                    if(ex.Message.Contains("PRIMARY KEY"))
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
                 bangCTNhap.Rows[dongHienTai].Delete();
                 dataGridView1.DataSource = bangCTNhap;
             }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dongHienTai = dataGridView1.CurrentRow.Index;
            DuaThongTinRaControl();
            cbbNCC.SelectedIndex = -1;
        }
        public void DuaThongTinDaCapNhatVaoDataRow()
        {
            DataRow dataRow = bangCTNhap.Rows[dongHienTai];
            dataRow[0] = txtMaNhap.Text;
            dataRow[1] = cbbMaHang.SelectedValue.ToString();
            dataRow[2] = txtSL.Text;           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DuaThongTinDaCapNhatVaoDataRow();
            dataGridView1.DataSource = bangCTNhap;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            objCSDL.CapNhatDuLieu(bangNhap, "SELECT * FROM NhapHang");
            objCSDL.CapNhatDuLieu(bangCTNhap, "SELECT MaNhap, MaMH, SoLuong FROM ChiTietNhap");
            MessageBox.Show("Cập nhật thành công");

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (txtMaNhap.Text==""||cbbNCC.Text=="")
                MessageBox.Show("Nhập mã và chọn nhà cung cấp");
            else
            {
                DuaDuLieuVaoBangNhap();
                dataGridView2.DataSource = bangNhap;

                btnBatDau.Enabled = false;
                txtMaNhap.Enabled = false;
                cbbNCC.Enabled = false;
                dateTimePicker1.Enabled = false;

                cbbMaHang.Enabled = true;
                txtSL.Enabled = true;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtMaNhap.Clear();
            txtSL.Clear();
            cbbMaHang.SelectedIndex = -1;
            cbbNCC.SelectedIndex = -1;
            
            btnBatDau.Enabled = true;
            txtMaNhap.Enabled = true;
            cbbNCC.Enabled = true;
            
            cbbMaHang.Enabled = false;
            txtSL.Enabled = false;
        }

        private void cbbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSL.Clear();
        }

        private void FrmNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void cbbNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
