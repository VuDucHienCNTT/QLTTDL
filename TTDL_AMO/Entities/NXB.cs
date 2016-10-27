using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTDL_AMO.Entities
{
    public class NXB
    {
        private string maNXB;

        public string MaNXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }
        private string tenNXB;

        public string TenNXB
        {
            get { return tenNXB; }
            set { tenNXB = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private double sDT;

        public double SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        private string website;

        public string Website
        {
            get { return website; }
            set { website = value; }
        }
        public NXB()
        {
        }
        public NXB(string manxb, string tennxb, string diachi, double sdt, string website)
        {
            this.maNXB = manxb;
            this.tenNXB = tennxb;
            this.diaChi = diachi;
            this.sDT= sdt;
            this.website = website;
        }
    }
}
