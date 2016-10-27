using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TTDL_AMO.Entities;
namespace TTDL_AMO.DataAccessLayer
{
    class PHIEUMUONDAL
    {
        KetNoi kn = new KetNoi();
        public void ThemPM(PHIEUMUON PM)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("ThemPM", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaPM", PM.MaPM.Trim()));
            cmd.Parameters.Add(new SqlParameter("@MaDG", PM.MaDG.Trim()));
            cmd.Parameters.Add(new SqlParameter("@HoTenDG", PM.HoTenDG.Trim()));
            cmd.Parameters.Add(new SqlParameter("@MaSach", PM.MaSach.Trim()));
            cmd.Parameters.Add(new SqlParameter("@NgayMuon", PM.NgayMuon.ToString()));
            cmd.Parameters.Add(new SqlParameter("@NgayTra", PM.NgayTra.ToString()));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", PM.SoLuong.ToString()));
            cmd.Parameters.Add(new SqlParameter("@SLmuon", PM.SlMuon.ToString()));
            cmd.Parameters.Add(new SqlParameter("@SLcon", PM.SlCon.ToString()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public void XoaPM(string PM)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("XoaPM", KetNoi.sqlCon);// ten proc trong csdl
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaPM", PM));
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }
        public void SuaPM(PHIEUMUON PM)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("SuaPM", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaPM", PM.MaPM.Trim()));
            cmd.Parameters.Add(new SqlParameter("@MaDG", PM.MaDG.Trim()));
            cmd.Parameters.Add(new SqlParameter("@HoTenDG", PM.HoTenDG.Trim()));
            cmd.Parameters.Add(new SqlParameter("@MaSach", PM.MaSach.Trim()));
            cmd.Parameters.Add(new SqlParameter("@NgayMuon", PM.NgayMuon.ToString()));
            cmd.Parameters.Add(new SqlParameter("@NgayTra", PM.NgayTra.ToString()));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", PM.SoLuong.ToString()));
            cmd.Parameters.Add(new SqlParameter("@SLmuon", PM.SlMuon.ToString()));
            cmd.Parameters.Add(new SqlParameter("@SLcon", PM.SlCon.ToString()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public bool KTraMaTrung(string MaPM)
        {
            string Sql = "Select * from tblPHIEUMUON where MAPM='" + MaPM + "'";
            return kn.KTraMaTrung(Sql);
        }
        public DataTable LayDL(string DieuKien)
        {
            return kn.LoadDuLieu("Select * from tblPHIEUMUON " + DieuKien);
        }
        // Lấy thông tin sách (số lượng)
        public DataTable LayThongTin_SACH(string DieuKien)
        {
            return kn.LoadDuLieu("Select MASACH,SOLUONG from tblSACH " + DieuKien);
        }
        // Lấy thông tin độc giả 
        public DataTable LayThongTin_DOCGIA(string DieuKien)
        {
            return kn.LoadDuLieu("Select MADG,HOTENDG from tblDOCGIA " + DieuKien);
        }
    }
}
