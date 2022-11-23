using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace QuanLyCuaHang
{
    class TheThanhVien
    {
        private string maThe = "";
        private DateTime ngayTao;
        public string MaThe
        {
            get { return maThe; }
        }

        public DateTime NgayTao
        {
            get { return ngayTao; }
            set { ngayTao = value; }
        }

        public TheThanhVien() { }

        public TheThanhVien(string maThe, DateTime ngayTao)
        {
            this.maThe = maThe;
            this.ngayTao = ngayTao;
        }
        public TheThanhVien(DateTime ngayTao)
        {
            this.ngayTao = ngayTao;
        }
        public string HetHan()
        {
            DateTime ngayHetHan;
            ngayHetHan = NgayTao.AddMonths(2);
            string result = "";
            if (ngayHetHan < DateTime.Now)
                result = "The da het han. Ban can tao the thanh vien moi";
            else result = "The con hieu luc den " + ngayHetHan.ToString("d");
            return result;
        }
        public void XuatThongTin()
        {
            Console.WriteLine($"Ma the: {maThe}\nNgay tao: {ngayTao.ToString("d")}\n{HetHan()}\n");
        }
    }
}