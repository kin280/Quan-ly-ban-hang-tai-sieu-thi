
namespace Banhangtaisieuthi
{
    partial class FrmTKHDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTKHDB));
            this.tblHDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBHHDataSet = new Banhangtaisieuthi.QLBHHDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpD = new System.Windows.Forms.DateTimePicker();
            this.rptBan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblHDBanTableAdapter = new Banhangtaisieuthi.QLBHHDataSetTableAdapters.tblHDBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHHDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dtpD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày Bán Hàng:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tạo Thống Kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpD
            // 
            this.dtpD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpD.Location = new System.Drawing.Point(147, 39);
            this.dtpD.Name = "dtpD";
            this.dtpD.Size = new System.Drawing.Size(105, 22);
            this.dtpD.TabIndex = 0;
            // 
            // rptBan
            // 
            this.rptBan.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HDBAN";
            reportDataSource1.Value = this.tblHDBanBindingSource;
            this.rptBan.LocalReport.DataSources.Add(reportDataSource1);
            this.rptBan.LocalReport.ReportEmbeddedResource = "Banhangtaisieuthi.TKHDB.rdlc";
            this.rptBan.Location = new System.Drawing.Point(0, 100);
            this.rptBan.Name = "rptBan";
            this.rptBan.ServerReport.BearerToken = null;
            this.rptBan.Size = new System.Drawing.Size(1082, 653);
            this.rptBan.TabIndex = 4;
            // 
            // tblHDBanTableAdapter
            // 
            this.tblHDBanTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTKHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.rptBan);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTKHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Kê Hóa Đơn Bán Hàng";
            this.Load += new System.EventHandler(this.FrmTKHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHDBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHHDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpD;
        private Microsoft.Reporting.WinForms.ReportViewer rptBan;
        private System.Windows.Forms.BindingSource tblHDBanBindingSource;
        private QLBHHDataSet QLBHHDataSet;
        private QLBHHDataSetTableAdapters.tblHDBanTableAdapter tblHDBanTableAdapter;
    }
}