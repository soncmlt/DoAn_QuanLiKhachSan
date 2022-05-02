
namespace DoAn_QuanLiKhachSan
{
    partial class QuanLiPhongForm
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
            this.cbo_LoaiPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbo_TrangThai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Lưu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgv_DSPhong = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TenPhong = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_LoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_TrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenPhong.Properties)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.cbo_LoaiPhong, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_TrangThai, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Sua, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Lưu, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Xoa, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_DSPhong, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_TenPhong, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1327, 703);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbo_LoaiPhong
            // 
            this.cbo_LoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_LoaiPhong.Location = new System.Drawing.Point(530, 63);
            this.cbo_LoaiPhong.Name = "cbo_LoaiPhong";
            this.cbo_LoaiPhong.Properties.AutoHeight = false;
            this.cbo_LoaiPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_LoaiPhong.Size = new System.Drawing.Size(266, 34);
            this.cbo_LoaiPhong.TabIndex = 1;
            this.cbo_LoaiPhong.ToolTip = "Loại phòng";
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_TrangThai.Location = new System.Drawing.Point(802, 63);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Properties.AutoHeight = false;
            this.cbo_TrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_TrangThai.Size = new System.Drawing.Size(266, 34);
            this.cbo_TrangThai.TabIndex = 1;
            this.cbo_TrangThai.ToolTip = "Trạng thái phòng";
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lí phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sua.Location = new System.Drawing.Point(258, 103);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(266, 44);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Lưu
            // 
            this.btn_Lưu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btn_Lưu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Lưu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lưu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lưu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Lưu.Location = new System.Drawing.Point(530, 103);
            this.btn_Lưu.Name = "btn_Lưu";
            this.btn_Lưu.Size = new System.Drawing.Size(266, 44);
            this.btn_Lưu.TabIndex = 3;
            this.btn_Lưu.Text = "Lưu";
            this.btn_Lưu.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(802, 103);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(266, 44);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // dgv_DSPhong
            // 
            this.dgv_DSPhong.AllowUserToAddRows = false;
            this.dgv_DSPhong.AllowUserToDeleteRows = false;
            this.dgv_DSPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Ten,
            this.col_Loai,
            this.col_TrangThai});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_DSPhong, 5);
            this.dgv_DSPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSPhong.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_DSPhong.Location = new System.Drawing.Point(16, 166);
            this.dgv_DSPhong.Margin = new System.Windows.Forms.Padding(16);
            this.dgv_DSPhong.Name = "dgv_DSPhong";
            this.dgv_DSPhong.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DSPhong.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DSPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSPhong.Size = new System.Drawing.Size(1295, 521);
            this.dgv_DSPhong.TabIndex = 4;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "Mã phòng";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Ten
            // 
            this.col_Ten.HeaderText = "Tên phòng";
            this.col_Ten.Name = "col_Ten";
            this.col_Ten.ReadOnly = true;
            // 
            // col_Loai
            // 
            this.col_Loai.HeaderText = "Loại phòng";
            this.col_Loai.Name = "col_Loai";
            this.col_Loai.ReadOnly = true;
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.HeaderText = "Trạng thái";
            this.col_TrangThai.Name = "col_TrangThai";
            this.col_TrangThai.ReadOnly = true;
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TenPhong.Location = new System.Drawing.Point(258, 63);
            this.txt_TenPhong.MaximumSize = new System.Drawing.Size(1000000, 50);
            this.txt_TenPhong.MinimumSize = new System.Drawing.Size(0, 25);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Properties.AutoHeight = false;
            this.txt_TenPhong.Size = new System.Drawing.Size(266, 34);
            this.txt_TenPhong.TabIndex = 0;
            this.txt_TenPhong.ToolTip = "Tên phòng";
            // 
            // QuanLiPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLiPhongForm";
            this.Text = "QuanLiPhongForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_LoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_TrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenPhong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txt_TenPhong;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_LoaiPhong;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_TrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Lưu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_DSPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TrangThai;
    }
}