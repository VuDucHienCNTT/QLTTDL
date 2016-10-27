using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TTDL_AMO.Entities
{
    public class PHIEUMUON
    {
        private string maPM;

        public string MaPM
        {
            get { return maPM; }
            set { maPM = value; }
        }
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
        private string maSach;

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        private DateTime ngayMuon;

        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }
        private DateTime ngayTra;

        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private int slMuon;

        public int SlMuon
        {
            get { return slMuon; }
            set { slMuon = value; }
        }
        private int slCon;

        public int SlCon
        {
            get { return slCon; }
            set { slCon = value; }
        }
        public PHIEUMUON()
        {

        }
        public PHIEUMUON(string mapm, string madg, string manv, string masach, DateTime ngaymuon, DateTime ngaytra,int soluong, int slmuon, int slcon)
        {
            this.maPM = mapm;
            this.maDG = madg;
            this.maSach = masach;
            this.ngayMuon = ngaymuon;
            this.ngayTra = ngaytra;
            this.soLuong = soluong;
            this.slMuon = slmuon;
            this.slCon = slcon;
        }
    }
}
