using QuanLyDiaOc.BusinesLogicLayers;
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

namespace QuanLyDiaOc.PresentationLayers
{
    public partial class FormSearch : Form
    {
        private CustomerBLL customerBLL;
        private RealEstateBLL realEstateBLL;
        private String customerId;
        private DataView dtViewKH;
        private DataGridViewRow dtgridDO;
        private DocumentBLL documentBLL;
        private DataTable dtDangKy;
        private RegistrationBLL registrationBLL;
        private FlyersBLL flyersBLL;
        private DataTable dtBuom;
        private DataTable dtBang;
        private DataTable dtBao;

        private void Empty()
        {
            customerId = "";
        }
        public FormSearch()
        {
            InitializeComponent();
            customerBLL = new CustomerBLL();
            realEstateBLL = new RealEstateBLL();
            dtViewKH = new DataView();
            dtgridDO = new DataGridViewRow();
            documentBLL = new DocumentBLL();
            dtDangKy = new DataTable();
            registrationBLL = new RegistrationBLL();
            flyersBLL = new FlyersBLL();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            dtViewKH = customerBLL.GetListCustomer().DefaultView;
            dgvKhachHang.DataSource = dtViewKH;
            dgvKhachHang.Columns["Email"].Visible = false;
            dgvKhachHang.Columns["SDT"].Visible = false;
            dgvKhachHang.Columns["NamSinh"].Visible = false;
            dgvKhachHang.Columns["GioiTinh"].Visible = false;
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageKHvsDO;
            enableInputKH(false);
            enableInputDO(false);
            setNullInputDO();
            setNullInputQC();

            if (dgvKhachHang.SelectedRows.Count <= 0)
            {
                return;
            }
            try
            {
                int i = -1;
                i = dgvKhachHang.CurrentRow.Index;
                customerId = dgvKhachHang.Rows[i].Cells["MaKH"].Value.ToString();
                txtMakh.Text = customerId;
                //customerName = dgvKhachHang.Rows[i].Cells["TenKH"].Value.ToString();
                txtHoTen.Text = dgvKhachHang.Rows[i].Cells["TenKH"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[i].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[i].Cells["SDT"].Value.ToString();
                txtEmail.Text = dgvKhachHang.Rows[i].Cells["Email"].Value.ToString();
                if (customerId != null)
                {
                    dgvDiaOc.DataSource = realEstateBLL.GetListRealEstate(customerId);
                    HideColumnDiaOc();
                }
            }
            catch { }
        }

        private void HideColumnDiaOc()
        {
            dgvDiaOc.Columns["TenLoaiDO"].Visible = false;
            dgvDiaOc.Columns["DienTichSuDung"].Visible = false;
            dgvDiaOc.Columns["HuongNha"].Visible = false;
            dgvDiaOc.Columns["ViTri"].Visible = false;
            dgvDiaOc.Columns["MoTaChiTiet"].Visible = false;
            dgvDiaOc.Columns["TrangThai"].Visible = false;
        }

        private void enableInputKH(Boolean status)
        {
            txtHoTen.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = txtEmail.Enabled = btnCapNhat_KH.Enabled = status;
        }
        private void enableInputDO(Boolean status)
        {
             dataGridBao.Enabled = btnCapNhat_DO.Enabled = cbLoaiDiaOc.Enabled = ckbTrangThai.Enabled = txtGiaTien.Enabled = lBUSoaiDO.Enabled = txtDC.Enabled = txtHuongNha.Enabled = txtViTri.Enabled = txtMoTa.Enabled = txtDTKV.Enabled = txtDTSD.Enabled = status;
        }
        private void setNullInputDO()
        {
            txtMaDiaOc.Text = txtGiaTien.Text = txtDC.Text = txtViTri.Text = txtHuongNha.Text = txtMoTa.Text = txtDTKV.Text = txtDTSD.Text = null;
            cbLoaiDiaOc.Text = null;
            ckbTrangThai.Checked = false;

        }
        private void setNullInputQC()
        {
            ckb_QCTrenBao.Checked = ckbCoHinh_Bao.Checked = ckbCoMau.Checked = ckb_QCTrenBang.Checked = ckbCoHinh_Bang.Checked = ckb_QCToBuom.Checked = false;
        }

        private void dgvDiaOc_SelectionChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageKHvsDO;
            enableInputDO(false);
            string mado = null;
            setNullInputDO();
            setNullInputQC();
            dgvGiayTo.DataSource = new DataTable();

            if (dgvDiaOc.SelectedRows.Count <= 0)
            {
                return;
            }
            try
            {
                int i = -1;
                i = dgvDiaOc.CurrentRow.Index;

                mado = dgvDiaOc.Rows[i].Cells["MaDO"].Value.ToString();
                txtMaDiaOc.Text = dgvDiaOc.Rows[i].Cells["MaDO"].Value.ToString();
                txtGiaTien.Text = string.Format("{0:#,###0}", double.Parse(dgvDiaOc.Rows[i].Cells["GiaBan"].Value.ToString()));
                txtDC.Text = dgvDiaOc.Rows[i].Cells["DiaChi"].Value.ToString();
                txtHuongNha.Text = dgvDiaOc.Rows[i].Cells[7].Value.ToString();
                txtViTri.Text = dgvDiaOc.Rows[i].Cells["ViTri"].Value.ToString();
                txtMoTa.Text = dgvDiaOc.Rows[i].Cells["MoTaChiTiet"].Value.ToString();
                txtDTKV.Text = dgvDiaOc.Rows[i].Cells["DienTichKhuonVien"].Value.ToString();
                txtDTSD.Text = dgvDiaOc.Rows[i].Cells["DienTichSuDung"].Value.ToString();
                cbLoaiDiaOc.Text =dgvDiaOc.Rows[i].Cells["TenLoaiDO"].Value.ToString();
                if (dgvDiaOc.Rows[i].Cells["TrangThai"].Value.ToString() == "True")
                {
                    ckbTrangThai.Checked = true;
                }
                else
                    ckbTrangThai.Checked = false;
                dtgridDO = dgvKhachHang.Rows[i];

                dgvGiayTo.DataSource = documentBLL.GetListDocument(mado);
                dgvGiayTo.Columns["MaDO"].Visible = false;
                dgvGiayTo.Columns["MaGiayTo"].Visible = false;

                if(mado != null)
                {
                    dtDangKy = registrationBLL.GetInfoRegistration(customerId, mado);

                    if (dtDangKy.Rows.Count != 0)
     //                   dataGridBao.DataSource = Baos.getListBao(dtDangKy.Rows[0]["MAQCTRENBAO"].ToString());
                    //dataGridBao.Columns["MABAO"].Visible = false;
                    try
                    {
                        DateTime dt = DateTime.Parse(dtDangKy.Rows[0]["NGAYDANGKY"].ToString());
                        dateTimePicker_DKy.Value = dt;
                        DateTime dt1 = DateTime.Parse(dtDangKy.Rows[0]["NGAYKETTHUC"].ToString());
                        dateTimePicker_KetThuc.Value = dt1;
                        if (dtDangKy.Rows.Count == 0)
                        {
                             return;
                        }
                        lbl_SoLan.Text = dtDangKy.Rows[0][8].ToString();
                        }
                    catch { }

                    /*          HoaDonBUS hd = new HoaDonBUS();
                              DataTable dtHD = hd.GetHoaDon(dtDangKy.Rows[0]["MADANGKY"].ToString());

                              try
                              {
                                  if (dtHD.Rows[0]["TINHTRANGTHANHTOAN"].ToString() == "True")
                                  {
                                      isEditQC = false;
                                      txtThanhToan.Text = "*Đã thanh toán phí quảng cáo và lập phiếu thu";
                                  }
                                  else
                                  {
                                      isEditQC = true;
                                      txtThanhToan.Text = "*Vui lòng thanh toán phí quảng cáo và lập phiếu thu";
                                  }
                              }
                              catch { }
                              if (dtDangKy.Rows[0]["MADANGKY"].ToString() != null)
                              {
                                  if (dtDangKy.Rows[0]["MAQCTRENBAO"].ToString() != "")
                                  {
                                      ckb_QCTrenBao.Checked = true;
                                      string mLoaiDK = QCBaos.GetMaLoaiQC(dtDangKy.Rows[0]["MAQCTRENBAO"].ToString());
                                      dtBao = QCBaos.GetInfoLoaiQC(mLoaiDK);
                                      cbQCBao.Text = dtBao.Rows[0]["MATIENQCBAO"].ToString();
                                      lblViTri.Text = string.Format("{0:#,###0}", double.Parse(dtBao.Rows[0]["GIATIEN"].ToString().Trim()));
                                      if (dtBao.Rows[0]["ANH"].ToString().Trim() == "False")
                                      {
                                          ckbCoHinh_Bao.Checked = false;
                                      }
                                      else
                                      {
                                          ckbCoHinh_Bao.Checked = true;
                                      }
                                      if (dtBao.Rows[0]["MAUSAC"].ToString().Trim() == "False")
                                      {
                                          ckbCoMau.Checked = false;
                                      }
                                      else
                                          ckbCoMau.Checked = true;
                                  }
                                  else
                                  {
                                      dataGridBao.Enabled = false;
                                      cbQCBao.Enabled = false;
                                      cbQCBao.Text = null;
                                      ckbCoMau.Checked = false;
                                      ckbCoHinh_Bao.Checked = false;
                                      lblViTri.Text = null;
                                      txtGia_Bao.Text = null;
                                  }
                                  if (dtDangKy.Rows[0]["MAQCTRENBANG"].ToString() != "")
                                  {
                                      ckb_QCTrenBang.Checked = true;
                                      string mLoaiDK = QCBangs.GetMaLoaiQC(dtDangKy.Rows[0]["MAQCTRENBANG"].ToString());
                                      dtBang = QCBangs.GetInfoLoaiQC(mLoaiDK);
                                      cbLoaiQCBang.Text = dtBang.Rows[0]["MAGIATIENBANG"].ToString();
                                      lblKichCo_Bang.Text = dtBang.Rows[0]["KICHCO"].ToString().Trim();
                                      txtHinhthuc_Bang.Text = dtBang.Rows[0]["LOAIQCTRENBANG"].ToString().Trim();
                                      if (dtBang.Rows[0]["ANH"].ToString().Trim() == "False")
                                      {
                                          ckbCoHinh_Bang.Checked = false;
                                      }
                                      else
                                          ckbCoHinh_Bang.Checked = true;
                                      txtGia_Bang.Text = string.Format("{0:#,###0}", double.Parse(dtBang.Rows[0]["GIATIEN"].ToString().Trim()));
                                  }
                                  else
                                  {
                                      ckb_QCTrenBang.Checked = false;
                                      cbLoaiQCBang.Enabled = false;
                                      cbLoaiQCBang.Text = null;
                                      lblKichCo_Bang.Text = null;
                                      txtHinhthuc_Bang.Text = null;
                                      ckbCoHinh_Bang.Checked = false;
                                      txtGia_Bang.Text = null;

                                  } */
                    if (dtDangKy.Rows[0]["MaQCToBuom"].ToString() != "")
                    {
                        //cmbQCToBuom_LoaiQC.Enabled = true;
                        ckb_QCToBuom.Checked = true;
                        dtBuom = flyersBLL.GetInfoFlyers(dtDangKy.Rows[0]["MaQCToBuom"].ToString());
                        txt_NoiDung_ToBuom.Text = dtBuom.Rows[0]["NoiDung"].ToString();
                        lblSoLuong_ToBuom.Text = dtBuom.Rows[0]["SoLuongPhatHanh"].ToString();
                        txtGia_ToBuom.Text = String.Format("{0:#,###0}", double.Parse(dtBuom.Rows[0]["GiaTien"].ToString()));
                    }
                    else
                    {
                        txt_NoiDung_ToBuom.Text = null;
                        ckb_QCToBuom.Checked = false;
                        lblSoLuong_ToBuom.Text = null;
                        txtGia_ToBuom.Text = null;
                    }
            }
            }
            catch { }
        }

