using System;
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
        public FormRegistration()
        {
            InitializeComponent();
            customerBLL = new CustomerBLL();
        }

        private enum EnumQuangCao
        {
            QC_ToBuom = 0,
            QC_Bang = 1,
            QC_Bao = 2
        }

        private bool[] isChecked = new bool[3];


        private void PhieuDangKy_Load(object sender, EventArgs e)
        {
            tabCtrlPhieuDangKy.SelectedIndex = 0;
            dgvKhachHang.DataSource = customerBLL.GetListCustomer();
            txtDiaChi.Text = txtHoTen.Text = txtNamSinh.Text = txtDiaChi.Text = txtEmail.Text = "";
            rbNam.Checked = true;
        }

        private bool KiemTraTab()
        {
            return true;
        }

        private void tabCtrlPhieuDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            KiemTraTab();
        }
        private bool KiemTraSoKyTuNhapVao(int max, string str)
        {
            if (str.Length <= max)
                return true;
            return false;
        }

        bool checkThemKH = false;
        bool checkThemDO = false;


        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh = "Nam";
            if (rbNu.Checked)
                gioiTinh = "Nữ";

            CustomerDTO customerDTO = new CustomerDTO(txtHoTen.Text, gioiTinh, Int32.Parse(txtNamSinh.Text.ToString()), txtDiaChi.Text, txtSDT.Text, txtEmail.Text);

            try
            {
                if (customerBLL.InsertCustomer(customerDTO))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    dgvKhachHang.DataSource = customerBLL.GetListCustomer();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
                }
            }
            catch
            {
            }
        }


        private void dataGrid_KH_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSua_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGrid_DiaOc_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemDiaOc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaDO_Click(object sender, EventArgs e)
        {
        }

        private void btnXoaDO_Click(object sender, EventArgs e)
        {
            
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

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDiaChiDO_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChiDO.Text.Trim() == "")
            {
                lblDiaChiDO.Text = "Vui lòng nhập địa chỉ";
                checkThemDO = false;
                return;
            }
            else
            {
                checkThemDO = true;
                lblDiaChiDO.Text = "";
            }

            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(200, txtDiaChiDO.Text))
            {
                lblDiaChiDO.Text = "Chỉ được nhập tối đa 200 kí tự!";
                checkThemDO = false;
                return;
            }
            else
            {
                checkThemDO = true;
                lblDiaChiDO.Text = "";
            }
        }

        private void txtDTKV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDTSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHuongNha_TextChanged(object sender, EventArgs e)
        {
            if (txtHuongNha.Text.Trim() == "")
            {
                checkThemDO = true;
                lblHuongNha.Text = "";
                return;
            }

            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(80, txtHuongNha.Text.Trim()))
            {
                lblHuongNha.Text = "Chỉ được nhập tối đa 100 kí tự!";
                checkThemDO = false;
                return;
            }
            else
            {
                checkThemDO = true;
                lblHuongNha.Text = "";
            }
        }

        private void txtViTri_TextChanged(object sender, EventArgs e)
        {
            if (txtViTri.Text.Trim() == "")
            {
                checkThemDO = true;
                lblViTri.Text = "";
                return;
            }

            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(50, txtViTri.Text.Trim()))
            {
                lblViTri.Text = "Chỉ được nhập tối đa 100 kí tự!";
                checkThemDO = false;
                return;
            }
            else
            {
                checkThemDO = true;
                lblViTri.Text = "";
            }
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {
            if (txtMoTa.Text.Trim() == "")
            {
                checkThemDO = true;
                lblMoTa.Text = "";
                return;
            }

            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(200, txtMoTa.Text.Trim()))
            {
                lblMoTa.Text = "Chỉ được nhập tối đa 100 kí tự!";
                checkThemDO = false;
                return;
            }
            else
            {
                checkThemDO = true;
                lblMoTa.Text = "";
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaBan.Text.Trim() == "")
            {
                checkThemDO = true;
                lblGiaBan.Text = "";
                return;
            }

            //kiem tra neu chuoi vuot qua ki tu cho phep
            if (!KiemTraSoKyTuNhapVao(25, txtGiaBan.Text.Trim()))
            {
                lblGiaBan.Text = "Chỉ được nhập tối đa 25 kí tự!";
                checkThemDO = false;
                return;
            }
            else
            {
                checkThemDO = true;
                lblGiaBan.Text = "";
            }

            Regex regex = new Regex(@"^[0-9.]+$");
            if (!regex.IsMatch(txtGiaBan.Text.Trim()))
            {
                lblGiaBan.Text = "Định dạng không hợp lệ";
                checkThemDO = false;
                return;
            }
            else
            {
                lblGiaBan.Text = "";
                checkThemDO = true;
            }
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void cbLoaiDiaOc_TextChanged(object sender, EventArgs e)
        {
            int find = cbLoaiDiaOc.FindString(cbLoaiDiaOc.Text);
            if (find != -1)
            {
                int len = cbLoaiDiaOc.Text.Length;
                cbLoaiDiaOc.SelectedIndex = find;
                cbLoaiDiaOc.Select(len, cbLoaiDiaOc.Text.Length);
            }
        }
    }
}
