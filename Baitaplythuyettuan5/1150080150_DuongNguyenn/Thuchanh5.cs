using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh5
    {
        public static void Run()
        {
            Console.Write("Nhập vào số nguyên n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // a) Kiểm tra chẵn hay lẻ
            if (n % 2 == 0)
                Console.WriteLine("a) {0} là số chẵn.", n);
            else
                Console.WriteLine("a) {0} là số lẻ.", n);

            // b) Kiểm tra âm hay không âm
            if (n < 0)
                Console.WriteLine("b) {0} là số âm.", n);
            else
                Console.WriteLine("b) {0} là số không âm.", n);
        }
    }
}
