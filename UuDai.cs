using System;

namespace quanlitrasua
{
    public class UuDai
    {
        public static int Noel()
        {
            Console.WriteLine("Nhan dip Noel chung toi giam gia 7% cho cac mat hang.".ToUpper());
            return 7;
        }

        public static int SinhNhat()
        {
            Console.WriteLine("Nhan dip sinh nhat cua hang chung toi giam gia 10% cho cac mat hang.".ToUpper());
            return 10;
        }

        public static int DipHe()
        {
            Console.WriteLine("Nhan dip he chung toi giam gia 5% cho cac mat hang.".ToUpper());
            return 5;
        }

        public static bool UuDaiTheThanhViec(int SoLy) // Khuyến mãi mua 10 tặng 1
        {
            if (SoLy < 10)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}