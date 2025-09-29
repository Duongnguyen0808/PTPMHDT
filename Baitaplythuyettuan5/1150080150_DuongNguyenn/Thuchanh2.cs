using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh2
    {
        public static void Run()
        {
            Console.Write("Nhập vào số nguyên a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập vào số nguyên b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? a : b;

            Console.WriteLine("Số lớn hơn trong 2 số là: " + max);
        }
    }
}
