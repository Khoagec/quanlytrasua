using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyCuaHang
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime A = new DateTime(2022, 10, 23);
            DateTime B = new DateTime(2022, 10, 23);
            var aList = new List<Nguoi>
            {
                new Nguoi("Khoa","0352291310","Sai Gon"),
                new Nguoi("Khoa","0352291310","Sai Gon"),
            };
            DocGhi<Nguoi>.write(aList, "nguoi.csv");
            
            var nList = new List<Nhanvien>
            {
                new Nhanvien("Khoa","0352291310","Sai Gon",ViTriCv.phache,"parttime",4,5,A),
                new Nhanvien("Khoa","0352291310","Sai Gon",ViTriCv.thungan,"fulltiem",8,10,B),
            };
            DocGhi<Nhanvien>.write(nList, "nhanvien.csv");
            
            
            var dsnv = DocGhi<Nhanvien>.read("nhanvien.csv");
            foreach(var p in dsnv)
            {
                p.xuat();
            }
            /*
            Menu menu = new Menu();
            menu.TaoMenu();
            menu.XuatMenu();
            */
        }
    }
}
