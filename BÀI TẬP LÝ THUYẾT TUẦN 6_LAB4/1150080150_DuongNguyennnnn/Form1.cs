using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080150_DuongNguyennnnn
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối đến SQL Server
        private string strCon =
            @"Data Source=LAPTOP-C0262QM5;Initial Catalog=Quanlybanhang;Integrated Security=True;TrustServerCertificate=True";

        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                // Lấy thông tin từ textbox
                string tenKhoa = txtNhapTenKhoa.Text.Trim();
                string maKhoa = "";

                // Gán mã khoa tương ứng
                if (tenKhoa == "Công nghệ thông tin")
                    maKhoa = "CNTT";
                else if (tenKhoa == "Cơ khí")
                    maKhoa = "CK";
                else if (tenKhoa == "Điện tử")
                    maKhoa = "DT";
                else if (tenKhoa == "Kinh tế")
                    maKhoa = "KT";
                else
                    maKhoa = "Sai rồi";

                if (maKhoa == "Sai rồi")
                {
                    MessageBox.Show("Tên khoa không hợp lệ!", "Thông báo lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng truy vấn
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM Lop WHERE MaKhoa = @maKhoa";

                // Tạo parameter
                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", SqlDbType.Char);
                parMaKhoa.Value = maKhoa;
                sqlCmd.Parameters.Add(parMaKhoa);

                // Gán kết nối
                sqlCmd.Connection = sqlCon;

                // Thực thi truy vấn
                SqlDataReader reader = sqlCmd.ExecuteReader();

                // Xóa dữ liệu cũ trên ListView (nếu có)
                lsvDanhSach.Items.Clear();

                while (reader.Read())
                {
                    // Đọc dữ liệu trong database
                    string maLop = reader.GetString(0);
                    string tenLop = reader.GetString(1);

                    // Hiển thị lên ListView
                    ListViewItem lvi = new ListViewItem(maLop);
                    lvi.SubItems.Add(tenLop);
                    lsvDanhSach.Items.Add(lvi);
                }

                // Đóng DataReader
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
