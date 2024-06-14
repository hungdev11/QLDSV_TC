namespace QLDSV_TC.views
{
    partial class formDSHocPhi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spinEditHk = new DevExpress.XtraEditors.SpinEdit();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.cbbNienKhoa = new System.Windows.Forms.ComboBox();
            this.dS_HP = new QLDSV_TC.DS_HP();
            this.lOP1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOP1TableAdapter = new QLDSV_TC.DS_HPTableAdapters.LOP1TableAdapter();
            this.btnin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOP1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Niên khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Học kỳ";
            // 
            // spinEditHk
            // 
            this.spinEditHk.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditHk.Location = new System.Drawing.Point(215, 255);
            this.spinEditHk.Margin = new System.Windows.Forms.Padding(6);
            this.spinEditHk.Name = "spinEditHk";
            this.spinEditHk.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditHk.Properties.Appearance.Options.UseFont = true;
            this.spinEditHk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditHk.Properties.IsFloatValue = false;
            this.spinEditHk.Properties.MaskSettings.Set("mask", "N00");
            this.spinEditHk.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinEditHk.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditHk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinEditHk.Size = new System.Drawing.Size(137, 56);
            this.spinEditHk.TabIndex = 6;
            // 
            // cbbLop
            // 
            this.cbbLop.DataSource = this.lOP1BindingSource;
            this.cbbLop.DisplayMember = "TENLOP";
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(186, 60);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(535, 50);
            this.cbbLop.TabIndex = 9;
            this.cbbLop.ValueMember = "MALOP";
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbblop_SelectedIndexChanged);
            // 
            // cbbNienKhoa
            // 
            this.cbbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNienKhoa.FormattingEnabled = true;
            this.cbbNienKhoa.Items.AddRange(new object[] {
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024"});
            this.cbbNienKhoa.Location = new System.Drawing.Point(258, 155);
            this.cbbNienKhoa.Name = "cbbNienKhoa";
            this.cbbNienKhoa.Size = new System.Drawing.Size(313, 50);
            this.cbbNienKhoa.TabIndex = 10;
            // 
            // dS_HP
            // 
            this.dS_HP.DataSetName = "DS_HP";
            this.dS_HP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOP1BindingSource
            // 
            this.lOP1BindingSource.DataMember = "LOP1";
            this.lOP1BindingSource.DataSource = this.dS_HP;
            // 
            // lOP1TableAdapter
            // 
            this.lOP1TableAdapter.ClearBeforeFill = true;
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(1086, 145);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(238, 141);
            this.btnin.TabIndex = 11;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // formDSHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 552);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.cbbNienKhoa);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.spinEditHk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formDSHocPhi";
            this.Text = "formDSHocPhi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formDSHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOP1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SpinEdit spinEditHk;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.ComboBox cbbNienKhoa;
        private DS_HP dS_HP;
        private System.Windows.Forms.BindingSource lOP1BindingSource;
        private DS_HPTableAdapters.LOP1TableAdapter lOP1TableAdapter;
        private System.Windows.Forms.Button btnin;
    }
}