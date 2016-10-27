using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TTDL_AMO.DataAccessLayer;
using TTDL_AMO.Entities;

namespace TTDL_AMO.Bussiness
{
    public class SACHBLL
    {
        SACHDAL dal = new SACHDAL();

        public void ThemSach(SACH SACH)
        {
            dal.ThemSach(SACH);
        }
        public void XoaSach(string SACH)
        {
            dal.XoaSach(SACH);
        }
        public void SuaSach(SACH SACH)
        {
            dal.SuaSach(SACH);
        }
        public bool KTraMaTrung(string MaSach)
        {
            return dal.KTraMaTrung(MaSach);
        }
        public DataTable LayDL(string DieuKien)
        {
            return dal.LayDL(DieuKien);
        }
        // Lấy thông tin nhà xuất bản
        public DataTable LayThongTin_NXB(string DieuKien)
        {
            return dal.LayThongTin_NXB(DieuKien);
        }
    }
}
