using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TTDL_AMO.DataAccessLayer;
using TTDL_AMO.Entities;
namespace TTDL_AMO.Bussiness
{
    public class PHIEUMUONBLL
    {
        PHIEUMUONDAL dal = new PHIEUMUONDAL();

        public void ThemPM(PHIEUMUON PM)
        {
            dal.ThemPM(PM);
        }
        public void XoaPM(string PM)
        {
            dal.XoaPM(PM);
        }
        public void SuaPM(PHIEUMUON PM)
        {
            dal.SuaPM(PM);
        }
        public bool KTraMaTrung(string MaPM)
        {
            return dal.KTraMaTrung(MaPM);
        }
        public DataTable LayDL(string DieuKien)
        {
            return dal.LayDL(DieuKien);
        }
        // Lấy thông tin sách
        public DataTable LayThongTin_SACH(string DieuKien)
        {
            return dal.LayThongTin_SACH(DieuKien);
        }
        // Lấy thông tin độc giả
        public DataTable LayThongTin_DOCGIA(string DieuKien)
        {
            return dal.LayThongTin_DOCGIA(DieuKien);
        }
    }
}
