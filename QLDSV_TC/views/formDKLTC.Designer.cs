
namespace QLDSV_TC.views
{
    partial class formDKLTC
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTim = new System.Windows.Forms.Button();
            this.spinHK = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.thongTinSV = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcDSLTC = new DevExpress.XtraGrid.GridControl();
            this.gvLTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SVDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGV = new DevExpress.XtraEditors.TextEdit();
            this.txtMH = new DevExpress.XtraEditors.TextEdit();
            this.txtLTC = new DevExpress.XtraEditors.TextEdit();
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcLTCDaDK = new DevExpress.XtraGrid.GridControl();
            this.gvLTCDaDK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhom1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenGV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SVDK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).BeginInit();
            this.thongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLTC.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLTCDaDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTCDaDK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTim);
            this.panelControl1.Controls.Add(this.spinHK);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.thongTinSV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1886, 276);
            this.panelControl1.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1436, 69);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(166, 121);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // spinHK
            // 
            this.spinHK.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHK.Location = new System.Drawing.Point(1094, 158);
            this.spinHK.Name = "spinHK";
            this.spinHK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinHK.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinHK.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHK.Size = new System.Drawing.Size(118, 40);
            this.spinHK.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(950, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Học Kỳ";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(1094, 50);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(240, 41);
            this.cmbNienKhoa.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(950, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Niên Khóa";
            // 
            // thongTinSV
            // 
            this.thongTinSV.Controls.Add(this.label3);
            this.thongTinSV.Controls.Add(this.txtMaLop);
            this.thongTinSV.Controls.Add(this.label2);
            this.thongTinSV.Controls.Add(this.txtTenSV);
            this.thongTinSV.Controls.Add(this.label1);
            this.thongTinSV.Controls.Add(this.txtMaSV);
            this.thongTinSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.thongTinSV.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinSV.Location = new System.Drawing.Point(3, 3);
            this.thongTinSV.Name = "thongTinSV";
            this.thongTinSV.Size = new System.Drawing.Size(853, 270);
            this.thongTinSV.TabIndex = 0;
            this.thongTinSV.TabStop = false;
            this.thongTinSV.Text = "Thông Tin Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(334, 190);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(354, 48);
            this.txtMaLop.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và Tên";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(334, 120);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Properties.Appearance.Options.UseFont = true;
            this.txtTenSV.Size = new System.Drawing.Size(354, 48);
            this.txtTenSV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(334, 59);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Size = new System.Drawing.Size(354, 48);
            this.txtMaSV.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcDSLTC);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 276);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1886, 352);
            this.panelControl3.TabIndex = 0;
            // 
            // gcDSLTC
            // 
            this.gcDSLTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSLTC.Location = new System.Drawing.Point(3, 3);
            this.gcDSLTC.MainView = this.gvLTC;
            this.gcDSLTC.Name = "gcDSLTC";
            this.gcDSLTC.Size = new System.Drawing.Size(1880, 346);
            this.gcDSLTC.TabIndex = 0;
            this.gcDSLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLTC});
            // 
            // gvLTC
            // 
            this.gvLTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maMH,
            this.tenMH,
            this.nhom,
            this.tenGV,
            this.SVDangKy});
            this.gvLTC.GridControl = this.gcDSLTC;
            this.gvLTC.Name = "gvLTC";
            this.gvLTC.OptionsBehavior.ReadOnly = true;
            this.gvLTC.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvLTC_RowClick);
            // 
            // maMH
            // 
            this.maMH.Caption = "Mã Môn Học";
            this.maMH.FieldName = "MAMH";
            this.maMH.MinWidth = 40;
            this.maMH.Name = "maMH";
            this.maMH.Visible = true;
            this.maMH.VisibleIndex = 0;
            this.maMH.Width = 150;
            // 
            // tenMH
            // 
            this.tenMH.Caption = "Tên Môn Học";
            this.tenMH.FieldName = "TENMH";
            this.tenMH.MinWidth = 40;
            this.tenMH.Name = "tenMH";
            this.tenMH.Visible = true;
            this.tenMH.VisibleIndex = 1;
            this.tenMH.Width = 150;
            // 
            // nhom
            // 
            this.nhom.Caption = "Nhóm";
            this.nhom.FieldName = "NHOM";
            this.nhom.MinWidth = 40;
            this.nhom.Name = "nhom";
            this.nhom.Visible = true;
            this.nhom.VisibleIndex = 2;
            this.nhom.Width = 150;
            // 
            // tenGV
            // 
            this.tenGV.Caption = "Giảng Viên";
            this.tenGV.FieldName = "TENGV";
            this.tenGV.MinWidth = 40;
            this.tenGV.Name = "tenGV";
            this.tenGV.Visible = true;
            this.tenGV.VisibleIndex = 3;
            this.tenGV.Width = 150;
            // 
            // SVDangKy
            // 
            this.SVDangKy.Caption = "Số Sinh Viên Đã Đăng Ký";
            this.SVDangKy.FieldName = "soluongdk";
            this.SVDangKy.MinWidth = 40;
            this.SVDangKy.Name = "SVDangKy";
            this.SVDangKy.Visible = true;
            this.SVDangKy.VisibleIndex = 4;
            this.SVDangKy.Width = 150;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.txtGV);
            this.panelControl2.Controls.Add(this.txtMH);
            this.panelControl2.Controls.Add(this.txtLTC);
            this.panelControl2.Controls.Add(this.btnHuyDangKy);
            this.panelControl2.Controls.Add(this.btnDangKy);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 628);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(606, 446);
            this.panelControl2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 33);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giảng Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Môn Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lớp Tín Chỉ";
            // 
            // txtGV
            // 
            this.txtGV.Location = new System.Drawing.Point(188, 253);
            this.txtGV.Name = "txtGV";
            this.txtGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGV.Properties.Appearance.Options.UseFont = true;
            this.txtGV.Size = new System.Drawing.Size(364, 48);
            this.txtGV.TabIndex = 5;
            // 
            // txtMH
            // 
            this.txtMH.Location = new System.Drawing.Point(188, 165);
            this.txtMH.Name = "txtMH";
            this.txtMH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMH.Properties.Appearance.Options.UseFont = true;
            this.txtMH.Size = new System.Drawing.Size(364, 48);
            this.txtMH.TabIndex = 4;
            // 
            // txtLTC
            // 
            this.txtLTC.Location = new System.Drawing.Point(188, 77);
            this.txtLTC.Name = "txtLTC";
            this.txtLTC.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLTC.Properties.Appearance.Options.UseFont = true;
            this.txtLTC.Size = new System.Drawing.Size(364, 48);
            this.txtLTC.TabIndex = 2;
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDangKy.Location = new System.Drawing.Point(362, 356);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(190, 68);
            this.btnHuyDangKy.TabIndex = 1;
            this.btnHuyDangKy.Text = "Hủy Đăng Ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = true;
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(72, 356);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(162, 68);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcLTCDaDK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(606, 628);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1280, 446);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH LỚP TÍN CHỈ ĐÃ ĐĂNG KÝ";
            // 
            // gcLTCDaDK
            // 
            this.gcLTCDaDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLTCDaDK.Location = new System.Drawing.Point(3, 27);
            this.gcLTCDaDK.MainView = this.gvLTCDaDK;
            this.gcLTCDaDK.Name = "gcLTCDaDK";
            this.gcLTCDaDK.Size = new System.Drawing.Size(1274, 416);
            this.gcLTCDaDK.TabIndex = 3;
            this.gcLTCDaDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLTCDaDK});
            // 
            // gvLTCDaDK
            // 
            this.gvLTCDaDK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maMH1,
            this.tenMH1,
            this.nhom1,
            this.tenGV1,
            this.SVDK});
            this.gvLTCDaDK.GridControl = this.gcLTCDaDK;
            this.gvLTCDaDK.Name = "gvLTCDaDK";
            this.gvLTCDaDK.OptionsBehavior.ReadOnly = true;
            this.gvLTCDaDK.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvLTCDaDK_RowClick);
            // 
            // maMH1
            // 
            this.maMH1.Caption = "Mã Môn Học";
            this.maMH1.FieldName = "MAMH";
            this.maMH1.MinWidth = 40;
            this.maMH1.Name = "maMH1";
            this.maMH1.Visible = true;
            this.maMH1.VisibleIndex = 0;
            this.maMH1.Width = 150;
            // 
            // tenMH1
            // 
            this.tenMH1.Caption = "Tên Môn Học";
            this.tenMH1.FieldName = "TENMH";
            this.tenMH1.MinWidth = 40;
            this.tenMH1.Name = "tenMH1";
            this.tenMH1.Visible = true;
            this.tenMH1.VisibleIndex = 1;
            this.tenMH1.Width = 150;
            // 
            // nhom1
            // 
            this.nhom1.Caption = "Nhóm";
            this.nhom1.FieldName = "NHOM";
            this.nhom1.MinWidth = 40;
            this.nhom1.Name = "nhom1";
            this.nhom1.Visible = true;
            this.nhom1.VisibleIndex = 2;
            this.nhom1.Width = 150;
            // 
            // tenGV1
            // 
            this.tenGV1.Caption = "Giảng Viên";
            this.tenGV1.FieldName = "TENGV";
            this.tenGV1.MinWidth = 40;
            this.tenGV1.Name = "tenGV1";
            this.tenGV1.Visible = true;
            this.tenGV1.VisibleIndex = 3;
            this.tenGV1.Width = 150;
            // 
            // SVDK
            // 
            this.SVDK.Caption = "Số lượng SV đã Đăng ký";
            this.SVDK.FieldName = "soluongdk";
            this.SVDK.MinWidth = 40;
            this.SVDK.Name = "SVDK";
            this.SVDK.Visible = true;
            this.SVDK.VisibleIndex = 4;
            this.SVDK.Width = 150;
            // 
            // formDKLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 1074);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "formDKLTC";
            this.Text = "Đăng Ký Lớp Tín Chỉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formDKLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).EndInit();
            this.thongTinSV.ResumeLayout(false);
            this.thongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLTC.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLTCDaDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTCDaDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox thongTinSV;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.SpinEdit spinHK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTim;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcDSLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLTC;
        private DevExpress.XtraGrid.Columns.GridColumn maMH;
        private DevExpress.XtraGrid.Columns.GridColumn tenMH;
        private DevExpress.XtraGrid.Columns.GridColumn nhom;
        private DevExpress.XtraGrid.Columns.GridColumn tenGV;
        private DevExpress.XtraGrid.Columns.GridColumn SVDangKy;
        private System.Windows.Forms.Button btnHuyDangKy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcLTCDaDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLTCDaDK;
        private DevExpress.XtraGrid.Columns.GridColumn maMH1;
        private DevExpress.XtraGrid.Columns.GridColumn tenMH1;
        private DevExpress.XtraGrid.Columns.GridColumn nhom1;
        private DevExpress.XtraGrid.Columns.GridColumn tenGV1;
        private DevExpress.XtraGrid.Columns.GridColumn SVDK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtGV;
        private DevExpress.XtraEditors.TextEdit txtMH;
        private DevExpress.XtraEditors.TextEdit txtLTC;
    }
}