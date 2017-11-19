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
    public partial class FormHome : Form
    {
        public string user { get; set; }
        public string type { get; set; }

        public FormHome()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.MdiParent = this;
            formRegistration.Show();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FormSetting formSetting = new FormSetting();
            formSetting.MdiParent = this;
            formSetting.Show();
        }
    }
}
