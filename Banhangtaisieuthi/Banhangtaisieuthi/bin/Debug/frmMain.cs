using Banhangtaisieuthi.Class;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Banhangtaisieuthi
{
    public partial class frmMain : Form
    {
        private string tentk;
        private string message;
        SqlDataReader sdr;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string sql = "select * from tblNhanVien where MaNhanVien = '" + tentk + "'";
            sdr = Functions.GetdataSDR(sql);
            sdr.Read();
            if (sdr[2].Equals("nhanvien"))
            {
                mnuTK.Visible = false;
                mnuDanhMuc.Visible = false;
                tsbHH.Visible = false;
            }
            else
            {
                mnuTK.Visible = true;             
                mnuDanhMuc.Visible = true;
            }
        }

        public string Message
        {
            get { return tentk; }
            set { tentk = value; }
        }

        private void mnuTKHDBan_Click(object sender, EventArgs e)
        {
            FrmTKHDB frm = new FrmTKHDB(); //Khởi tạo đối tượng
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuLLP_Click(object sender, EventArgs e)
        {
            frmthaydoimk frm = new frmthaydoimk(); //Khởi tạo đối tượng
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Thoát
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void mnuHangHoa_Click_1(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa(); //Khởi tạo đối tượng
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhanVien_Click_1(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien(); //Khởi tạo đối tượng
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuHoaDonBan_Click_1(object sender, EventArgs e)
        {
            frmHDBanHang frm = new frmHDBanHang(); //Khởi tạo đối tượng
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbHH_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa(); //Khởi tạo đối tượng
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbPBH_Click(object sender, EventArgs e)
        {
            frmHDBanHang frm = new frmHDBanHang(); //Khởi tạo đối tượng
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {

        }
    }
}
