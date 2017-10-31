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
    public partial class FormLogin : Form
    {
        private LoginBLL loginBLL;
        private string user;
        private string pass;
        public FormLogin()
        {
            InitializeComponent();
            loginBLL = new LoginBLL();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            pass = txtPass.Text;
            if (loginBLL.CheckLogin(user, pass) != null)
            {
                this.Hide();
                FormHome formHome = new FormHome();
                formHome.user = user;
                formHome.type = loginBLL.GetType(user);
                formHome.Show();
            }
            else if (user == "" || pass == "")
            {
                MessageBox.Show(this, "Phải nhập đủ tên đăng nhập và mật khẩu!!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            formConfig.ShowDialog();
        }
    }
}
