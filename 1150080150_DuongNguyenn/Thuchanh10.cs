using System;
using System.IO;

namespace _1150080150_DuongNguyenn
{
    internal class Thuchanh10
    {
        public static void Run()
        {
            string filePath = "input_array.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Không tìm thấy file input_array.txt!");
                return;
            }

            string[] parts = File.ReadAllText(filePath).Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = Array.ConvertAll(parts, int.Parse);

            // Selection Sort
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                // Hoán đổi
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
