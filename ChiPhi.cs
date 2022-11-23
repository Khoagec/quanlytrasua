using System;

namespace quanlitrasua
{
    public class ChiPhi
    {
        private string ten;
        private int tien;
        private static int tongluongnv;


        public static int TongLuongNV
        {
            get { return tongluongnv; }
            set { tongluongnv = value; }
        }

        public string Ten
        {
            get { return ten; }
        }
        public int Tien
        {
            get { return tien; }
        }
        public ChiPhi() { }
        public ChiPhi(string ten, int tien)
        {
            this.ten = ten;
            this.tien = tien;
        }
        public enum ChiPhiNhaO
        {
            Dien = 3000000,
            Nuoc = 400000,
            MatBang = 20000000,
        }
        public double Tinhphi()
        {
            Nguyenlieu ChiPhinl = new Nguyenlieu();
            double ChiPhiNL = ChiPhinl.Thumua();
            double ChiPhiTongTieu = (int)ChiPhiNhaO.Dien + (int)ChiPhiNhaO.Nuoc + (int)ChiPhiNhaO.MatBang + TongLuongNV + ChiPhiNL;

            return ChiPhiTongTieu;
        }



    }
}
