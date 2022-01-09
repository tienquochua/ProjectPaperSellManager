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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtUsername.MaxLength = 10;
            txtPassword.MaxLength = 10;

        }
        private void btnOK_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=windows\\sqlexpress;Initial Catalog=PaperSellMng;Integrated Security=True");
            SqlDataReader dr = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DangNhap where TaiKhoan='" + txtUsername.Text.Trim() + "'and MatKhau='" + txtPassword.Text.Trim() + "'", conn);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Nhập tên tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }
                else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy bỏ quá trình đăng nhập?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
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

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnOK_Click(sender, e);
        }

        
    }
}
