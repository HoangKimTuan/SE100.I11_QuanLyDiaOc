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
using QuanLyDiaOc.DataTransferObject;
using System.Text.RegularExpressions;

namespace QuanLyDiaOc.PresentationLayers
{
    public partial class FormSetting : Form
    {
        private SettingBLL settingBLL;
        private UserTypeBLL userTypeBLL;
        private UserBLL userBLL;
        private bool checkInsertUser;
        private String userId;
        public FormSetting()
        {
            InitializeComponent();
            checkInsertUser = false;
            userId = "";
            settingBLL = new SettingBLL();
            userTypeBLL = new UserTypeBLL();
            userBLL = new UserBLL();
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

            cbChucVu.DataSource = userTypeBLL.GetListUserType();
            cbChucVu.DisplayMember = "LoaiNguoiDung";
            cbChucVu.ValueMember = "MaLoaiNguoiDung";
            dgvTaiKhoan.DataSource = userBLL.GetListUser();
            userId = "";
        }

        private void btn_LuuMK_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.Text.ToString().Equals(txtXacNhanMK.Text.ToString()) && txtMKMoi.Text.Trim().Length >= 6)
            {
                UserDTO userDTO = new UserDTO(txtUser.Text.ToString(), txtMKMoi.Text.ToString());
                if (userBLL.UpdateUser(userDTO).Rows.Count > 0)
                {
                    MessageBox.Show("Sửa người dùng thành công");
                    dgvTaiKhoan.DataSource = userBLL.GetListUser();
                    userId = "";
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được trùng nhau và phải từ 6 ký tự trở lên");
            }
        }

        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            if (checkInsertUser)
            {
                UserDTO userDTO = new UserDTO(txtTaiKhoan.Text.ToString(), txtMatKhau.Text.ToString(), cbChucVu.SelectedValue.ToString());
                if (userBLL.InsertUser(userDTO))
                {
                    MessageBox.Show("Thêm người dùng thành công");
                    dgvTaiKhoan.DataSource = userBLL.GetListUser();
                    userId = "";
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin người dùng");
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (userId == "")
            {
                MessageBox.Show("Làm ơn chọn người dùng muốn xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin tài khoản " + userId, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (userBLL.DeleteUser(userId))
                    {
                        MessageBox.Show("Xóa khách hàng thành công");
                        dgvTaiKhoan.DataSource = userBLL.GetListUser();
                        userId = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại");
                    }
                }
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.'-_?@]+)$");
            if (!reg.IsMatch(txtTaiKhoan.Text))
            {
                lblUserName.Text = "Tài khoản không hợp lệ";
                checkInsertUser = false;
                return;
            }
            else
            {
                lblUserName.Text = "";
                checkInsertUser = true;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.ToString().Length < 6)
            {
                lblPass.Text = "Mật khẩu phải từ 6 ký tự trở lên";
                checkInsertUser = false;
                return;
            }
            else
            {
                lblPass.Text = "";
                checkInsertUser = true;
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvTaiKhoan.Rows[e.RowIndex];
                    userId = row.Cells["MaTK"].Value.ToString();
                    txtTaiKhoan.Text = row.Cells["TenTK"].Value.ToString();
                    cbChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                }
                catch { }
            }
        }
    }
}
