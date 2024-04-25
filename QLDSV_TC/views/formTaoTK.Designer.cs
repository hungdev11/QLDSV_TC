
namespace QLDSV_TC.views
{
    partial class formTaoTK
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
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dS_SV = new QLDSV_TC.DS_SV();
            this.bdsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.dSGVTableAdapter = new QLDSV_TC.DS_SVTableAdapters.DSGVTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS_SVTableAdapters.TableAdapterManager();
            this.cmbDSGV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTK = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.groupROLE = new DevExpress.XtraEditors.RadioGroup();
            this.label4 = new System.Windows.Forms.Label();
            this.hienMatKhau = new System.Windows.Forms.CheckBox();
            this.txtMK2 = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupROLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(151, 620);
            this.btnTaoTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(263, 148);
            this.btnTaoTK.TabIndex = 0;
            this.btnTaoTK.Text = "Tạo Tài Khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(644, 620);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(217, 148);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dS_SV
            // 
            this.dS_SV.DataSetName = "DS_SV";
            this.dS_SV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSGV
            // 
            this.bdsDSGV.DataMember = "DSGV";
            this.bdsDSGV.DataSource = this.dS_SV;
            // 
            // dSGVTableAdapter
            // 
            this.dSGVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS_SVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbDSGV
            // 
            this.cmbDSGV.DataSource = this.bdsDSGV;
            this.cmbDSGV.DisplayMember = "HOTEN";
            this.cmbDSGV.FormattingEnabled = true;
            this.cmbDSGV.Location = new System.Drawing.Point(333, 125);
            this.cmbDSGV.Name = "cmbDSGV";
            this.cmbDSGV.Size = new System.Drawing.Size(434, 41);
            this.cmbDSGV.TabIndex = 3;
            this.cmbDSGV.ValueMember = "MAGV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giảng Viên";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(333, 208);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(397, 40);
            this.txtTK.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(333, 298);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(397, 40);
            this.txtMK.TabIndex = 8;
            // 
            // groupROLE
            // 
            this.groupROLE.Location = new System.Drawing.Point(261, 476);
            this.groupROLE.Name = "groupROLE";
            this.groupROLE.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupROLE.Properties.Appearance.Options.UseFont = true;
            this.groupROLE.Properties.Columns = 3;
            this.groupROLE.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PGV", "Phòng Giáo Vụ", true, null, ""),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PKT", "Phòng Kế Toán"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("KHOA", "Khoa")});
            this.groupROLE.Size = new System.Drawing.Size(753, 74);
            this.groupROLE.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quyền";
            // 
            // hienMatKhau
            // 
            this.hienMatKhau.AutoSize = true;
            this.hienMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienMatKhau.Location = new System.Drawing.Point(802, 375);
            this.hienMatKhau.Name = "hienMatKhau";
            this.hienMatKhau.Size = new System.Drawing.Size(212, 37);
            this.hienMatKhau.TabIndex = 14;
            this.hienMatKhau.Text = "Hiện mật khẩu";
            this.hienMatKhau.UseVisualStyleBackColor = true;
            this.hienMatKhau.CheckedChanged += new System.EventHandler(this.hienMatKhau_CheckedChanged);
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(333, 374);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.Size = new System.Drawing.Size(397, 40);
            this.txtMK2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // formTaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 826);
            this.Controls.Add(this.txtMK2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hienMatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupROLE);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDSGV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoTK);
            this.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTaoTK";
            this.Text = "formTaoTK";
            this.Load += new System.EventHandler(this.formTaoTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupROLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnThoat;
        private DS_SV dS_SV;
        private System.Windows.Forms.BindingSource bdsDSGV;
        private DS_SVTableAdapters.DSGVTableAdapter dSGVTableAdapter;
        private DS_SVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbDSGV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.RadioGroup groupROLE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox hienMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMK2;
        private System.Windows.Forms.Label label5;
    }
}