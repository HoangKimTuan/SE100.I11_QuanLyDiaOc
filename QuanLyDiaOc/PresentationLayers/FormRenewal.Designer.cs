using System;
using System.Windows.Forms;

namespace QuanLyDiaOc.PresentationLayers
{
    partial class FormRenewal
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridChiTiet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTienGiaHan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbTrangThai = new System.Windows.Forms.CheckBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaDO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHuongNha = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbLoaiDiaOc = new System.Windows.Forms.ComboBox();
            this.txtDTSD = new System.Windows.Forms.TextBox();
            this.txtDTKV = new System.Windows.Forms.TextBox();
            this.txtDiaChiDO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gbthongtinkhachhang = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lDienthoai = new System.Windows.Forms.Label();
            this.lDiachi = new System.Windows.Forms.Label();
            this.lHoten = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridDangKy = new System.Windows.Forms.DataGridView();
            this.MaDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiaOc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgàyKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanGiaHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChiTiet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbthongtinkhachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.dataGridChiTiet);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(608, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 124);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phiếu thu";
            // 
            // dataGridChiTiet
            // 
            this.dataGridChiTiet.AllowUserToAddRows = false;
            this.dataGridChiTiet.AllowUserToDeleteRows = false;
            this.dataGridChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridChiTiet.Location = new System.Drawing.Point(63, 21);
            this.dataGridChiTiet.Name = "dataGridChiTiet";
            this.dataGridChiTiet.ReadOnly = true;
            this.dataGridChiTiet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridChiTiet.RowHeadersVisible = false;
            this.dataGridChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridChiTiet.Size = new System.Drawing.Size(346, 97);
            this.dataGridChiTiet.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nội dung";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Đơn giá";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thành tiền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txtTienGiaHan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(211, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 124);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán";
            // 
            // txtTienGiaHan
            // 
            this.txtTienGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienGiaHan.Location = new System.Drawing.Point(256, 71);
            this.txtTienGiaHan.Name = "txtTienGiaHan";
            this.txtTienGiaHan.ReadOnly = true;
            this.txtTienGiaHan.Size = new System.Drawing.Size(121, 22);
            this.txtTienGiaHan.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Số tiền phải trả sau khi gia hạn (VNĐ): ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(256, 27);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(121, 22);
            this.txtTongTien.TabIndex = 31;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(6, 27);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(228, 16);
            this.label34.TabIndex = 30;
            this.label34.Text = "Số tiền đã thanh toán trước đó (VNĐ): ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.ckbTrangThai);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtViTri);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtMaDO);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtHuongNha);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cbLoaiDiaOc);
            this.groupBox1.Controls.Add(this.txtDTSD);
            this.groupBox1.Controls.Add(this.txtDTKV);
            this.groupBox1.Controls.Add(this.txtDiaChiDO);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(522, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 214);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin địa ốc";
            // 
            // ckbTrangThai
            // 
            this.ckbTrangThai.AutoSize = true;
            this.ckbTrangThai.Location = new System.Drawing.Point(354, 23);
            this.ckbTrangThai.Name = "ckbTrangThai";
            this.ckbTrangThai.Size = new System.Drawing.Size(74, 22);
            this.ckbTrangThai.TabIndex = 24;
            this.ckbTrangThai.Text = "Đã bán";
            this.ckbTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(354, 131);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(153, 24);
            this.txtMoTa.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(271, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 18);
            this.label22.TabIndex = 22;
            this.label22.Text = "Mô tả:";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(86, 131);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.ReadOnly = true;
            this.txtViTri.Size = new System.Drawing.Size(167, 24);
            this.txtViTri.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 18);
            this.label21.TabIndex = 20;
            this.label21.Text = "Vị trí: ";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(86, 96);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.ReadOnly = true;
            this.txtGiaTien.Size = new System.Drawing.Size(167, 24);
            this.txtGiaTien.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 18);
            this.label15.TabIndex = 18;
            this.label15.Text = "Giá bán: ";
            // 
            // txtMaDO
            // 
            this.txtMaDO.Location = new System.Drawing.Point(86, 28);
            this.txtMaDO.Name = "txtMaDO";
            this.txtMaDO.ReadOnly = true;
            this.txtMaDO.Size = new System.Drawing.Size(167, 24);
            this.txtMaDO.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mã: ";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(110, 336);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(195, 24);
            this.txtGiaBan.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "Giá bán: ";
            // 
            // txtHuongNha
            // 
            this.txtHuongNha.Location = new System.Drawing.Point(354, 92);
            this.txtHuongNha.Name = "txtHuongNha";
            this.txtHuongNha.ReadOnly = true;
            this.txtHuongNha.Size = new System.Drawing.Size(153, 24);
            this.txtHuongNha.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(271, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "Hướng nhà: ";
            // 
            // cbLoaiDiaOc
            // 
            this.cbLoaiDiaOc.FormattingEnabled = true;
            this.cbLoaiDiaOc.Location = new System.Drawing.Point(354, 55);
            this.cbLoaiDiaOc.Name = "cbLoaiDiaOc";
            this.cbLoaiDiaOc.Size = new System.Drawing.Size(153, 26);
            this.cbLoaiDiaOc.TabIndex = 9;
            // 
            // txtDTSD
            // 
            this.txtDTSD.Location = new System.Drawing.Point(145, 170);
            this.txtDTSD.Name = "txtDTSD";
            this.txtDTSD.ReadOnly = true;
            this.txtDTSD.Size = new System.Drawing.Size(108, 24);
            this.txtDTSD.TabIndex = 8;
            // 
            // txtDTKV
            // 
            this.txtDTKV.Location = new System.Drawing.Point(413, 170);
            this.txtDTKV.Name = "txtDTKV";
            this.txtDTKV.ReadOnly = true;
            this.txtDTKV.Size = new System.Drawing.Size(94, 24);
            this.txtDTKV.TabIndex = 7;
            // 
            // txtDiaChiDO
            // 
            this.txtDiaChiDO.Location = new System.Drawing.Point(86, 60);
            this.txtDiaChiDO.Name = "txtDiaChiDO";
            this.txtDiaChiDO.ReadOnly = true;
            this.txtDiaChiDO.Size = new System.Drawing.Size(167, 24);
            this.txtDiaChiDO.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 18);
            this.label17.TabIndex = 7;
            this.label17.Text = "Diện tích sử dụng: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(271, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 18);
            this.label18.TabIndex = 6;
            this.label18.Text = "Diện tích khuôn viên: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 18);
            this.label19.TabIndex = 3;
            this.label19.Text = "Địa chỉ:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(271, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "Loại địa ốc: ";
            // 
            // gbthongtinkhachhang
            // 
            this.gbthongtinkhachhang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbthongtinkhachhang.Controls.Add(this.txtMaKH);
            this.gbthongtinkhachhang.Controls.Add(this.label10);
            this.gbthongtinkhachhang.Controls.Add(this.txtEmail);
            this.gbthongtinkhachhang.Controls.Add(this.txtSDT);
            this.gbthongtinkhachhang.Controls.Add(this.txtDiaChiKH);
            this.gbthongtinkhachhang.Controls.Add(this.txtHoTen);
            this.gbthongtinkhachhang.Controls.Add(this.lEmail);
            this.gbthongtinkhachhang.Controls.Add(this.lDienthoai);
            this.gbthongtinkhachhang.Controls.Add(this.lDiachi);
            this.gbthongtinkhachhang.Controls.Add(this.lHoten);
            this.gbthongtinkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbthongtinkhachhang.Location = new System.Drawing.Point(211, 233);
            this.gbthongtinkhachhang.Name = "gbthongtinkhachhang";
            this.gbthongtinkhachhang.Size = new System.Drawing.Size(293, 214);
            this.gbthongtinkhachhang.TabIndex = 22;
            this.gbthongtinkhachhang.TabStop = false;
            this.gbthongtinkhachhang.Text = "Thông tin khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(85, 23);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(175, 24);
            this.txtMaKH.TabIndex = 10;
            this.txtMaKH.Tag = "Mã khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mã: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(175, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(85, 137);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(175, 24);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(85, 96);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.ReadOnly = true;
            this.txtDiaChiKH.Size = new System.Drawing.Size(175, 24);
            this.txtDiaChiKH.TabIndex = 6;
            this.txtDiaChiKH.Tag = "Địa chỉ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(85, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(175, 24);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Tag = "Tên khách hàng";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(8, 182);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(53, 18);
            this.lEmail.TabIndex = 7;
            this.lEmail.Text = "Email :";
            // 
            // lDienthoai
            // 
            this.lDienthoai.AutoSize = true;
            this.lDienthoai.Location = new System.Drawing.Point(8, 143);
            this.lDienthoai.Name = "lDienthoai";
            this.lDienthoai.Size = new System.Drawing.Size(78, 18);
            this.lDienthoai.TabIndex = 6;
            this.lDienthoai.Text = "Điện thoại:";
            // 
            // lDiachi
            // 
            this.lDiachi.AutoSize = true;
            this.lDiachi.Location = new System.Drawing.Point(8, 99);
            this.lDiachi.Name = "lDiachi";
            this.lDiachi.Size = new System.Drawing.Size(57, 18);
            this.lDiachi.TabIndex = 3;
            this.lDiachi.Text = "Địa chỉ:";
            // 
            // lHoten
            // 
            this.lHoten.AutoSize = true;
            this.lHoten.Location = new System.Drawing.Point(9, 66);
            this.lHoten.Name = "lHoten";
            this.lHoten.Size = new System.Drawing.Size(56, 18);
            this.lHoten.TabIndex = 0;
            this.lHoten.Text = "Họ tên:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phiếu gia hạn dịch vụ";
            // 
            // dataGridDangKy
            // 
            this.dataGridDangKy.AllowUserToAddRows = false;
            this.dataGridDangKy.AllowUserToDeleteRows = false;
            this.dataGridDangKy.AllowUserToResizeRows = false;
            this.dataGridDangKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridDangKy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridDangKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDangKy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridDangKy.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridDangKy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDK,
            this.MaKH,
            this.MaDiaOc,
            this.NgayDangKy,
            this.NgàyKetThuc,
            this.SoLanGiaHan});
            this.dataGridDangKy.EnableHeadersVisualStyles = false;
            this.dataGridDangKy.Location = new System.Drawing.Point(211, 59);
            this.dataGridDangKy.MultiSelect = false;
            this.dataGridDangKy.Name = "dataGridDangKy";
            this.dataGridDangKy.ReadOnly = true;
            this.dataGridDangKy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridDangKy.RowHeadersVisible = false;
            this.dataGridDangKy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDangKy.Size = new System.Drawing.Size(824, 159);
            this.dataGridDangKy.TabIndex = 27;
     //       this.dataGridDangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDangKy_CellContentClick);
   //         this.dataGridDangKy.SelectionChanged += new System.EventHandler(this.dataGridDangKy_SelectionChanged);
            // 
            // MaDK
            // 
            this.MaDK.DataPropertyName = "MADANGKY";
            this.MaDK.HeaderText = "Mã đăng ký";
            this.MaDK.Name = "MaDK";
            this.MaDK.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MAKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // MaDiaOc
            // 
            this.MaDiaOc.DataPropertyName = "MADIAOC";
            this.MaDiaOc.HeaderText = "Mã địa ốc";
            this.MaDiaOc.Name = "MaDiaOc";
            this.MaDiaOc.ReadOnly = true;
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.DataPropertyName = "NGAYDANGKY";
            this.NgayDangKy.HeaderText = "Ngày đăng ký";
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.ReadOnly = true;
            // 
            // NgàyKetThuc
            // 
            this.NgàyKetThuc.DataPropertyName = "NGAYKETTHUC";
            this.NgàyKetThuc.HeaderText = "Ngày kết thúc";
            this.NgàyKetThuc.Name = "NgàyKetThuc";
            this.NgàyKetThuc.ReadOnly = true;
            // 
            // SoLanGiaHan
            // 
            this.SoLanGiaHan.DataPropertyName = "SO_LAN_GIA_HAN";
            this.SoLanGiaHan.HeaderText = "Số lần gia hạn";
            this.SoLanGiaHan.Name = "SoLanGiaHan";
            this.SoLanGiaHan.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1119, 636);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 28);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
  //          this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaHan.Location = new System.Drawing.Point(972, 636);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(92, 28);
            this.btnGiaHan.TabIndex = 29;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
 //           this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // FormRenewal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 670);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridDangKy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbthongtinkhachhang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRenewal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gia hạn";
            this.Load += new System.EventHandler(this.FormRenewal_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChiTiet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbthongtinkhachhang.ResumeLayout(false);
            this.gbthongtinkhachhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridChiTiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbTrangThai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaDO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHuongNha;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbLoaiDiaOc;
        private System.Windows.Forms.TextBox txtDTSD;
        private System.Windows.Forms.TextBox txtDTKV;
        private System.Windows.Forms.TextBox txtDiaChiDO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox gbthongtinkhachhang;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lDienthoai;
        private System.Windows.Forms.Label lDiachi;
        private System.Windows.Forms.Label lHoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTienGiaHan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiaOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgàyKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanGiaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}