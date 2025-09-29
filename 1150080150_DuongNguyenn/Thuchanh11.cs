using System;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh11
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

            // Đảm bảo mảng đã sắp xếp tăng dần
            Array.Sort(arr);

            Console.Write("Nhập số nguyên cần chèn: ");
            int x = int.Parse(Console.ReadLine());

            int[] newArr = new int[n + 1];
            int k = 0;
            bool inserted = false;

            for (int i = 0; i < n; i++)
            {
                if (!inserted && x < arr[i])
                {
                    newArr[k++] = x;
                    inserted = true;
                }
                newArr[k++] = arr[i];
            }

            if (!inserted) newArr[k] = x;

            Console.WriteLine("Mảng sau khi chèn:");
            Console.WriteLine(string.Join(" ", newArr));
        }
    }
}
