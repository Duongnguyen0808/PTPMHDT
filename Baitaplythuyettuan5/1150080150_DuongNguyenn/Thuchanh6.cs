using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh6
    {
        public static void Run()
        {
            Console.Write("Nhập chiều dài a (>0): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều rộng b (>0): ");
            double b = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Chiều dài và chiều rộng phải là số dương!");
                return;
            }

            double P = 2 * (a + b);
            double S = a * b;

            Console.WriteLine($"Chu vi hình chữ nhật: {P}");
            Console.WriteLine($"Diện tích hình chữ nhật: {S}");
        }
    }
}
