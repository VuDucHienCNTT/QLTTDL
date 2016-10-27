using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TTDL_AMO.Entities;
using TTDL_AMO.Bussiness;
using TTDL_AMO.DataAccessLayer;

namespace TTDL_AMO
{
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }
        KetNoi dah = new KetNoi();
        DOCGIA et = new DOCGIA();
        DOCGIABLL bll = new DOCGIABLL();
        DOCGIADAL dal = new DOCGIADAL();
        public void HThiDuLieu(string ht)
        {
            dgvDG.DataSource = bll.LayDL(ht);
        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            HThiDuLieu("");
            cboMahayTen.Text = "Họ Tên";
        }
        public void LamMoi()
        {
            txtMaDG.Text = "";
            txtHoTenDG.Text = "";
            cboGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtMaDG.Enabled = true;
            txtMaDG.Focus();
            this.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaDG.Text==""||txtHoTenDG.Text==""||cboGioiTinh.Text==""||txtDiaChi.Text==""||txtSDT.Text==""||txtEmail.Text=="")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
                return;
            }
            if (bll.KTraMaTrung(txtMaDG.Text.Trim()) == false)
            {
                et.MaDG = txtMaDG.Text;
                et.HoTenDG = txtHoTenDG.Text;
                et.GioiTinh = cboGioiTinh.Text;
                et.DiaChi = txtDiaChi.Text;
                et.SDT = double.Parse(txtSDT.Text);
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
                {
                    MessageBox.Show("SĐT Từ 10 Đến 11 Kí Tự Số");
                    return;
                }
                et.Email = txtEmail.Text;

                bll.ThemDG(et);
                MessageBox.Show("Bạn Đã Thêm Thành Công!");
                txtMaDG.Focus();
                HThiDuLieu("");
            }
            else
            {
                MessageBox.Show("Độc Giả Này Đã Tồn Tại!");
                txtMaDG.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoTenDG.Text == "" || cboGioiTinh.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
                return;
            }
            et.MaDG = txtMaDG.Text;
            et.HoTenDG = txtHoTenDG.Text;
            et.GioiTinh = cboGioiTinh.Text;
            et.DiaChi=txtDiaChi.Text;           
            et.SDT = double.Parse(txtSDT.Text);
            if (txtSDT.Text.Length < 9 || txtSDT.Text.Length > 10)
            {
                MessageBox.Show("SĐT Từ 9 Đến 10 Kí Tự Số");
                return;
            }
            et.Email = txtEmail.Text;
            bll.SuaDG(et);
            MessageBox.Show("Bạn Đã Sửa Thành Công!");
            txtMaDG.Focus();
            HThiDuLieu("");
            LamMoi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDG.Text == "" || txtHoTenDG.Text == "" || cboGioiTinh.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn gì!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                et.MaDG = txtMaDG.Text;
                bll.XoaDG(txtMaDG.Text);
                DialogResult xn = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xn == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn đã xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HThiDuLieu("");
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaDG.Text = dgvDG[0, dong].Value.ToString();
            txtHoTenDG.Text = dgvDG[1, dong].Value.ToString();
            cboGioiTinh.Text = dgvDG[2, dong].Value.ToString();
            txtDiaChi.Text = dgvDG[3, dong].Value.ToString();
            txtSDT.Text = dgvDG[4, dong].Value.ToString();
            txtEmail.Text = dgvDG[5, dong].Value.ToString();
            txtMaDG.Enabled = false;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Điện thoại là kí tự số ", "Thông Báo ");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (cboMahayTen.Text == "Mã")
            {
                dgvDG.DataSource = dah.GetDataTable("select * from tblDOCGIA where MADG like '%" + txtTuKhoa.Text.Trim() + "%'");
            }
            else if (cboMahayTen.Text == "Họ Tên")
            {
                dgvDG.DataSource = dah.GetDataTable("select * from tblDOCGIA where HOTENDG like N'%" + txtTuKhoa.Text.Trim() + "%'");
            }
        }
    }
}
