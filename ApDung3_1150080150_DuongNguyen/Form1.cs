using System;
using System.Windows.Forms;
using System.Drawing;

namespace ThucHanh3
{
    public class Form1 : Form
    {
        TextBox txtNhap;
        ListBox lstSo;
        Button btnThem, btnTong, btnXoa;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Xử lý dãy số";
            this.Width = 500;
            this.Height = 400;

            Label lblNhap = new Label() { Text = "Nhập số:", Left = 20, Top = 20, Width = 80 };
            txtNhap = new TextBox() { Left = 100, Top = 20, Width = 150 };
            btnThem = new Button() { Text = "Thêm", Left = 270, Top = 20, Width = 80 };
            btnThem.Click += (s, e) =>
            {
                if (int.TryParse(txtNhap.Text, out int so))
                {
                    lstSo.Items.Add(so);
                    txtNhap.Clear();
                }
                else
                {
                    MessageBox.Show("Nhập số hợp lệ!");
                }
            };

            lstSo = new ListBox() { Left = 20, Top = 60, Width = 200, Height = 200 };

            btnTong = new Button() { Text = "Tính tổng", Left = 250, Top = 100, Width = 100 };
            btnTong.Click += (s, e) =>
            {
                int tong = 0;
                foreach (var item in lstSo.Items)
                    tong += Convert.ToInt32(item);
                MessageBox.Show("Tổng = " + tong);
            };

            btnXoa = new Button() { Text = "Xóa hết", Left = 250, Top = 150, Width = 100 };
            btnXoa.Click += (s, e) => lstSo.Items.Clear();

            this.Controls.AddRange(new Control[] { lblNhap, txtNhap, btnThem, lstSo, btnTong, btnXoa });
        }
    }
}
