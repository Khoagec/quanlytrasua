using quanlitrasua;
using QuanLyCuaHang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyCuaHang
{
    public enum MucDoHaiLong
    {
        Tot,
        On,
        Te,
        RatTe,
    }

    public enum Hinhthucmua
    {
        Online,
        OffLine,
    }

    public enum TheThanhVienKh
    {
        Co=10,
        Khong=0,
    }

    internal class KhachHang:Nguoi
    {
        public List<KhachHang> DSden = new List<KhachHang>();
        private TheThanhVienKh thethanhvien;
        private int sldaUong;
        public int SLDaUong
        {
            get { return sldaUong; }
            set { sldaUong = value; }
        }
        public TheThanhVienKh Thethanhvien
        {
            get { return thethanhvien; }
            set { thethanhvien = value; }
        }
        public KhachHang() { }
        public KhachHang(string name, string sdt, string diachi, TheThanhVienKh thanhVien) : base(name, sdt, diachi)
        {
        }
        public void TaoTTV(string mathe, DateTime ngaytao)
        {
            TheThanhVien TheTv = new TheThanhVien(mathe, ngaytao);
            TheTv.XuatThongTin();
        }
        public void Order(ThucUong thucuong, int soluong,TheThanhVienKh a)
        {
            DateTime NgayGio = DateTime.Now;
            int SLthucUong = soluong;
            double Tongtien = thucuong.Gia * soluong;
            if (a==TheThanhVienKh.Co)
            {
                Tongtien = Tongtien * (1 - (int)TheThanhVienKh.Co / 100);
            }
            if (NgayGio.Day == 25 && NgayGio.Month == 12)
            {
                Tongtien = Tongtien * (1-(UuDai.Noel()) / 100);
            }
            // Xét Sinh Nhat 
            if (NgayGio.Day == 28 && NgayGio.Month == 4)
            {
                Tongtien = Tongtien * (1-(UuDai.SinhNhat()) / 100);

            }
            // Xet Dip He 
            if (NgayGio.Month <= 9 && NgayGio.Month >= 6)
            {
                Tongtien = Tongtien * (1-(UuDai.DipHe()) / 100);
            }
            DoanhThu.TinhDoanhThu(NgayGio, Tongtien);
        }
        public Hinhthucmua HinhThucMua(Hinhthucmua A)
        {
            return A;
        }
        public void HuyDon()
        {
            Console.WriteLine("Ban da huy don thang cong".ToUpper());
        }
        public void BungHang()
        {
            KhachHang A = new KhachHang(this.Name, this.Sdt, this.Diachi, this.Thethanhvien);
            DSden.Add(A);
            Console.WriteLine($"Khach hang {Name} da bung hang".ToUpper());
            DocGhi<KhachHang>.write(DSden, "danhsachden.csv");
        }

        public void DanhGia(MucDoHaiLong mdhl)
        {
            if (mdhl != MucDoHaiLong.Tot || mdhl != MucDoHaiLong.On)
            {
                Console.WriteLine("Chung toi se co gang khac phuc".ToUpper());
            }
            Console.WriteLine("Cam on ban da danh gia.".ToUpper());
        }
    }
}
