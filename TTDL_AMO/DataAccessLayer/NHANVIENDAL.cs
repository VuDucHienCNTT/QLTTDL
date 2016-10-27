using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TTDL_AMO.Entities;

namespace TTDL_AMO.DataAccessLayer
{
    class NHANVIENDAL
    {
        KetNoi kn = new KetNoi();
        public void ThemNV(NHANVIEN NV)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("ThemNV", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaNV", NV.MaNV.Trim()));// tạo ra 1 biến có tên @manv và gtri nhận vào là manv
            cmd.Parameters.Add(new SqlParameter("@HoTenNV", NV.HotenNV.Trim()));
            cmd.Parameters.Add(new SqlParameter("@ChucVu", NV.ChucVu.Trim()));
            cmd.Parameters.Add(new SqlParameter("@BoPhan", NV.BoPhan.Trim()));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", NV.GioiTinh.Trim()));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", NV.NgaySinh.ToString()));
            cmd.Parameters.Add(new SqlParameter("@BangCap", NV.BangCap.Trim()));
            cmd.Parameters.Add(new SqlParameter("@DiaChiNV", NV.DiaChi.Trim()));
            cmd.Parameters.Add(new SqlParameter("@DanToc", NV.DanToc.Trim()));
            cmd.Parameters.Add(new SqlParameter("@Sdt", NV.SDT.ToString()));
            cmd.Parameters.Add(new SqlParameter("@TheAtm", NV.TheATM.ToString()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public void XoaNV(string NV)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("XoaNV", KetNoi.sqlCon);// ten proc trong csdl
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNV", NV));
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }
        public void SuaNV(NHANVIEN NV)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("SuaNV", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaNV", NV.MaNV.Trim()));// tạo ra 1 biến có tên @manv và gtri nhận vào là manv
            cmd.Parameters.Add(new SqlParameter("@HoTenNV", NV.HotenNV.Trim()));
            cmd.Parameters.Add(new SqlParameter("@ChucVu", NV.ChucVu.Trim()));
            cmd.Parameters.Add(new SqlParameter("@BoPhan", NV.BoPhan.Trim()));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", NV.GioiTinh.Trim()));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", NV.NgaySinh.ToString()));
            cmd.Parameters.Add(new SqlParameter("@BangCap", NV.BangCap.Trim()));
            cmd.Parameters.Add(new SqlParameter("@DanToc", NV.DanToc.Trim()));
            cmd.Parameters.Add(new SqlParameter("@DiaChiNV", NV.DiaChi.Trim()));
            cmd.Parameters.Add(new SqlParameter("@Sdt", NV.SDT.ToString()));
            cmd.Parameters.Add(new SqlParameter("@TheAtm", NV.TheATM.ToString()));
            
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public bool KTraMaTrung(string MaNV)
        {
            string Sql = "Select * from tblNHANVIEN where MANV='" + MaNV + "'";
            return kn.KTraMaTrung(Sql);
        }
        public DataTable LayDL(string DieuKien)
        {
            return kn.LoadDuLieu("Select * from tblNHANVIEN " + DieuKien);
        }
    }
}
