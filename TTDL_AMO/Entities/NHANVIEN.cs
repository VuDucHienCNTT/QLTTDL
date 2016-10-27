using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTDL_AMO.Entities
{
    public class NHANVIEN
    {
        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string hotenNV;

        public string HotenNV
        {
            get { return hotenNV; }
            set { hotenNV = value; }
        }
        private string chucVu;

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
        private string boPhan;

        public string BoPhan
        {
            get
            { return boPhan; }
            set
            { boPhan = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string bangCap;

        public string BangCap
        {
            get
            {
                return bangCap;
            }

            set
            {
                bangCap = value;
            }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string danToc;

        public string DanToc
        {
            get
            {
                return danToc;
            }

            set
            {
                danToc = value;
            }
        }
        private double sDT;

        public double SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        public double TheATM
        {
            get
            {
                return theATM;
            }

            set
            {
                theATM = value;
            }
        }

        private double theATM;


        public NHANVIEN()
        {
        }
        public NHANVIEN(string manv, string hotennv, string chucvu, string bophan, string gioitinh, DateTime ngaysinh, string bangcap, string diachi, string dantoc, double sdt, double theatm)
        {
            this.maNV = manv;
            this.hotenNV = hotennv;
            this.chucVu = chucvu;
            this.boPhan = bophan;
            this.gioiTinh = gioitinh;
            this.ngaySinh = ngaysinh;
            this.bangCap = bangcap;
            this.diaChi = diachi;
            this.danToc = dantoc;
            this.sDT = sdt;
            this.theATM = theatm;
        }
    }
}
