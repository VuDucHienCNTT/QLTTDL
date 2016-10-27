using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TTDL_AMO.DataAccessLayer;
using TTDL_AMO.Entities;
namespace TTDL_AMO.Bussiness
{
   public class ANHBLL
    {
       ANHDAL dal = new ANHDAL();

        public void ThemAnh(ANH AH)
        {
            dal.ThemAnh(AH);
        }
        public bool KTraMaTrung(string TenAnh)
        {
            return dal.KTraMaTrung(TenAnh);
        }
        public DataTable LayDL(string DieuKien)
        {
            return dal.LayDL(DieuKien);
        }
    }
}
