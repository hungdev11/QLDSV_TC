using DevExpress.XtraReports.UI;
using QLDSV_TC.reports;
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
    public partial class formTongKetDiem : Form
    {
        public formTongKetDiem()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {    
                XtrDiemTongKetKhoaHoc rpt = new XtrDiemTongKetKhoaHoc(cbbLop.SelectedValue.ToString());

                int viTriHP = lOPBindingSource.Position;

                rpt.xlblLop.Text = "Lớp: " + cbbLop.Text + " - Niên Khóa: " + ((DataRowView)lOPBindingSource[viTriHP])["KHOAHOC"].ToString();
                rpt.xlblKhoa.Text = "Khoa " + cbbKhoa.Text;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch
            {
                MessageBox.Show("Không thể tìm thấy thông tin cần in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbKhoa.SelectedValue is DataRowView)
                {
                    return; // Exit the method if it is
                }
                Program.servername = cbbKhoa.SelectedValue.ToString();
                if (cbbKhoa.SelectedIndex != Program.mPhongBan)
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
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS_SV.LOP);
                    }
                }
            }
            catch (Exception) { }
        }

        private void formTongKetDiem_Load(object sender, EventArgs e)
        {
            dS_SV.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_SV.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS_SV.LOP);

            Program.bdsDSPM.Filter = "TENCN not LIKE 'Kế Toán%'  ";
            cbbKhoa.DataSource = Program.bdsDSPM;
            cbbKhoa.DisplayMember = "TENCN";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedValue = Program.servername;
            if (Program.mGroup == "PGV")
            {
                cbbKhoa.Enabled = true;
            }
            else
            {
                cbbKhoa.Enabled = false;
            }
            this.lOPTableAdapter.Fill(this.dS_SV.LOP); 
        }
    }
}
