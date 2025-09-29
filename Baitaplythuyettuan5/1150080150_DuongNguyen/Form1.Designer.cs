using System;
using System.Windows.Forms;

namespace _1150080150_DuongNguyen
{
    public class Form1 : Form
    {
        TextBox txtA, txtB, txtKetQua;
        Button btnCong, btnTru, btnNhan, btnChia, btnXoa, btnThoat;

        public Form1()
        {
            BuildUI(); // Tự dựng giao diện
        }

        private void BuildUI()
        {
            this.Text = "Máy tính 4 phép toán";
            this.Width = 420;
            this.Height = 250;

            Label lblA = new Label() { Text = "Nhập A:", Left = 20, Top = 20, Width = 80 };
            txtA = new TextBox() { Left = 120, Top = 20, Width = 200 };

            Label lblB = new Label() { Text = "Nhập B:", Left = 20, Top = 60, Width = 80 };
            txtB = new TextBox() { Left = 120, Top = 60, Width = 200 };

            Label lblKQ = new Label() { Text = "Kết quả:", Left = 20, Top = 100, Width = 80 };
            txtKetQua = new TextBox() { Left = 120, Top = 100, Width = 200, ReadOnly = true };

            btnCong = new Button() { Text = "+", Left = 20, Top = 150, Width = 50 };
            btnTru = new Button() { Text = "-", Left = 80, Top = 150, Width = 50 };
            btnNhan = new Button() { Text = "×", Left = 140, Top = 150, Width = 50 };
            btnChia = new Button() { Text = "÷", Left = 200, Top = 150, Width = 50 };
            btnXoa = new Button() { Text = "Xóa", Left = 260, Top = 150, Width = 60 };
            btnThoat = new Button() { Text = "Thoát", Left = 330, Top = 150, Width = 60 };

            // Gắn sự kiện
            btnCong.Click += btnCong_Click;
            btnTru.Click += btnTru_Click;
            btnNhan.Click += btnNhan_Click;
            btnChia.Click += btnChia_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;

            this.Controls.AddRange(new Control[] { lblA, txtA, lblB, txtB, lblKQ, txtKetQua,
                btnCong, btnTru, btnNhan, btnChia, btnXoa, btnThoat });
        }

        private void btnCong_Click(object sender, EventArgs e) =>
            XuLy((a, b) => a + b);

        private void btnTru_Click(object sender, EventArgs e) =>
            XuLy((a, b) => a - b);

        private void btnNhan_Click(object sender, EventArgs e) =>
            XuLy((a, b) => a * b);

        private void btnChia_Click(object sender, EventArgs e) =>
            XuLy((a, b) => b == 0 ? double.NaN : a / b);

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void XuLy(Func<double, double, double> phepTinh)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double kq = phepTinh(a, b);

                if (double.IsNaN(kq))
                    MessageBox.Show("Không chia cho 0 được!");
                else
                    txtKetQua.Text = kq.ToString();
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!");
            }
        }
    }
}
