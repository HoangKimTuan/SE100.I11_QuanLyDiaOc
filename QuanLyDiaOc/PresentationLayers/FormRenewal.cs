using QuanLyDiaOc.BusinesLogicLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiaOc.PresentationLayers
{
    public partial class FormRenewal : Form
    {
        private RenewalBLL renewalBLL;
        private CustomerBLL customerBLL;
        private RealEstateBLL realEstateBLL;
        private DataTable dtCustomer;
        private DataTable dtRealEstate;
        private DataTable dtRegistration;
        private RegistrationBLL registrationBLL;
        private SettingBLL settingBLL;
        private BillBLL billBLL;

        private String customerId;
        private String realEstateId;
        private String customerIdOld;
        
        public FormRenewal()
        {
            InitializeComponent();
            renewalBLL = new RenewalBLL();
            customerId = "";
            realEstateId = "";
            customerBLL = new CustomerBLL();
            realEstateBLL = new RealEstateBLL();
            dtCustomer = new DataTable();
            dtRealEstate = new DataTable();
            dtRegistration = new DataTable();
            registrationBLL = new RegistrationBLL();
            settingBLL = new SettingBLL();
            billBLL = new BillBLL();
        }

        private void FormRenewal_Load(object sender, EventArgs e)
        {
            dgvDangKyGiaHan.DataSource = renewalBLL.GetListRenewal();
            dgvDangKyGiaHan.Columns["MaQCToBuom"].Visible = false;
            dgvDangKyGiaHan.Columns["MaQCTrenBang"].Visible = false;
            dgvDangKyGiaHan.Columns["MaQCTrenBao"].Visible = false;
        }

        private void dgvDangKyGiaHan_SelectionChanged(object sender, EventArgs e)
        {
                if (dgvDangKyGiaHan.SelectedRows.Count <= 0)
                {
                    return;
                }
                try
                {
                    double TongTien = 0.0;
                    double TienGiaHan = 0.0;
                    int i = -1;
                    i = dgvDangKyGiaHan.CurrentRow.Index;
                dataGridChiTiet.Rows.Clear();
                    
                    customerId = dgvDangKyGiaHan.Rows[i].Cells["MaKH"].Value.ToString();
                    realEstateId = dgvDangKyGiaHan.Rows[i].Cells["MaDO"].Value.ToString();

                    dtRegistration = registrationBLL.GetInfoRegistration(customerId, realEstateId);
                    dtCustomer = customerBLL.GetInfoCustomer(customerId);
                    dtRealEstate = realEstateBLL.GetInfoRealEstate(realEstateId);

                    txtMaKH.Text = customerId;
                    txtHoTen.Text = dtCustomer.Rows[0]["TenKH"].ToString();
                    txtDiaChiKH.Text = dtCustomer.Rows[0]["DiaChi"].ToString();
                    txtSDT.Text = dtCustomer.Rows[0]["SDT"].ToString();
                    txtEmail.Text = dtCustomer.Rows[0]["Email"].ToString();

                    txtMaDO.Text = realEstateId;
                    txtGiaTien.Text = String.Format("{0:#,###0}", double.Parse(dtRealEstate.Rows[0]["GiaBan"].ToString()));
                    txtDiaChiDO.Text = dtRealEstate.Rows[0]["DiaChi"].ToString();
                    txtHuongNha.Text = dtRealEstate.Rows[0]["HuongNha"].ToString();
                    txtViTri.Text = dtRealEstate.Rows[0]["ViTri"].ToString();
                    txtMoTa.Text = dtRealEstate.Rows[0]["MoTaChiTiet"].ToString();
                    txtDTSD.Text = dtRealEstate.Rows[0]["DienTichSuDung"].ToString();
                    txtDTKV.Text = dtRealEstate.Rows[0]["DienTichKhuonVien"].ToString();
                    String maLoaiDO = dtRealEstate.Rows[0]["MaLoaiDO"].ToString();
                    txtLoaiDiaOc.Text = realEstateBLL.GetTypeRealEstate(maLoaiDO).Rows[0]["TenLoaiDO"].ToString();
                    ckbTrangThai.Checked = (dtRealEstate.Rows[0]["TrangThai"].ToString() == "True");

                    if (dtRegistration.Rows[0]["MaDO"].ToString() != null)
                    {
                        if (dtRegistration.Rows[0]["MaQCTrenBao"].ToString() != "")
                        {
                            AdvNewpaperBLL advNewspaperBLL = new AdvNewpaperBLL();
                            DataTable dtBao = advNewspaperBLL.GetInfoNewspaper(dtRegistration.Rows[0]["MaQCTrenBao"].ToString());
                            TongTien += double.Parse(dtBao.Rows[0]["ThanhTien"].ToString().Trim());
                            dataGridChiTiet.Rows.Add("Quảng cáo trên báo", String.Format("{0:#,###0}", double.Parse(dtBao.Rows[0]["DonGia"].ToString())), String.Format("{0:#,###0}", double.Parse(dtBao.Rows[0]["ThanhTien"].ToString().Trim())));
                        }
                        if (dtRegistration.Rows[0]["MaQCTrenBang"].ToString() != "")
                        {
                            AdvBoardBLL advBoardBLL = new AdvBoardBLL();
                            DataTable dtBang = advBoardBLL.GetInfoBoard(dtRegistration.Rows[0]["MaQCTrenBang"].ToString());
                            TongTien += double.Parse(dtBang.Rows[0]["ThanhTien"].ToString().Trim());
                            dataGridChiTiet.Rows.Add("Quảng cáo trên bảng", String.Format("{0:#,###0}", double.Parse(dtBang.Rows[0]["DonGia"].ToString())), String.Format("{0:#,###0}", double.Parse(dtBang.Rows[0]["ThanhTien"].ToString().Trim())));
                        }
                        if (dtRegistration.Rows[0]["MaQCToBuom"].ToString() != "")
                        {
                            AdvFlyersBLL advFlyersBLL = new AdvFlyersBLL();
                            DataTable dtToBuom = advFlyersBLL.GetInfoFlyers(dtRegistration.Rows[0]["MaQCToBuom"].ToString());
                            TongTien += double.Parse(dtToBuom.Rows[0]["ThanhTien"].ToString().Trim());
                            dataGridChiTiet.Rows.Add("Quảng cáo tờ bướm", String.Format("{0:#,###0}", double.Parse(dtToBuom.Rows[0]["DonGia"].ToString().Trim())), String.Format("{0:#,###0}", double.Parse(dtToBuom.Rows[0]["ThanhTien"].ToString().Trim())));
                        }

                        txtTongTien.Text = String.Format("{0:#,###0}", TongTien) ;
                        double reduceCost = 0.0;
                        string rate = settingBLL.GetInterestRate();

                        reduceCost = double.Parse(rate);
                        TienGiaHan = (TongTien * reduceCost) / 100;
                        txtTienGiaHan.Text = String.Format("{0:#,###0}", TienGiaHan);
                    }

                }
                catch
                {
                    return;
                }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show(this, "Bạn có muốn gia hạn đăng ký cho quảng cáo này không?", "Gia hạn dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ds == DialogResult.Yes)
            {
                try
                {
                    billBLL.RenewalBill(dtRegistration.Rows[0]["SoPDK"].ToString(), double.Parse(txtTienGiaHan.Text));
                    renewalBLL.DateRenewalEnd(dtRegistration.Rows[0]["SoPDK"].ToString());
                    dgvDangKyGiaHan.DataSource = renewalBLL.GetListRenewal();
                }
                catch
                {

                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
