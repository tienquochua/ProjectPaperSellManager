namespace ProjectPaperSellManager
{
    partial class FrmMatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDL = new System.Windows.Forms.TextBox();
            this.txtKT = new System.Windows.Forms.TextBox();
            this.txtDGBan = new System.Windows.Forms.TextBox();
            this.txtDGNhap = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnXoaTxtBox = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(51, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1137, 27);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 59);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1137, 100);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 59);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1137, 171);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(160, 59);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lí mặt hàng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(1137, 118);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(160, 59);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(685, 107);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(192, 22);
            this.txtSL.TabIndex = 27;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // txtDL
            // 
            this.txtDL.Location = new System.Drawing.Point(685, 69);
            this.txtDL.Margin = new System.Windows.Forms.Padding(4);
            this.txtDL.Name = "txtDL";
            this.txtDL.Size = new System.Drawing.Size(192, 22);
            this.txtDL.TabIndex = 26;
            this.txtDL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDL_KeyPress);
            // 
            // txtKT
            // 
            this.txtKT.Location = new System.Drawing.Point(685, 34);
            this.txtKT.Margin = new System.Windows.Forms.Padding(4);
            this.txtKT.Name = "txtKT";
            this.txtKT.Size = new System.Drawing.Size(192, 22);
            this.txtKT.TabIndex = 25;
            this.txtKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKT_KeyPress);
            // 
            // txtDGBan
            // 
            this.txtDGBan.Location = new System.Drawing.Point(212, 132);
            this.txtDGBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDGBan.Name = "txtDGBan";
            this.txtDGBan.Size = new System.Drawing.Size(192, 22);
            this.txtDGBan.TabIndex = 24;
            this.txtDGBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDGBan_KeyPress);
            // 
            // txtDGNhap
            // 
            this.txtDGNhap.Location = new System.Drawing.Point(212, 102);
            this.txtDGNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDGNhap.Name = "txtDGNhap";
            this.txtDGNhap.Size = new System.Drawing.Size(192, 22);
            this.txtDGNhap.TabIndex = 23;
            this.txtDGNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDGNhap_KeyPress);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(212, 64);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(192, 22);
            this.txtTenHang.TabIndex = 22;
            this.txtTenHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenHang_KeyPress);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(212, 31);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(192, 22);
            this.txtMaHang.TabIndex = 21;
            this.txtMaHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHang_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Định lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kích thước(cm):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Đơn giá bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Đơn giá nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbTimKiem);
            this.groupBox1.Controls.Add(this.btnXoaTxtBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDGBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDGNhap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Location = new System.Drawing.Point(36, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1329, 238);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tìm kiếm mặt hàng";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Location = new System.Drawing.Point(449, 188);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(301, 24);
            this.cbbTimKiem.TabIndex = 31;
            this.cbbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbbTimKiem_SelectedIndexChanged);
            // 
            // btnXoaTxtBox
            // 
            this.btnXoaTxtBox.Location = new System.Drawing.Point(953, 27);
            this.btnXoaTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTxtBox.Name = "btnXoaTxtBox";
            this.btnXoaTxtBox.Size = new System.Drawing.Size(160, 59);
            this.btnXoaTxtBox.TabIndex = 28;
            this.btnXoaTxtBox.Text = "Tạo mới";
            this.btnXoaTxtBox.UseVisualStyleBackColor = true;
            this.btnXoaTxtBox.Click += new System.EventHandler(this.btnXoaTxtBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Location = new System.Drawing.Point(36, 319);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1329, 331);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // FrmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 670);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMatHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMatHang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMatHang_FormClosed);
            this.Load += new System.EventHandler(this.FrmMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDL;
        private System.Windows.Forms.TextBox txtKT;
        private System.Windows.Forms.TextBox txtDGBan;
        private System.Windows.Forms.TextBox txtDGNhap;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbTimKiem;
    }
}