using System;
using System.Windows.Forms;
using System.Drawing;

namespace ApDung3
{
    public class Form1 : Form
    {
        TextBox txtUser, txtPass;
        Button btnLogin, btnThoat;

        public Form1()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Đăng nhập ứng dụng";
            this.Width = 400;
            this.Height = 250;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tiêu đề
            Label lblTitle = new Label()
            {
                Text = "ĐĂNG NHẬP HỆ THỐNG",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblTitle);

            // Username
            Label lblUser = new Label() { Text = "Username:", Left = 50, Top = 70, Width = 80 };
            txtUser = new TextBox() { Left = 150, Top = 70, Width = 180 };

            // Password
            Label lblPass = new Label() { Text = "Password:", Left = 50, Top = 110, Width = 80 };
            txtPass = new TextBox() { Left = 150, Top = 110, Width = 180, PasswordChar = '*' };

            // Nút chức năng
            btnLogin = new Button() { Text = "Đăng nhập", Left = 100, Top = 160, Width = 100 };
            btnThoat = new Button() { Text = "Thoát", Left = 220, Top = 160, Width = 100 };

            btnLogin.Click += BtnLogin_Click;
            btnThoat.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] { lblUser, txtUser, lblPass, txtPass, btnLogin, btnThoat });
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Vui lòng nhập Username!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập Password!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }

            // Nếu yêu cầu chỉ check trống thì dừng ở đây
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
