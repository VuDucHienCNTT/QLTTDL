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
    public class NHANVIENBLL
    {
        NHANVIENDAL dal = new NHANVIENDAL();

        public void ThemNV(NHANVIEN NV)
        {
            dal.ThemNV(NV);
        }
        public void XoaNV(string NV)
        {
            dal.XoaNV(NV);
        }
        public void SuaNV(NHANVIEN NV)
        {
            dal.SuaNV(NV);
        }
        public bool KTraMaTrung(string MaNV)
        {
            return dal.KTraMaTrung(MaNV);
        }
        public DataTable LayDL(string DieuKien)
        {
            return dal.LayDL(DieuKien);
        }
    }
}
