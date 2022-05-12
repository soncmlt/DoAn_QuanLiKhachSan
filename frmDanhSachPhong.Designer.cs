
using DevExpress.XtraEditors;

namespace DoAn_QuanLiKhachSan
{
    partial class frmDanhSachPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachPhong));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.trv_DSTenPhong = new System.Windows.Forms.TreeView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_maPhong = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenPhong = new DevExpress.XtraEditors.TextEdit();
            this.txt_loaiPhong = new DevExpress.XtraEditors.TextEdit();
            this.txt_trangThai = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_capNhat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_loaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_trangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.trv_DSTenPhong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(221, 667);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tên phòng";
            // 
            // trv_DSTenPhong
            // 
            this.trv_DSTenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_DSTenPhong.Location = new System.Drawing.Point(2, 23);
            this.trv_DSTenPhong.Name = "trv_DSTenPhong";
            this.trv_DSTenPhong.Size = new System.Drawing.Size(217, 642);
            this.trv_DSTenPhong.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tableLayoutPanel1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(221, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1142, 190);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin phòng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82601F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.17399F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_maPhong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_tenPhong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_loaiPhong, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_trangThai, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 165);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(16);
            this.labelControl1.Size = new System.Drawing.Size(230, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phòng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(16);
            this.labelControl2.Size = new System.Drawing.Size(230, 35);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên phòng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(16);
            this.labelControl3.Size = new System.Drawing.Size(230, 35);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Loại phòng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(3, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Padding = new System.Windows.Forms.Padding(16);
            this.labelControl4.Size = new System.Drawing.Size(230, 36);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Trạng thái";
            // 
            // txt_maPhong
            // 
            this.txt_maPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maPhong.Location = new System.Drawing.Point(239, 3);
            this.txt_maPhong.Name = "txt_maPhong";
            this.txt_maPhong.Properties.AutoHeight = false;
            this.txt_maPhong.Size = new System.Drawing.Size(896, 35);
            this.txt_maPhong.TabIndex = 4;
            // 
            // txt_tenPhong
            // 
            this.txt_tenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tenPhong.Location = new System.Drawing.Point(239, 44);
            this.txt_tenPhong.Name = "txt_tenPhong";
            this.txt_tenPhong.Properties.AutoHeight = false;
            this.txt_tenPhong.Size = new System.Drawing.Size(896, 35);
            this.txt_tenPhong.TabIndex = 5;
            // 
            // txt_loaiPhong
            // 
            this.txt_loaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_loaiPhong.Location = new System.Drawing.Point(239, 85);
            this.txt_loaiPhong.Name = "txt_loaiPhong";
            this.txt_loaiPhong.Properties.AutoHeight = false;
            this.txt_loaiPhong.Size = new System.Drawing.Size(896, 35);
            this.txt_loaiPhong.TabIndex = 6;
            // 
            // txt_trangThai
            // 
            this.txt_trangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_trangThai.Location = new System.Drawing.Point(239, 126);
            this.txt_trangThai.Name = "txt_trangThai";
            this.txt_trangThai.Properties.AutoHeight = false;
            this.txt_trangThai.Size = new System.Drawing.Size(896, 36);
            this.txt_trangThai.TabIndex = 7;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.flowLayoutPanel1);
            this.groupControl3.Controls.Add(this.btn_capNhat);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(221, 190);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1142, 477);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Danh sách phòng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1138, 387);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_capNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_capNhat.ImageOptions.Image")));
            this.btn_capNhat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_capNhat.Location = new System.Drawing.Point(2, 23);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(1138, 65);
            this.btn_capNhat.TabIndex = 0;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // frmDanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 667);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDanhSachPhong";
            this.Text = "DANH SÁCH PHÒNG";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_loaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_trangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TreeView trv_DSTenPhong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private TextEdit txt_maPhong;
        private TextEdit txt_tenPhong;
        private TextEdit txt_loaiPhong;
        private TextEdit txt_trangThai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SimpleButton btn_capNhat;
    }
}