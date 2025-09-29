using System;
using System.Windows.Forms;
using System.Drawing;

namespace ApDung1
{
    public class Form1 : Form
    {
        TextBox txtA, txtB, txtKetQua;
        RadioButton rdoUSCLN, rdoBSCNN;
        Button btnTim, btnThoat;

        public Form1()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            this.Width = 600;
            this.Height = 300;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Group nhập dữ liệu
            GroupBox grpNhap = new GroupBox()
            {
                Text = "Nhập dữ liệu:",
                Left = 20,
                Top = 20,
                Width = 300,
                Height = 120,
                BackColor = Color.Honeydew
            };

            Label lblA = new Label() { Text = "Số nguyên a:", Left = 20, Top = 30, Width = 100 };
            txtA = new TextBox() { Left = 120, Top = 30, Width = 150 };

            Label lblB = new Label() { Text = "Số nguyên b:", Left = 20, Top = 70, Width = 100 };
            txtB = new TextBox() { Left = 120, Top = 70, Width = 150 };

            grpNhap.Controls.AddRange(new Control[] { lblA, txtA, lblB, txtB });

            // Group tùy chọn
            GroupBox grpChon = new GroupBox()
            {
                Text = "Tùy chọn:",
                Left = 340,
                Top = 20,
                Width = 200,
                Height = 120,
                BackColor = Color.Gainsboro
            };

            rdoUSCLN = new RadioButton() { Text = "USCLN", Left = 40, Top = 40, Checked = true };
            rdoBSCNN = new RadioButton() { Text = "BSCNN", Left = 40, Top = 70 };

            grpChon.Controls.AddRange(new Control[] { rdoUSCLN, rdoBSCNN });

            // Group kết quả
            GroupBox grpKQ = new GroupBox()
            {
                Text = "Kết quả:",
                Left = 20,
                Top = 150,
                Width = 520,
                Height = 80
            };

            txtKetQua = new TextBox() { Left = 20, Top = 30, Width = 350, ReadOnly = true };
            btnTim = new Button() { Text = "Tìm", Left = 390, Top = 25, Width = 100 };
            btnThoat = new Button() { Text = "Thoát", Left = 390, Top = 55, Width = 100 };

            btnTim.Click += btnTim_Click;
            btnThoat.Click += btnThoat_Click;

            grpKQ.Controls.AddRange(new Control[] { txtKetQua, btnTim, btnThoat });

            // Add vào form
            this.Controls.AddRange(new Control[] { grpNhap, grpChon, grpKQ });
        }

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

        // Hàm tính USCLN
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        // Hàm tính BSCNN
        private int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        // Sự kiện nút Tìm
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);

                if (rdoUSCLN.Checked)
                    txtKetQua.Text = $"USCLN({a},{b}) = {USCLN(a, b)}";
                else
                    txtKetQua.Text = $"BSCNN({a},{b}) = {BSCNN(a, b)}";
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        // Sự kiện nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
