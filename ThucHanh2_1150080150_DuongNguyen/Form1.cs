using System;
using System.Windows.Forms;
using System.Drawing;

namespace ThucHanh2
{
    public class Form1 : Form
    {
        TextBox txtTenKH, txtThanhTien;
        CheckBox chkLayCaoRang, chkTayTrangRang, chkHanRang, chkBeRang, chkBocRang;
        NumericUpDown numHanRang, numBeRang, numBocRang;
        Button btnTinhTien, btnThoat;

        public Form1()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Phòng khám nha khoa";
            this.Width = 600;
            this.Height = 400;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tiêu đề
            Label lblTitle = new Label()
            {
                Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU",
                Font = new Font("Arial", 14, FontStyle.Bold),
                BackColor = Color.Green,
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblTitle);

            // Tên khách hàng
            Label lblTenKH = new Label() { Text = "Tên khách hàng:", Left = 20, Top = 70, Width = 120 };
            txtTenKH = new TextBox() { Left = 150, Top = 70, Width = 300 };
            this.Controls.Add(lblTenKH);
            this.Controls.Add(txtTenKH);

            // Dịch vụ
            GroupBox grpDV = new GroupBox() { Text = "Dịch vụ tại phòng khám:", Left = 20, Top = 110, Width = 540, Height = 180 };

            chkLayCaoRang = new CheckBox() { Text = "Lấy cao răng (50.000đ / 2 hàm)", Left = 20, Top = 30, Width = 250 };
            chkTayTrangRang = new CheckBox() { Text = "Tẩy trắng răng (100.000đ / 2 hàm)", Left = 20, Top = 60, Width = 280 };

            chkHanRang = new CheckBox() { Text = "Hàn răng (100.000đ / răng)", Left = 20, Top = 90, Width = 250 };
            numHanRang = new NumericUpDown() { Left = 300, Top = 90, Width = 50, Minimum = 1, Maximum = 20, Value = 1 };

            chkBeRang = new CheckBox() { Text = "Bẻ răng (10.000đ / răng)", Left = 20, Top = 120, Width = 250 };
            numBeRang = new NumericUpDown() { Left = 300, Top = 120, Width = 50, Minimum = 1, Maximum = 20, Value = 1 };

            chkBocRang = new CheckBox() { Text = "Bọc răng (1.000.000đ / răng)", Left = 20, Top = 150, Width = 250 };
            numBocRang = new NumericUpDown() { Left = 300, Top = 150, Width = 50, Minimum = 1, Maximum = 20, Value = 1 };

            grpDV.Controls.AddRange(new Control[] { chkLayCaoRang, chkTayTrangRang, chkHanRang, numHanRang, chkBeRang, numBeRang, chkBocRang, numBocRang });
            this.Controls.Add(grpDV);

            // Kết quả
            Label lblKQ = new Label() { Text = "Thành tiền:", Left = 20, Top = 310, Width = 100 };
            txtThanhTien = new TextBox() { Left = 120, Top = 310, Width = 200, ReadOnly = true };
            this.Controls.Add(lblKQ);
            this.Controls.Add(txtThanhTien);

            // Nút chức năng
            btnTinhTien = new Button() { Text = "Tính tiền", Left = 350, Top = 310, Width = 80 };
            btnThoat = new Button() { Text = "Thoát", Left = 450, Top = 310, Width = 80 };

            btnTinhTien.Click += btnTinhTien_Click;
            btnThoat.Click += (s, e) => this.Close();

            this.Controls.Add(btnTinhTien);
            this.Controls.Add(btnThoat);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!");
                txtTenKH.Focus();
                return;
            }

            double thanhTien = 0;

            if (chkLayCaoRang.Checked) thanhTien += 50000;
            if (chkTayTrangRang.Checked) thanhTien += 100000;
            if (chkHanRang.Checked) thanhTien += (int)numHanRang.Value * 100000;
            if (chkBeRang.Checked) thanhTien += (int)numBeRang.Value * 10000;
            if (chkBocRang.Checked) thanhTien += (int)numBocRang.Value * 1000000;

            txtThanhTien.Text = thanhTien.ToString("N0") + " VND";
        }
    }
}
