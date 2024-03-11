
namespace QLDSV_TC.views
{
    partial class formLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtBMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.comBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.hienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.checkIsSV = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng Ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtBTaiKhoan
            // 
            this.txtBTaiKhoan.Location = new System.Drawing.Point(309, 256);
            this.txtBTaiKhoan.Name = "txtBTaiKhoan";
            this.txtBTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.txtBTaiKhoan.Size = new System.Drawing.Size(386, 48);
            this.txtBTaiKhoan.TabIndex = 3;
            // 
            // txtBMatKhau
            // 
            this.txtBMatKhau.Location = new System.Drawing.Point(309, 356);
            this.txtBMatKhau.Name = "txtBMatKhau";
            this.txtBMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtBMatKhau.Size = new System.Drawing.Size(386, 48);
            this.txtBMatKhau.TabIndex = 4;
            // 
            // comBoxPhongBan
            // 
            this.comBoxPhongBan.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxPhongBan.FormattingEnabled = true;
            this.comBoxPhongBan.Location = new System.Drawing.Point(309, 159);
            this.comBoxPhongBan.Name = "comBoxPhongBan";
            this.comBoxPhongBan.Size = new System.Drawing.Size(386, 41);
            this.comBoxPhongBan.TabIndex = 5;
            this.comBoxPhongBan.SelectedIndexChanged += new System.EventHandler(this.comBoxPhongBan_SelectedIndexChanged);
            // 
            // hienMatKhau
            // 
            this.hienMatKhau.AutoSize = true;
            this.hienMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienMatKhau.Location = new System.Drawing.Point(754, 367);
            this.hienMatKhau.Name = "hienMatKhau";
            this.hienMatKhau.Size = new System.Drawing.Size(212, 37);
            this.hienMatKhau.TabIndex = 6;
            this.hienMatKhau.Text = "Hiện mật khẩu";
            this.hienMatKhau.UseVisualStyleBackColor = true;
            this.hienMatKhau.CheckedChanged += new System.EventHandler(this.hienMatKhau_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(309, 504);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(181, 77);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(514, 504);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(181, 77);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // checkIsSV
            // 
            this.checkIsSV.AutoSize = true;
            this.checkIsSV.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIsSV.Location = new System.Drawing.Point(417, 70);
            this.checkIsSV.Name = "checkIsSV";
            this.checkIsSV.Size = new System.Drawing.Size(159, 37);
            this.checkIsSV.TabIndex = 9;
            this.checkIsSV.Text = "Sinh Viên";
            this.checkIsSV.UseVisualStyleBackColor = true;
            this.checkIsSV.CheckedChanged += new System.EventHandler(this.checkIsSV_CheckedChanged);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 648);
            this.Controls.Add(this.checkIsSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.hienMatKhau);
            this.Controls.Add(this.comBoxPhongBan);
            this.Controls.Add(this.txtBMatKhau);
            this.Controls.Add(this.txtBTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formLogin";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtBTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtBMatKhau;
        private System.Windows.Forms.ComboBox comBoxPhongBan;
        private System.Windows.Forms.CheckBox hienMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox checkIsSV;
    }
}