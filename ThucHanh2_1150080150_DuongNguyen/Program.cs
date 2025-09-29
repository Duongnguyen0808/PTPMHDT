using System;
using System.Windows.Forms;
using ThucHanh2_1150080150_DuongNguyen;

namespace ThucHanh2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
