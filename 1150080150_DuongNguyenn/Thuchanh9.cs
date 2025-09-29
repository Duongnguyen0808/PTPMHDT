using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh9
    {
        public static void Run()
        {
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int x in arr) sum += x;

            Console.WriteLine("Tổng các phần tử trong mảng = " + sum);
        }
    }
}
