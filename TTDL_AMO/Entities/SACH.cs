using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTDL_AMO.Entities
{
    public class SACH
    {
        private string maSach;

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        private string tenSach;

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
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
        private string theLoai;

        public string TheLoai
        {
            get { return theLoai; }
            set { theLoai = value; }
        }
        private string tacGia;

        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        private string ngonNgu;

        public string NgonNgu
        {
            get { return ngonNgu; }
            set { ngonNgu = value; }
        }
        private int namXuatBan;

        public int NamXuatBan
        {
            get { return namXuatBan; }
            set { namXuatBan = value; }
        }
        private string tinhTrang;

        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private int soTrang;

        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }
        public SACH()
        {
        }
        public SACH(string masach,string tensach, string manxb,string tennxb, string theloai,string tacgia,string ngonngu,int namxuatban,string tinhtrang,int soluong,int sotrang)
        {
            this.maSach = masach;
            this.tenSach = tensach;
            this.maNXB = manxb;
            this.tenNXB = tennxb;
            this.theLoai = theloai;
            this.tacGia = tacgia;
            this.ngonNgu = ngonngu;
            this.namXuatBan = namxuatban;
            this.tinhTrang = tinhtrang;
            this.soLuong = soluong;
            this.soTrang = sotrang;
        }
    }
}
