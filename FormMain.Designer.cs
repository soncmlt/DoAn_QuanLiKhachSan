
namespace DoAn_QuanLiKhachSan
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_quanLiPhong = new System.Windows.Forms.Button();
            this.btn_thongTinKhachHang = new System.Windows.Forms.Button();
            this.btn_quanLiNhanVien = new System.Windows.Forms.Button();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 712);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_quanLiPhong, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_thongTinKhachHang, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_quanLiNhanVien, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_dangXuat, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_DatPhong, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_thanhToan, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 712);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_quanLiPhong
            // 
            this.btn_quanLiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.tableLayoutPanel1.SetColumnSpan(this.btn_quanLiPhong, 2);
            this.btn_quanLiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_quanLiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quanLiPhong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLiPhong.ForeColor = System.Drawing.Color.White;
            this.btn_quanLiPhong.Location = new System.Drawing.Point(3, 119);
            this.btn_quanLiPhong.Name = "btn_quanLiPhong";
            this.btn_quanLiPhong.Size = new System.Drawing.Size(353, 74);
            this.btn_quanLiPhong.TabIndex = 0;
            this.btn_quanLiPhong.Text = "Quản lí phòng";
            this.btn_quanLiPhong.UseVisualStyleBackColor = false;
            this.btn_quanLiPhong.Click += new System.EventHandler(this.btn_quanLiPhong_Click);
            // 
            // btn_thongTinKhachHang
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_thongTinKhachHang, 2);
            this.btn_thongTinKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_thongTinKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongTinKhachHang.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongTinKhachHang.Location = new System.Drawing.Point(3, 199);
            this.btn_thongTinKhachHang.Name = "btn_thongTinKhachHang";
            this.btn_thongTinKhachHang.Size = new System.Drawing.Size(353, 74);
            this.btn_thongTinKhachHang.TabIndex = 0;
            this.btn_thongTinKhachHang.Text = "Thông tin khách hàng";
            this.btn_thongTinKhachHang.UseVisualStyleBackColor = true;
            this.btn_thongTinKhachHang.Click += new System.EventHandler(this.btn_thongTinKhachHang_Click);
            // 
            // btn_quanLiNhanVien
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_quanLiNhanVien, 2);
            this.btn_quanLiNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_quanLiNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quanLiNhanVien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLiNhanVien.Location = new System.Drawing.Point(3, 279);
            this.btn_quanLiNhanVien.Name = "btn_quanLiNhanVien";
            this.btn_quanLiNhanVien.Size = new System.Drawing.Size(353, 74);
            this.btn_quanLiNhanVien.TabIndex = 0;
            this.btn_quanLiNhanVien.Text = "Quản lí nhân viên";
            this.btn_quanLiNhanVien.UseVisualStyleBackColor = true;
            this.btn_quanLiNhanVien.Click += new System.EventHandler(this.btn_quanLiNhanVien_Click);
            // 
            // btn_thanhToan
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_thanhToan, 2);
            this.btn_thanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_thanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thanhToan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhToan.Location = new System.Drawing.Point(3, 439);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(353, 74);
            this.btn_thanhToan.TabIndex = 0;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.UseVisualStyleBackColor = true;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.tableLayoutPanel1.SetColumnSpan(this.btn_dangXuat, 2);
            this.btn_dangXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangXuat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_dangXuat.Location = new System.Drawing.Point(3, 635);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(353, 74);
            this.btn_dangXuat.TabIndex = 0;
            this.btn_dangXuat.Text = "Đăng xuất";
            this.btn_dangXuat.UseVisualStyleBackColor = false;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // btn_DatPhong
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_DatPhong, 2);
            this.btn_DatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DatPhong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatPhong.Location = new System.Drawing.Point(3, 359);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(353, 74);
            this.btn_DatPhong.TabIndex = 0;
            this.btn_DatPhong.Text = "Đặt phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = true;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 712);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_quanLiPhong;
        private System.Windows.Forms.Button btn_thongTinKhachHang;
        private System.Windows.Forms.Button btn_quanLiNhanVien;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.Button btn_dangXuat;
        private System.Windows.Forms.Button btn_DatPhong;
    }
}