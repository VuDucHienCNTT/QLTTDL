using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTDL_AMO.Entities
{
    public class ANH
    {
        private string tenAnh;

        public string TenAnh
        {
            get { return tenAnh; }
            set { tenAnh = value; }
        }
        private string fileAnh;

        public string FileAnh
        {
            get { return fileAnh; }
            set { fileAnh = value; }
        }
        public ANH()
        {

        }
        public ANH(string tenanh, string fileanh)
        {
            this.tenAnh = tenanh;
            this.fileAnh = fileanh;
        }

    }
}
