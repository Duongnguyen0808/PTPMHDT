using ApDung1;
using System;
using System.Windows.Forms;

namespace _1150080150_DuongNguyen
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // chạy Form1
        }
    }
}
