using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTDL_AMO.Entities
{
    public class DOCGIA
    {
        private string maDG;

        public string MaDG
        {
            get { return maDG; }
            set { maDG = value; }
        }
        private string hoTenDG;

        public string HoTenDG
        {
            get { return hoTenDG; }
            set { hoTenDG = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
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
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DOCGIA()
        {
        }
        public DOCGIA(string madg, string hotendg,string gioitinh, string diachi, double sdt, string email)
        {
            this.maDG = madg;
            this.hoTenDG = hotendg;
            this.gioiTinh = gioitinh;
            this.email = email;
            this.diaChi = diachi;
            this.sDT = sdt;
        }
    }
}
