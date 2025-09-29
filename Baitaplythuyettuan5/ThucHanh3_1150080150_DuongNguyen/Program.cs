using System;
using System.Windows.Forms;
using ThucHanh3_1150080150_DuongNguyen;

namespace ApDung3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // chạy form đăng nhập
        }
    }
}
