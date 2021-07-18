using Banhangtaisieuthi.Class;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banhangtaisieuthi
{
    public partial class INHOADON : Form
    {
        public INHOADON()
        {
            InitializeComponent();
        }

        private void INHOADON_Load(object sender, EventArgs e)
        {
            this.rpvHD.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = Properties.Settings.Default.quanlybanhang;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HDB";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDBan", CboMaHDBan.SelectedValue.ToString()));

            cmd.Connection = Con;
            DataSet ds = new DataSet();
            SqlDataAdapter q = new SqlDataAdapter(cmd);
            q.Fill(ds);

            rpvHD.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rpvHD.LocalReport.ReportPath = "hoadonban.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                rpvHD.LocalReport.DataSources.Clear();
                rpvHD.LocalReport.DataSources.Add(rds);
                rpvHD.RefreshReport();
            }
        }

        private void CboMaHDBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboMaHDBan_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaHDBan FROM tblChiTietHDBan", CboMaHDBan, "MaHDBan", "MaHDBan");
            CboMaHDBan.SelectedIndex = -1;
        }
    }
}
