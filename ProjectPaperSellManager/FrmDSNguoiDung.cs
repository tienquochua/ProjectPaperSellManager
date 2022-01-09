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
    public partial class FrmDSNguoiDung : Form
    {
        string strConn;
        CoSoDuLieu objCSDL;
        DataTable bangUser;
        
        public FrmDSNguoiDung()
        {
            InitializeComponent();
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            objCSDL = new CoSoDuLieu(strConn);
            txtPassword.MaxLength = 10;
            txtUsername.MaxLength = 10;
            txtSDT.MaxLength = 12;
        }

        private void FrmDSNguoiDung_Load(object sender, EventArgs e)
        {
            bangUser = objCSDL.DocDuLieu("SELECT * FROM DangNhap");
            dataGridView1.DataSource = bangUser;
        }

        void DuaDuLieuVaoBangUser()
        {
            DataRow dataRow = bangUser.NewRow();
            dataRow[0] = txtUsername.Text;
            dataRow[1] = txtPassword.Text;
            dataRow[2] = txtSDT.Text;
            bangUser.Rows.Add(dataRow);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUsername.Text == "")
                MessageBox.Show("Nhập tên người dùng và mật khẩu");
            else
            {
                if (MessageBox.Show("Chắc chắn thêm người dùng?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DuaDuLieuVaoBangUser();
                    dataGridView1.DataSource = bangUser;
                    objCSDL.CapNhatDuLieu(bangUser, "SELECT * FROM DangNhap");
                    MessageBox.Show("Thêm người dùng thành công");
                    txtPassword.Clear();
                    txtUsername.Clear();
                    txtSDT.Clear();
                }
            }
        }

        private void FrmDSNguoiDung_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số");
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ và số");
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập chữ và số");
                e.Handled = true;
            }
        }
    }
}
