using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _1150080150_DuongNguyen
{
    public partial class Form1 : Form
    {
        private DataTable dtOrder = new DataTable();
        private ComboBox cboBan;
        private DataGridView dgvOrder;

        public Form1()
        {
            InitializeComponent();
            KhoiTaoBang();
            TaoGiaoDienCoDien();
        }

        private void KhoiTaoBang()
        {
            dtOrder.Columns.Add("Tên món");
            dtOrder.Columns.Add("Số lượng", typeof(int));
        }

        private void TaoGiaoDienCoDien()
        {
            // ======= FORM =======
            this.Text = "Quán ăn nhanh Dương Nguyên";
            this.Size = new Size(720, 580);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = SystemColors.Control;

            // ======= HEADER =======
            PictureBox picLogo = new PictureBox()
            {
                Location = new Point(10, 10),
                Size = new Size(100, 80),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            // Nếu có ảnh burger.png thì dùng ảnh thật
            try
            {
                picLogo.Image = Image.FromFile("burger.png");
            }
            catch
            {
                picLogo.Image = SystemIcons.Information.ToBitmap();
            }
            this.Controls.Add(picLogo);

            Label lblTitle = new Label()
            {
                Text = "Quán ăn nhanh Dương Nguyên",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Green,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(120, 10),
                Size = new Size(570, 80)
            };
            this.Controls.Add(lblTitle);

            // ======= GROUPBOX MÓN ĂN =======
            GroupBox grpMon = new GroupBox()
            {
                Text = "Danh sách món ăn:",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 100),
                Size = new Size(680, 180)
            };
            this.Controls.Add(grpMon);

            string[] dsMon =
            {
                "Cơm chiên trứng", "Bánh mì ốp la", "Coca", "Lipton",
                "Ốc rang muối", "Khoai tây chiên", "7 up", "Cam",
                "Mỳ xào hải sản", "Cá viên chiên", "Pepsi", "Cafe",
                "Burger bò nướng", "Đùi gà rán", "Bún bò Huế"
            };

            int x = 10, y = 25, count = 0;
            foreach (string mon in dsMon)
            {
                Button btn = new Button()
                {
                    Text = mon,
                    Font = new Font("Segoe UI", 9),
                    Size = new Size(150, 35),
                    Location = new Point(x, y),
                    BackColor = SystemColors.ControlLight,
                    FlatStyle = FlatStyle.System
                };
                btn.Click += (s, e) => ThemMon(mon);
                grpMon.Controls.Add(btn);

                x += 165;
                count++;
                if (count % 4 == 0)
                {
                    x = 10;
                    y += 45;
                }
            }

            // ======= GROUPBOX THAO TÁC =======
            GroupBox grpThaoTac = new GroupBox()
            {
                Location = new Point(10, 290),
                Size = new Size(680, 55)
            };
            this.Controls.Add(grpThaoTac);

            Button btnXoa = new Button()
            {
                Text = "Xóa",
                Size = new Size(80, 30),
                Location = new Point(20, 18)
            };
            btnXoa.Click += BtnXoa_Click;
            grpThaoTac.Controls.Add(btnXoa);

            Label lblBan = new Label()
            {
                Text = "Chọn bàn:",
                Location = new Point(130, 23),
                Font = new Font("Segoe UI", 9)
            };
            grpThaoTac.Controls.Add(lblBan);

            cboBan = new ComboBox()
            {
                Location = new Point(200, 20),
                Size = new Size(120, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboBan.Items.AddRange(new string[] { "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4", "Bàn 5" });
            grpThaoTac.Controls.Add(cboBan);

            Button btnOrder = new Button()
            {
                Text = "Order",
                Size = new Size(100, 30),
                Location = new Point(340, 18)
            };
            btnOrder.Click += BtnOrder_Click;
            grpThaoTac.Controls.Add(btnOrder);

            // ======= DATAGRIDVIEW =======
            dgvOrder = new DataGridView()
            {
                Location = new Point(10, 355),
                Size = new Size(680, 160),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                BackgroundColor = Color.LightGray,
                GridColor = Color.Gray
            };
            this.Controls.Add(dgvOrder);
        }

        // ======= XỬ LÝ DỮ LIỆU =======
        private void ThemMon(string tenMon)
        {
            foreach (DataRow row in dtOrder.Rows)
            {
                if (row["Tên món"].ToString() == tenMon)
                {
                    row["Số lượng"] = (int)row["Số lượng"] + 1;
                    CapNhatBang();
                    return;
                }
            }
            dtOrder.Rows.Add(tenMon, 1);
            CapNhatBang();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null)
            {
                dgvOrder.Rows.Remove(dgvOrder.CurrentRow);
            }
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (cboBan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi Order!", "Thông báo");
                return;
            }

            string fileName = $"Order_{cboBan.Text}_{DateTime.Now:HHmmss}.txt";
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine($"Bàn: {cboBan.Text}");
                sw.WriteLine("===========================");
                foreach (DataRow row in dtOrder.Rows)
                {
                    sw.WriteLine($"{row["Tên món"]} - SL: {row["Số lượng"]}");
                }
            }

            MessageBox.Show("Đã lưu order xuống file: " + fileName, "Thành công");
            dtOrder.Rows.Clear();
            CapNhatBang();
        }

        private void CapNhatBang()
        {
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = dtOrder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
