using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh3
    {
        public static void Run()
        {
            Console.Write("Nhập vào số nguyên a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập vào số nguyên b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập vào số nguyên c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Tìm số lớn nhất trong 3 số
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine("Số lớn nhất trong 3 số là: {0}", max);
        }
    }
}
