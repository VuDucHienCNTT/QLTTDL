using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTDL_AMO.Entities;
using TTDL_AMO.Bussiness;
using TTDL_AMO.DataAccessLayer;

namespace TTDL_AMO
{
    public partial class frmImageCoQuan : Form
    {
        KetNoi dah = new KetNoi();
        ANH et = new ANH();
        ANHBLL bll = new ANHBLL();
        ANHDAL dal = new ANHDAL();
        public frmImageCoQuan()
        {
            InitializeComponent();
            Load += frmImageCoQuan_Load;
        }

        private void btnChonTep_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = openFileDialog.Filter = "All file(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                txtDuongDan.Text = openFileDialog.FileName;
            }
            txtTenAnh.Enabled = true;
            txtDuongDan.Enabled = true;
        }

        private void frmImageCoQuan_Load(object sender, EventArgs e)
        {
            HThiDuLieu("");

            txtTenAnh.Enabled = false;
            txtDuongDan.Enabled = false;

        }
        // Hàm con Load ảnh 
        //private void LoadPicture()
        //{
        //    try
        //    {
        //        string tenanh = Application.StartupPath + "\\Pictures\\" + txtDuongDan.Text;// Muc dich tao duong dan the nay de khi save anh moi khong bao loi duong dan!
        //        picImage.Image = Image.FromFile(tenanh);
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Hồ sơ này chưa có ảnh!");
        //    }
        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bll.KTraMaTrung(txtTenAnh.Text.Trim()) == false)
            {
                et.TenAnh = txtTenAnh.Text;
                et.FileAnh = txtDuongDan.Text;

                bll.ThemAnh(et);
                MessageBox.Show("Bạn Đã Thêm Thành Công!");
                txtTenAnh.Focus();
                HThiDuLieu("");
            }
            else
            {
                MessageBox.Show("Ảnh Này Đã Tồn Tại!");
                txtTenAnh.Focus();
            }
        }
        public void HThiDuLieu(string ht)
        {
            dgvDSImage.DataSource = bll.LayDL(ht);
        }

        private void dgvDSImage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtTenAnh.Text = dgvDSImage[0, dong].Value.ToString();
            txtDuongDan.Text = dgvDSImage[1, dong].Value.ToString();
            LableImg.Text = txtTenAnh.Text.ToString();
        }

        private void dgvDSImage_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(dgvDSImage.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally { }
        }
    }
}
