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
    public partial class formLop : Form
    {
        public formLop()
        {
            InitializeComponent();
        }
        private void formLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SV.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Fill(this.dS_SV.SINHVIEN);
            dS_SV.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_SV.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS_SV.LOP);

            panelThongTinLop.Enabled = false;

            Program.bdsDSPM.Filter = "TENCN NOT LIKE 'Kế Toán%'";
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.servername;

            if (Program.mGroup == "PGV")
            {
                panelChonKhoa.Enabled = true;
            }
            else
            {
                panelChonKhoa.Enabled = false;
            }
        }
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbKhoa.SelectedValue is DataRowView)
                {
                    return; // Exit the method if it is
                }
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
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS_SV.LOP);
                    //gvLop.ReadOnly = true;
                }
            }
            catch (Exception) { }
        }

        private void lOPDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = gvLop.Rows[e.RowIndex];  //tracking mouse click
                txtKhoa.Text = clickedRow.Cells[3].Value.ToString();
                txtMaLop.Text = clickedRow.Cells[0].Value.ToString();
                txtTenLop.Text = clickedRow.Cells[1].Value.ToString();
                txtKhoaHoc.Text = clickedRow.Cells[2].Value.ToString();
                clickedRow.ReadOnly = false;

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS_SV.SINHVIEN);

                dgvSinhVien.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frmLop.Close();
        }
    }
}
