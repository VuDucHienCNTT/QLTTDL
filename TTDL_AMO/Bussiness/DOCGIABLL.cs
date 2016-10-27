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
    public class DOCGIABLL
    {

        DOCGIADAL dal = new DOCGIADAL();

        public void ThemDG(DOCGIA DG)
        {
            dal.ThemDG(DG);
        }
        public void XoaDG(string DG)
        {
            dal.XoaDG(DG);
        }
        public void SuaDG(DOCGIA DG)
        {
            dal.SuaDG(DG);
        }
        public bool KTraMaTrung(string MaDG)
        {
            return dal.KTraMaTrung(MaDG);
        }
        public DataTable LayDL(string DieuKien)
        {
            return dal.LayDL(DieuKien);
        }
    }
}