        private void txtTim_MaDO_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSoKyTuNhapVao(15, txtTim_MaDO.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void txtTim_DiaChiDO_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSoKyTuNhapVao(200, txtTim_DiaChiDO.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 200 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void txtTimDT_Tu_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSoKyTuNhapVao(10, txtTimDT_Tu.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 10 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            try
            {
                if (float.Parse(txtTimDT_Den.Text) < float.Parse(txtTimDT_Tu.Text))
                {
                    lblDienTich.Text = "Giá trị diện tích đến phải lớn hơn diện tích từ";

                }
                else
                    lblDienTich.Text = "";
            }
            catch
            {

            }
        }

        private void txtTimDT_Den_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSoKyTuNhapVao(10, txtTimDT_Den.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 10 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            try
            {
                if (float.Parse(txtTimDT_Den.Text) < float.Parse(txtTimDT_Tu.Text))
                {
                    lblDienTich.Text = "Giá trị diện tích đến phải lớn hơn diện tích từ";

                }
                else
                    lblDienTich.Text = "";
            }
            catch
            {

            }
        }

        private void ChiChoNhapSoNguyen(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;


        }

        private void txtTimGia_Tu_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSoKyTuNhapVao(15, txtTimGia_Tu.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            try
            {
                if (float.Parse(txtTimGia_Den.Text) < float.Parse(txtTimGia_Tu.Text))
                {
                    lblGia.Text = "Giá đến phải lớn hơn giá từ";

                }
                else
                    lblGia.Text = "";
            }
            catch
            {

            }
        }

        private void txtTimGia_Den_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSoKyTuNhapVao(15, txtTimGia_Den.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            try
            {
                if (float.Parse(txtTimGia_Den.Text) < float.Parse(txtTimGia_Tu.Text))
                {
                    lblGia.Text = "Giá đến phải lớn hơn giá từ";

                }
                else
                    lblGia.Text = "";
            }
            catch
            {

            }
        }

        private void txtTim_MaKH_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSoKyTuNhapVao(15, txtTim_MaKH.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void txtTim_HoTen_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSoKyTuNhapVao(100, txtTim_HoTen.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 100 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            Regex reg = new Regex(@"^([\w.'-_?@áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ ]+)$");
            if (!reg.IsMatch(txtTim_HoTen.Text))
            {
                MessageBox.Show("Tên không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtTim_DiaChiKH_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSoKyTuNhapVao(200, txtTim_DiaChiKH.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 200 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void txtTim_DiaChiKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private bool KiemTraSoKyTuNhapVao(int max, string str)
        {
            if (str.Length <= max)
                return true;
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = customerBLL.SearchCustomer(txtTim_MaKH.Text, txtTim_HoTen.Text, txtTim_DiaChiKH.Text, txtTim_SDT.Text);
        }

        private void btnTimKiemDO_Click(object sender, EventArgs e)
        {
            dgvDiaOc.DataSource = realEstateBLL.SearchRealEstate(txtTim_MaDO.Text, txtTim_DiaChiDO.Text, txtTimDT_Tu.Text, txtTimDT_Den.Text, txtTimGia_Tu.Text, txtTimGia_Den.Text);
            dgvGiayTo.DataSource = documentBLL.GetListDocument(txtTim_MaDO.Text);
            dgvGiayTo.Columns["MaDO"].Visible = false;
            dgvGiayTo.Columns["MaGiayTo"].Visible = false;
        }

        private void cbLoaiQCToBuom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
