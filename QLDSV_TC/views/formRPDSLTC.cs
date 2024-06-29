using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.views
{
    public partial class formRPDSLTC : DevExpress.XtraEditors.XtraForm
    {
        public formRPDSLTC()
        {
            InitializeComponent();
        }

        private void formRPDSLTC_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            Program.bdsDSPM.Filter = "TENCN not LIKE 'Kế Toán%'  ";
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "KHOA")
            {
                panelControl1.Enabled = false;
            }
            loadcbNienkhoa();
        }

        void loadcbNienkhoa()
        {

            string cmd = "EXEC dbo.SP_LayNienKhoa";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cbNIENKHOA.DataSource = dt;
            cbNIENKHOA.DisplayMember = "NIENKHOA";
            cbNIENKHOA.ValueMember = "NIENKHOA";

        }
        void loadcbHocKi(string nienkhoa)
        {

            string cmd = "EXEC dbo.SP_GET_HOCKY '" + nienkhoa + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cbHOCKY.DataSource = dt;
            cbHOCKY.DisplayMember = "HOCKY";
            cbHOCKY.ValueMember = "HOCKY";

        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

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
                else
                {
                    loadcbNienkhoa();
                    loadcbHocKi(cbNIENKHOA.Text);
                }
            }
        }

        private void cbNIENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbNIENKHOA.Text);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (cbNIENKHOA.Text == "" || cbHOCKY.Text == "")
            {
                MessageBox.Show("Không có thông tin lớp tín chỉ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                reports.XtrDSLTC rpt = new reports.XtrDSLTC(cbNIENKHOA.Text, int.Parse(cbHOCKY.Text));
                rpt.lbNienKhoa.Text = cbNIENKHOA.Text;
                rpt.lcHocKy.Text = cbHOCKY.Text;
                rpt.lbKhoa.Text = "KHOA: " + cmbKhoa.Text.ToUpper();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }


        }
    }
}