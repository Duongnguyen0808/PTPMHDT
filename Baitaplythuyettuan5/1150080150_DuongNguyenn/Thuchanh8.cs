using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh8
    {
        public static void Run()
        {
            Console.WriteLine("Giải phương trình bậc 2: ax^2 + bx + c = 0");

            Console.Write("Nhập a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0) // phương trình bậc 1
            {
                if (b == 0)
                    Console.WriteLine(c == 0 ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.");
                else
                    Console.WriteLine($"Phương trình có 1 nghiệm: x = {-c / b}");
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
            }
        }
    }
}
