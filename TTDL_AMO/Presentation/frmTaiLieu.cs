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
    public partial class frmTaiLieu : Form
    {
        public frmTaiLieu()
        {
            InitializeComponent();
        }
        KetNoi dah = new KetNoi();
        SACHDAL dal = new SACHDAL();
        SACHBLL bll = new SACHBLL();
        SACH et = new SACH();
        public void HThiDuLieu(string ht)
        {
            dgvTaiLieu.DataSource = bll.LayDL(ht);
        }
        public void LamMoi()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cboMaNXB.Text = "";
            txtTenNXB.Text = "";
            cboTheLoai.Text = "";
            txtNamXB.Text = "";
            txtTacGia.Text = "";
            cboNgonNgu.Text = "";
            cboTinhTrang.Text = "";
            txtSoLuong.Text = "";
            txtSoTrang.Text = "";
            txtMaSach.Enabled = true;
            txtMaSach.Focus();
            this.Refresh();
        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            HThiDuLieu("");
            // lấy tt nhà xuất bản
            cboMaNXB.DataSource = bll.LayThongTin_NXB("");
            cboMaNXB.ValueMember = "TENNXB";
            cboMaNXB.DisplayMember = "MANXB";
            cboMahayTen.Text = "Tên";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "" || txtTenSach.Text == "" || cboTheLoai.Text == "" || txtNamXB.Text == "" || txtTacGia.Text == "" || cboNgonNgu.Text=="" || cboTinhTrang.Text == "" || txtSoLuong.Text == "" || txtSoTrang.Text == "")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
                return;
            }
            if (bll.KTraMaTrung(txtMaSach.Text.Trim()) == false)
            {
                et.MaSach = txtMaSach.Text;
                et.TenSach = txtTenSach.Text;
                et.MaNXB = cboMaNXB.Text;
                et.TenNXB = txtTenNXB.Text;
                et.TheLoai = cboTheLoai.Text;
                et.NamXuatBan = int.Parse(txtNamXB.Text);
                et.TacGia = txtTacGia.Text;
                et.NgonNgu = cboNgonNgu.Text;
                et.TinhTrang = cboTinhTrang.Text;
                et.SoLuong = int.Parse(txtSoLuong.Text);
                et.SoTrang = int.Parse(txtSoTrang.Text);

                bll.ThemSach(et);
                MessageBox.Show("Bạn Đã Thêm Thành Công!");
                txtMaSach.Focus();
                HThiDuLieu("");
            }
            else
            {
                MessageBox.Show("Tài Liệu Này Đã Tồn Tại!");
                txtMaSach.Focus();
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSach.Text = dgvTaiLieu[0, dong].Value.ToString();
            txtTenSach.Text = dgvTaiLieu[1, dong].Value.ToString();
            cboMaNXB.Text = dgvTaiLieu[2, dong].Value.ToString();
            txtTenNXB.Text = dgvTaiLieu[3, dong].Value.ToString();
            cboTheLoai.Text = dgvTaiLieu[4, dong].Value.ToString();
            txtTacGia.Text = dgvTaiLieu[5, dong].Value.ToString();
            cboNgonNgu.Text = dgvTaiLieu[6, dong].Value.ToString();
            txtNamXB.Text = dgvTaiLieu[7, dong].Value.ToString();
            cboTinhTrang.Text = dgvTaiLieu[8, dong].Value.ToString();
            txtSoLuong.Text = dgvTaiLieu[9, dong].Value.ToString();
            txtSoTrang.Text = dgvTaiLieu[10, dong].Value.ToString();
            txtMaSach.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaNXB_SelectedValueChanged(object sender, EventArgs e)
        {
            this.txtTenNXB.Text = cboMaNXB.SelectedValue.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "" || cboTheLoai.Text == "" || txtNamXB.Text == "" || txtTacGia.Text == "" || cboTinhTrang.Text == "" ||cboNgonNgu.Text=="" || txtSoLuong.Text == "" || txtSoTrang.Text =="")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
                return;
            }
            et.MaNXB = cboMaNXB.Text;
            et.TenNXB = txtTenNXB.Text;
            et.MaSach = txtMaSach.Text;
            et.TenSach = txtTenSach.Text;
            et.TheLoai = cboTheLoai.Text;
            et.NamXuatBan = int.Parse(txtNamXB.Text);
            et.TacGia = txtTacGia.Text;
            et.NgonNgu = cboNgonNgu.Text;
            et.TinhTrang = cboTinhTrang.Text;
            et.SoLuong = int.Parse(txtSoLuong.Text);
            et.SoTrang = int.Parse(txtSoTrang.Text);
            bll.SuaSach(et);
            MessageBox.Show("Bạn Đã Sửa Thành Công!");
            txtMaSach.Focus();
            HThiDuLieu("");
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaSach.Text == "" || txtTenSach.Text == "" || cboTheLoai.Text == "" || txtNamXB.Text == "" || txtTacGia.Text == "" || cboNgonNgu.Text == "" || cboTinhTrang.Text == "" || txtSoLuong.Text == "" || txtSoTrang.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn gì!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                et.MaSach = txtMaSach.Text;
                bll.XoaSach(txtMaSach.Text);
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

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboMahayTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (cboMahayTen.Text == "Mã")
            {
                dgvTaiLieu.DataSource = dah.GetDataTable("select MASACH,TENSACH,TENNXB,THELOAI,NAMXUATBAN,TACGIA,NGONNGU,TINHTRANG,SOLUONG,SOTRANG from tblSACH where MASACH like '%" + txtTuKhoa.Text.Trim() + "%'");
            }
            else if(cboMahayTen.Text == "Tên")
            {
                dgvTaiLieu.DataSource = dah.GetDataTable("select MASACH,TENSACH,TENNXB,THELOAI,NAMXUATBAN,TACGIA,NGONNGU,TINHTRANG,SOLUONG,SOTRANG from tblSACH where TENSACH like N'%" + txtTuKhoa.Text.Trim() + "%'");
            }
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
