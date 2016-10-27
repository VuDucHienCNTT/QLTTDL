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
    public partial class frmNXB : Form
    {
        public frmNXB()
        {
            InitializeComponent();
        }
        KetNoi dah = new KetNoi();
        NXBDAL dal = new NXBDAL();
        NXBBLL bll = new NXBBLL();
        NXB et = new NXB();

        public void HThiDuLieu(string ht)
        {
            dgvNXB.DataSource = bll.LayDL(ht);
        }
        public void LamMoi()
        {
            txtMaNXB.Text = "";
            cboTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtWeb.Text = "";
            txtMaNXB.Enabled = true;
            txtMaNXB.Focus();
            Refresh();
        }
        private void frmNXB_Load(object sender, EventArgs e)
        {
            HThiDuLieu("");
            cboMahayTen.Text = "Tên";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text == "" || cboTenNXB.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == ""|| txtWeb.Text=="")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
                return;
            }
            if (bll.KTraMaTrung(txtMaNXB.Text.Trim()) == false)
            {
                et.MaNXB = txtMaNXB.Text;
                et.TenNXB = cboTenNXB.Text;
                et.DiaChi = txtDiaChi.Text;
                et.SDT = double.Parse(txtSDT.Text);
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
                {
                    MessageBox.Show("SĐT Từ 10 Đến 11 Kí Tự Số");
                    return;
                }
                et.Website = txtWeb.Text;
                bll.ThemNXB(et);
                MessageBox.Show("Bạn Đã Thêm Thành Công!");
                txtMaNXB.Focus();
                HThiDuLieu("");
            }
            else
            {
                MessageBox.Show("Nhà Xuất Bản Này Đã Tồn Tại!");
                txtMaNXB.Focus();
            }
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaNXB.Text = dgvNXB[0, dong].Value.ToString();
            cboTenNXB.Text = dgvNXB[1, dong].Value.ToString();
            txtDiaChi.Text = dgvNXB[2, dong].Value.ToString();
            txtSDT.Text = dgvNXB[3, dong].Value.ToString();
            txtWeb.Text = dgvNXB[4, dong].Value.ToString();
            txtMaNXB.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboTenNXB.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtWeb.Text == "")
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin!");
                return;
            }
            et.MaNXB = txtMaNXB.Text;
            et.TenNXB = cboTenNXB.Text;
            et.DiaChi = txtDiaChi.Text;
            et.SDT = double.Parse(txtSDT.Text);
            if (txtSDT.Text.Length < 9 || txtSDT.Text.Length > 10)
            {
                MessageBox.Show("SĐT Từ 9 Đến 10 Kí Tự Số");
                return;
            }
            et.Website = txtWeb.Text;
            bll.SuaNXB(et);
            MessageBox.Show("Bạn Đã Sửa Thành Công!");
            txtMaNXB.Focus();
            HThiDuLieu("");
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNXB.Text == "" || cboTenNXB.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtWeb.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn gì!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                et.MaNXB = txtMaNXB.Text;
                bll.XoaNXB(txtMaNXB.Text);
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
                MessageBox.Show(ex.Message,"Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ràng buộc textbox phải là số
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Điện thoại là kí tự số ", "Thông Báo ");
            }

            // ràng buộc textbox là chữ
            //if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Họ tên phải là kí tự chữ ", "Thông Báo ");
            //}
        }

        private void grpCTNXB_Enter(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if(cboMahayTen.Text=="Mã")
            {
                dgvNXB.DataSource = dah.GetDataTable("select * from tblNXB where MANXB like '%" + txtTuKhoa.Text.Trim() + "%'");
            }
            else if (cboMahayTen.Text == "Tên")
            {
                dgvNXB.DataSource = dah.GetDataTable("select * from tblNXB where TENNXB like N'%" + txtTuKhoa.Text.Trim() + "%'");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
