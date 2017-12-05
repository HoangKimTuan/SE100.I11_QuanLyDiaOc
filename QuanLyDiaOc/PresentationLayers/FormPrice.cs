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
    public partial class FormPrice : Form
    {
        private PriceAdvFlyerBLL priceAdvFlyerBLL;
        private PriceAdvBoardBLL priceAdvBoardBLL;
        private PriceAdvNewspaperBLL priceAdvNewspaperBLL;

        public FormPrice()
        {
            InitializeComponent();
            priceAdvFlyerBLL = new PriceAdvFlyerBLL();
            priceAdvBoardBLL = new PriceAdvBoardBLL();
            priceAdvNewspaperBLL = new PriceAdvNewspaperBLL();
        }

        private void GiaQCToBuom_Load(object sender, EventArgs e)
        {
            tabCtrlGiaQuangCao.SelectedIndex = 0;
            dgvGiaQCToBuom.DataSource = priceAdvFlyerBLL.GetListPriceAdvFlyer();
        }

        private void tabCtrlGiaQuangCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlGiaQuangCao.SelectedIndex == 0)
                return;
            else if (tabCtrlGiaQuangCao.SelectedIndex == 1)
            {
                dgvGiaQCTrenBang.DataSource = priceAdvBoardBLL.GetListPriceAdvBoard();
            }
            else
            {
                dgvGiaQCTrenBao.DataSource = priceAdvNewspaperBLL.GetListPriceAdvNewspaper();
            }
        }

        private void btnCapNhatQCToBuom_Click(object sender, EventArgs e)
        {
            if (txtMaGiaQCToBuom.Text == "")
            {
                MessageBox.Show("Chọn mã quảng cáo muốn cập nhật giá");
            }
            else if (txtGiaQCToBuom.Text == "")
            {
                MessageBox.Show("Vui lòng điền vào giá muốn cập nhật");
            }
            else
            {
                PriceAdvFlyerDTO priceAdvFlyerDTO = new PriceAdvFlyerDTO(txtMaGiaQCToBuom.Text, Double.Parse(txtGiaQCToBuom.Text));
                try
                {
                    if (priceAdvFlyerBLL.UpdatePriceAdvFlyer(priceAdvFlyerDTO))
                    {
                        MessageBox.Show("Sửa giá quảng cáo tờ bướm thành công");
                        dgvGiaQCToBuom.DataSource = priceAdvFlyerBLL.GetListPriceAdvFlyer();
                    }
                    else
                    {
                        MessageBox.Show("Sửa giá quảng cáo tờ bướm thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa giá quảng cáo tờ bướm thất bại");
                }
            }
        }

        private void dgvGiaQCToBuom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvGiaQCToBuom.Rows[e.RowIndex];
                    txtMaGiaQCToBuom.Text = row.Cells["MaGiaQCToBuom"].Value.ToString();
                    txtGiaQCToBuom.Text = row.Cells["DonGiaQCToBuom"].Value.ToString();
                }
                catch { }
            }
        }

        private void btnCapNhatQCTrenBang_Click(object sender, EventArgs e)
        {
            if (txtMaGiaQCTrenBang.Text == "")
            {
                MessageBox.Show("Chọn mã quảng cáo muốn cập nhật giá");
            }
            else if (txtGiaQCTrenBang.Text == "")
            {
                MessageBox.Show("Vui lòng điền vào giá muốn cập nhật");
            }
            else
            {
                PriceAdvBoardDTO priceAdvBoardDTO = new PriceAdvBoardDTO(txtMaGiaQCTrenBang.Text, Double.Parse(txtGiaQCTrenBang.Text));
                try
                {
                    if (priceAdvBoardBLL.UpdatePriceAdvBoard(priceAdvBoardDTO))
                    {
                        MessageBox.Show("Sửa giá quảng cáo trên bảng thành công");
                        dgvGiaQCTrenBang.DataSource = priceAdvBoardBLL.GetListPriceAdvBoard();
                    }
                    else
                    {
                        MessageBox.Show("Sửa giá quảng cáo trên bảng thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa giá quảng cáo trên bảng thất bại");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGiaQCTrenBang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvGiaQCTrenBang.Rows[e.RowIndex];
                    txtMaGiaQCTrenBang.Text = row.Cells["MaGiaQCTrenBang"].Value.ToString();
                    txtGiaQCTrenBang.Text = row.Cells["DonGiaQCTrenBang"].Value.ToString();
                }
                catch { }
            }
        }

        private void btnCapNhatQCTrenBao_Click(object sender, EventArgs e)
        {
            if (txtMaGiaQCTrenBao.Text == "")
            {
                MessageBox.Show("Chọn mã quảng cáo muốn cập nhật giá");
            }
            else if (txtMaGiaQCTrenBao.Text == "")
            {
                MessageBox.Show("Vui lòng điền vào giá muốn cập nhật");
            }
            else
            {
                PriceAdvNewspaperDTO priceAdvNewspaperDTO = new PriceAdvNewspaperDTO(txtMaGiaQCTrenBao.Text, Double.Parse(txtGiaQCTrenBao.Text));
                try
                {
                    if (priceAdvNewspaperBLL.UpdatePriceAdvNewspaper(priceAdvNewspaperDTO))
                    {
                        MessageBox.Show("Sửa giá quảng cáo trên báo thành công");
                        dgvGiaQCTrenBao.DataSource = priceAdvNewspaperBLL.GetListPriceAdvNewspaper();
                    }
                    else
                    {
                        MessageBox.Show("Sửa giá quảng cáo trên báo thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa giá quảng cáo trên báo thất bại");
                }
            }
        }

        private void dgvGiaQCTrenBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvGiaQCTrenBao.Rows[e.RowIndex];
                    txtMaGiaQCTrenBao.Text = row.Cells["MaGiaQCTrenBao"].Value.ToString();
                    txtGiaQCTrenBao.Text = row.Cells["DonGiaQCTrenBao"].Value.ToString();
                }
                catch { }
            }
        }
    }
}
