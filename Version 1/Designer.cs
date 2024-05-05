using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1
{
    // kế thừa từ NhanVien
    class Designer : NhanVien
    {
        private double TienThuong;

        public double _TIENTHUONG
        {
            get { return TienThuong; }
            set { TienThuong = value; }
        }

        public Designer()
            : base()
        {
            TienThuong = 0;
        }

        public Designer(string maso, string hoten, string diachi, DateTime ngay, double heso, double luongcanban, double tienthuong)
            : base(maso, hoten, diachi, ngay, heso, luongcanban)
        {
            this.TienThuong = tienthuong;
        }

        public Designer(Designer thietke)
            : base((NhanVien)thietke)
        {
            this.TienThuong = thietke.TienThuong;
        }

        public override double TinhLuong()
        {
            return LuongCanBan * HeSoLuong + TienThuong;
        }
    }
}
