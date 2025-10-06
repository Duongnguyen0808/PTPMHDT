namespace _1150080150_DuongNguyennnnn
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txtNhapTenKhoa;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMaLop;
        private System.Windows.Forms.ColumnHeader colTenLop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.txtNhapTenKhoa = new System.Windows.Forms.TextBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hiển thị danh sách lớp theo khoa";
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(50, 60);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(97, 16);
            this.lblTenKhoa.TabIndex = 1;
            this.lblTenKhoa.Text = "Nhập tên khoa:";
            // 
            // txtNhapTenKhoa
            // 
            this.txtNhapTenKhoa.Location = new System.Drawing.Point(160, 57);
            this.txtNhapTenKhoa.Name = "txtNhapTenKhoa";
            this.txtNhapTenKhoa.Size = new System.Drawing.Size(200, 22);
            this.txtNhapTenKhoa.TabIndex = 2;
            // 
            // btnXemDS
            // 
            this.btnXemDS.Location = new System.Drawing.Point(160, 95);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(150, 30);
            this.btnXemDS.TabIndex = 3;
            this.btnXemDS.Text = "Xem danh sách";
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLop,
            this.colTenLop});
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(50, 150);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(350, 200);
            this.lsvDanhSach.TabIndex = 4;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 100;
            // 
            // colTenLop
            // 
            this.colTenLop.Text = "Tên lớp";
            this.colTenLop.Width = 200;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTenKhoa);
            this.Controls.Add(this.txtNhapTenKhoa);
            this.Controls.Add(this.btnXemDS);
            this.Controls.Add(this.lsvDanhSach);
            this.Name = "Form1";
            this.Text = "Thực hành 4 - Parameter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
