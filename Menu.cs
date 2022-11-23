using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace quanlyCuaHang
{
    public class Menu
    {
        public ThucUong[] menu = new ThucUong[50];
        public int dem = 0;
        public void ThemSP(string ten, double gia)
        {
            menu[dem] = new ThucUong(ten, gia);
            dem++;
        }
        public void XoaSP(string ten)
        {
            for(int i=0;i<dem;i++)
            {
                if(menu[i].Ten == ten)
                {
                    for (int j = i; j < dem - 1; j++)
                        menu[j] = menu[j + 1];
                    dem++;
                    menu[dem] = null;
                    break;
                }
            }
        }
        public void TaoMenu()
        {
            ThemSP("Tra sua full topping", 35000);
            ThemSP("Tra sua thai", 20000);
            ThemSP("Hong tra nhiet doi", 35000);
        }
        public void XuatMenu()
        {
            for (int i = 0; i < dem; i++)
                menu[i].xuat();
        }
    }
}
