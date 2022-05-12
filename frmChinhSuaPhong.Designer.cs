using DevExpress.XtraEditors;

namespace DoAn_QuanLiKhachSan
{
	partial class frmChinhSuaPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinhSuaPhong));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_DSLoaiPhong = new System.Windows.Forms.DataGridView();
            this.col_MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_maLoai = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenLoai = new DevExpress.XtraEditors.TextEdit();
            this.txt_soGiuong = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_themLoai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suaLoai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaLoai = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_loaiPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.cbo_TrangThai = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_themPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suaPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaPhong = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_DSPhong = new System.Windows.Forms.DataGridView();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.col_MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_maPhong = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenPhong = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLoaiPhong)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soGiuong.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_loaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_TrangThai.Properties)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1153, 667);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(8);
            this.groupControl1.Size = new System.Drawing.Size(570, 661);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin loại phòng";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgv_DSLoaiPhong);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(10, 221);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(550, 430);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Danh sách loại phòng";
            // 
            // dgv_DSLoaiPhong
            // 
            this.dgv_DSLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSLoaiPhong.ColumnHeadersHeight = 36;
            this.dgv_DSLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DSLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaLoai,
            this.col_TenLoai,
            this.col_SoGiuong});
            this.dgv_DSLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSLoaiPhong.Location = new System.Drawing.Point(2, 23);
            this.dgv_DSLoaiPhong.Name = "dgv_DSLoaiPhong";
            this.dgv_DSLoaiPhong.Size = new System.Drawing.Size(546, 405);
            this.dgv_DSLoaiPhong.TabIndex = 0;
            // 
            // col_MaLoai
            // 
            this.col_MaLoai.HeaderText = "Mã loại phòng";
            this.col_MaLoai.Name = "col_MaLoai";
            // 
            // col_TenLoai
            // 
            this.col_TenLoai.HeaderText = "Tên loại phòng";
            this.col_TenLoai.Name = "col_TenLoai";
            // 
            // col_SoGiuong
            // 
            this.col_SoGiuong.HeaderText = "Số giường";
            this.col_SoGiuong.Name = "col_SoGiuong";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_maLoai, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_tenLoai, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_soGiuong, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(550, 190);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(269, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã loại";
            // 
            // labelControl2
            // 
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(269, 30);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên loại";
            // 
            // labelControl3
            // 
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(269, 30);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Số giường";
            // 
            // txt_maLoai
            // 
            this.txt_maLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maLoai.Location = new System.Drawing.Point(278, 3);
            this.txt_maLoai.Name = "txt_maLoai";
            this.txt_maLoai.Properties.AutoHeight = false;
            this.txt_maLoai.Size = new System.Drawing.Size(269, 30);
            this.txt_maLoai.TabIndex = 1;
            // 
            // txt_tenLoai
            // 
            this.txt_tenLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tenLoai.Location = new System.Drawing.Point(278, 39);
            this.txt_tenLoai.Name = "txt_tenLoai";
            this.txt_tenLoai.Properties.AutoHeight = false;
            this.txt_tenLoai.Size = new System.Drawing.Size(269, 30);
            this.txt_tenLoai.TabIndex = 1;
            // 
            // txt_soGiuong
            // 
            this.txt_soGiuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_soGiuong.Location = new System.Drawing.Point(278, 75);
            this.txt_soGiuong.Name = "txt_soGiuong";
            this.txt_soGiuong.Properties.AutoHeight = false;
            this.txt_soGiuong.Size = new System.Drawing.Size(269, 30);
            this.txt_soGiuong.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.btn_themLoai, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_suaLoai, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_xoaLoai, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 111);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(544, 76);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_themLoai
            // 
            this.btn_themLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_themLoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_themLoai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_themLoai.Location = new System.Drawing.Point(3, 3);
            this.btn_themLoai.Name = "btn_themLoai";
            this.btn_themLoai.Size = new System.Drawing.Size(175, 70);
            this.btn_themLoai.TabIndex = 0;
            this.btn_themLoai.Text = "Thêm";
            // 
            // btn_suaLoai
            // 
            this.btn_suaLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_suaLoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_suaLoai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_suaLoai.Location = new System.Drawing.Point(184, 3);
            this.btn_suaLoai.Name = "btn_suaLoai";
            this.btn_suaLoai.Size = new System.Drawing.Size(175, 70);
            this.btn_suaLoai.TabIndex = 0;
            this.btn_suaLoai.Text = "Sửa";
            // 
            // btn_xoaLoai
            // 
            this.btn_xoaLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_xoaLoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoaLoai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_xoaLoai.Location = new System.Drawing.Point(365, 3);
            this.btn_xoaLoai.Name = "btn_xoaLoai";
            this.btn_xoaLoai.Size = new System.Drawing.Size(176, 70);
            this.btn_xoaLoai.TabIndex = 0;
            this.btn_xoaLoai.Text = "Xoá";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tableLayoutPanel4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(579, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(8);
            this.groupControl2.Size = new System.Drawing.Size(571, 661);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin phòng";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupControl4, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 31);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(551, 620);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel4.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.labelControl5, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.labelControl6, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.cbo_TrangThai, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.labelControl4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbo_loaiPhong, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelControl7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_maPhong, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_tenPhong, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(545, 226);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(3, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(266, 30);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Loại phòng";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(3, 75);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(266, 30);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tên phòng";
            // 
            // labelControl6
            // 
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(3, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(266, 30);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Trạng thái";
            // 
            // cbo_loaiPhong
            // 
            this.cbo_loaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_loaiPhong.Location = new System.Drawing.Point(275, 3);
            this.cbo_loaiPhong.Name = "cbo_loaiPhong";
            this.cbo_loaiPhong.Properties.AutoHeight = false;
            this.cbo_loaiPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_loaiPhong.Size = new System.Drawing.Size(267, 30);
            this.cbo_loaiPhong.TabIndex = 1;
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_TrangThai.Location = new System.Drawing.Point(275, 111);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Properties.AutoHeight = false;
            this.cbo_TrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_TrangThai.Size = new System.Drawing.Size(267, 30);
            this.cbo_TrangThai.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel5.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.Controls.Add(this.btn_themPhong, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_suaPhong, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_xoaPhong, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 147);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(539, 76);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // btn_themPhong
            // 
            this.btn_themPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_themPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_themPhong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_themPhong.Location = new System.Drawing.Point(3, 3);
            this.btn_themPhong.Name = "btn_themPhong";
            this.btn_themPhong.Size = new System.Drawing.Size(173, 70);
            this.btn_themPhong.TabIndex = 0;
            this.btn_themPhong.Text = "Thêm";
            // 
            // btn_suaPhong
            // 
            this.btn_suaPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_suaPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btn_suaPhong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_suaPhong.Location = new System.Drawing.Point(182, 3);
            this.btn_suaPhong.Name = "btn_suaPhong";
            this.btn_suaPhong.Size = new System.Drawing.Size(173, 70);
            this.btn_suaPhong.TabIndex = 0;
            this.btn_suaPhong.Text = "Sửa";
            // 
            // btn_xoaPhong
            // 
            this.btn_xoaPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_xoaPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btn_xoaPhong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_xoaPhong.Location = new System.Drawing.Point(361, 3);
            this.btn_xoaPhong.Name = "btn_xoaPhong";
            this.btn_xoaPhong.Size = new System.Drawing.Size(175, 70);
            this.btn_xoaPhong.TabIndex = 0;
            this.btn_xoaPhong.Text = "Xoá";
            // 
            // groupControl4
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.groupControl4, 2);
            this.groupControl4.Controls.Add(this.dgv_DSPhong);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(3, 235);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(545, 382);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Danh sách phòng";
            // 
            // dgv_DSPhong
            // 
            this.dgv_DSPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSPhong.ColumnHeadersHeight = 36;
            this.dgv_DSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DSPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaPhong,
            this.col_TenPhong,
            this.col_LoaiPhong,
            this.col_TrangThai});
            this.dgv_DSPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSPhong.Location = new System.Drawing.Point(2, 23);
            this.dgv_DSPhong.Name = "dgv_DSPhong";
            this.dgv_DSPhong.Size = new System.Drawing.Size(541, 357);
            this.dgv_DSPhong.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl7.Location = new System.Drawing.Point(3, 39);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(266, 30);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Mã phòng";
            // 
            // col_MaPhong
            // 
            this.col_MaPhong.HeaderText = "Mã phòng";
            this.col_MaPhong.Name = "col_MaPhong";
            // 
            // col_TenPhong
            // 
            this.col_TenPhong.HeaderText = "Tên phòng";
            this.col_TenPhong.Name = "col_TenPhong";
            // 
            // col_LoaiPhong
            // 
            this.col_LoaiPhong.HeaderText = "Loại phòng";
            this.col_LoaiPhong.Name = "col_LoaiPhong";
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.HeaderText = "Trạng thái";
            this.col_TrangThai.Name = "col_TrangThai";
            // 
            // txt_maPhong
            // 
            this.txt_maPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maPhong.Location = new System.Drawing.Point(275, 39);
            this.txt_maPhong.Name = "txt_maPhong";
            this.txt_maPhong.Properties.AutoHeight = false;
            this.txt_maPhong.Size = new System.Drawing.Size(267, 30);
            this.txt_maPhong.TabIndex = 5;
            // 
            // txt_tenPhong
            // 
            this.txt_tenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tenPhong.Location = new System.Drawing.Point(275, 75);
            this.txt_tenPhong.Name = "txt_tenPhong";
            this.txt_tenPhong.Properties.AutoHeight = false;
            this.txt_tenPhong.Size = new System.Drawing.Size(267, 30);
            this.txt_tenPhong.TabIndex = 6;
            // 
            // frmChinhSuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 667);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmChinhSuaPhong";
            this.Text = "CHỈNH SỬA THÔNG TIN PHÒNG";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLoaiPhong)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soGiuong.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_loaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_TrangThai.Properties)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenPhong.Properties)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private TextEdit txt_maLoai;
        private TextEdit txt_tenLoai;
        private TextEdit txt_soGiuong;
        private GroupControl groupControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private GroupControl groupControl3;
        private SimpleButton btn_themLoai;
        private SimpleButton btn_suaLoai;
        private SimpleButton btn_xoaLoai;
        private System.Windows.Forms.DataGridView dgv_DSLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoGiuong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private LookUpEdit cbo_loaiPhong;
        private LookUpEdit cbo_TrangThai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private SimpleButton btn_themPhong;
        private SimpleButton btn_suaPhong;
        private SimpleButton btn_xoaPhong;
        private GroupControl groupControl4;
        private System.Windows.Forms.DataGridView dgv_DSPhong;
        private LabelControl labelControl7;
        private TextEdit txt_maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TrangThai;
        private TextEdit txt_tenPhong;
    }
}