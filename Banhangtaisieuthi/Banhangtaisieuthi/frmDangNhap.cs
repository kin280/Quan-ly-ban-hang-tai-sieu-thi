using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Banhangtaisieuthi
{
    public partial class frmDangNhap : Form
    {
        SqlDataReader sdr;
        public string TenDN = null;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public static string user { get; internal set; }

        SqlDataReader GetData(string sql)
        {

            SqlConnection Con = new SqlConnection();   //Khởi tạo đối tượng
            Con.ConnectionString = Properties.Settings.Default.quanlybanhang;
            SqlCommand cmd = new SqlCommand(sql, Con);
            DataTable dt = new DataTable();
            Con.Open();
            sdr = cmd.ExecuteReader();
            return sdr;
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string error = "error";
            GetData("Select * from tblNhanVien");
            while (sdr.Read())
            {
                if (sdr[0].Equals(txtTen.Text) && sdr[1].Equals(txtPass.Text))
                {
                    frmMain main = new frmMain();
                    main.Message = sdr[0].ToString();
                    main.Show();
                    this.Visible = false;
                    error = "success";
                    TenDN = txtTen.Text;
                }
            }
            if (error.Equals("error"))
            {
                MessageBox.Show("Tài Khoản hoặc mật khẩu sai vui lòng nhập lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }
    }
}
