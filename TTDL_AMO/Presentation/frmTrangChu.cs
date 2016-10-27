using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TTDL_AMO
{
    public partial class frmTrangChu : Form
    {
        System.Media.SoundPlayer play = new System.Media.SoundPlayer();
        public frmTrangChu()
        {
            InitializeComponent();

            play.SoundLocation = "WavBayGiuaNganHa.wav";

        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            lblTime.Text = "Thời Gian : " + DateTime.Now.ToString();
            play.Play();
        }
        //int x = 250, y = 60, a = 1;
        //Random random = new Random();
        private void tmrChayChu_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    x += a;
            //    lblNhan.Location = new Point(x, y);
            //    if (x > 420)
            //    {
            //        a = -1;
            //        lblNhan.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //    }
            //    if (x < 230)
            //    {
            //        a = 1;
            //        lblNhan.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //    }
            //}
            //catch
            //{
            //}
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đóng không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                Application.Exit();
                this.Dispose();
            }
        }

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNXB frm = new frmNXB();
            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiLieu frm = new frmTaiLieu();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void mnuQLTV_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void giớiThiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGioiThieu frm = new frmGioiThieu();
            frm.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void sáchTrongNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuMuon frm = new frmPhieuMuon();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void timKiếm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timKiếm2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ảnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ảnhCơQuanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmImageCoQuan frm = new frmImageCoQuan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
