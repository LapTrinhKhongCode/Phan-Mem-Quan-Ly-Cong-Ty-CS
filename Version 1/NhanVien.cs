using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1
{
    class NhanVien
    {
        protected string MaSo, HoTen, DiaChi;

        public string _DIACHI
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }

        public string _HOTEN
        {
            get { return HoTen; }
            set { HoTen = value; }
        }

        public string _MASO
        {
            get { return MaSo; }
            set { MaSo = value; }
        }
        protected DateTime NgaySinh;

        public DateTime _NGAYSINH
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        protected double HeSoLuong, LuongCanBan;

        public double _LUONGCANBAN
        {
            get { return LuongCanBan; }
            set { LuongCanBan = value; }
        }

        public double _HESOLUONG
        {
            get { return HeSoLuong; }
            set { HeSoLuong = value; }
        }

        public NhanVien()
        {
            MaSo = "";
            this.HoTen = "";
            this.DiaChi = "";
            this.HeSoLuong = 0;
            this.LuongCanBan = 0;
        }

        public NhanVien(string maso, string hoten, string diachi, DateTime ngay, double heso, double luongcanban)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.NgaySinh = ngay;
            this.HeSoLuong = heso;
            this.LuongCanBan = luongcanban;
        }

        public NhanVien(NhanVien nv)
        {
            this.MaSo = nv.MaSo;
            this.HoTen = nv.HoTen;
            this.DiaChi = nv.DiaChi;
            this.NgaySinh = nv.NgaySinh;
            this.HeSoLuong = nv.HeSoLuong;
            this.LuongCanBan = nv.LuongCanBan;
        }

        public virtual double TinhLuong()
        {
            return 0; 
        }
    }

}
