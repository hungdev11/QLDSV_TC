
using DevExpress.XtraGrid.Views.Base;
using System;

namespace QLDSV_TC.views
{
    partial class formNhapDiem
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
            this.panelChonKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.spinHK = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGhiDiem = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnTaiLTC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gvSPLTC = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsSpLTC = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SV = new QLDSV_TC.DS_SV();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV_TC.DS_SVTableAdapters.MONHOCTableAdapter();
            this.sP_LayLTCTableAdapter = new QLDSV_TC.DS_SVTableAdapters.SP_LayLTCTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS_SVTableAdapters.TableAdapterManager();
            this.gcDSDangKy = new DevExpress.XtraGrid.GridControl();
            this.gvDSDangKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemGK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemTK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).BeginInit();
            this.panelChonKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSpLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChonKhoa
            // 
            this.panelChonKhoa.Controls.Add(this.cmbNhom);
            this.panelChonKhoa.Controls.Add(this.spinHK);
            this.panelChonKhoa.Controls.Add(this.label5);
            this.panelChonKhoa.Controls.Add(this.cmbMonHoc);
            this.panelChonKhoa.Controls.Add(this.label4);
            this.panelChonKhoa.Controls.Add(this.btnGhiDiem);
            this.panelChonKhoa.Controls.Add(this.btnNhapDiem);
            this.panelChonKhoa.Controls.Add(this.btnTaiLTC);
            this.panelChonKhoa.Controls.Add(this.label3);
            this.panelChonKhoa.Controls.Add(this.cmbNienKhoa);
            this.panelChonKhoa.Controls.Add(this.label1);
            this.panelChonKhoa.Controls.Add(this.cmbKhoa);
            this.panelChonKhoa.Controls.Add(this.label2);
            this.panelChonKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChonKhoa.Location = new System.Drawing.Point(0, 0);
            this.panelChonKhoa.Name = "panelChonKhoa";
            this.panelChonKhoa.Size = new System.Drawing.Size(2010, 151);
            this.panelChonKhoa.TabIndex = 5;
            // 
            // cmbNhom
            // 
            this.cmbNhom.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(683, 84);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(140, 41);
            this.cmbNhom.TabIndex = 14;
            // 
            // spinHK
            // 
            this.spinHK.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHK.Location = new System.Drawing.Point(1020, 23);
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
            this.spinHK.TabIndex = 13;
            this.spinHK.EditValueChanged += new System.EventHandler(this.spinHK_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhóm";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(152, 84);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(393, 41);
            this.cmbMonHoc.TabIndex = 10;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Môn Học";
            // 
            // btnGhiDiem
            // 
            this.btnGhiDiem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiDiem.Location = new System.Drawing.Point(1676, 52);
            this.btnGhiDiem.Name = "btnGhiDiem";
            this.btnGhiDiem.Size = new System.Drawing.Size(156, 51);
            this.btnGhiDiem.TabIndex = 8;
            this.btnGhiDiem.Text = "Ghi Điểm";
            this.btnGhiDiem.UseVisualStyleBackColor = true;
            this.btnGhiDiem.Click += new System.EventHandler(this.btnGhiDiem_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.Location = new System.Drawing.Point(1469, 52);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(178, 51);
            this.btnNhapDiem.TabIndex = 8;
            this.btnNhapDiem.Text = "Nhập Điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnTaiLTC
            // 
            this.btnTaiLTC.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLTC.Location = new System.Drawing.Point(1193, 52);
            this.btnTaiLTC.Name = "btnTaiLTC";
            this.btnTaiLTC.Size = new System.Drawing.Size(229, 51);
            this.btnTaiLTC.TabIndex = 7;
            this.btnTaiLTC.Text = "Tải Lớp Tín Chỉ";
            this.btnTaiLTC.UseVisualStyleBackColor = true;
            this.btnTaiLTC.Click += new System.EventHandler(this.btnTaiLTC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(913, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Học Kỳ";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(628, 22);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(240, 41);
            this.cmbNienKhoa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Niên Khóa";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(105, 22);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(350, 41);
            this.cmbKhoa.TabIndex = 2;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gvSPLTC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 151);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2010, 102);
            this.panelControl1.TabIndex = 6;
            // 
            // gvSPLTC
            // 
            this.gvSPLTC.AllowUserToAddRows = false;
            this.gvSPLTC.AllowUserToDeleteRows = false;
            this.gvSPLTC.AllowUserToOrderColumns = true;
            this.gvSPLTC.AutoGenerateColumns = false;
            this.gvSPLTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSPLTC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gvSPLTC.DataSource = this.bdsSpLTC;
            this.gvSPLTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSPLTC.Location = new System.Drawing.Point(3, 3);
            this.gvSPLTC.Name = "gvSPLTC";
            this.gvSPLTC.ReadOnly = true;
            this.gvSPLTC.RowHeadersWidth = 82;
            this.gvSPLTC.RowTemplate.Height = 33;
            this.gvSPLTC.Size = new System.Drawing.Size(2004, 96);
            this.gvSPLTC.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALTC";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Lớp Tín Chỉ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Môn Học";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giảng Viên";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bdsSpLTC
            // 
            this.bdsSpLTC.DataMember = "SP_LayLTC";
            this.bdsSpLTC.DataSource = this.dS_SV;
            // 
            // dS_SV
            // 
            this.dS_SV.DataSetName = "DS_SV";
            this.dS_SV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS_SV;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LayLTCTableAdapter
            // 
            this.sP_LayLTCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS_SVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcDSDangKy
            // 
            this.gcDSDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSDangKy.Location = new System.Drawing.Point(0, 253);
            this.gcDSDangKy.MainView = this.gvDSDangKy;
            this.gcDSDangKy.Name = "gcDSDangKy";
            this.gcDSDangKy.Size = new System.Drawing.Size(2010, 821);
            this.gcDSDangKy.TabIndex = 7;
            this.gcDSDangKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSDangKy});
            // 
            // gvDSDangKy
            // 
            this.gvDSDangKy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maSV,
            this.tenSV,
            this.diemCC,
            this.diemGK,
            this.diemCK,
            this.diemTK});
            this.gvDSDangKy.GridControl = this.gcDSDangKy;
            this.gvDSDangKy.Name = "gvDSDangKy";
            this.gvDSDangKy.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvDSDangKy_ValidatingEditor);
            // 
            // maSV
            // 
            this.maSV.Caption = "Mã Sinh Viên";
            this.maSV.FieldName = "MASV";
            this.maSV.MinWidth = 40;
            this.maSV.Name = "maSV";
            this.maSV.OptionsColumn.AllowFocus = false;
            this.maSV.OptionsColumn.ReadOnly = true;
            this.maSV.Visible = true;
            this.maSV.VisibleIndex = 0;
            this.maSV.Width = 150;
            // 
            // tenSV
            // 
            this.tenSV.Caption = "Tên Sinh Viên";
            this.tenSV.FieldName = "HOTEN";
            this.tenSV.MinWidth = 40;
            this.tenSV.Name = "tenSV";
            this.tenSV.OptionsColumn.AllowFocus = false;
            this.tenSV.OptionsColumn.ReadOnly = true;
            this.tenSV.Visible = true;
            this.tenSV.VisibleIndex = 1;
            this.tenSV.Width = 150;
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
            this.diemTK.FieldName = "diemTK";
            this.diemTK.MinWidth = 40;
            this.diemTK.Name = "diemTK";
            this.diemTK.OptionsColumn.AllowEdit = false;
            this.diemTK.OptionsColumn.AllowFocus = false;
            this.diemTK.OptionsColumn.ReadOnly = true;
            this.diemTK.UnboundDataType = typeof(string);
            this.diemTK.UnboundExpression = "Round(Iif(IsNullOrEmpty([DIEM_CC]), 0, [DIEM_CC]) * 0.1 + Iif(IsNullOrEmpty([DIEM" +
    "_GK]), 0, [DIEM_GK]) * 0.3 + Iif(IsNullOrEmpty([DIEM_CK]), 0, [DIEM_CK]) * 0.6, " +
    "1)";
            this.diemTK.Visible = true;
            this.diemTK.VisibleIndex = 5;
            this.diemTK.Width = 150;
            // 
            // formNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 1074);
            this.Controls.Add(this.gcDSDangKy);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelChonKhoa);
            this.Name = "formNhapDiem";
            this.Text = "Nhập Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).EndInit();
            this.panelChonKhoa.ResumeLayout(false);
            this.panelChonKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSPLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSpLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSDangKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelChonKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGhiDiem;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnTaiLTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNhom;
        private DevExpress.XtraEditors.SpinEdit spinHK;
        private DS_SV dS_SV;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DS_SVTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsSpLTC;
        private DS_SVTableAdapters.SP_LayLTCTableAdapter sP_LayLTCTableAdapter;
        private DS_SVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gvSPLTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevExpress.XtraGrid.GridControl gcDSDangKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn maSV;
        private DevExpress.XtraGrid.Columns.GridColumn tenSV;
        private DevExpress.XtraGrid.Columns.GridColumn diemCC;
        private DevExpress.XtraGrid.Columns.GridColumn diemGK;
        private DevExpress.XtraGrid.Columns.GridColumn diemCK;
        private DevExpress.XtraGrid.Columns.GridColumn diemTK;
    }
}