using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TTDL_AMO.Entities;

namespace TTDL_AMO.DataAccessLayer
{
    class DOCGIADAL
    {
        KetNoi kn = new KetNoi();
        public void ThemDG(DOCGIA DG)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("ThemDG", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaDG", DG.MaDG.Trim()));// tạo ra 1 biến có tên @manv và gtri nhận vào là manv
            cmd.Parameters.Add(new SqlParameter("@HoTenDG", DG.HoTenDG.Trim()));           
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", DG.GioiTinh.Trim()));
            cmd.Parameters.Add(new SqlParameter("@DiaChiDG", DG.DiaChi.Trim()));
            cmd.Parameters.Add(new SqlParameter("@Sdt", DG.SDT.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Email", DG.Email.Trim()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public void XoaDG(string DG)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("XoaDG", KetNoi.sqlCon);// ten proc trong csdl
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaDG", DG));
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }
        public void SuaDG(DOCGIA DG)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("SuaDG", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaDG", DG.MaDG.Trim()));
            cmd.Parameters.Add(new SqlParameter("@HoTenDG", DG.HoTenDG.Trim()));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", DG.GioiTinh.Trim()));
            cmd.Parameters.Add(new SqlParameter("@DiaChiDG", DG.DiaChi.Trim()));
            cmd.Parameters.Add(new SqlParameter("@Sdt", DG.SDT.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Email", DG.Email.Trim()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public bool KTraMaTrung(string MaDG)
        {
            string Sql = "Select * from tblDOCGIA where MADG='" + MaDG + "'";
            return kn.KTraMaTrung(Sql);
        }
        public DataTable LayDL(string DieuKien)
        {
            return kn.LoadDuLieu("Select * from tblDOCGIA " + DieuKien);
        }
    }
}
