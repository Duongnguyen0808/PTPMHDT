using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh7
    {
        public static void Run()
        {
            Console.Write("Nhập cạnh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            double c = double.Parse(Console.ReadLine());

            // Kiểm tra điều kiện tam giác
            if (a + b > c && a + c > b && b + c > a)
            {
                double P = a + b + c;
                double p = P / 2; // nửa chu vi
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("Ba cạnh lập thành tam giác.");
                Console.WriteLine($"Chu vi: {P}");
                Console.WriteLine($"Diện tích: {S}");
            }
            else
            {
                Console.WriteLine("Ba cạnh không lập thành tam giác!");
            }
        }
    }
}
