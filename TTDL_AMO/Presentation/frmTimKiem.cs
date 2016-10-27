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
    public partial class frmTimKiem : Form
    {

        public frmTimKiem()
        {
            InitializeComponent();
        }
        KetNoi dah = new KetNoi();
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
          
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            cboMaTen.Text ="Mã";
            cboTimKiem.Text = "Tài Liệu";
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (cboMaTen.Text == "Mã")
            {
                if (cboTimKiem.Text == "Tài Liệu")
                {
                    dgvTimKiem.DataSource = dah.GetDataTable("select * from tblSACH where MASACH like '%" + txtTuKhoa.Text.Trim() + "%'");
                }
                if (cboTimKiem.Text == "Độc Giả")
                {
                    dgvTimKiem.DataSource = dah.GetDataTable("select * from tblDOCGIA where MADG like '%" + txtTuKhoa.Text.Trim() + "%'");
                }
                if (cboTimKiem.Text == "Nhân Viên")
                {
                    dgvTimKiem.DataSource = dah.GetDataTable("select * from tblNHANVIEN where MANV like '%" + txtTuKhoa.Text.Trim() + "%'");

                }
                if (cboTimKiem.Text == "Phiếu Mượn")
                {
                    dgvTimKiem.DataSource = dah.GetDataTable("select * from tblPHIEUMUON where MAPM like '%" + txtTuKhoa.Text.Trim() + "%'");
                }
                if (cboTimKiem.Text == "Nhà Xuất Bản")
                {
                    dgvTimKiem.DataSource = dah.GetDataTable("select * from tblNXB where MANXB like '%" + txtTuKhoa.Text.Trim() + "%'");
                }
            }
            else if (cboMaTen.Text == "Tên")
            {
                if (cboTimKiem.Text == "Tài Liệu")
                {
                    dgvTimKiem.DataSource = dah.GetDataTable("select * from tblSACH where TENSACH like N'%" + txtTuKhoa.Text.Trim() + "%'");
                }
                if (cboTimKiem.Text == "Độc Giả")
                {
                    dgvTimKiem.DataSource = dah.GetDataTable("select * from tblDOCGIA where HOTENDG like N'%" + txtTuKhoa.Text.Trim() + "%'");
                }
                if (cboTimKiem.Text == "Nhân Viên")
                {
                    dgvTimKiem.DataSource = dah.GetDataTable("select * from tblNHANVIEN where HOTENNV like N'%" + txtTuKhoa.Text.Trim() + "%'");
                }
                if (cboTimKiem.Text == "Phiếu Mượn")
                {
                    MessageBox.Show("Không tìm phiếu mượn theo tên được!");
                    return;
                }
                if (cboTimKiem.Text == "Nhà Xuất Bản")
                {
                    dgvTimKiem.DataSource = dah.GetDataTable("select * from tblNXB where TENNXB like N'%" + txtTuKhoa.Text.Trim() + "%'");
                }
            }
        }

        private void cboMaTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
