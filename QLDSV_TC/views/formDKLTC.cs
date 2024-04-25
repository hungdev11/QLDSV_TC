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
    public partial class formDKLTC : Form
    {
        int maLTC = -1;
        DataTable dtDSLTC = null;
        DataTable dtDSLTCDaDangKy = null;
        public formDKLTC()
        {
            InitializeComponent();
            thongTinSV.Enabled = false;
            cmbNienKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            btnDangKy.Enabled = btnHuyDangKy.Enabled = false;
            txtLTC.Enabled = txtMH.Enabled = txtGV.Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            String query = "EXEC SP_DSLTC '" + cmbNienKhoa.Text + "'," + spinHK.Text.Substring(0, 1);
            dtDSLTC = Program.ExecSqlDataTable(query);
            if (dtDSLTC != null)
                gcDSLTC.DataSource = dtDSLTC;

            String query2 = "EXEC [SP_DSLTCSVDaDangky] '" + txtMaSV.Text + "','"+ cmbNienKhoa.Text + "'," + spinHK.Text.Substring(0, 1);
            dtDSLTCDaDangKy = Program.ExecSqlDataTable(query2);
            if (dtDSLTCDaDangKy != null)
                gcLTCDaDK.DataSource = dtDSLTCDaDangKy;
        }
        private void taiThongTinSV()
        {
            try
            {
                string command = "EXEC SP_LayThongTinSV " + "'" + Program.username + "'";
                Program.myReader = Program.ExecSqlDataReader(command);

                if (Program.myReader == null) return;

                Program.myReader.Read();
                txtMaSV.Text = Program.myReader.GetString(0);
                txtTenSV.Text = Program.myReader.GetString(1);
                txtMaLop.Text = Program.myReader.GetString(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load thông tin của bạn trong sever" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Program.myReader.Close();
            }
        }
        private void taiNienKhoa()
        {
            string cmd = "EXEC dbo.SP_LayNienKhoa";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbNienKhoa.DataSource = dt;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
        }
        private void formDKLTC_Load(object sender, EventArgs e)
        {
            taiThongTinSV();
            taiNienKhoa();
        }

        private void gvLTCDaDK_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnHuyDangKy.Enabled = true;
            btnDangKy.Enabled = false;
            maLTC = int.Parse(dtDSLTCDaDangKy.Rows[e.RowHandle][0].ToString());
            txtLTC.Text = maLTC.ToString();
            txtMH.Text = dtDSLTCDaDangKy.Rows[e.RowHandle]["tenMH"].ToString();
            txtGV.Text = dtDSLTCDaDangKy.Rows[e.RowHandle]["tenGV"].ToString();

        }
        private void gvLTC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnDangKy.Enabled = true;
            btnHuyDangKy.Enabled = false;
            maLTC = int.Parse(dtDSLTC.Rows[e.RowHandle][0].ToString());
            txtLTC.Text = maLTC.ToString();
            txtMH.Text = dtDSLTC.Rows[e.RowHandle]["tenMH"].ToString();
            txtGV.Text = dtDSLTC.Rows[e.RowHandle]["tenGV"].ToString();
        }
        private void taiLaiLTC()
        {
            String query = "EXEC SP_DSLTC '" + cmbNienKhoa.Text + "'," + spinHK.Text.Substring(0, 1);
            dtDSLTC = Program.ExecSqlDataTable(query);
            if (dtDSLTC != null)
                gcDSLTC.DataSource = dtDSLTC;

            String query2 = "EXEC [SP_DSLTCSVDaDangky] '" + txtMaSV.Text + "','" + cmbNienKhoa.Text + "'," + spinHK.Text.Substring(0, 1);
            dtDSLTCDaDangKy = Program.ExecSqlDataTable(query2);
            if (dtDSLTCDaDangKy != null)
                gcLTCDaDK.DataSource = dtDSLTCDaDangKy;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC [dbo].[SP_LTC_DangKy] " + txtLTC.Text + " , '" + txtMaSV.Text + "' ";
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Đăng kí thành công!");
                    taiLaiLTC();

                }
                else
                {
                    MessageBox.Show("Đăng kí thất bại");
                }
            }
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC [dbo].[SP_LTC_HuyDangKy] " + txtLTC.Text + " , '" + txtMaSV.Text + "' ";
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Hủy đăng kí thành công!");
                    taiLaiLTC();
                }
                else
                {
                    MessageBox.Show("Hủy đăng kí thất bại");
                }
            }
        }
    }
}
