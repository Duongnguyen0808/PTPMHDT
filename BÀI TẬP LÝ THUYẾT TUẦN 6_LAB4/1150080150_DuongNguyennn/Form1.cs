using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080150_DuongNguyennn
{
    public partial class Form1 : Form
    {
        private string strCon =
            @"Data Source=LAPTOP-C0262QM5;Initial Catalog=Quanlybanhang;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // Lấy mã sinh viên từ textbox
                string maSV = txtNhapMaSV.Text.Trim();

                // Câu truy vấn SQL
                string sql = "SELECT * FROM SinhVien WHERE MaSV = @MaSV";

                SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);
                sqlCmd.Parameters.AddWithValue("@MaSV", maSV);

                SqlDataReader reader = sqlCmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTenSV.Text = reader["TenSV"].ToString();
                    txtGioiTinh.Text = reader["GioiTinh"].ToString();
                    txtNgaySinh.Text = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy");
                    txtQueQuan.Text = reader["QueQuan"].ToString();
                    txtMaLop.Text = reader["MaLop"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã này!");
                    ClearFields();
                }

                reader.Close();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtTenSV.Clear();
            txtGioiTinh.Clear();
            txtNgaySinh.Clear();
            txtQueQuan.Clear();
            txtMaLop.Clear();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
