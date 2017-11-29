using QuanLyDiaOc.DataAccessLayers;
using QuanLyDiaOc.PresentationLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class BillBLL
    {
        BillDAL billDAL = new BillDAL();
        public void RenewalBill(string madk, double tienGiaHan)
        {
            try
            {
                if (billDAL.RenewalBill(madk, tienGiaHan))
                {
                    MessageBox.Show(FormRenewal.ActiveForm, "Đã gia hạn cho phiếu đăng ký quảng cáo", "Gia hạn thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(FormRenewal.ActiveForm, "Không thể gia hạn cho phiếu đăng ký quảng cáo", "Gia hạn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show(FormRenewal.ActiveForm, "Không thể gia hạn cho phiếu đăng ký quảng cáo", "Gia hạn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
