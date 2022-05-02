
namespace DoAn_QuanLiKhachSan
{
    partial class ThanhToanForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_DSThue = new System.Windows.Forms.DataGridView();
            this.col_MaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenPhong = new DevExpress.XtraEditors.TextEdit();
            this.cbo_HinhThucThue = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.txt_MaKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_ThoiGianThue = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_HinhThucThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ThoiGianThue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_DSThue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_TenPhong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_ThanhToan, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_ThoiGianThue, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_HinhThucThue, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_MaKH, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1327, 703);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgv_DSThue
            // 
            this.dgv_DSThue.AllowUserToAddRows = false;
            this.dgv_DSThue.AllowUserToDeleteRows = false;
            this.dgv_DSThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSThue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DSThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaThue,
            this.col_Ma,
            this.col_MaKH,
            this.col_NgayDat,
            this.col_SoNgayThue,
            this.col_TongTien});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_DSThue, 8);
            this.dgv_DSThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSThue.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_DSThue.Location = new System.Drawing.Point(16, 126);
            this.dgv_DSThue.Margin = new System.Windows.Forms.Padding(16);
            this.dgv_DSThue.Name = "dgv_DSThue";
            this.dgv_DSThue.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DSThue.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DSThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSThue.Size = new System.Drawing.Size(1295, 561);
            this.dgv_DSThue.TabIndex = 6;
            // 
            // col_MaThue
            // 
            this.col_MaThue.HeaderText = "Mã thuê";
            this.col_MaThue.Name = "col_MaThue";
            this.col_MaThue.ReadOnly = true;
            // 
            // col_Ma
            // 
            this.col_Ma.HeaderText = "Mã phòng";
            this.col_Ma.Name = "col_Ma";
            this.col_Ma.ReadOnly = true;
            // 
            // col_MaKH
            // 
            this.col_MaKH.HeaderText = "Mã khách hàng";
            this.col_MaKH.Name = "col_MaKH";
            this.col_MaKH.ReadOnly = true;
            // 
            // col_NgayDat
            // 
            this.col_NgayDat.HeaderText = "Ngày đặt";
            this.col_NgayDat.Name = "col_NgayDat";
            this.col_NgayDat.ReadOnly = true;
            // 
            // col_SoNgayThue
            // 
            this.col_SoNgayThue.HeaderText = "Số ngày thuê";
            this.col_SoNgayThue.Name = "col_SoNgayThue";
            this.col_SoNgayThue.ReadOnly = true;
            // 
            // col_TongTien
            // 
            this.col_TongTien.HeaderText = "Tổng tiền";
            this.col_TongTien.Name = "col_TongTien";
            this.col_TongTien.ReadOnly = true;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thanh toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TenPhong.Location = new System.Drawing.Point(20, 63);
            this.txt_TenPhong.MaximumSize = new System.Drawing.Size(1000000, 50);
            this.txt_TenPhong.MinimumSize = new System.Drawing.Size(0, 25);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Properties.AutoHeight = false;
            this.txt_TenPhong.Size = new System.Drawing.Size(254, 44);
            this.txt_TenPhong.TabIndex = 0;
            this.txt_TenPhong.ToolTip = "Tên phòng";
            // 
            // cbo_HinhThucThue
            // 
            this.cbo_HinhThucThue.Location = new System.Drawing.Point(540, 63);
            this.cbo_HinhThucThue.Name = "cbo_HinhThucThue";
            this.cbo_HinhThucThue.Properties.AutoHeight = false;
            this.cbo_HinhThucThue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_HinhThucThue.Size = new System.Drawing.Size(254, 44);
            this.cbo_HinhThucThue.TabIndex = 7;
            this.cbo_HinhThucThue.ToolTip = "Hình thức thuê";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThanhToan.Location = new System.Drawing.Point(1060, 63);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(254, 44);
            this.btn_ThanhToan.TabIndex = 3;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(280, 63);
            this.txt_MaKH.MaximumSize = new System.Drawing.Size(1000000, 50);
            this.txt_MaKH.MinimumSize = new System.Drawing.Size(0, 25);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Properties.AutoHeight = false;
            this.txt_MaKH.Size = new System.Drawing.Size(254, 44);
            this.txt_MaKH.TabIndex = 4;
            this.txt_MaKH.ToolTip = "Mã khách hàng";
            // 
            // txt_ThoiGianThue
            // 
            this.txt_ThoiGianThue.Location = new System.Drawing.Point(800, 63);
            this.txt_ThoiGianThue.MaximumSize = new System.Drawing.Size(1000000, 50);
            this.txt_ThoiGianThue.MinimumSize = new System.Drawing.Size(0, 25);
            this.txt_ThoiGianThue.Name = "txt_ThoiGianThue";
            this.txt_ThoiGianThue.Properties.AutoHeight = false;
            this.txt_ThoiGianThue.Size = new System.Drawing.Size(254, 44);
            this.txt_ThoiGianThue.TabIndex = 4;
            this.txt_ThoiGianThue.ToolTip = "Thời gian thuê";
            // 
            // ThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThanhToanForm";
            this.Text = "ThanhToanForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_HinhThucThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ThoiGianThue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_MaKH;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.DataGridView dgv_DSThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TongTien;
        private DevExpress.XtraEditors.TextEdit txt_TenPhong;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_HinhThucThue;
        private DevExpress.XtraEditors.TextEdit txt_ThoiGianThue;
    }
}