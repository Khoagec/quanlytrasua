using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyCuaHang
{
    public enum ViTriCv
    {
        phucvu = 20,
        baove = 30,
        thungan = 50,
        quanli = 60,
        phache = 40,
    }
    public class Nhanvien : Nguoi
    {
        private ViTriCv vitri;
        private string loai;
        private int giolamviec;
        private int songaylamviec;
        private double hesoluong;
        private DateTime ngaybdlam;
        public ViTriCv Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }
        public string Loai
        {
            get { return loai; }
            set
            {
                loai = value;
            }
        }
        public int Giolamviec
        {
            get { return giolamviec; }
            set { giolamviec = value; }
        }
        public int Songaylamviec
        {
            get { return songaylamviec; }
            set { songaylamviec = value; }
        }
        public double Hesoluong
        {
            get { return hesoluong; }
            set { hesoluong = value; }
        }
        public DateTime NgayBDLam
        {
            get{return ngaybdlam;}
            set{ngaybdlam=value;}
        }
        public Nhanvien()
        { }
        public Nhanvien(string name, string sdt, string diachi, ViTriCv vitri, string loai, int giolamviec, int songaylamviec, DateTime ngaybdlam) : base(name, sdt, diachi)
        {
            this.vitri = vitri;
            this.loai = loai;
            this.giolamviec = giolamviec;
            this.songaylamviec = songaylamviec;
            this.ngaybdlam = ngaybdlam;
        }
        public int XetTangLuong()
        {
            TimeSpan DKTangLuong = new TimeSpan(60, 0, 0, 0);
            int kq = 0;
            while(DateTime.Now-NgayBDLam>=DKTangLuong)
            {
                kq += 2;
                NgayBDLam=NgayBDLam.Add(DKTangLuong);
            }
            return kq;
        }
        public double LuongTrenThang()
        {
            Hesoluong = (int)Vitri + (int)Vitri * XetTangLuong() / 100; //tang luong theo he so luong
            double luongnv= Hesoluong * giolamviec * songaylamviec;
            return luongnv;
        }
        public int XinNghi(DateTime date)
        {
            return songaylamviec - 1;
        }
        public void xuat()
        {
            Console.WriteLine("Ten nhan vien:" + this.Name);
            Console.WriteLine("So dien thoai:" + this.Sdt);
            Console.WriteLine("Diachi:" + this.Diachi);
            Console.WriteLine("Vi tri:" + this.Loai);
            Console.WriteLine("Vi tri cong viec:" + Vitri);
            Console.WriteLine("Luong/THang:" + LuongTrenThang());
            Console.WriteLine("-------------------------------");
        }
    }
}
