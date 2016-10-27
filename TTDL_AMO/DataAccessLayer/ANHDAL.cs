using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TTDL_AMO.Entities;
namespace TTDL_AMO.DataAccessLayer
{
    class ANHDAL
    {
        KetNoi kn = new KetNoi();
        public void ThemAnh(ANH AH)
        {
            kn.MoKetNoi();
            SqlCommand cmd = new SqlCommand("ThemAnh", KetNoi.sqlCon);// gọi thủ tục trong csdl lên
            cmd.CommandType = CommandType.StoredProcedure;//xác nhận kiểu store
            cmd.Parameters.Add(new SqlParameter("@TenAnh", AH.TenAnh.Trim()));// tạo ra 1 biến có tên @manv và gtri nhận vào là manv
            cmd.Parameters.Add(new SqlParameter("@Anh", AH.FileAnh.Trim()));
            cmd.ExecuteNonQuery();//truy vấn
            kn.DongKetNoi();//đóng kn lại
        }
        public bool KTraMaTrung(string TenAnh)
        {
            string Sql = "Select * from tblANH where TENANH='" + TenAnh + "'";
            return kn.KTraMaTrung(Sql);
        }
        public DataTable LayDL(string DieuKien)
        {
            return kn.LoadDuLieu("Select * from tblANH " + DieuKien);
        }
    }
}
