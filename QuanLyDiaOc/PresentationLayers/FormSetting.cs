using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiaOc.BusinesLogicLayers;

namespace QuanLyDiaOc.PresentationLayers
{
    public partial class FormSetting : Form
    {
        private SettingBLL settingBLL;
        public FormSetting()
        {
            InitializeComponent();
            settingBLL = new SettingBLL();
        }

        private void btnLuu_ThamSo_Click(object sender, EventArgs e)
        {
            if (txtSoTienGH.Text.ToString() == "" || txtSoTu.Text.ToString() == "" || txtSoTuoi.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin thay đổi");
                return;
            }
            try
            {
                if (settingBLL.UpdataParamater(txtSoTienGH.Text.ToString(), txtSoTu.Text.ToString(), txtSoTuoi.Text.ToString()))
                {
                    MessageBox.Show("Thay đổi quy định thành công");
                }
                else
                {
                    MessageBox.Show("Thay đổi quy định thất bại");
                }
            }
            catch
            {
            }
        }

        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTienGH_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != '.')
                e.Handled = true;
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            txtSoTienGH.Text = settingBLL.GetInterestRate();
            txtSoTu.Text = settingBLL.GetNumberWords();
            txtSoTuoi.Text = settingBLL.GetMinAge();
        }
    }
}
