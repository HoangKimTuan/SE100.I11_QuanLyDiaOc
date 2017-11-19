namespace QuanLyDiaOc.PresentationLayers
{
    partial class FormSetting
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
            this.dataGridTaiKhoan = new System.Windows.Forms.DataGridView();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LuuMK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.Label();
            this.btn_ThemTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.tabPage_ThemTK = new System.Windows.Forms.TabPage();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageThayDoiMK = new System.Windows.Forms.TabPage();
            this.btnLuu_ThamSo = new System.Windows.Forms.Button();
            this.txtSoTu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTienGH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSoTuoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl_CaiDat = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaiKhoan)).BeginInit();
            this.tabPage_ThemTK.SuspendLayout();
            this.tabPageThayDoiMK.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl_CaiDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridTaiKhoan
            // 
            this.dataGridTaiKhoan.AllowUserToAddRows = false;
            this.dataGridTaiKhoan.AllowUserToDeleteRows = false;
            this.dataGridTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTK,
            this.ChucVu});
            this.dataGridTaiKhoan.Location = new System.Drawing.Point(24, 110);
            this.dataGridTaiKhoan.Name = "dataGridTaiKhoan";
            this.dataGridTaiKhoan.ReadOnly = true;
            this.dataGridTaiKhoan.Size = new System.Drawing.Size(258, 101);
            this.dataGridTaiKhoan.TabIndex = 28;
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TENNGUOIDUNG";
            this.TenTK.HeaderText = "Tên đăng nhập";
            this.TenTK.Name = "TenTK";
            this.TenTK.ReadOnly = true;
            this.TenTK.Width = 115;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "CAP";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(383, 32);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(121, 21);
            this.cbChucVu.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Chức vụ";
            // 
            // btn_LuuMK
            // 
            this.btn_LuuMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LuuMK.Location = new System.Drawing.Point(210, 157);
            this.btn_LuuMK.Name = "btn_LuuMK";
            this.btn_LuuMK.Size = new System.Drawing.Size(119, 28);
            this.btn_LuuMK.TabIndex = 21;
            this.btn_LuuMK.Text = "Lưu thay đổi ";
            this.btn_LuuMK.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(95, 32);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(187, 22);
            this.txtTaiKhoan.TabIndex = 22;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(95, 73);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(187, 22);
            this.txtMatKhau.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Xác nhận mật khẩu mới";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMK.Location = new System.Drawing.Point(259, 107);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PasswordChar = '*';
            this.txtXacNhanMK.Size = new System.Drawing.Size(187, 22);
            this.txtXacNhanMK.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tài khoản";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(259, 31);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(187, 22);
            this.txtUser.TabIndex = 5;
            // 
            // txtMK
            // 
            this.txtMK.AutoSize = true;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(21, 75);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(62, 16);
            this.txtMK.TabIndex = 24;
            this.txtMK.Text = "Mật khẩu";
            // 
            // btn_ThemTK
            // 
            this.btn_ThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemTK.Location = new System.Drawing.Point(413, 196);
            this.btn_ThemTK.Name = "btn_ThemTK";
            this.btn_ThemTK.Size = new System.Drawing.Size(131, 28);
            this.btn_ThemTK.TabIndex = 21;
            this.btn_ThemTK.Text = "Thêm tài khoản";
            this.btn_ThemTK.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(475, 316);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 28);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoi.Location = new System.Drawing.Point(259, 67);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(187, 22);
            this.txtMKMoi.TabIndex = 6;
            // 
            // tabPage_ThemTK
            // 
            this.tabPage_ThemTK.Controls.Add(this.btnXoaTK);
            this.tabPage_ThemTK.Controls.Add(this.dataGridTaiKhoan);
            this.tabPage_ThemTK.Controls.Add(this.cbChucVu);
            this.tabPage_ThemTK.Controls.Add(this.label3);
            this.tabPage_ThemTK.Controls.Add(this.txtMK);
            this.tabPage_ThemTK.Controls.Add(this.label7);
            this.tabPage_ThemTK.Controls.Add(this.txtTaiKhoan);
            this.tabPage_ThemTK.Controls.Add(this.txtMatKhau);
            this.tabPage_ThemTK.Controls.Add(this.btn_ThemTK);
            this.tabPage_ThemTK.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ThemTK.Name = "tabPage_ThemTK";
            this.tabPage_ThemTK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThemTK.Size = new System.Drawing.Size(550, 230);
            this.tabPage_ThemTK.TabIndex = 2;
            this.tabPage_ThemTK.Text = "Thêm tài khoản";
            this.tabPage_ThemTK.UseVisualStyleBackColor = true;
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaTK.Location = new System.Drawing.Point(288, 196);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(119, 28);
            this.btnXoaTK.TabIndex = 29;
            this.btnXoaTK.Text = "Xóa tài khoản";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 31);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cài đặt hệ thống";
            // 
            // tabPageThayDoiMK
            // 
            this.tabPageThayDoiMK.Controls.Add(this.btn_LuuMK);
            this.tabPageThayDoiMK.Controls.Add(this.label2);
            this.tabPageThayDoiMK.Controls.Add(this.txtXacNhanMK);
            this.tabPageThayDoiMK.Controls.Add(this.label5);
            this.tabPageThayDoiMK.Controls.Add(this.label4);
            this.tabPageThayDoiMK.Controls.Add(this.txtUser);
            this.tabPageThayDoiMK.Controls.Add(this.txtMKMoi);
            this.tabPageThayDoiMK.Location = new System.Drawing.Point(4, 22);
            this.tabPageThayDoiMK.Name = "tabPageThayDoiMK";
            this.tabPageThayDoiMK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThayDoiMK.Size = new System.Drawing.Size(550, 230);
            this.tabPageThayDoiMK.TabIndex = 1;
            this.tabPageThayDoiMK.Text = "Thay đổi mật khẩu";
            this.tabPageThayDoiMK.UseVisualStyleBackColor = true;
            // 
            // btnLuu_ThamSo
            // 
            this.btnLuu_ThamSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu_ThamSo.Location = new System.Drawing.Point(210, 158);
            this.btnLuu_ThamSo.Name = "btnLuu_ThamSo";
            this.btnLuu_ThamSo.Size = new System.Drawing.Size(119, 28);
            this.btnLuu_ThamSo.TabIndex = 22;
            this.btnLuu_ThamSo.Text = "Lưu thay đổi ";
            this.btnLuu_ThamSo.UseVisualStyleBackColor = true;
            this.btnLuu_ThamSo.Click += new System.EventHandler(this.btnLuu_ThamSo_Click);
            // 
            // txtSoTu
            // 
            this.txtSoTu.Location = new System.Drawing.Point(375, 75);
            this.txtSoTu.Name = "txtSoTu";
            this.txtSoTu.Size = new System.Drawing.Size(115, 20);
            this.txtSoTu.TabIndex = 14;
            this.txtSoTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapSo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số từ tối đa trong mô tả thông tin quảng cáo báo:";
            // 
            // txtSoTienGH
            // 
            this.txtSoTienGH.Location = new System.Drawing.Point(375, 31);
            this.txtSoTienGH.Name = "txtSoTienGH";
            this.txtSoTienGH.Size = new System.Drawing.Size(115, 20);
            this.txtSoTienGH.TabIndex = 12;
            this.txtSoTienGH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienGH_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Số tiền phải trả khi gia hạn (%): ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSoTuoi);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnLuu_ThamSo);
            this.tabPage1.Controls.Add(this.txtSoTu);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSoTienGH);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thay đổi các tham số";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSoTuoi
            // 
            this.txtSoTuoi.Location = new System.Drawing.Point(375, 120);
            this.txtSoTuoi.Name = "txtSoTuoi";
            this.txtSoTuoi.Size = new System.Drawing.Size(115, 20);
            this.txtSoTuoi.TabIndex = 20;
            this.txtSoTuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapSo);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Số tuổi tối thiểu";
            // 
            // tabControl_CaiDat
            // 
            this.tabControl_CaiDat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl_CaiDat.Controls.Add(this.tabPage1);
            this.tabControl_CaiDat.Controls.Add(this.tabPageThayDoiMK);
            this.tabControl_CaiDat.Controls.Add(this.tabPage_ThemTK);
            this.tabControl_CaiDat.Location = new System.Drawing.Point(13, 54);
            this.tabControl_CaiDat.Name = "tabControl_CaiDat";
            this.tabControl_CaiDat.SelectedIndex = 0;
            this.tabControl_CaiDat.Size = new System.Drawing.Size(558, 256);
            this.tabControl_CaiDat.TabIndex = 36;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 348);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl_CaiDat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaiKhoan)).EndInit();
            this.tabPage_ThemTK.ResumeLayout(false);
            this.tabPage_ThemTK.PerformLayout();
            this.tabPageThayDoiMK.ResumeLayout(false);
            this.tabPageThayDoiMK.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl_CaiDat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_LuuMK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label txtMK;
        private System.Windows.Forms.Button btn_ThemTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TabPage tabPage_ThemTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageThayDoiMK;
        private System.Windows.Forms.Button btnLuu_ThamSo;
        private System.Windows.Forms.TextBox txtSoTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTienGH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl_CaiDat;
        private System.Windows.Forms.TextBox txtSoTuoi;
        private System.Windows.Forms.Label label8;
    }
}