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
    public partial class frmPhieuMuon : Form
    {
        public frmPhieuMuon()
        {
            InitializeComponent();
        }
        KetNoi dah = new KetNoi();
        PHIEUMUONDAL dal = new PHIEUMUONDAL();
        PHIEUMUONBLL bll = new PHIEUMUONBLL();
        PHIEUMUON et = new PHIEUMUON();
        public void HThiDuLieu(string ht)
        {
            dgvPM.DataSource = bll.LayDL(ht);
            txtDocGia.Enabled = false;
            txtSoLuong.Enabled = false;
            txtSLCon.Enabled = false;
        }
        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            HThiDuLieu("");
            // lấy tt sách(so luong)
            cboMaSach.DataSource = bll.LayThongTin_SACH("");
            cboMaSach.ValueMember = "SOLUONG";
            cboMaSach.DisplayMember = "MASACH";
            // lấy tt đôc giả
            cboDocGia.DataSource = bll.LayThongTin_DOCGIA("");
            cboDocGia.ValueMember = "HOTENDG";
            cboDocGia.DisplayMember = "MADG";
        }
        public void LamMoi()
        {
            txtMaPM.Text = "";
            cboMaSach.Text = "";
            cboDocGia.Text = "";
            txtDocGia.Text = "";
            dtpNgayMuon.Text = "";
            dtpNgayTra.Text = "";
            txtSoLuong.Text = "";
            txtSLCon.Text = "";
            txtSLMuon.Text = "";
            txtMaPM.Enabled = true;
            txtSLCon.Text = "0";
            txtMaPM.Focus();
            this.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPM.Text == "" || cboMaSach.Text == "" || txtDocGia.Text==""|| cboDocGia.Text == "" || dtpNgayMuon.Text == "" || dtpNgayTra.Text == "" || txtSoLuong.Text == "" || txtSLMuon.Text=="")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
                return;
            }
            if (bll.KTraMaTrung(txtMaPM.Text.Trim()) == false)
            {
                et.MaPM= txtMaPM.Text;
                et.MaSach= cboMaSach.Text;
                et.MaDG = cboDocGia.Text;
                et.HoTenDG = txtDocGia.Text;
                et.NgayMuon = DateTime.Parse(dtpNgayMuon.Text);
                et.NgayTra = DateTime.Parse(dtpNgayTra.Text);
                et.SoLuong = int.Parse(txtSoLuong.Text);
                et.SlMuon = int.Parse(txtSLMuon.Text);
                et.SlCon = int.Parse(txtSLCon.Text);

                int SoLuong, SlMuon;
                SoLuong = Convert.ToInt32(txtSoLuong.Text);
                SlMuon = Convert.ToInt32(txtSLMuon.Text);              
                if (SoLuong - SlMuon < 0)
                {
                    MessageBox.Show("Số lượng Mượn phải ít hơn số lượng Có!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bll.ThemPM(et);
                MessageBox.Show("Bạn Đã Thêm Thành Công!");
                txtMaPM.Focus();
                HThiDuLieu("");
            }
            else
            {
                MessageBox.Show("Phiếu Mượn Này Đã Tồn Tại!");
                txtMaPM.Focus();
            }
        }

        private void dgvPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPM.Text = dgvPM[0, dong].Value.ToString();
            cboDocGia.Text = dgvPM[1, dong].Value.ToString();
            txtDocGia.Text = dgvPM[2, dong].Value.ToString();
            cboMaSach.Text = dgvPM[3, dong].Value.ToString();
            dtpNgayMuon.Text = dgvPM[4, dong].Value.ToString();
            dtpNgayTra.Text = dgvPM[5, dong].Value.ToString();
            txtSoLuong.Text = dgvPM[6, dong].Value.ToString();
            txtSLMuon.Text = dgvPM[7, dong].Value.ToString();
            txtSLCon.Text = dgvPM[8, dong].Value.ToString();
            txtMaPM.Enabled = false;
            txtDocGia.Enabled = false;
            txtSoLuong.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaSach_SelectedValueChanged(object sender, EventArgs e)
        {
            this.txtSoLuong.Text = cboMaSach.SelectedValue.ToString();
        }

        private void grpTTPM_Enter(object sender, EventArgs e)
        {

        }

        private void cboDocGia_SelectedValueChanged(object sender, EventArgs e)
        {
            this.txtDocGia.Text = cboDocGia.SelectedValue.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboMaSach.Text == "" || txtDocGia.Text == "" || cboDocGia.Text == "" || dtpNgayMuon.Text == "" || dtpNgayTra.Text == "" || txtSoLuong.Text == "" || txtSLCon.Text == "" || txtSLMuon.Text == "")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
            }
            et.MaPM = txtMaPM.Text;
            et.MaSach = cboMaSach.Text;
            et.MaDG = cboDocGia.Text;
            et.HoTenDG = txtDocGia.Text;
            et.NgayMuon = DateTime.Parse(dtpNgayMuon.Text);
            et.NgayTra = DateTime.Parse(dtpNgayTra.Text);
            et.SoLuong = int.Parse(txtSoLuong.Text);
            et.SlMuon = int.Parse(txtSLMuon.Text);
            et.SlCon = int.Parse(txtSLCon.Text);
            int SoLuong, SlMuon;
            SoLuong = Convert.ToInt32(txtSoLuong.Text);
            SlMuon = Convert.ToInt32(txtSLMuon.Text);
            if (SoLuong - SlMuon < 0)
            {
                MessageBox.Show("Số lượng Mượn phải ít hơn số lượng Có!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bll.SuaPM(et);
            MessageBox.Show("Bạn Đã Sửa Thành Công!");
            txtMaPM.Focus();
            HThiDuLieu("");
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaPM.Text==""||cboMaSach.Text == "" || txtDocGia.Text == "" || cboDocGia.Text == "" || dtpNgayMuon.Text == "" || dtpNgayTra.Text == "" || txtSoLuong.Text == "" || txtSLCon.Text == "" || txtSLMuon.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn gì!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                et.MaPM = txtMaPM.Text;
                bll.XoaPM(txtMaPM.Text);
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

        private void txtSLMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số lượng Mượn là kí tự số !", "Thông Báo ");
            }
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            dgvPM.DataSource = dah.GetDataTable("select * from tblPHIEUMUON where MAPM like '%" + txtTuKhoa.Text.Trim() + "%'");
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
                    }
    }
}
