
namespace QLDSV_TC
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLopHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDKLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemDiem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgQuanLyKhoa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBaoCaoKhoa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMa = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusNhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLopHoc,
            this.btnMonHoc,
            this.btnLTC,
            this.btnNhapDiem,
            this.btnDKLTC,
            this.btnXemDiem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 660;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageQuanLy,
            this.ribbonPageBaoCao,
            this.ribbonPageSinhVien});
            this.ribbonControl1.Size = new System.Drawing.Size(1516, 315);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Caption = "Lớp Học";
            this.btnLopHoc.Id = 1;
            this.btnLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLopHoc.ImageOptions.Image")));
            this.btnLopHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLopHoc.ImageOptions.LargeImage")));
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLopHoc_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn Học";
            this.btnMonHoc.Id = 2;
            this.btnMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.Image")));
            this.btnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.LargeImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnLTC
            // 
            this.btnLTC.Caption = "Lớp Tín Chỉ";
            this.btnLTC.Id = 3;
            this.btnLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLTC.ImageOptions.Image")));
            this.btnLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLTC.ImageOptions.LargeImage")));
            this.btnLTC.Name = "btnLTC";
            this.btnLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLTC_ItemClick);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Caption = "Nhập Điểm";
            this.btnNhapDiem.Id = 4;
            this.btnNhapDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.ImageOptions.Image")));
            this.btnNhapDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.ImageOptions.LargeImage")));
            this.btnNhapDiem.Name = "btnNhapDiem";
            // 
            // btnDKLTC
            // 
            this.btnDKLTC.Caption = "Đăng Kí Lớp Tín Chỉ";
            this.btnDKLTC.Id = 5;
            this.btnDKLTC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDKLTC.ImageOptions.SvgImage")));
            this.btnDKLTC.Name = "btnDKLTC";
            this.btnDKLTC.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Caption = "Xem Điểm";
            this.btnXemDiem.Id = 6;
            this.btnXemDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemDiem.ImageOptions.SvgImage")));
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // ribbonPageQuanLy
            // 
            this.ribbonPageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgQuanLyKhoa});
            this.ribbonPageQuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageQuanLy.ImageOptions.Image")));
            this.ribbonPageQuanLy.Name = "ribbonPageQuanLy";
            this.ribbonPageQuanLy.Text = "Quản Lý";
            // 
            // rpgQuanLyKhoa
            // 
            this.rpgQuanLyKhoa.ItemLinks.Add(this.btnLopHoc);
            this.rpgQuanLyKhoa.ItemLinks.Add(this.btnMonHoc);
            this.rpgQuanLyKhoa.ItemLinks.Add(this.btnLTC);
            this.rpgQuanLyKhoa.ItemLinks.Add(this.btnNhapDiem);
            this.rpgQuanLyKhoa.Name = "rpgQuanLyKhoa";
            // 
            // ribbonPageBaoCao
            // 
            this.ribbonPageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBaoCaoKhoa});
            this.ribbonPageBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageBaoCao.ImageOptions.Image")));
            this.ribbonPageBaoCao.Name = "ribbonPageBaoCao";
            this.ribbonPageBaoCao.Text = "Báo Cáo";
            // 
            // rpgBaoCaoKhoa
            // 
            this.rpgBaoCaoKhoa.Name = "rpgBaoCaoKhoa";
            this.rpgBaoCaoKhoa.Text = "ribbonPageGroup1";
            // 
            // ribbonPageSinhVien
            // 
            this.ribbonPageSinhVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageSinhVien.ImageOptions.Image")));
            this.ribbonPageSinhVien.Name = "ribbonPageSinhVien";
            this.ribbonPageSinhVien.Text = "Sinh Viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDKLTC);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXemDiem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMa,
            this.statusTen,
            this.statusNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1249);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1516, 42);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMa
            // 
            this.statusMa.Name = "statusMa";
            this.statusMa.Size = new System.Drawing.Size(49, 32);
            this.statusMa.Text = "Mã";
            // 
            // statusTen
            // 
            this.statusTen.Name = "statusTen";
            this.statusTen.Size = new System.Drawing.Size(53, 32);
            this.statusTen.Text = "Tên";
            // 
            // statusNhom
            // 
            this.statusNhom.Name = "statusNhom";
            this.statusNhom.Size = new System.Drawing.Size(82, 32);
            this.statusNhom.Text = "Nhóm";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 1291);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBaoCaoKhoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public  System.Windows.Forms.ToolStripStatusLabel statusMa;
        public System.Windows.Forms.ToolStripStatusLabel statusTen;
        public System.Windows.Forms.ToolStripStatusLabel statusNhom;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgQuanLyKhoa;
        private DevExpress.XtraBars.BarButtonItem btnLopHoc;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnLTC;
        private DevExpress.XtraBars.BarButtonItem btnNhapDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDKLTC;
        private DevExpress.XtraBars.BarButtonItem btnXemDiem;
    }
}

