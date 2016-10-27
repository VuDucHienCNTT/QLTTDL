using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TTDL_AMO.DataAccessLayer;

namespace TTDL_AMO
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string TENDN = txtTenDN.Text.ToString();
            string MATKHAU = txtMK.Text.ToString();
            int so = kn.GetValue("Select count(*) from tblDANGNHAP where TENDN = '" + txtTenDN.Text.Trim() + "' And MATKHAU = '" + txtMK.Text.Trim() + "'");
            if (so > 0)
            {
                this.Hide();
                MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                frmTrangChu frm = new frmTrangChu();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtTenDN.Text = "";
                txtMK.Text = "";

            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            btnDN.Enabled = false;
        }

        private void tmrHienMK_Tick(object sender, EventArgs e)
        {
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {
            btnDN.Enabled = (txtTenDN.Text.Trim() != string.Empty);
        }
    }
}
