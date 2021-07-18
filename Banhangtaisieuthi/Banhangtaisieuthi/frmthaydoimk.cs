using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banhangtaisieuthi.Class;

namespace Banhangtaisieuthi
{
    public partial class frmthaydoimk : Form
    {
        public frmthaydoimk()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql;


            if (txtPassnew.Text == txtNhaplai.Text)
            {
                sql = "update tblNhanVien set MK = N'" + txtPassnew.Text + "' where MaNhanVien = '" + txtTenTK.Text + "'";
                if (Functions.CRUDdata(sql).ToString() != null)
                {
                    MessageBox.Show("Đổi mật khẩu thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void btnLuuPass_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
