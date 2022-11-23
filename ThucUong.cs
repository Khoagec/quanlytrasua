using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyCuaHang
{
    public enum Kichco
    {
        M=0,
        L=7000,
    }
    public class ThucUong
    {
        private string ten;
        private double gia;
        private Kichco size;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public double Gia
        {
            get { return gia; }
            set
            {
                gia = value;
            }
        }
        public Kichco Size
        {
            get { return size; }
            set { size = value; }
        }
        public ThucUong(string ten, double gia)
        {
            this.Ten = ten;
            this.Gia = gia;
        }

        public ThucUong(string ten, double gia, Kichco size)
        {
            this.ten = ten;
            this.gia = gia;
            this.size = size;
        }
        public void xuat()
        {
            Console.WriteLine(this.Ten+", gia: "+ this.Gia+" vnd");
        }
    }
}
