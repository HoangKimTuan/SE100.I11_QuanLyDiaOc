using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using QuanLyDiaOc.DataAccessLayers;

namespace QuanLyDiaOc.PresentationLayers
{
    public partial class FormConfig : Form
    {
        private Server server;
        private string nameComputer;
        private Connection connection;
        public FormConfig()
        {
            InitializeComponent();
            txtServer.Text = "SQLEXPRESS";
            cmbDatabase.Text = "QuanLyDiaOc";
            server = new Server();
            nameComputer = System.Environment.MachineName + @"\";
            connection = new Connection();
            connection.Config(nameComputer, txtServer.Text, cmbDatabase.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUserWindows.Checked)
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void cmbDatabase_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                server = new Server(nameComputer + txtServer.Text);
                if (server.Databases.Count > 0)
                {
                    cmbDatabase.Items.Clear();
                    foreach (Database db in server.Databases)
                    {
                        cmbDatabase.Items.Add(db.Name);
                    }
                }
            }
            catch
            {

            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (connection.CheckConnect())
            {
                MessageBox.Show("Kết nối thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            connection.Config(nameComputer, txtServer.Text, cmbDatabase.Text);
            MessageBox.Show("Lưu thành công", "Thông báo");
        }
    }
}
