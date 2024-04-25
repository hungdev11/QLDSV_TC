
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
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreatAcc = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpQuanLyKhoa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpHocPhi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpBaoCaoKhoa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpSV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btnXemDiem,
            this.btnLogin,
            this.btnLogout,
            this.btnCreatAcc,
            this.btnExit,
            this.btnHocPhi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 660;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageQuanLy,
            this.ribbonBaoCao,
            this.ribbonPageSinhVien,
            this.ribbonPageHeThong});
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
            this.btnNhapDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapDiem_ItemClick);
            // 
            // btnDKLTC
            // 
            this.btnDKLTC.Caption = "Đăng Kí Lớp Tín Chỉ";
            this.btnDKLTC.Id = 5;
            this.btnDKLTC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDKLTC.ImageOptions.SvgImage")));
            this.btnDKLTC.Name = "btnDKLTC";
            this.btnDKLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDKLTC_ItemClick);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Caption = "Xem Điểm";
            this.btnXemDiem.Id = 6;
            this.btnXemDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemDiem.ImageOptions.SvgImage")));
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemDiem_ItemClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng Nhập";
            this.btnLogin.Id = 7;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng Xuất";
            this.btnLogout.Id = 8;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnCreatAcc
            // 
            this.btnCreatAcc.Caption = "Tạo Tài Khoản";
            this.btnCreatAcc.Id = 9;
            this.btnCreatAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreatAcc.ImageOptions.Image")));
            this.btnCreatAcc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCreatAcc.ImageOptions.LargeImage")));
            this.btnCreatAcc.Name = "btnCreatAcc";
            this.btnCreatAcc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreatAcc_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 10;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Caption = "Học Phí";
            this.btnHocPhi.Id = 11;
            this.btnHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.Image")));
            this.btnHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.LargeImage")));
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocPhi_ItemClick);
            // 
            // ribbonPageQuanLy
            // 
            this.ribbonPageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpQuanLyKhoa,
            this.rbpHocPhi});
            this.ribbonPageQuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageQuanLy.ImageOptions.Image")));
            this.ribbonPageQuanLy.Name = "ribbonPageQuanLy";
            this.ribbonPageQuanLy.Text = "Quản Lý";
            // 
            // rbpQuanLyKhoa
            // 
            this.rbpQuanLyKhoa.ItemLinks.Add(this.btnLopHoc);
            this.rbpQuanLyKhoa.ItemLinks.Add(this.btnMonHoc);
            this.rbpQuanLyKhoa.ItemLinks.Add(this.btnLTC);
            this.rbpQuanLyKhoa.ItemLinks.Add(this.btnNhapDiem);
            this.rbpQuanLyKhoa.Name = "rbpQuanLyKhoa";
            // 
            // rbpHocPhi
            // 
            this.rbpHocPhi.ItemLinks.Add(this.btnHocPhi);
            this.rbpHocPhi.Name = "rbpHocPhi";
            // 
            // ribbonBaoCao
            // 
            this.ribbonBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpBaoCaoKhoa});
            this.ribbonBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonBaoCao.ImageOptions.Image")));
            this.ribbonBaoCao.Name = "ribbonBaoCao";
            this.ribbonBaoCao.Text = "Báo Cáo";
            // 
            // rbpBaoCaoKhoa
            // 
            this.rbpBaoCaoKhoa.Name = "rbpBaoCaoKhoa";
            this.rbpBaoCaoKhoa.Text = "ribbonPageGroup1";
            // 
            // ribbonPageSinhVien
            // 
            this.ribbonPageSinhVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpSV});
            this.ribbonPageSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageSinhVien.ImageOptions.Image")));
            this.ribbonPageSinhVien.Name = "ribbonPageSinhVien";
            this.ribbonPageSinhVien.Text = "Sinh Viên";
            // 
            // rbpSV
            // 
            this.rbpSV.ItemLinks.Add(this.btnDKLTC);
            this.rbpSV.ItemLinks.Add(this.btnXemDiem);
            this.rbpSV.Name = "rbpSV";
            // 
            // ribbonPageHeThong
            // 
            this.ribbonPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpHeThong});
            this.ribbonPageHeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageHeThong.ImageOptions.Image")));
            this.ribbonPageHeThong.Name = "ribbonPageHeThong";
            this.ribbonPageHeThong.Text = "Hệ Thống";
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.ItemLinks.Add(this.btnLogin);
            this.rbpHeThong.ItemLinks.Add(this.btnLogout);
            this.rbpHeThong.ItemLinks.Add(this.btnCreatAcc);
            this.rbpHeThong.ItemLinks.Add(this.btnExit);
            this.rbpHeThong.Name = "rbpHeThong";
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
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpBaoCaoKhoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public  System.Windows.Forms.ToolStripStatusLabel statusMa;
        public System.Windows.Forms.ToolStripStatusLabel statusTen;
        public System.Windows.Forms.ToolStripStatusLabel statusNhom;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpQuanLyKhoa;
        private DevExpress.XtraBars.BarButtonItem btnLopHoc;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnLTC;
        private DevExpress.XtraBars.BarButtonItem btnNhapDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpSV;
        private DevExpress.XtraBars.BarButtonItem btnDKLTC;
        private DevExpress.XtraBars.BarButtonItem btnXemDiem;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnCreatAcc;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpHeThong;
        private DevExpress.XtraBars.BarButtonItem btnHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpHocPhi;
    }
}

