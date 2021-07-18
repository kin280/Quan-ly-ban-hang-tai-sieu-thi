
namespace Banhangtaisieuthi
{
    partial class INHOADON
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INHOADON));
            this.tblChiTietHDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBHHDataSet = new Banhangtaisieuthi.QLBHHDataSet();
            this.tblHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblHDBanTableAdapter = new Banhangtaisieuthi.QLBHHDataSetTableAdapters.tblHDBanTableAdapter();
            this.tblHangTableAdapter = new Banhangtaisieuthi.QLBHHDataSetTableAdapters.tblHangTableAdapter();
            this.CboMaHDBan = new System.Windows.Forms.ComboBox();
            this.btnin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblChiTietHDBanBindingSource
            // 
            this.tblChiTietHDBanBindingSource.DataMember = "tblChiTietHDBan";
            // 
            // tblHDBanBindingSource
            // 
            this.tblHDBanBindingSource.DataMember = "tblHDBan";
            this.tblHDBanBindingSource.DataSource = this.QLBHHDataSet;
            // 
            // QLBHHDataSet
            // 
            this.QLBHHDataSet.DataSetName = "QLBHHDataSet";
            this.QLBHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHangBindingSource
            // 
            this.tblHangBindingSource.DataMember = "tblHang";
            this.tblHangBindingSource.DataSource = this.QLBHHDataSet;
            // 
            // rpvHD
            // 
            this.rpvHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblChiTietHDBanBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.tblHDBanBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.tblHangBindingSource;
            this.rpvHD.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvHD.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvHD.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvHD.LocalReport.ReportEmbeddedResource = "Banhangtaisieuthi.hoadonban.rdlc";
            this.rpvHD.Location = new System.Drawing.Point(0, 71);
            this.rpvHD.Name = "rpvHD";
            this.rpvHD.ServerReport.BearerToken = null;
            this.rpvHD.Size = new System.Drawing.Size(1082, 682);
            this.rpvHD.TabIndex = 0;
            this.rpvHD.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tblHDBanTableAdapter
            // 
            this.tblHDBanTableAdapter.ClearBeforeFill = true;
            // 
            // tblHangTableAdapter
            // 
            this.tblHangTableAdapter.ClearBeforeFill = true;
            // 
            // CboMaHDBan
            // 
            this.CboMaHDBan.FormattingEnabled = true;
            this.CboMaHDBan.Location = new System.Drawing.Point(265, 21);
            this.CboMaHDBan.Name = "CboMaHDBan";
            this.CboMaHDBan.Size = new System.Drawing.Size(192, 24);
            this.CboMaHDBan.TabIndex = 1;
            this.CboMaHDBan.DropDown += new System.EventHandler(this.CboMaHDBan_DropDown);
            this.CboMaHDBan.SelectedIndexChanged += new System.EventHandler(this.CboMaHDBan_SelectedIndexChanged);
            // 
            // btnin
            // 
            this.btnin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnin.Location = new System.Drawing.Point(485, 17);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(93, 30);
            this.btnin.TabIndex = 2;
            this.btnin.Text = "In Hoa Don";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // INHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.CboMaHDBan);
            this.Controls.Add(this.rpvHD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "INHOADON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Hóa Đơn";
            this.Load += new System.EventHandler(this.INHOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHD;
        private System.Windows.Forms.BindingSource tblChiTietHDBanBindingSource;
        
        private System.Windows.Forms.BindingSource tblHDBanBindingSource;
        private QLBHHDataSet QLBHHDataSet;
        private System.Windows.Forms.BindingSource tblHangBindingSource;
        
        private QLBHHDataSetTableAdapters.tblHDBanTableAdapter tblHDBanTableAdapter;
        private QLBHHDataSetTableAdapters.tblHangTableAdapter tblHangTableAdapter;
        private System.Windows.Forms.ComboBox CboMaHDBan;
        private System.Windows.Forms.Button btnin;
    }
}