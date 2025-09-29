using System;

namespace _1150080150_DuongNguyenn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== MENU BÀI THỰC HÀNH =====");
                Console.WriteLine("1. Thực hành 1: Chu vi, diện tích HCN (số nguyên)");
                Console.WriteLine("2. Thực hành 2: Tìm số lớn hơn (2 số)");
                Console.WriteLine("3. Thực hành 3: Tìm số lớn nhất (3 số)");
                Console.WriteLine("4. Thực hành 4: Số ngày trong tháng");
                Console.WriteLine("5. Thực hành 5: Kiểm tra số nguyên n");
                Console.WriteLine("6. Thực hành 6: Chu vi, diện tích HCN (số thực)");
                Console.WriteLine("7. Thực hành 7: Kiểm tra tam giác + chu vi + diện tích");
                Console.WriteLine("8. Thực hành 8: Giải phương trình bậc 2");
                Console.WriteLine("9. Thực hành 9: Tính tổng mảng");
                Console.WriteLine("10. Thực hành 10: Sắp xếp mảng (Selection Sort từ file)");
                Console.WriteLine("11. Thực hành 11: Chèn số vào mảng tăng dần");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn bài: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Thuchanh1.Run(); break;
                    case "2": Thuchanh2.Run(); break;
                    case "3": Thuchanh3.Run(); break;
                    case "4": Thuchanh4.Run(); break;
                    case "5": Thuchanh5.Run(); break;
                    case "6": Thuchanh6.Run(); break;
                    case "7": Thuchanh7.Run(); break;
                    case "8": Thuchanh8.Run(); break;
                    case "9": Thuchanh9.Run(); break;
                    case "10": Thuchanh10.Run(); break;
                    case "11": Thuchanh11.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey();
            }
        }
    }
}
