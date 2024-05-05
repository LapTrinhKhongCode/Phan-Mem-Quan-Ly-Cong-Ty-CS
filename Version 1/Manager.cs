using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1
{
    // kế thừa từ NhanVien
    class Manager : NhanVien
    {

        public Manager()
            : base()
        {
            
        }

        public Manager(string maso, string hoten, string diachi, DateTime ngay, double heso, double luongcanban)
            : base(maso, hoten, diachi, ngay, heso, luongcanban)
        {
            
        }

        public Manager(Manager kiemtra)
            : base((NhanVien)kiemtra)
        {
            
        }

        public override double TinhLuong()
        {
            return LuongCanBan * HeSoLuong;
        }
    }
}
