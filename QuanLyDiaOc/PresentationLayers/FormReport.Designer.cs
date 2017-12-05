namespace QuanLyDiaOc.PresentationLayers
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label6 = new System.Windows.Forms.Label();
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataQuangCao = new QuanLyDiaOc.PresentationLayers.DataQuangCao();
            this.KhachHangTableAdapter = new QuanLyDiaOc.PresentationLayers.DataQuangCaoTableAdapters.KhachHangTableAdapter();
            this.NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NguoiDungTableAdapter = new QuanLyDiaOc.PresentationLayers.DataQuangCaoTableAdapters.NguoiDungTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQuangCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(355, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thống kê quảng cáo";
            // 
            // KhachHangBindingSource
            // 
            this.KhachHangBindingSource.DataMember = "KhachHang";
            this.KhachHangBindingSource.DataSource = this.DataQuangCao;
            // 
            // DataQuangCao
            // 
            this.DataQuangCao.DataSetName = "DataQuangCao";
            this.DataQuangCao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KhachHangTableAdapter
            // 
            this.KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // NguoiDungBindingSource
            // 
            this.NguoiDungBindingSource.DataMember = "NguoiDung";
            this.NguoiDungBindingSource.DataSource = this.DataQuangCao;
            // 
            // NguoiDungTableAdapter
            // 
            this.NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NguoiDungBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDiaOc.PresentationLayers.ReportTest.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(186, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 3;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1017, 499);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReport";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataQuangCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private DataQuangCao DataQuangCao;
        private DataQuangCaoTableAdapters.KhachHangTableAdapter KhachHangTableAdapter;
        private System.Windows.Forms.BindingSource NguoiDungBindingSource;
        private DataQuangCaoTableAdapters.NguoiDungTableAdapter NguoiDungTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}