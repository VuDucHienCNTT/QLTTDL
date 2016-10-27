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
    public class NXBBLL
    {
        NXBDAL dal = new NXBDAL();

        public void ThemNXB(NXB NXB)
        {
            dal.ThemNXB(NXB);
        }
        public void XoaNXB(string NXB)
        {
            dal.XoaNXB(NXB);
        }
        public void SuaNXB(NXB NXB)
        {
            dal.SuaNXB(NXB);
        }
        public bool KTraMaTrung(string MaNXB)
        {
            return dal.KTraMaTrung(MaNXB);
        }
        public DataTable LayDL(string DieuKien)
        {
            return dal.LayDL(DieuKien);
        }
    }
}
