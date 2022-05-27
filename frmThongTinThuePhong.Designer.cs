
using DevExpress.XtraEditors;

namespace DoAn_QuanLiKhachSan
{
    partial class frmThongTinThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinThuePhong));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_KhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.cbl_LoaiPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.cbo_Phong = new DevExpress.XtraEditors.LookUpEdit();
            this.dtp_NgayDat = new DevExpress.XtraEditors.DateEdit();
            this.cbo_HinhThuc = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_PhieuThue = new System.Windows.Forms.DataGridView();
            this.col_MaPhieuDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HinhThucThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayGioCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_KhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbl_LoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Phong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayDat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_HinhThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuThue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 725);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.55911F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.44089F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1290, 719);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupControl1, 2);
            this.groupControl1.Controls.Add(this.tableLayoutPanel3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1284, 299);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin thuê phòng";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.labelControl4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelControl5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cbo_KhachHang, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbl_LoaiPhong, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbo_Phong, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtp_NgayDat, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbo_HinhThuc, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1280, 274);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(378, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thông tin khách hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(378, 30);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Loại phòng";
            // 
            // labelControl3
            // 
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(378, 30);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Phòng";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Them, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Sua, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Xoa, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1274, 88);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.ImageOptions.Image")));
            this.btn_Them.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Them.Location = new System.Drawing.Point(256, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(250, 82);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.ImageOptions.Image")));
            this.btn_Sua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Sua.Location = new System.Drawing.Point(512, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(250, 82);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.Image")));
            this.btn_Xoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Xoa.Location = new System.Drawing.Point(768, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(250, 82);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(3, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(378, 30);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Ngày đặt";
            // 
            // labelControl5
            // 
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(3, 147);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(378, 30);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Hình thức thuê";
            // 
            // cbo_KhachHang
            // 
            this.cbo_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_KhachHang.Location = new System.Drawing.Point(387, 3);
            this.cbo_KhachHang.Name = "cbo_KhachHang";
            this.cbo_KhachHang.Properties.AutoHeight = false;
            this.cbo_KhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_KhachHang.Size = new System.Drawing.Size(890, 30);
            this.cbo_KhachHang.TabIndex = 3;
            // 
            // cbl_LoaiPhong
            // 
            this.cbl_LoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbl_LoaiPhong.Location = new System.Drawing.Point(387, 39);
            this.cbl_LoaiPhong.Name = "cbl_LoaiPhong";
            this.cbl_LoaiPhong.Properties.AutoHeight = false;
            this.cbl_LoaiPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbl_LoaiPhong.Size = new System.Drawing.Size(890, 30);
            this.cbl_LoaiPhong.TabIndex = 4;
            this.cbl_LoaiPhong.EditValueChanged += new System.EventHandler(this.cbl_LoaiPhong_EditValueChanged);
            // 
            // cbo_Phong
            // 
            this.cbo_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Phong.Location = new System.Drawing.Point(387, 75);
            this.cbo_Phong.Name = "cbo_Phong";
            this.cbo_Phong.Properties.AutoHeight = false;
            this.cbo_Phong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_Phong.Size = new System.Drawing.Size(890, 30);
            this.cbo_Phong.TabIndex = 5;
            // 
            // dtp_NgayDat
            // 
            this.dtp_NgayDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_NgayDat.EditValue = null;
            this.dtp_NgayDat.Enabled = false;
            this.dtp_NgayDat.Location = new System.Drawing.Point(387, 111);
            this.dtp_NgayDat.Name = "dtp_NgayDat";
            this.dtp_NgayDat.Properties.AutoHeight = false;
            this.dtp_NgayDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayDat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayDat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtp_NgayDat.Size = new System.Drawing.Size(890, 30);
            this.dtp_NgayDat.TabIndex = 6;
            // 
            // cbo_HinhThuc
            // 
            this.cbo_HinhThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_HinhThuc.Location = new System.Drawing.Point(387, 147);
            this.cbo_HinhThuc.Name = "cbo_HinhThuc";
            this.cbo_HinhThuc.Properties.AutoHeight = false;
            this.cbo_HinhThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_HinhThuc.Size = new System.Drawing.Size(890, 30);
            this.cbo_HinhThuc.TabIndex = 7;
            // 
            // groupControl2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupControl2, 2);
            this.groupControl2.Controls.Add(this.dgv_PhieuThue);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 308);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1284, 408);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách phòng cho thuê";
            // 
            // dgv_PhieuThue
            // 
            this.dgv_PhieuThue.AllowUserToAddRows = false;
            this.dgv_PhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuThue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_PhieuThue.ColumnHeadersHeight = 36;
            this.dgv_PhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_PhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaPhieuDat,
            this.col_MaPhong,
            this.col_MaKH,
            this.col_HinhThucThue,
            this.col_NgayGioCheckIn});
            this.dgv_PhieuThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PhieuThue.Location = new System.Drawing.Point(2, 23);
            this.dgv_PhieuThue.Name = "dgv_PhieuThue";
            this.dgv_PhieuThue.ReadOnly = true;
            this.dgv_PhieuThue.RowHeadersWidth = 62;
            this.dgv_PhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhieuThue.Size = new System.Drawing.Size(1280, 383);
            this.dgv_PhieuThue.TabIndex = 0;
            this.dgv_PhieuThue.SelectionChanged += new System.EventHandler(this.dgv_PhieuThue_SelectionChanged);
            // 
            // col_MaPhieuDat
            // 
            this.col_MaPhieuDat.DataPropertyName = "MaPhieuThue";
            this.col_MaPhieuDat.HeaderText = "Mã phiếu đặt phòng";
            this.col_MaPhieuDat.MinimumWidth = 8;
            this.col_MaPhieuDat.Name = "col_MaPhieuDat";
            this.col_MaPhieuDat.ReadOnly = true;
            // 
            // col_MaPhong
            // 
            this.col_MaPhong.DataPropertyName = "MaPhong";
            this.col_MaPhong.HeaderText = "Mã phòng";
            this.col_MaPhong.MinimumWidth = 8;
            this.col_MaPhong.Name = "col_MaPhong";
            this.col_MaPhong.ReadOnly = true;
            // 
            // col_MaKH
            // 
            this.col_MaKH.DataPropertyName = "MaKH";
            this.col_MaKH.HeaderText = "Mã khách hàng";
            this.col_MaKH.MinimumWidth = 8;
            this.col_MaKH.Name = "col_MaKH";
            this.col_MaKH.ReadOnly = true;
            // 
            // col_HinhThucThue
            // 
            this.col_HinhThucThue.DataPropertyName = "MaHinhThuc";
            this.col_HinhThucThue.HeaderText = "Hình thức thuê";
            this.col_HinhThucThue.MinimumWidth = 8;
            this.col_HinhThucThue.Name = "col_HinhThucThue";
            this.col_HinhThucThue.ReadOnly = true;
            // 
            // col_NgayGioCheckIn
            // 
            this.col_NgayGioCheckIn.DataPropertyName = "NgayDat";
            this.col_NgayGioCheckIn.HeaderText = "Thời gian vào";
            this.col_NgayGioCheckIn.MinimumWidth = 8;
            this.col_NgayGioCheckIn.Name = "col_NgayGioCheckIn";
            this.col_NgayGioCheckIn.ReadOnly = true;
            // 
            // frmThongTinThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThongTinThuePhong";
            this.Text = "THÔNG TIN ĐẶT PHÒNG";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_KhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbl_LoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Phong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayDat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_HinhThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private SimpleButton btn_Them;
        private SimpleButton btn_Sua;
        private SimpleButton btn_Xoa;
        private GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgv_PhieuThue;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private LookUpEdit cbo_KhachHang;
        private LookUpEdit cbl_LoaiPhong;
        private LookUpEdit cbo_Phong;
        private LookUpEdit cbo_HinhThuc;
        private DateEdit dtp_NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HinhThucThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayGioCheckIn;
    }
}