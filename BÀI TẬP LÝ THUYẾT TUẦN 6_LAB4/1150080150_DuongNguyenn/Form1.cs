using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080150_DuongNguyenn
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
            // Khi form load chưa cần làm gì
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM SinhVien", sqlCon);
                int soLuongSV = (int)sqlCmd.ExecuteScalar();

                MessageBox.Show("Số lượng sinh viên là: " + soLuongSV,
                    "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }
    }
}
