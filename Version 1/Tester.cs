using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1
{
    // kế thừa từ NhanVien
    class Tester : NhanVien
    {
        private int SoLoi;

        public int _SOLOI
        {
            get { return SoLoi; }
            set { SoLoi = value; }
        }

        public Tester()
            : base()
        {
            SoLoi = 0;
        }

        public Tester(string maso, string hoten, string diachi, DateTime ngay, double heso, double luongcanban, int soloi)
            : base(maso, hoten, diachi, ngay, heso, luongcanban)
        {
            this.SoLoi = soloi;
        }

        public Tester(Tester kiemtra)
            : base((NhanVien)kiemtra)
        {
            this.SoLoi = kiemtra.SoLoi;
        }

        public override double TinhLuong()
        {
            return LuongCanBan * HeSoLuong + SoLoi * 100000;
        }
    }
}
