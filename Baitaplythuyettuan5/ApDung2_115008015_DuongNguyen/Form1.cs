using System;
using System.Windows.Forms;
using System.Drawing;

namespace ApDung2
{
    public class Form1 : Form
    {
        TextBox txtPassword;
        DataGridView dgvLog;

        public Form1()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Security Panel";
            this.Width = 600;
            this.Height = 500;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Label + TextBox Password
            Label lblPass = new Label() { Text = "Password:", Left = 20, Top = 20, Width = 100 };
            txtPassword = new TextBox() { Left = 120, Top = 20, Width = 300, ReadOnly = true, BackColor = Color.LightGray };
            this.Controls.Add(lblPass);
            this.Controls.Add(txtPassword);

            // Label Keyboard
            Label lblKeyboard = new Label() { Text = "Keyboard:", Left = 20, Top = 70, Width = 100 };
            this.Controls.Add(lblKeyboard);

            // Tạo bàn phím số
            int x = 120, y = 100, size = 60;
            int num = 1;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Button btnNum = new Button()
                    {
                        Text = num.ToString(),
                        Left = x + col * (size + 10),
                        Top = y + row * (size + 10),
                        Width = size,
                        Height = size
                    };
                    btnNum.Click += (s, e) => txtPassword.Text += ((Button)s).Text;
                    this.Controls.Add(btnNum);
                    num++;
                }
            }

            // Nút Clear
            Button btnClear = new Button()
            {
                Text = "Clear",
                Left = x + 3 * (size + 10),
                Top = y,
                Width = size + 20,
                Height = size,
                BackColor = Color.Yellow
            };
            btnClear.Click += (s, e) => txtPassword.Clear();
            this.Controls.Add(btnClear);

            // Nút Enter
            Button btnEnter = new Button()
            {
                Text = "Enter",
                Left = x + 3 * (size + 10),
                Top = y + (size + 10),
                Width = size + 20,
                Height = size,
                BackColor = Color.LightGreen
            };
            btnEnter.Click += BtnEnter_Click;
            this.Controls.Add(btnEnter);

            // Nút Ring
            Button btnRing = new Button()
            {
                Text = "RING",
                Left = x + 3 * (size + 10),
                Top = y + 2 * (size + 10),
                Width = size + 20,
                Height = size,
                BackColor = Color.Red
            };
            btnRing.Click += (s, e) => MessageBox.Show("BÁO ĐỘNG!!!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Controls.Add(btnRing);

            // Label Log
            Label lblLog = new Label() { Text = "Login Log:", Left = 20, Top = 320, Width = 100 };
            this.Controls.Add(lblLog);

            // DataGridView Log
            dgvLog = new DataGridView()
            {
                Left = 20,
                Top = 350,
                Width = 540,
                Height = 100,
                AllowUserToAddRows = false,
                ReadOnly = true,
                ColumnCount = 3
            };
            dgvLog.Columns[0].Name = "Ngày giờ";
            dgvLog.Columns[1].Name = "Nhóm";
            dgvLog.Columns[2].Name = "Kết quả";
            this.Controls.Add(dgvLog);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text.Trim();
            string group = "Không có";
            string result = "Từ chối!";

            // Kiểm tra password
            if (pass == "1496" || pass == "2673") { group = "Phát triển công nghệ"; result = "Chấp nhận!"; }
            else if (pass == "7462") { group = "Nghiên cứu viên"; result = "Chấp nhận!"; }
            else if (pass == "8884" || pass == "3842" || pass == "3383") { group = "Thiết kế mô hình"; result = "Chấp nhận!"; }

            // Thêm log
            dgvLog.Rows.Add(DateTime.Now.ToString(), group, result);

            // Reset pass
            txtPassword.Clear();
        }
    }
}
