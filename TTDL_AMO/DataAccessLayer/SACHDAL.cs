using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TTDL_AMO.Entities;

namespace TTDL_AMO.DataAccessLayer
{
    class SACHDAL
    {
        KetNoi kn = new KetNoi();
        public void ThemSach(SACH SACH)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("ThemSach", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaSach", SACH.MaSach.Trim()));// tạo ra 1 biến có tên @masach và gtri nhận vào là masach
            cmd.Parameters.Add(new SqlParameter("@TenSach", SACH.TenSach.Trim()));
            cmd.Parameters.Add(new SqlParameter("@MaNXB", SACH.MaNXB.Trim()));
            cmd.Parameters.Add(new SqlParameter("@TenNXB", SACH.TenNXB.Trim()));
            cmd.Parameters.Add(new SqlParameter("@TheLoai", SACH.TheLoai.Trim()));
            cmd.Parameters.Add(new SqlParameter("@TacGia", SACH.TacGia.Trim()));
            cmd.Parameters.Add(new SqlParameter("@NgonNgu", SACH.NgonNgu.Trim()));
            cmd.Parameters.Add(new SqlParameter("@NamXuatBan", SACH.NamXuatBan.ToString()));
            cmd.Parameters.Add(new SqlParameter("@TinhTrang", SACH.TinhTrang.Trim()));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SACH.SoLuong.ToString()));
            cmd.Parameters.Add(new SqlParameter("@SoTrang", SACH.SoTrang.ToString()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public void XoaSach(string SACH)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("XoaSach", KetNoi.sqlCon);// ten proc trong csdl
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSach", SACH));
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }
        public void SuaSach(SACH SACH)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("SuaSach", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaSach", SACH.MaSach.Trim()));// tạo ra 1 biến có tên @maSACH và gtri nhận vào là masach
            cmd.Parameters.Add(new SqlParameter("@TenSach", SACH.TenSach.Trim()));
            cmd.Parameters.Add(new SqlParameter("@MaNXB", SACH.MaNXB.Trim()));
            cmd.Parameters.Add(new SqlParameter("@TenNXB", SACH.TenNXB.Trim()));
            cmd.Parameters.Add(new SqlParameter("@TheLoai", SACH.TheLoai.Trim()));
            cmd.Parameters.Add(new SqlParameter("@TacGia", SACH.TacGia.Trim()));
            cmd.Parameters.Add(new SqlParameter("@NgonNgu", SACH.NgonNgu.Trim()));
            cmd.Parameters.Add(new SqlParameter("@NamXuatBan", SACH.NamXuatBan.ToString()));
            cmd.Parameters.Add(new SqlParameter("@TinhTrang", SACH.TinhTrang.Trim()));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SACH.SoLuong.ToString()));
            cmd.Parameters.Add(new SqlParameter("@SoTrang", SACH.SoTrang.ToString()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public bool KTraMaTrung(string MaSach)
        {
            string Sql = "Select * from tblSACH where MASACH='" + MaSach + "'";
            return kn.KTraMaTrung(Sql);
        }
        public DataTable LayDL(string DieuKien)
        {
            return kn.LoadDuLieu("Select * from tblSACH " + DieuKien);
        }
        // Lấy thông tin nhà xuất bản
        public DataTable LayThongTin_NXB(string DieuKien)
        {
            return kn.LoadDuLieu("Select MANXB,TENNXB from tblNXB " + DieuKien);
        }
    }
}
