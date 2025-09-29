using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh1
    {
        public static void Run()
        {
            Console.Write("Nhập chiều dài a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều rộng b: ");
            double b = double.Parse(Console.ReadLine());

            double P = 2 * (a + b);
            double S = a * b;

            Console.WriteLine($"\nChu vi hình chữ nhật: {P}");
            Console.WriteLine($"Diện tích hình chữ nhật: {S}");
        }
    }
}
