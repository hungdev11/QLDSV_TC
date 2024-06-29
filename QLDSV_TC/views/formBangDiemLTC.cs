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
    public partial class formBangDiemLTC : Form
    {
        public formBangDiemLTC()
        {
            InitializeComponent();
        }

        private void formBangDiemLTC_Load(object sender, EventArgs e)
        {
            Program.bdsDSPM.Filter = "TENCN not LIKE 'Kế Toán%'  ";
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            //cmbKhoa.SelectedIndex = Program.mPhongBan;
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else if (Program.mGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
            }
            loadcbNienkhoa();
        }

        void loadcbNienkhoa()
        {

            string cmd = "EXEC SP_LayNienKhoa";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbNienKhoa.DataSource = dt;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";

        }

        void loadcbHocKi(string nienkhoa)
        {

            string cmd = "EXEC SP_GET_HOCKY '" + nienkhoa + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbHocKy.DataSource = dt;
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";

        }

        void loadMH(string nienkhoa, string hocki)
        {

            string cmd = "EXEC SP_LayMonHoc '" + nienkhoa + "', " + hocki;
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbMonHoc.DataSource = dt;
            cmbMonHoc.DisplayMember = "TENMH";
            cmbMonHoc.ValueMember = "MAMH";
        }

        void loadNhom(string nienkhoa, string hocki, string mamonhoc)
        {

            string cmd = "SP_LayNhom '" + nienkhoa + "', " + hocki + ", '" + mamonhoc + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbNhom.DataSource = dt;
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNienKhoa.Text != "System.Data.DataRowView")
                loadcbHocKi(cmbNienKhoa.Text);
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHocKy.Text != "System.Data.DataRowView")
                loadMH(cmbNienKhoa.Text, cmbHocKy.Text);
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonHoc.Text != "System.Data.DataRowView" && cmbMonHoc.SelectedValue != null)
                loadNhom(cmbNienKhoa.Text, cmbHocKy.Text, cmbMonHoc.SelectedValue.ToString());
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
                    cmbNienKhoa.DataSource = null;
                    cmbHocKy.DataSource = null;
                    cmbMonHoc.DataSource = null;
                    cmbNhom.DataSource = null;
                    loadcbNienkhoa();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbNienKhoa.Text == "" || cmbHocKy.Text == "" || cmbMonHoc.Text == "" || cmbNhom.Text == "")
            {
                MessageBox.Show("Không có thông tin lớp tín chỉ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                reports.XtrBangDiemLTC rpt = new reports.XtrBangDiemLTC(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text), int.Parse(cmbNhom.Text), cmbMonHoc.SelectedValue.ToString().Trim());

                rpt.lbKhoa.Text = "KHOA: " + cmbKhoa.Text;
                rpt.lbNienKhoa.Text = cmbNienKhoa.Text.Trim();
                rpt.lbhocKy.Text = cmbHocKy.Text;
                rpt.lbNhom.Text = cmbNhom.Text;
                rpt.lbMonHoc.Text = cmbMonHoc.Text.Trim();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }
    }
}
