namespace DoAn_QuanLiKhachSan
{
    partial class DatPhongForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DSThue = new System.Windows.Forms.DataGridView();
            this.col_MaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_Phong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbo_KhachHang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtp_NgayDat = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Lưu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.cbo_LoaiPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Phong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_KhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayDat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayDat.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_LoaiPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_DSThue, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtp_NgayDat, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_KhachHang, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_Phong, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_LoaiPhong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1327, 703);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = " Đặt phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_DSThue
            // 
            this.dgv_DSThue.AllowUserToOrderColumns = true;
            this.dgv_DSThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSThue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DSThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaThue,
            this.col_Ma,
            this.col_MaKH,
            this.col_NgayDat,
            this.col_SoNgayThue,
            this.col_TongTien});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_DSThue, 6);
            this.dgv_DSThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSThue.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_DSThue.Location = new System.Drawing.Point(16, 166);
            this.dgv_DSThue.Margin = new System.Windows.Forms.Padding(16);
            this.dgv_DSThue.Name = "dgv_DSThue";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DSThue.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DSThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSThue.Size = new System.Drawing.Size(1295, 521);
            this.dgv_DSThue.TabIndex = 4;
            // 
            // col_MaThue
            // 
            this.col_MaThue.HeaderText = "Mã thuê";
            this.col_MaThue.Name = "col_MaThue";
            // 
            // col_Ma
            // 
            this.col_Ma.HeaderText = "Mã phòng";
            this.col_Ma.Name = "col_Ma";
            // 
            // col_MaKH
            // 
            this.col_MaKH.HeaderText = "Mã khách hàng";
            this.col_MaKH.Name = "col_MaKH";
            // 
            // col_NgayDat
            // 
            this.col_NgayDat.HeaderText = "Ngày đặt";
            this.col_NgayDat.Name = "col_NgayDat";
            // 
            // col_SoNgayThue
            // 
            this.col_SoNgayThue.HeaderText = "Số ngày thuê";
            this.col_SoNgayThue.Name = "col_SoNgayThue";
            // 
            // col_TongTien
            // 
            this.col_TongTien.HeaderText = "Tổng tiền";
            this.col_TongTien.Name = "col_TongTien";
            // 
            // cbo_Phong
            // 
            this.cbo_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Phong.Location = new System.Drawing.Point(401, 63);
            this.cbo_Phong.Name = "cbo_Phong";
            this.cbo_Phong.Properties.AutoHeight = false;
            this.cbo_Phong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_Phong.Size = new System.Drawing.Size(259, 34);
            this.cbo_Phong.TabIndex = 1;
            this.cbo_Phong.ToolTip = "Chọn mã phòng";
            // 
            // cbo_KhachHang
            // 
            this.cbo_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_KhachHang.Location = new System.Drawing.Point(666, 63);
            this.cbo_KhachHang.Name = "cbo_KhachHang";
            this.cbo_KhachHang.Properties.AutoHeight = false;
            this.cbo_KhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_KhachHang.Size = new System.Drawing.Size(259, 34);
            this.cbo_KhachHang.TabIndex = 1;
            this.cbo_KhachHang.ToolTip = "Mã khách hàng";
            // 
            // dtp_NgayDat
            // 
            this.dtp_NgayDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_NgayDat.EditValue = null;
            this.dtp_NgayDat.Location = new System.Drawing.Point(931, 63);
            this.dtp_NgayDat.Name = "dtp_NgayDat";
            this.dtp_NgayDat.Properties.AutoHeight = false;
            this.dtp_NgayDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayDat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayDat.Size = new System.Drawing.Size(259, 34);
            this.dtp_NgayDat.TabIndex = 5;
            this.dtp_NgayDat.ToolTip = "Ngày đặt";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Xoa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Lưu, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(136, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1054, 44);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btn_Lưu
            // 
            this.btn_Lưu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btn_Lưu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Lưu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lưu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lưu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Lưu.Location = new System.Drawing.Point(268, 3);
            this.btn_Lưu.Name = "btn_Lưu";
            this.btn_Lưu.Size = new System.Drawing.Size(256, 38);
            this.btn_Lưu.TabIndex = 3;
            this.btn_Lưu.Text = "Lưu";
            this.btn_Lưu.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(530, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(259, 38);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // cbo_LoaiPhong
            // 
            this.cbo_LoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_LoaiPhong.Location = new System.Drawing.Point(136, 63);
            this.cbo_LoaiPhong.Name = "cbo_LoaiPhong";
            this.cbo_LoaiPhong.Properties.AutoHeight = false;
            this.cbo_LoaiPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_LoaiPhong.Size = new System.Drawing.Size(259, 34);
            this.cbo_LoaiPhong.TabIndex = 1;
            this.cbo_LoaiPhong.ToolTip = "Chọn loại phòng";
            // 
            // DatPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatPhongForm";
            this.Text = "DatPhongForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Phong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_KhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayDat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayDat.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_LoaiPhong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Lưu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_DSThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TongTien;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_Phong;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_KhachHang;
        private DevExpress.XtraEditors.DateEdit dtp_NgayDat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_LoaiPhong;
    }
}