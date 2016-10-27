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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        KetNoi dah = new KetNoi();
        NHANVIENDAL dal = new NHANVIENDAL();
        NHANVIENBLL bll = new NHANVIENBLL();
        NHANVIEN et = new NHANVIEN();
        public void HThiDuLieu(string ht)
        {
            dgvNV.DataSource = bll.LayDL(ht);
        }
        public void LamMoi()
        {
            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            txtChucVu.Text = "";
            txtBophan.Text = "";
            cboGioiTinh.Text = "";
            dtpNgaySinh.Text = "";
            txtBangcap.Text = "";
            txtDiaChi.Text = "";
            txtDantoc.Text = "";
            txtSDT.Text = "";
            txtTheATM.Text = "";
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
            this.Refresh();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HThiDuLieu("");
            cboMahayTen.Text = "Họ Tên";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtHoTenNV.Text == "" ||txtChucVu.Text == "" ||txtBophan.Text == ""||cboGioiTinh.Text == ""||dtpNgaySinh.Text == ""|| txtBangcap.Text==""|| txtDiaChi.Text == "" || txtDantoc.Text==""|| txtSDT.Text == "" || txtTheATM.Text=="")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
                return;
            }
            if (bll.KTraMaTrung(txtMaNV.Text.Trim()) == false)
            {
                et.MaNV = txtMaNV.Text;
                et.HotenNV = txtHoTenNV.Text;
                et.ChucVu = txtChucVu.Text;
                et.BoPhan = txtBophan.Text;
                et.GioiTinh = cboGioiTinh.Text;
                et.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                et.BangCap = txtBangcap.Text;
                et.DiaChi = txtDiaChi.Text;
                et.DanToc = txtDantoc.Text;
                et.SDT = double.Parse(txtSDT.Text);
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
                {
                    MessageBox.Show("SĐT Từ 10 Đến 11 Kí Tự Số");
                    return;
                }

                et.TheATM = double.Parse(txtTheATM.Text);
                if(txtSDT.Text.Length > 16)
                {
                    MessageBox.Show(" Số Tài Khoản ATM Không Vượt Quá 16 Số");
                    return;
                }
                bll.ThemNV(et);
                MessageBox.Show("Bạn Đã Thêm Thành Công!");
                txtMaNV.Focus();
                HThiDuLieu("");
            }
            else
            {
                MessageBox.Show("Nhân Viên Này Đã Tồn Tại!");
                txtMaNV.Focus();
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaNV.Text = dgvNV[0, dong].Value.ToString();
            txtHoTenNV.Text = dgvNV[1, dong].Value.ToString();
            txtChucVu.Text = dgvNV[2, dong].Value.ToString();
            txtBophan.Text = dgvNV[3, dong].Value.ToString();
            cboGioiTinh.Text = dgvNV[4, dong].Value.ToString();
            dtpNgaySinh.Text = dgvNV[5, dong].Value.ToString();
            txtBangcap.Text = dgvNV[6, dong].Value.ToString();
            txtDiaChi.Text = dgvNV[7, dong].Value.ToString();
            txtDantoc.Text = dgvNV[8, dong].Value.ToString();
            txtSDT.Text = dgvNV[9, dong].Value.ToString();
            txtTheATM.Text = dgvNV[10, dong].Value.ToString();
            txtMaNV.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text == "" || txtChucVu.Text == "" || txtBophan.Text == "" || cboGioiTinh.Text == "" || dtpNgaySinh.Text == "" || txtBangcap.Text == "" || txtDiaChi.Text == "" || txtDantoc.Text == "" || txtSDT.Text == "" || txtTheATM.Text == "")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
                return;
            }
            et.MaNV = txtMaNV.Text;
            et.HotenNV = txtHoTenNV.Text;
            et.ChucVu = txtChucVu.Text;
            et.BoPhan = txtBophan.Text;
            et.GioiTinh = cboGioiTinh.Text;
            et.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            et.BangCap = txtBangcap.Text;
            et.DiaChi = txtDiaChi.Text;
            et.DanToc = txtDantoc.Text;
            et.SDT = double.Parse(txtSDT.Text);
            if (txtSDT.Text.Length < 9 || txtSDT.Text.Length > 10)
            {
                MessageBox.Show("SĐT Từ 9 Đến 10 Kí Tự Số");
                return;
            }
            et.TheATM = double.Parse(txtTheATM.Text);
            if (txtSDT.Text.Length > 16)
            {
                MessageBox.Show(" Số Tài Khoản ATM Không Vượt Quá 16 Số");
                return;
            }
            bll.SuaNV(et);
            MessageBox.Show("Bạn Đã Sửa Thành Công!");
            txtMaNV.Focus();
            HThiDuLieu("");
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text == "" || txtChucVu.Text == "" || txtBophan.Text == "" || cboGioiTinh.Text == "" || dtpNgaySinh.Text == "" || txtBangcap.Text == "" || txtDiaChi.Text == "" || txtDantoc.Text == "" || txtSDT.Text == "" || txtTheATM.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn gì!");
                return;
            }
            et.MaNV = txtMaNV.Text;
            bll.XoaNV(txtMaNV.Text);
            DialogResult xn = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xn == DialogResult.Yes)
            {
                MessageBox.Show("Bạn đã xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HThiDuLieu("");
                LamMoi();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // textbox chỉ được nhập số
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
            if(cboMahayTen.Text=="Mã")
            {
                dgvNV.DataSource = dah.GetDataTable("select * from tblNHANVIEN where MANV like '%" + txtTuKhoa.Text.Trim() + "%'");
            }
            else if(cboMahayTen.Text=="Họ Tên")
            {
                dgvNV.DataSource = dah.GetDataTable("select * from tblNHANVIEN where HOTENNV like N'%" + txtTuKhoa.Text.Trim() + "%'");
            }
        }

        private void txtTheATM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số tài khoản là kí tự số ", "Thông Báo ");
            }
        }
    }
}
