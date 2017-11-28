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
                if(customerId != null)
                {
                    double TongTien = 0.0;
                    double TienGiaHan = 0.0;
                    int i = -1;
                    i = dgvDangKyGiaHan.CurrentRow.Index;
                    customerId = dgvDangKyGiaHan.Rows[i].Cells["MaKH"].Value.ToString();
                    realEstateId = dgvDangKyGiaHan.Rows[i].Cells["MaDO"].Value.ToString();

                    dtRegistration = registrationBLL.GetInfoRegistration(customerId, realEstateId);
                    dtCustomer = customerBLL.GetInfoCustomer(customerId);
                    dtRealEstate = realEstateBLL.GetInfoRealEstate(realEstateId);

                    txtMaKH.Text = customerId;
                    txtHoTen.Text = dtCustomer.Rows[i]["TenKH"].ToString();
                    txtDiaChiKH.Text = dtCustomer.Rows[i]["DiaChi"].ToString();
                    txtSDT.Text = dtCustomer.Rows[i]["SDT"].ToString();
                    txtEmail.Text = dtCustomer.Rows[i]["Email"].ToString();

                    txtMaDO.Text = realEstateId;
                    txtGiaTien.Text = String.Format("{0:#,###0}", double.Parse(dtRealEstate.Rows[i]["GiaBan"].ToString()));
                    txtDiaChiDO.Text = dtRealEstate.Rows[i]["DiaChi"].ToString();
                    txtHuongNha.Text = dtRealEstate.Rows[i]["HuongNha"].ToString();
                    txtViTri.Text = dtRealEstate.Rows[i]["ViTri"].ToString();
                    txtMoTa.Text = dtRealEstate.Rows[i]["MoTaChiTiet"].ToString();
                    txtDTSD.Text = dtRealEstate.Rows[i]["DienTichSuDung"].ToString();
                    txtDTKV.Text = dtRealEstate.Rows[i]["DienTichKhuonVien"].ToString();
                    String maLoaiDO = dtRealEstate.Rows[i]["MaLoaiDO"].ToString();
                    txtLoaiDiaOc.Text = realEstateBLL.GetTypeRealEstate(maLoaiDO).Rows[i]["TenLoaiDO"].ToString();
                    ckbTrangThai.Checked = (dtRealEstate.Rows[i]["TrangThai"].ToString() == "True");

                    if (dtRegistration.Rows[i]["MaDO"].ToString() != null)
                    {
                        if (dtRegistration.Rows[i]["MaQCTrenBao"].ToString() != "")
                        {
                            AdvNewpaperBLL advNewspaperBLL = new AdvNewpaperBLL();
                            DataTable dtBao = advNewspaperBLL.GetInfoNewspaper(dtRegistration.Rows[i]["MaQCTrenBao"].ToString());
                            TongTien += double.Parse(dtBao.Rows[i]["ThanhTien"].ToString().Trim());
                            dataGridChiTiet.Rows.Add("Quảng cáo trên báo", String.Format("{0:#,###0}", dtBao.Rows[i]["DonGia"].ToString()), String.Format("{0:#,###0}", double.Parse(dtBao.Rows[i]["ThanhTien"].ToString().Trim())));
                        }
                        if (dtRegistration.Rows[i]["MaQCTrenBang"].ToString() != "")
                        {
                            AdvBoardBLL advBoardBLL = new AdvBoardBLL();
                            DataTable dtBang = advBoardBLL.GetInfoBoard(dtRegistration.Rows[i]["MaQCTrenBang"].ToString());
                            TongTien += double.Parse(dtBang.Rows[i]["ThanhTien"].ToString().Trim());
                            dataGridChiTiet.Rows.Add("Quảng cáo trên bảng", String.Format("{0:#,###0}", dtBang.Rows[i]["DonGia"].ToString()), String.Format("{0:#,###0}", double.Parse(dtBang.Rows[i]["ThanhTien"].ToString().Trim())));
                        }
                        if (dtRegistration.Rows[i]["MaQCToBuom"].ToString() != "")
                        {
                            AdvFlyersBLL advFlyersBLL = new AdvFlyersBLL();
                            DataTable dtToBuom = advFlyersBLL.GetInfoFlyers(dtRegistration.Rows[i]["MaQCToBuom"].ToString());
                            TongTien += double.Parse(dtToBuom.Rows[i]["ThanhTien"].ToString().Trim());
                            dataGridChiTiet.Rows.Add("Quảng cáo tờ bướm", String.Format("{0:#,###0}", dtToBuom.Rows[i]["DonGia"].ToString().Trim()), String.Format("{0:#,###0}", double.Parse(dtToBuom.Rows[i]["ThanhTien"].ToString().Trim())));
                        }

                        txtTongTien.Text = String.Format("{0:#,###0}", TongTien) + " VNĐ";
                        double reduceCost = 0.0;
                        string rate = settingBLL.GetInterestRate();

                        reduceCost = double.Parse(rate);
                        TienGiaHan = (TongTien * reduceCost) / 100;
                        txtTienGiaHan.Text = String.Format("{0:#,###0}", TienGiaHan) + " VNĐ";
                    }
                }
                 
                customerId = null;
            }
            catch
            {
                return;
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
