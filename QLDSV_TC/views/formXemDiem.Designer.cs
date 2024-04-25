
namespace QLDSV_TC.views
{
    partial class formXemDiem
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
            this.groupTTSV = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.wcfInstantFeedbackSource1 = new DevExpress.Data.WcfLinq.WcfInstantFeedbackSource();
            this.gcXemDiem = new DevExpress.XtraGrid.GridControl();
            this.gvXemDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maTLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemGK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTTSV
            // 
            this.groupTTSV.Controls.Add(this.label3);
            this.groupTTSV.Controls.Add(this.txtMaLop);
            this.groupTTSV.Controls.Add(this.label2);
            this.groupTTSV.Controls.Add(this.txtTenSV);
            this.groupTTSV.Controls.Add(this.label1);
            this.groupTTSV.Controls.Add(this.txtMaSV);
            this.groupTTSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTTSV.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTTSV.Location = new System.Drawing.Point(0, 0);
            this.groupTTSV.Name = "groupTTSV";
            this.groupTTSV.Size = new System.Drawing.Size(1886, 351);
            this.groupTTSV.TabIndex = 0;
            this.groupTTSV.TabStop = false;
            this.groupTTSV.Text = "Thông Tin Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(871, 221);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(354, 48);
            this.txtMaLop.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ và Tên";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(871, 151);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Properties.Appearance.Options.UseFont = true;
            this.txtTenSV.Size = new System.Drawing.Size(354, 48);
            this.txtTenSV.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(871, 90);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Size = new System.Drawing.Size(354, 48);
            this.txtMaSV.TabIndex = 6;
            // 
            // gcXemDiem
            // 
            this.gcXemDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXemDiem.Location = new System.Drawing.Point(0, 351);
            this.gcXemDiem.MainView = this.gvXemDiem;
            this.gcXemDiem.Name = "gcXemDiem";
            this.gcXemDiem.Size = new System.Drawing.Size(1886, 723);
            this.gcXemDiem.TabIndex = 1;
            this.gcXemDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXemDiem});
            // 
            // gvXemDiem
            // 
            this.gvXemDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maTLC,
            this.tenMH,
            this.diemCC,
            this.diemGK,
            this.diemCK,
            this.diemTK,
            this.gridColumn1});
            this.gvXemDiem.GridControl = this.gcXemDiem;
            this.gvXemDiem.GroupCount = 1;
            this.gvXemDiem.Name = "gvXemDiem";
            this.gvXemDiem.OptionsBehavior.ReadOnly = true;
            this.gvXemDiem.OptionsView.ShowGroupPanel = false;
            this.gvXemDiem.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // maTLC
            // 
            this.maTLC.Caption = "Mã Lớp Tín Chỉ";
            this.maTLC.FieldName = "MALTC";
            this.maTLC.MinWidth = 40;
            this.maTLC.Name = "maTLC";
            this.maTLC.UnboundDataType = typeof(string);
            this.maTLC.Visible = true;
            this.maTLC.VisibleIndex = 0;
            this.maTLC.Width = 150;
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
            // diemCC
            // 
            this.diemCC.Caption = "Điểm Chuyên Cần";
            this.diemCC.FieldName = "DIEM_CC";
            this.diemCC.MinWidth = 40;
            this.diemCC.Name = "diemCC";
            this.diemCC.Visible = true;
            this.diemCC.VisibleIndex = 2;
            this.diemCC.Width = 150;
            // 
            // diemGK
            // 
            this.diemGK.Caption = "Điểm Giữa Kỳ";
            this.diemGK.FieldName = "DIEM_GK";
            this.diemGK.MinWidth = 40;
            this.diemGK.Name = "diemGK";
            this.diemGK.Visible = true;
            this.diemGK.VisibleIndex = 3;
            this.diemGK.Width = 150;
            // 
            // diemCK
            // 
            this.diemCK.Caption = "Điểm Cuối Kỳ";
            this.diemCK.FieldName = "DIEM_CK";
            this.diemCK.MinWidth = 40;
            this.diemCK.Name = "diemCK";
            this.diemCK.Visible = true;
            this.diemCK.VisibleIndex = 4;
            this.diemCK.Width = 150;
            // 
            // diemTK
            // 
            this.diemTK.Caption = "Điểm Tổng Kết";
            this.diemTK.FieldName = "DIEMTK";
            this.diemTK.MinWidth = 40;
            this.diemTK.Name = "diemTK";
            this.diemTK.OptionsColumn.AllowEdit = false;
            this.diemTK.OptionsColumn.AllowFocus = false;
            this.diemTK.OptionsColumn.ReadOnly = true;
            this.diemTK.Visible = true;
            this.diemTK.VisibleIndex = 5;
            this.diemTK.Width = 150;
            this.diemTK.UnboundDataType = typeof(string);
            this.diemTK.UnboundExpression = "Round(Iif(IsNullOrEmpty([DIEM_CC]), 0, [DIEM_CC]) * 0.1 + Iif(IsNullOrEmpty([DIEM" +
    "_GK]), 0, [DIEM_GK]) * 0.3 + Iif(IsNullOrEmpty([DIEM_CK]), 0, [DIEM_CK]) * 0.6, " +
    "1)";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "NKHK";
            this.gridColumn1.MinWidth = 40;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 150;
            // 
            // formXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 1074);
            this.Controls.Add(this.gcXemDiem);
            this.Controls.Add(this.groupTTSV);
            this.Name = "formXemDiem";
            this.Text = "Xem Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formXemDiem_Load);
            this.groupTTSV.ResumeLayout(false);
            this.groupTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXemDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTTSV;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.Data.WcfLinq.WcfInstantFeedbackSource wcfInstantFeedbackSource1;
        private DevExpress.XtraGrid.GridControl gcXemDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXemDiem;
        private DevExpress.XtraGrid.Columns.GridColumn maTLC;
        private DevExpress.XtraGrid.Columns.GridColumn tenMH;
        private DevExpress.XtraGrid.Columns.GridColumn diemCC;
        private DevExpress.XtraGrid.Columns.GridColumn diemGK;
        private DevExpress.XtraGrid.Columns.GridColumn diemCK;
        private DevExpress.XtraGrid.Columns.GridColumn diemTK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}