﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiaOc.BusinesLogicLayers;
using QuanLyDiaOc.DataTransferObject;

namespace QuanLyDiaOc.PresentationLayers
{
    public partial class FormRegistration : Form
    {
        private CustomerBLL customerBLL;
        private RealEstateBLL realEstateBLL;
        private RealEstateTypeBLL RealEstateTypeBLL;
        private SettingBLL settingBLL;
        private string customerId;
        private string customerName;
        private bool checkInsertCustommer;
        private string realEstateId;
        private bool checkInsertRealEstate;
        private bool[] isChecked;

        public FormRegistration()
        {
            InitializeComponent();
            customerBLL = new CustomerBLL();
            realEstateBLL = new RealEstateBLL();
            RealEstateTypeBLL = new RealEstateTypeBLL();
            settingBLL = new SettingBLL();
            isChecked = new bool[3];
        }

        private enum EnumQuangCao
        {
            QC_ToBuom = 0,
            QC_Bang = 1,
            QC_Bao = 2
        }

        private void EmptyCustomer()
        {
            txtHoTen.Text = txtDiaChi.Text = txtNamSinh.Text = txtEmail.Text = txtSDT.Text = "";
            rbNam.Checked = true;
            customerId = "";
            customerName = "";
            checkInsertCustommer = false;
            lblHoTen.Text = lblDiaChi.Text = lblNamSinh.Text = lblEmail.Text = lblDT.Text = "";
            txtHoTen.Focus();
        }

