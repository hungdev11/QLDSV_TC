
namespace QLDSV_TC.views
{
    partial class formHocPhi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label hOCPHILabel;
            System.Windows.Forms.Label dADONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHocPhi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.traCuu = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.traCuuSV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gcHocPhi = new DevExpress.XtraGrid.GridControl();
            this.bdsHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.dS_HP = new QLDSV_TC.DS_HP();
            this.gvHocPhi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SVIF = new System.Windows.Forms.GroupBox();
            this.daDong = new DevExpress.XtraEditors.SpinEdit();
            this.hocPhi = new DevExpress.XtraEditors.SpinEdit();
            this.hocKy = new DevExpress.XtraEditors.SpinEdit();
            this.nienKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.gcCTHP = new DevExpress.XtraGrid.GridControl();
            this.bdsCTHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTHP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new QLDSV_TC.DS_HPTableAdapters.TableAdapterManager();
            this.sP_TaiHocPhiTableAdapter = new QLDSV_TC.DS_HPTableAdapters.SP_TaiHocPhiTableAdapter();
            this.sP_TaiCTHocPhiTableAdapter = new QLDSV_TC.DS_HPTableAdapters.SP_TaiCTHocPhiTableAdapter();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            dADONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.traCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traCuuSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocPhi)).BeginInit();
            this.SVIF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTHP)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(29, 162);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(138, 33);
            nIENKHOALabel.TabIndex = 17;
            nIENKHOALabel.Text = "Niên Khóa";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(518, 159);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(101, 33);
            hOCKYLabel.TabIndex = 18;
            hOCKYLabel.Text = "Học Kỳ";
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Location = new System.Drawing.Point(34, 271);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(106, 33);
            hOCPHILabel.TabIndex = 19;
            hOCPHILabel.Text = "Học Phí";
            // 
            // dADONGLabel
            // 
            dADONGLabel.AutoSize = true;
            dADONGLabel.Location = new System.Drawing.Point(465, 270);
            dADONGLabel.Name = "dADONGLabel";
            dADONGLabel.Size = new System.Drawing.Size(117, 33);
            dADONGLabel.TabIndex = 20;
            dADONGLabel.Text = "Đã Đóng";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnGhi,
            this.btnThoat});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1886, 46);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1074);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1886, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1028);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1886, 46);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1028);
            // 
            // traCuu
            // 
            this.traCuu.Controls.Add(this.btnTraCuu);
            this.traCuu.Controls.Add(this.traCuuSV);
            this.traCuu.Controls.Add(this.label1);
            this.traCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.traCuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCuu.Location = new System.Drawing.Point(0, 46);
            this.traCuu.Name = "traCuu";
            this.traCuu.Size = new System.Drawing.Size(1886, 182);
            this.traCuu.TabIndex = 4;
            this.traCuu.TabStop = false;
            this.traCuu.Text = "Tra cứu học phí";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(1100, 59);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(151, 68);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // traCuuSV
            // 
            this.traCuuSV.Location = new System.Drawing.Point(671, 70);
            this.traCuuSV.MenuManager = this.barManager1;
            this.traCuuSV.Name = "traCuuSV";
            this.traCuuSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCuuSV.Properties.Appearance.Options.UseFont = true;
            this.traCuuSV.Size = new System.Drawing.Size(361, 48);
            this.traCuuSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // gcHocPhi
            // 
            this.gcHocPhi.DataSource = this.bdsHocPhi;
            this.gcHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHocPhi.Location = new System.Drawing.Point(0, 228);
            this.gcHocPhi.MainView = this.gvHocPhi;
            this.gcHocPhi.MenuManager = this.barManager1;
            this.gcHocPhi.Name = "gcHocPhi";
            this.gcHocPhi.Size = new System.Drawing.Size(1886, 418);
            this.gcHocPhi.TabIndex = 5;
            this.gcHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocPhi});
            this.gcHocPhi.Click += new System.EventHandler(this.gcHocPhi_Click);
            // 
            // bdsHocPhi
            // 
            this.bdsHocPhi.DataMember = "SP_TaiHocPhi";
            this.bdsHocPhi.DataSource = this.dS_HP;
            // 
            // dS_HP
            // 
            this.dS_HP.DataSetName = "DS_HP";
            this.dS_HP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvHocPhi
            // 
            this.gvHocPhi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvHocPhi.GridControl = this.gcHocPhi;
            this.gvHocPhi.GroupCount = 1;
            this.gvHocPhi.Name = "gvHocPhi";
            this.gvHocPhi.OptionsBehavior.ReadOnly = true;
            this.gvHocPhi.OptionsView.ShowGroupPanel = false;
            this.gvHocPhi.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Niên Khóa";
            this.gridColumn1.FieldName = "NIENKHOA";
            this.gridColumn1.MinWidth = 40;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 150;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Học Kỳ";
            this.gridColumn2.FieldName = "HOCKY";
            this.gridColumn2.MinWidth = 40;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 150;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Học Phí";
            this.gridColumn3.FieldName = "HOCPHI";
            this.gridColumn3.MinWidth = 40;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 150;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số Tiền Đã Đóng";
            this.gridColumn4.FieldName = "DADONG";
            this.gridColumn4.MinWidth = 40;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 150;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Tiền Còn Nợ";
            this.gridColumn5.FieldName = "CONNO";
            this.gridColumn5.MinWidth = 40;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.UnboundDataType = typeof(string);
            this.gridColumn5.UnboundExpression = "[HOCPHI] - [DADONG]";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 150;
            // 
            // SVIF
            // 
            this.SVIF.Controls.Add(dADONGLabel);
            this.SVIF.Controls.Add(this.daDong);
            this.SVIF.Controls.Add(hOCPHILabel);
            this.SVIF.Controls.Add(this.hocPhi);
            this.SVIF.Controls.Add(hOCKYLabel);
            this.SVIF.Controls.Add(this.hocKy);
            this.SVIF.Controls.Add(nIENKHOALabel);
            this.SVIF.Controls.Add(this.nienKhoa);
            this.SVIF.Controls.Add(this.label3);
            this.SVIF.Controls.Add(this.txtMaLop);
            this.SVIF.Controls.Add(this.label2);
            this.SVIF.Controls.Add(this.txtTenSV);
            this.SVIF.Dock = System.Windows.Forms.DockStyle.Left;
            this.SVIF.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVIF.Location = new System.Drawing.Point(0, 646);
            this.SVIF.Name = "SVIF";
            this.SVIF.Size = new System.Drawing.Size(919, 428);
            this.SVIF.TabIndex = 6;
            this.SVIF.TabStop = false;
            this.SVIF.Text = "Thông tin sinh viên";
            // 
            // daDong
            // 
            this.daDong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "DADONG", true));
            this.daDong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.daDong.Location = new System.Drawing.Point(617, 267);
            this.daDong.MenuManager = this.barManager1;
            this.daDong.Name = "daDong";
            this.daDong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daDong.Properties.Appearance.Options.UseFont = true;
            this.daDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.daDong.Properties.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.daDong.Size = new System.Drawing.Size(248, 48);
            this.daDong.TabIndex = 21;
            // 
            // hocPhi
            // 
            this.hocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "HOCPHI", true));
            this.hocPhi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hocPhi.Location = new System.Drawing.Point(168, 268);
            this.hocPhi.MenuManager = this.barManager1;
            this.hocPhi.Name = "hocPhi";
            this.hocPhi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocPhi.Properties.Appearance.Options.UseFont = true;
            this.hocPhi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hocPhi.Properties.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.hocPhi.Properties.MaxValue = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.hocPhi.Size = new System.Drawing.Size(234, 48);
            this.hocPhi.TabIndex = 20;
            // 
            // hocKy
            // 
            this.hocKy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "HOCKY", true));
            this.hocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hocKy.Location = new System.Drawing.Point(644, 156);
            this.hocKy.MenuManager = this.barManager1;
            this.hocKy.Name = "hocKy";
            this.hocKy.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocKy.Properties.Appearance.Options.UseFont = true;
            this.hocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hocKy.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.hocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hocKy.Size = new System.Drawing.Size(221, 48);
            this.hocKy.TabIndex = 19;
            // 
            // nienKhoa
            // 
            this.nienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHocPhi, "NIENKHOA", true));
            this.nienKhoa.Location = new System.Drawing.Point(208, 159);
            this.nienKhoa.Name = "nienKhoa";
            this.nienKhoa.Size = new System.Drawing.Size(261, 41);
            this.nienKhoa.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(588, 50);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(277, 48);
            this.txtMaLop.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Họ và Tên";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(185, 50);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Properties.Appearance.Options.UseFont = true;
            this.txtTenSV.Size = new System.Drawing.Size(284, 48);
            this.txtTenSV.TabIndex = 14;
            // 
            // gcCTHP
            // 
            this.gcCTHP.DataSource = this.bdsCTHocPhi;
            this.gcCTHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTHP.Location = new System.Drawing.Point(919, 646);
            this.gcCTHP.MainView = this.gvCTHP;
            this.gcCTHP.MenuManager = this.barManager1;
            this.gcCTHP.Name = "gcCTHP";
            this.gcCTHP.Size = new System.Drawing.Size(967, 428);
            this.gcCTHP.TabIndex = 7;
            this.gcCTHP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTHP});
            // 
            // bdsCTHocPhi
            // 
            this.bdsCTHocPhi.DataMember = "SP_TaiCTHocPhi";
            this.bdsCTHocPhi.DataSource = this.dS_HP;
            // 
            // gvCTHP
            // 
            this.gvCTHP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7});
            this.gvCTHP.GridControl = this.gcCTHP;
            this.gvCTHP.Name = "gvCTHP";
            this.gvCTHP.OptionsBehavior.ReadOnly = true;
            this.gvCTHP.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày Đóng";
            this.gridColumn6.FieldName = "NGAYDONG";
            this.gridColumn6.MinWidth = 40;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 150;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Số Tiền Đóng";
            this.gridColumn7.FieldName = "SOTIENDONG";
            this.gridColumn7.MinWidth = 40;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 150;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS_HPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_TaiHocPhiTableAdapter
            // 
            this.sP_TaiHocPhiTableAdapter.ClearBeforeFill = true;
            // 
            // sP_TaiCTHocPhiTableAdapter
            // 
            this.sP_TaiCTHocPhiTableAdapter.ClearBeforeFill = true;
            // 
            // formHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 1074);
            this.Controls.Add(this.gcCTHP);
            this.Controls.Add(this.SVIF);
            this.Controls.Add(this.gcHocPhi);
            this.Controls.Add(this.traCuu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formHocPhi";
            this.Text = "formHocPhi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.traCuu.ResumeLayout(false);
            this.traCuu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traCuuSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocPhi)).EndInit();
            this.SVIF.ResumeLayout(false);
            this.SVIF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.GroupBox traCuu;
        private System.Windows.Forms.Button btnTraCuu;
        private DevExpress.XtraEditors.TextEdit traCuuSV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocPhi;
        private System.Windows.Forms.GroupBox SVIF;
        private DevExpress.XtraGrid.GridControl gcCTHP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTHP;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DS_HP dS_HP;
        private DS_HPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsHocPhi;
        private DS_HPTableAdapters.SP_TaiHocPhiTableAdapter sP_TaiHocPhiTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTHocPhi;
        private DS_HPTableAdapters.SP_TaiCTHocPhiTableAdapter sP_TaiCTHocPhiTableAdapter;
        private DevExpress.XtraEditors.SpinEdit daDong;
        private DevExpress.XtraEditors.SpinEdit hocPhi;
        private DevExpress.XtraEditors.SpinEdit hocKy;
        private System.Windows.Forms.TextBox nienKhoa;
    }
}