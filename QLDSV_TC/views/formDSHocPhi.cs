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
    public partial class formDSHocPhi : Form
    {
        public formDSHocPhi()
        {
            InitializeComponent();
        }

        private void formDSHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_HP.LOP1' table. You can move, or remove it, as needed.
            this.lOP1TableAdapter.Fill(this.dS_HP.LOP1);

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            

            XtraReport1 rpt = new XtraReport1(cbbLop.SelectedValue.ToString().Trim(), cbbNienKhoa.Text.ToString(), int.Parse(spinEditHk.Value.ToString()));

            rpt.xlblMaLop.Text = cbbLop.Text + " - " + cbbLop.SelectedValue.ToString();
            string cmd = "exec [SP_LayKhoaTuLop] '" + cbbLop.SelectedValue.ToString().Trim() + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            rpt.xlblKhoa.Text = dt.Rows[0][1].ToString();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cbblop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
