using System;

namespace quanlitrasua
{
    public class Nguyenlieu
    {
        private string ten;
        private int soluong;
        private int conlai;
        private DateTime ngaynhap;
        public string Ten
        {
            get { return ten; }
        }
        public int Soluong
        {
            get { return soluong; }
        }
        public DateTime Ngaynhap
        {
            get { return ngaynhap; }
        }
        public int Conlai
        {
            get { return conlai; }
        }
        private int tien;
        private int hsd;

        public int Tien
        {
            get { return tien; }
        }
        public int HSD
        {
            get { return hsd; }
        }
        public Nguyenlieu() { }
        public Nguyenlieu(string ten, int soluong, int conlai, int tien, int hsd, DateTime ngaynhap)
        {
            this.ten = ten;
            this.soluong = soluong;
            this.conlai = conlai;
            this.tien = tien;
            this.hsd = hsd;
            this.ngaynhap = ngaynhap;
        }
        public bool KtSL()
        {
            if (this.conlai <= 0)
                return false;
            else
                return true;
        }
        public bool KtHSD()
        {
            DateTime dcurrent = DateTime.Now;
            TimeSpan time = dcurrent - this.ngaynhap;
            if (time.Days > this.hsd)
                return false;
            else
                return true;
        }
        public double Thumua()
        {
            this.conlai += this.soluong;
            int kq = this.tien * this.soluong;
            return kq;
        }


    }
}