        private bool CheckEmptyCustomer()
        {
            if (txtHoTen.Text.ToString() == "" || txtNamSinh.Text.ToString() == "" || txtDiaChi.Text.ToString() == "" || txtSDT.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private void EmptyRealEstate()
        {
            cbLoaiDiaOc.Text = txtDiaChiDO.Text = txtDTKV.Text = txtDTSD.Text = txtHuongNha.Text = txtViTri.Text = txtMoTa.Text = txtGiaBan.Text = txtTrangThai.Text = "";
            realEstateId = "";
            checkInsertRealEstate = false;
            rbYes.Checked = true;
            lblDiaChiDO.Text = lblDTKV.Text = lblDTSD.Text = lblHuongNha.Text = lblViTri.Text = lblMoTa.Text = lblGiaBan.Text = "";
        }

        private bool CheckEmptyRealEstater()
        {
            if (cbLoaiDiaOc.Text.ToString() == "" || txtDiaChiDO.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private void PhieuDangKy_Load(object sender, EventArgs e)
        {
            tabCtrlPhieuDangKy.SelectedIndex = 0;
            dgvKhachHang.DataSource = customerBLL.GetListCustomer();
            EmptyCustomer();

            int minAge = Int32.Parse(settingBLL.GetMinAge());
            int maxAge = Int32.Parse(settingBLL.GetMaxAge());
            for (int i = maxAge; i >= minAge; i--)
            {
                txtNamSinh.Items.Add(DateTime.Now.Year - i);
            }
        }

        private void tabCtrlPhieuDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlPhieuDangKy.SelectedIndex == 0)
                return;
            if (tabCtrlPhieuDangKy.SelectedIndex == 1)
            {
                if (customerId != "")
                {
                    dgvDiaOc.DataSource = realEstateBLL.GetListRealEstate(customerId);
                    lblMaKH.Text = "Mã KH: " + customerId;
                    lblTenKH.Text = "Họ tên: " + customerName;
                    cbLoaiDiaOc.DataSource = RealEstateTypeBLL.GetListRealEstateType();
                    cbLoaiDiaOc.DisplayMember = "TenLoaiDO";
                    cbLoaiDiaOc.ValueMember = "MaLoaiDO";
                    EmptyRealEstate();
                }
                else
                {
                    tabCtrlPhieuDangKy.SelectedIndex -= 1;
                    MessageBox.Show(this, "Vui lòng chọn khách hàng trước khi sang tab kế tiếp", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
        }
        private bool KiemTraSoKyTuNhapVao(int max, string str)
        {
            if (str.Length <= max)
                return true;
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckEmptyCustomer())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin khách hàng");
            }
            else
            {
                if (checkInsertCustommer)
                {
                    string gioiTinh = "Nam";
                    if (rbNu.Checked)
                        gioiTinh = "Nữ";

                    CustomerDTO customerDTO = new CustomerDTO(txtHoTen.Text, gioiTinh, Int32.Parse(txtNamSinh.Text.ToString()), txtDiaChi.Text, txtSDT.Text, txtEmail.Text);

                    try
                    {
                        if (customerBLL.InsertCustomer(customerDTO))
                        {
                            MessageBox.Show("Thêm khách hàng thành công");
                            dgvKhachHang.DataSource = customerBLL.GetListCustomer();
                        }
                        else
                        {
                            MessageBox.Show("Thêm khách hàng thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Làm ơn kiểm tra lại thông tin khách hàng");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (customerId == "")
            {
                MessageBox.Show("Làm ơn chọn khách hàng muốn xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin khác hàng " + customerId, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (customerBLL.DeleteCustomer(customerId))
                    {
                        MessageBox.Show("Xóa khách hàng thành công");
                        dgvKhachHang.DataSource = customerBLL.GetListCustomer();
                        EmptyCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (customerId == "")
            {
                MessageBox.Show("Làm ơn chọn khách hàng muốn sửa");
            }
            else
            {
                if (CheckEmptyCustomer())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin khách hàng");
                }
                else
                {
                    if (checkInsertCustommer)
                    {
                        string gioiTinh = "Nam";
                        if (rbNu.Checked)
                            gioiTinh = "Nữ";

                        CustomerDTO customerDTO = new CustomerDTO(customerId, txtHoTen.Text, gioiTinh, Int32.Parse(txtNamSinh.Text.ToString()), txtDiaChi.Text, txtSDT.Text, txtEmail.Text);

                        try
                        {
                            if (customerBLL.UpdateCustomer(customerDTO))
                            {
                                MessageBox.Show("Sửa khách hàng thành công");
                                dgvKhachHang.DataSource = customerBLL.GetListCustomer();
                                EmptyCustomer();
                            }
                            else
                            {
                                MessageBox.Show("Sửa khách hàng thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("Làm ơn kiểm tra lại thông tin khách hàng");
                    }
                }
            }
        }

        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = customerBLL.SearchCustomer(txtTimKiemKH.Text);
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^([\w.'-_?@áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ ]+)$");
            if (!reg.IsMatch(txtHoTen.Text))
            {
                lblHoTen.Text = "Tên không hợp lệ";
                checkInsertCustommer = false;
                return;
            }
            else
            {
                lblHoTen.Text = "";
                checkInsertCustommer = true;
            }
            if (!KiemTraSoKyTuNhapVao(100, txtHoTen.Text))
            {
                lblHoTen.Text = "Chỉ được nhập tối đa 100 kí tự!";
                checkInsertCustommer = false;
                return;
            }
            else
            {
                checkInsertCustommer = true;
                lblHoTen.Text = "";
            }
            if (txtHoTen.Text.Trim() == "")
            {
                lblHoTen.Text = "Vui lòng nhập họ tên";
                checkInsertCustommer = false;
                return;
            }
            else
            {
                checkInsertCustommer = true;
                lblHoTen.Text = "";
            }
        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[\d]{4}$");
            bool hight = false;
            bool low = false;
            if (txtNamSinh.Text != "")
            {
                hight = Int32.Parse(txtNamSinh.Text.ToString()) <= DateTime.Now.Year - 18;
                low = Int32.Parse(txtNamSinh.Text.ToString()) >= DateTime.Now.Year - 120;
            }

            if (!reg.IsMatch(txtNamSinh.Text) || !hight || !low)
            {
                lblNamSinh.Text = "Năm sinh không hợp lệ";
                checkInsertCustommer = false;
            }
            else
            {
                lblNamSinh.Text = "";
                checkInsertCustommer = true;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Trim() == "")
            {
                lblDiaChi.Text = "Vui lòng nhập địa chỉ";
                checkInsertCustommer = false;
                return;
            }
            else
            {
                checkInsertCustommer = true;
                lblDiaChi.Text = "";
            }

            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(200, txtDiaChi.Text))
            {
                lblDiaChi.Text = "Chỉ được nhập tối đa 200 kí tự!";
                checkInsertCustommer = false;
                return;
            }
            else
            {
                checkInsertCustommer = true;
                lblDiaChi.Text = "";
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[\d]{10,11}$");

            if (!reg.IsMatch(txtSDT.Text))
            {
                lblDT.Text = "Số điện thoại phải 10 hoặc 11 số";
                checkInsertCustommer = false;
            }
            else
            {
                lblDT.Text = "";
                checkInsertCustommer = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[\w._%+-]+@[a-z]+\.[a-z]{2,6}$");

            if (!reg.IsMatch(txtEmail.Text))
            {
                lblEmail.Text = "Email không đúng định dạng";
                checkInsertCustommer = false;
            }
            else
            {
                lblEmail.Text = "";
                checkInsertCustommer = true;
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvKhachHang.Rows[e.RowIndex];
                    customerId = row.Cells["MaKH"].Value.ToString();
                    customerName = row.Cells["TenKH"].Value.ToString();
                    txtHoTen.Text = row.Cells["TenKH"].Value.ToString();
                    String gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                    if (gioiTinh == "Nam")
                        rbNam.Checked = true;
                    else
                        rbNu.Checked = true;
                    txtNamSinh.Text = row.Cells["NamSinh"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    txtSDT.Text = row.Cells["SDT"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                }
                catch { }
            }
        }

        private void btnThemDiaOc_Click(object sender, EventArgs e)
        {
            if (CheckEmptyRealEstater())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin địa ốc");
            }
            else
            {
                if (checkInsertRealEstate)
                {
                    int hinhAnh = 0;
                    if (rbYes.Checked)
                    {
                        hinhAnh = 1;
                    }

                    RealEstateDTO realEstateDTO = new RealEstateDTO(customerId, cbLoaiDiaOc.SelectedValue.ToString(), txtDiaChiDO.Text.ToString(), Double.Parse(txtDTKV.Text.ToString()), Double.Parse(txtDTSD.Text.ToString()), txtHuongNha.Text.ToString(), txtViTri.Text.ToString(), txtMoTa.Text.ToString(), txtGiaBan.Text.ToString(), hinhAnh, txtTrangThai.Text.ToString());

                    try
                    {
                        if (realEstateBLL.InsertRealEstate(realEstateDTO))
                        {
                            MessageBox.Show("Thêm địa ốc thành công");
                            dgvDiaOc.DataSource = realEstateBLL.GetListRealEstate(customerId);
                        }
                        else
                        {
                            MessageBox.Show("Thêm địa ốc thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Làm ơn kiểm tra lại thông tin địa ốc");
                }
            }
        }

        private void btnSuaDO_Click(object sender, EventArgs e)
        {
            if (realEstateId == "")
            {
                MessageBox.Show("Làm ơn chọn địa ốc muốn sửa");
            }
            else
            {
                if (CheckEmptyRealEstater())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin địa ốc");
                }
                else
                {
                    if (checkInsertRealEstate)
                    {
                        int hinhAnh = 0;
                        if (rbYes.Checked)
                            hinhAnh = 1;

                        RealEstateDTO realEstateDTO = new RealEstateDTO(realEstateId, customerId, cbLoaiDiaOc.SelectedValue.ToString(), txtDiaChiDO.Text.ToString(), Double.Parse(txtDTKV.Text.ToString()), Double.Parse(txtDTSD.Text.ToString()), txtHuongNha.Text.ToString(), txtViTri.Text.ToString(), txtMoTa.Text.ToString(), txtGiaBan.Text.ToString(), hinhAnh, txtTrangThai.Text.ToString());

                        try
                        {
                            if (realEstateBLL.UpdateRealEstate(realEstateDTO))
                            {
                                MessageBox.Show("Sửa địa ốc thành công");
                                dgvDiaOc.DataSource = realEstateBLL.GetListRealEstate(customerId);
                                EmptyRealEstate();
                            }
                            else
                            {
                                MessageBox.Show("Sửa địc ốc thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("Làm ơn kiểm tra lại thông tin khách hàng");
                    }
                }
            }
        }

        private void btnXoaDO_Click(object sender, EventArgs e)
        {
            if (realEstateId == "")
            {
                MessageBox.Show("Làm ơn chọn địa ốc muốn xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin địa ốc " + realEstateId, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (realEstateBLL.DeleteRealEstate(realEstateId))
                    {
                        MessageBox.Show("Xóa địa ốc thành công");
                        dgvDiaOc.DataSource = realEstateBLL.GetListRealEstate(customerId);
                        EmptyRealEstate();
                    }
                    else
                    {
                        MessageBox.Show("Xóa địa ốc thất bại");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void txtDiaChiDO_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChiDO.Text.Trim() == "")
            {
                lblDiaChiDO.Text = "Vui lòng nhập địa chỉ";
                checkInsertRealEstate = false;
                return;
            }
            else
            {
                checkInsertRealEstate = true;
                lblDiaChiDO.Text = "";
            }

            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(200, txtDiaChiDO.Text))
            {
                lblDiaChiDO.Text = "Chỉ được nhập tối đa 200 kí tự!";
                checkInsertRealEstate = false;
                return;
            }
            else
            {
                checkInsertRealEstate = true;
                lblDiaChiDO.Text = "";
            }
        }

        private void cbLoaiDiaOc_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Vui lòng chọn giá trị ở mũi tên bên cạnh");
            e.Handled = true;
        }

        private void DTKV_DTSD_Tex(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(txtDTKV.Text) < float.Parse(txtDTSD.Text))
                {
                    MessageBox.Show("Diện tích sử dụng phải nhỏ hơn hoặc bằng diện tích khuôn viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDTSD.Text = txtDTKV.Text;
                }
            }
            catch
            {

            }
        }

        private void txtHuongNha_TextChanged(object sender, EventArgs e)
        {
            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(80, txtHuongNha.Text.Trim()))
            {
                lblHuongNha.Text = "Chỉ được nhập tối đa 100 kí tự!";
                checkInsertRealEstate = false;
                return;
            }
            else
            {
                checkInsertRealEstate = true;
                lblHuongNha.Text = "";
            }
        }

        private void txtViTri_TextChanged(object sender, EventArgs e)
        {
            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(50, txtViTri.Text.Trim()))
            {
                lblViTri.Text = "Chỉ được nhập tối đa 100 kí tự!";
                checkInsertRealEstate = false;
                return;
            }
            else
            {
                checkInsertRealEstate = true;
                lblViTri.Text = "";
            }
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {
            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(200, txtMoTa.Text.Trim()))
            {
                lblMoTa.Text = "Chỉ được nhập tối đa 100 kí tự!";
                checkInsertRealEstate = false;
                return;
            }
            else
            {
                checkInsertRealEstate = true;
                lblMoTa.Text = "";
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(25, txtGiaBan.Text.Trim()))
            {
                lblGiaBan.Text = "Chỉ được nhập tối đa 25 kí tự!";
                checkInsertRealEstate = false;
                return;
            }
            else
            {
                checkInsertRealEstate = true;
                lblGiaBan.Text = "";
            }

            Regex regex = new Regex(@"^[0-9.]+$");
            if (!regex.IsMatch(txtGiaBan.Text.Trim()))
            {
                lblGiaBan.Text = "Định dạng không hợp lệ";
                checkInsertRealEstate = false;
                return;
            }
            else
            {
                lblGiaBan.Text = "";
                checkInsertRealEstate = true;
            }
        }

        private void dgvDiaOc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvDiaOc.Rows[e.RowIndex];
                    realEstateId = row.Cells["MaDO"].Value.ToString();
                    cbLoaiDiaOc.Text = row.Cells["LoaiDiaOc"].Value.ToString();
                    txtDiaChiDO.Text = row.Cells["DiaChiDO"].Value.ToString();
                    txtDTKV.Text = row.Cells["DienTichKhuonVien"].Value.ToString();
                    txtDTSD.Text = row.Cells["DienTichSuDung"].Value.ToString();
                    txtHuongNha.Text = row.Cells["HuongNha"].Value.ToString();
                    txtViTri.Text = row.Cells["ViTri"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTaChiTiet"].Value.ToString();
                    txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                    bool isImage = Boolean.Parse(row.Cells["HinhAnh"].Value.ToString());
                    if (!isImage)
                    {
                        rbNo.Checked = true;
                    }
                    else
                    {
                        rbYes.Checked = true;
                    }
                    txtTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
                }
                catch { }
            }
        }

        private void ckbQCToBuom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbQCToBuom.Checked)
                cbSoTo.Enabled = true;
            else
                cbSoTo.Enabled = false;
        }

        private void ckbQCTrenBao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbQCTrenBao.Checked)
            {
                cbViTri.Enabled = true;
                cbLoaiBao.Enabled = true;
                ckbHinhAnhBao.Enabled = true;
                ckbMauSac.Enabled = true;
                dtNgayQC.Enabled = true;
            }
            else
            {
                cbViTri.Enabled = false;
                cbLoaiBao.Enabled = false;
                ckbHinhAnhBao.Enabled = false;
                ckbMauSac.Enabled = false;
                dtNgayQC.Enabled = false;
            }
        }

        private void ckbQCTrenBang_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbQCTrenBang.Checked)
            {
                rdbBangChieuDien.Enabled = true;
                rdbBangThuong.Enabled = true;
                cbKichCo.Enabled = true;
                ckbHinhAnh.Enabled = true;
            }
            else
            {
                rdbBangChieuDien.Enabled = false;
                rdbBangThuong.Enabled = false;
                cbKichCo.Enabled = false;
                ckbHinhAnh.Enabled = false;
            }

        }

        private void btnLuuDVu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn chắc chắn muốn hủy bỏ đăng kí", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAll.Checked)
            {
                ckbGPXD.Checked = true;
                ckbCNQSDD.Checked = true;
                ckbCNSHN.Checked = true;
                ckbGPHC.Checked = true;
                ckbHDMB.Checked = true;
            }
            else
            {
                ckbGPXD.Checked = false;
                ckbCNQSDD.Checked = false;
                ckbCNSHN.Checked = false;
                ckbGPHC.Checked = false;
                ckbHDMB.Checked = false;
            }
        }

        private void ChiChoNhapSo(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != 127)
                e.Handled = true;

            if ((t.Text.Contains(".") || t.Text.Length == 0) && e.KeyChar == '.')
                e.Handled = true;
        }

        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void KhongNhapSo(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private void ChiChoNhapSoN(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void ChiNhapSo_Cmb(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Vui lòng chọn giá trị ở mũi tên bên cạnh");
            e.Handled = true;
        }
    }
}
