using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh4
    {
        public static void Run()
        {
            Console.Write("Nhập vào năm: ");
            int nam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập vào tháng: ");
            int thang = Convert.ToInt32(Console.ReadLine());

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Tháng {0} có 31 ngày!", thang);
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Tháng {0} có 30 ngày!", thang);
                    break;

                case 2:
                    if ((nam % 400 == 0) || ((nam % 4 == 0) && (nam % 100 != 0)))
                        Console.WriteLine("Tháng 2 năm {0} có 29 ngày! (Năm nhuận)", nam);
                    else
                        Console.WriteLine("Tháng 2 năm {0} có 28 ngày!", nam);
                    break;

                default:
                    Console.WriteLine("Tháng không hợp lệ!");
                    break;
            }
        }
    }
}
