using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Banhangtaisieuthi
{
    public partial class FrmTKHDB : Form
    {
        public FrmTKHDB()
        {
            InitializeComponent();
        }

        private void FrmTKHDB_Load(object sender, EventArgs e)
        {
          

            this.rptBan.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = Properties.Settings.Default.quanlybanhang;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCHDBAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@NgayBan", dtpD.Value.Date));
            cmd.Connection = Con;
            DataSet ds = new DataSet();
            SqlDataAdapter q = new SqlDataAdapter(cmd);

            q.Fill(ds);
            rptBan.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            rptBan.LocalReport.ReportPath = "TKHDB.rdlc";

            if (ds.Tables[0].Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "HDBAN";
                rds.Value = ds.Tables[0];


                rptBan.LocalReport.DataSources.Clear();

                rptBan.LocalReport.DataSources.Add(rds);

                rptBan.RefreshReport();
            }
        }
    }
}
