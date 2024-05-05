using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1
{
    // kế thừa từ NhanVien
    class Programmer : NhanVien
    {
        private double TienNgoaiGio;

        public double _TIENNGOAIGIO
        {
            get { return TienNgoaiGio; }
            set { TienNgoaiGio = value; }
        }

        public Programmer() : base()
        {
            TienNgoaiGio = 0;
        }

        public Programmer(string maso, string hoten, string diachi, DateTime ngay, double heso, double luongcanban, double tienngoaigio) 
            : base( maso,  hoten,  diachi,  ngay,  heso, luongcanban)
        {
            this.TienNgoaiGio = tienngoaigio;
        }

        public Programmer(Programmer laptrinh)
            : base((NhanVien)laptrinh)
        {
            this.TienNgoaiGio = laptrinh.TienNgoaiGio;
        }

        public override double TinhLuong()
        {
            return LuongCanBan * HeSoLuong + TienNgoaiGio;
        }
    }
}
