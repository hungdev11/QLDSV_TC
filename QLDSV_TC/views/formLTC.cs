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
    public partial class formLTC : Form
    {
        public formLTC()
        {
            InitializeComponent();
        }
        private void formLTC_Load(object sender, EventArgs e)
        {
            dS_SV.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_SV.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.dS_SV.LOPTINCHI);


            Program.bdsDSPM.Filter = "TENCN not LIKE 'Kế Toán%'  ";
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.servername;

            //    cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
            {
                //panelControl1.Enabled = true;
            }
            if (bdsLTC.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = false;
            else
                btnXoa.Enabled = btnSua.Enabled = true;


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
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dS_SV.LOPTINCHI);

            }
            if (bdsLTC.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = false;
            else
                btnXoa.Enabled = btnSua.Enabled = true;
        }

        private void gvLTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = gvLTC.Rows[e.RowIndex];  //tracking mouse click
                txtNienKhoa.Text = clickedRow.Cells[1].Value.ToString();
                spinHocKy.Text = clickedRow.Cells[2].Value.ToString();
                txtMaMonHoc.Text = clickedRow.Cells[3].Value.ToString();
                spinNhom.Text = clickedRow.Cells[4].Value.ToString();
                txtMaGiangVien.Text = clickedRow.Cells[5].Value.ToString();
                txtKhoa.Text = clickedRow.Cells[6].Value.ToString();
                spinSVToiThieu.Text = clickedRow.Cells[7].Value.ToString();
                checkHuyLTC.Checked = (bool)clickedRow.Cells[8].Value;

                clickedRow.ReadOnly = false;
            }
        }
    }
}
