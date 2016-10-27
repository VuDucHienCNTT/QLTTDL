using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TTDL_AMO.Entities;

namespace TTDL_AMO.DataAccessLayer
{
    class NXBDAL
    {
        KetNoi kn = new KetNoi();
        public void ThemNXB(NXB NXB)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("ThemNXB", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaNXB", NXB.MaNXB.Trim()));// tạo ra 1 biến có tên @maxb và gtri nhận vào là manxb
            cmd.Parameters.Add(new SqlParameter("@TenNXB", NXB.TenNXB.Trim()));
            cmd.Parameters.Add(new SqlParameter("@DiaChiNXB", NXB.DiaChi.Trim()));
            cmd.Parameters.Add(new SqlParameter("@Sdt", NXB.SDT.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Website", NXB.Website.Trim()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public void XoaNXB(string NXB)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("XoaNXB", KetNoi.sqlCon);// ten proc trong csdl
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNXB", NXB));
            cmd.ExecuteNonQuery();
            kn.DongKetNoi();
        }
        public void SuaNXB(NXB NXB)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("SuaNXB", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@MaNXB", NXB.MaNXB.Trim()));// tạo ra 1 biến có tên @maxb và gtri nhận vào là manxb
            cmd.Parameters.Add(new SqlParameter("@TenNXB", NXB.TenNXB.Trim()));
            cmd.Parameters.Add(new SqlParameter("@DiaChiNXB", NXB.DiaChi.Trim()));
            cmd.Parameters.Add(new SqlParameter("@Sdt", NXB.SDT.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Website", NXB.Website.Trim()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public bool KTraMaTrung(string MaNXB)
        {
            string Sql = "Select * from tblNXB where MANXB='" + MaNXB + "'";
            return kn.KTraMaTrung(Sql);
        }
        public DataTable LayDL(string DieuKien)
        {
            return kn.LoadDuLieu("Select * from tblNXB " + DieuKien);
        }
    }

}