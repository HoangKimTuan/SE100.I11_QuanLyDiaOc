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
    public partial class FormReport : Form
    {
       

        public FormReport()
        {
            InitializeComponent();
            
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataQuangCao.NguoiDung' table. You can move, or remove it, as needed.
            this.NguoiDungTableAdapter.Fill(this.DataQuangCao.NguoiDung);
            // TODO: This line of code loads data into the 'DataQuangCao.KhachHang' table. You can move, or remove it, as needed.
           // this.KhachHangTableAdapter.Fill(this.DataQuangCao.KhachHang);

            this.reportViewer1.RefreshReport();
        }
    }
}
