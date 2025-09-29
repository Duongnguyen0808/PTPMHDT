using System;
using System.Windows.Forms;
using System.Drawing;

namespace ApDung4
{
    public class Form1 : Form
    {
        ListBox lstMatHang, lstDaChon;
        Button btnChon1, btnChonAll, btnTra1, btnTraAll;

        public Form1()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Bài tập 7 - Áp dụng 4";
            this.Width = 700;
            this.Height = 400;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Label tiêu đề cho 2 ListBox
            Label lblDanhSach = new Label()
            {
                Text = "Danh sách các mặt hàng",
                Left = 50,
                Top = 20,
                Width = 200
            };
            Label lblDaChon = new Label()
            {
                Text = "Các mặt hàng lựa chọn",
                Left = 400,
                Top = 20,
                Width = 200
            };

            // ListBox trái
            lstMatHang = new ListBox()
            {
                Left = 50,
                Top = 50,
                Width = 250,
                Height = 250,
                SelectionMode = SelectionMode.MultiExtended
            };
            lstMatHang.Items.AddRange(new string[]
            {
                "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "NIC", "FAN"
            });

            // ListBox phải
            lstDaChon = new ListBox()
            {
                Left = 400,
                Top = 50,
                Width = 250,
                Height = 250,
                SelectionMode = SelectionMode.MultiExtended
            };

            // Các nút ở giữa
            btnChon1 = new Button() { Text = ">", Left = 320, Top = 80, Width = 50 };
            btnChon1.Click += BtnChon1_Click;

            btnChonAll = new Button() { Text = ">>", Left = 320, Top = 130, Width = 50 };
            btnChonAll.Click += BtnChonAll_Click;

            btnTra1 = new Button() { Text = "<", Left = 320, Top = 180, Width = 50 };
            btnTra1.Click += BtnTra1_Click;

            btnTraAll = new Button() { Text = "<<", Left = 320, Top = 230, Width = 50 };
            btnTraAll.Click += BtnTraAll_Click;

            // Thêm tất cả control vào form
            this.Controls.AddRange(new Control[]
            {
                lblDanhSach, lblDaChon,
                lstMatHang, lstDaChon,
                btnChon1, btnChonAll, btnTra1, btnTraAll
            });
        }

        // Chuyển phần tử chọn từ trái sang phải
        private void BtnChon1_Click(object sender, EventArgs e)
        {
            var items = lstMatHang.SelectedItems;
            for (int i = items.Count - 1; i >= 0; i--)
            {
                lstDaChon.Items.Add(items[i]);
                lstMatHang.Items.Remove(items[i]);
            }
        }

        // Chuyển tất cả sang phải
        private void BtnChonAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstMatHang.Items)
                lstDaChon.Items.Add(item);
            lstMatHang.Items.Clear();
        }

        // Chuyển phần tử chọn từ phải sang trái
        private void BtnTra1_Click(object sender, EventArgs e)
        {
            var items = lstDaChon.SelectedItems;
            for (int i = items.Count - 1; i >= 0; i--)
            {
                lstMatHang.Items.Add(items[i]);
                lstDaChon.Items.Remove(items[i]);
            }
        }

        // Chuyển tất cả sang trái
        private void BtnTraAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstDaChon.Items)
                lstMatHang.Items.Add(item);
            lstDaChon.Items.Clear();
        }
    }
}
