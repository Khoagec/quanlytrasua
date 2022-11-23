using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlitrasua
{
    public class DoanhThu
    {
        static public double[,] doanhthu = new double[31, 12];
        public static void TinhDoanhThu(DateTime dcurrent, double tien)
        {
            int d = dcurrent.Day;
            int m = dcurrent.Month;
            doanhthu[d, m] += tien;
        }
        public void TongKetNgay(DateTime dcurrent)
        {
            int d = dcurrent.Day;
            int m = dcurrent.Month;
            CultureInfo viVN = new CultureInfo("vi-VN");
            Console.WriteLine("Doanh thu cua ngay {0} la: {1}", dcurrent, doanhthu[d, m]);
        }
        public double DoanhthuThang(int month)
        {
            double kq = 0;
            for (int i = 0; i < 31; i++)
                kq = kq + doanhthu[i, month];
            Console.WriteLine("Doanh thu thang {0} la: {1}", month, kq);
            return kq;
        }
        public void TongKetThang(int month)
        {
            Console.WriteLine("Doanh thu thang {0} la: {1}", month, DoanhthuThang(month));
        }
        public double DoanhthuQuy(int q)
        {
            int temp = (q - 1) * 3;
            double kq = 0;
            for (int i = 1; i <= 3; i++)
            {
                kq = kq + DoanhthuThang(temp + i);
            }
            return kq;
        }
        public void TongKetQuy(int quy)
        {
            Console.WriteLine("Doanh thu thang {0} la: {1}", quy, DoanhthuQuy(quy));
        }
    }
}