using ApDung4_1150080150_DuongNguyen;
using System;
using System.Windows.Forms;

namespace ApDung4
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
