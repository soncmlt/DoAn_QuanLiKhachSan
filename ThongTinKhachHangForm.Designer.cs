
namespace DoAn_QuanLiKhachSan
{
    partial class ThongTinKhachHangForm
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
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_Ten = new DevExpress.XtraEditors.TextEdit();
            this.dgv_DSKhachHang = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Lưu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_GioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.col_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSKhachHang)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GioiTinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cbo_GioiTinh, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_SDT, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Ten, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_DSKhachHang, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1327, 703);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SDT.Location = new System.Drawing.Point(530, 62);
            this.txt_SDT.MaximumSize = new System.Drawing.Size(1000000, 50);
            this.txt_SDT.MinimumSize = new System.Drawing.Size(0, 25);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.AutoHeight = false;
            this.txt_SDT.Size = new System.Drawing.Size(266, 35);
            this.txt_SDT.TabIndex = 0;
            this.txt_SDT.ToolTip = "Số điện thoại";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Ten.Location = new System.Drawing.Point(258, 62);
            this.txt_Ten.MaximumSize = new System.Drawing.Size(1000000, 50);
            this.txt_Ten.MinimumSize = new System.Drawing.Size(0, 25);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Properties.AutoHeight = false;
            this.txt_Ten.Size = new System.Drawing.Size(266, 35);
            this.txt_Ten.TabIndex = 0;
            this.txt_Ten.ToolTip = "Tên người dùng";
            // 
            // dgv_DSKhachHang
            // 
            this.dgv_DSKhachHang.AllowUserToAddRows = false;
            this.dgv_DSKhachHang.AllowUserToDeleteRows = false;
            this.dgv_DSKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Ma,
            this.col_Ten,
            this.col_SDT,
            this.col_GioiTinh});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_DSKhachHang, 5);
            this.dgv_DSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSKhachHang.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_DSKhachHang.Location = new System.Drawing.Point(16, 166);
            this.dgv_DSKhachHang.Margin = new System.Windows.Forms.Padding(16);
            this.dgv_DSKhachHang.Name = "dgv_DSKhachHang";
            this.dgv_DSKhachHang.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dgv_DSKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DSKhachHang.Size = new System.Drawing.Size(1295, 521);
            this.dgv_DSKhachHang.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Xoa, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Sua, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Lưu, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(258, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 44);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(544, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(266, 38);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sua.Location = new System.Drawing.Point(272, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(266, 38);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Lưu
            // 
            this.btn_Lưu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btn_Lưu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lưu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lưu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Lưu.Location = new System.Drawing.Point(0, 3);
            this.btn_Lưu.Name = "btn_Lưu";
            this.btn_Lưu.Size = new System.Drawing.Size(266, 38);
            this.btn_Lưu.TabIndex = 3;
            this.btn_Lưu.Text = "Lưu";
            this.btn_Lưu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lí tài khoản khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_GioiTinh.Location = new System.Drawing.Point(802, 62);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Properties.AutoHeight = false;
            this.cbo_GioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GioiTinh.Size = new System.Drawing.Size(266, 35);
            this.cbo_GioiTinh.TabIndex = 1;
            this.cbo_GioiTinh.ToolTip = "Giới tính";
            // 
            // col_Ma
            // 
            this.col_Ma.HeaderText = "Mã khách hàng";
            this.col_Ma.Name = "col_Ma";
            this.col_Ma.ReadOnly = true;
            // 
            // col_Ten
            // 
            this.col_Ten.HeaderText = "Tên khách hàng";
            this.col_Ten.Name = "col_Ten";
            this.col_Ten.ReadOnly = true;
            // 
            // col_SDT
            // 
            this.col_SDT.HeaderText = "Số điện thoại";
            this.col_SDT.Name = "col_SDT";
            this.col_SDT.ReadOnly = true;
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.HeaderText = "Giới tính";
            this.col_GioiTinh.Name = "col_GioiTinh";
            this.col_GioiTinh.ReadOnly = true;
            // 
            // ThongTinKhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongTinKhachHangForm";
            this.Text = "ThongTinKhachHangForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSKhachHang)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GioiTinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_GioiTinh;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.TextEdit txt_Ten;
        private System.Windows.Forms.DataGridView dgv_DSKhachHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Lưu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;

    }
}