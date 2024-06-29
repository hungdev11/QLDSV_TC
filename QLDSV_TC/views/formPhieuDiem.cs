using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QLDSV_TC.reports;

namespace QLDSV_TC.views
{
    public partial class formPhieuDiem : DevExpress.XtraEditors.XtraForm
    {
        public formPhieuDiem()
        {
            InitializeComponent();
        }

        private void formPhieuDiem_Load(object sender, EventArgs e)
        {
            Program.bdsDSPM.Filter = "TENCN not LIKE 'Kế Toán%'  ";
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else if (Program.mGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            if (cmbKhoa.SelectedIndex != Program.mPhongBan)
            {
                Program.mlogin = Program.remoteLogin;
                Program.pass = Program.remotePass;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.pass = Program.passDN;
            }
            if (!(Program.mloginDN.Equals("") && Program.passDN.Equals("") && Program.mGroup.Equals("")))
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                }
            }   
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Length > 10)
            {
                MessageBox.Show("Mã sinh viên không hợp lệ.", "Thông Báo", MessageBoxButtons.OK);
                txtMaSV.Focus();
            }
            else
            {
                try
                {
                    XtrPhieuDiem rpt = new reports.XtrPhieuDiem(txtMaSV.Text);
                    rpt.lbKhoa.Text = "KHOA: " + cmbKhoa.Text.ToUpper();
                    rpt.lbMaSV.Text = txtMaSV.Text.ToUpper();
                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sinh viên không tồn tại \n " + ex.Message);
                    txtMaSV.Focus();
                }
            }
        }
    }
}