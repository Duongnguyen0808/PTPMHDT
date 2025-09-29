using System;
using System.Windows.Forms;
using System.Drawing; // cần để chỉnh font, màu, align

namespace _1150080150_DuongNguyen
{
    public class Form1 : Form
    {
        TextBox txtA, txtB, txtKetQua;
        Button btnCong, btnTru, btnNhan, btnChia, btnXoa, btnThoat;

        public Form1()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Thực hành 1";
            this.Width = 600;
            this.Height = 350;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            // Label tiêu đề
            Label lblTitle = new Label()
            {
                Text = "THỰC HIỆN CÁC PHÉP TÍNH SỐ HỌC",
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 50
            };
            this.Controls.Add(lblTitle);

            // Label A
            Label lblA = new Label() { Text = "Nhập số a:", Left = 100, Top = 70, Width = 100 };
            txtA = new TextBox() { Left = 200, Top = 70, Width = 250 };

            // Label B
            Label lblB = new Label() { Text = "Nhập số b:", Left = 100, Top = 110, Width = 100 };
            txtB = new TextBox() { Left = 200, Top = 110, Width = 250 };

            // Các button phép toán
            btnCong = new Button() { Text = "Cộng", Left = 100, Top = 160, Width = 80 };
            btnTru = new Button() { Text = "Trừ", Left = 190, Top = 160, Width = 80 };
            btnNhan = new Button() { Text = "Nhân", Left = 280, Top = 160, Width = 80 };
            btnChia = new Button() { Text = "Chia", Left = 370, Top = 160, Width = 80 };

            // Label kết quả
            Label lblKQ = new Label() { Text = "Kết quả:", Left = 100, Top = 210, Width = 100 };
            txtKetQua = new TextBox() { Left = 200, Top = 210, Width = 250, ReadOnly = true };

            // Button Xóa và Thoát
            btnXoa = new Button() { Text = "Xóa", Left = 200, Top = 260, Width = 100 };
            btnThoat = new Button() { Text = "Thoát", Left = 350, Top = 260, Width = 100 };

            // Gắn sự kiện
            btnCong.Click += btnCong_Click;
            btnTru.Click += btnTru_Click;
            btnNhan.Click += btnNhan_Click;
            btnChia.Click += btnChia_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;

            // Add controls
            this.Controls.AddRange(new Control[]
            { lblA, txtA, lblB, txtB, btnCong, btnTru, btnNhan, btnChia, lblKQ, txtKetQua, btnXoa, btnThoat });
        }

        // ================== Sự kiện ==================

        private void btnCong_Click(object sender, EventArgs e) => XuLy((a, b) => a + b);
        private void btnTru_Click(object sender, EventArgs e) => XuLy((a, b) => a - b);
        private void btnNhan_Click(object sender, EventArgs e) => XuLy((a, b) => a * b);
        private void btnChia_Click(object sender, EventArgs e) =>
            XuLy((a, b) => b == 0 ? double.NaN : a / b);

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
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
