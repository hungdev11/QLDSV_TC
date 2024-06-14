using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.views
{
    public partial class formNhapDiem : Form
    {
        String maLTC = "";
        DataTable dtDSDK = null;
        public formNhapDiem()
        {
            InitializeComponent();
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNhom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNienKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            btnGhiDiem.Enabled = false;
            gcDSDangKy.Enabled = false;
        }
        private void formNhapDiem_Load(object sender, EventArgs e)
        {
            Program.bdsDSPM.Filter = "TENCN not LIKE 'Kế Toán%'  ";
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.servername;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
                this.sP_LayLTCTableAdapter.Connection.ConnectionString = Program.connstr;
            }
            taiNienKhoa();
        }
        private void taiNienKhoa()
        {
            string cmd = "EXEC dbo.SP_LayNienKhoa";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbNienKhoa.DataSource = dt;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
        }
        private void taiMonHoc(String nienKhoa, int hocKy)
        {
            string cmd = "EXEC dbo.SP_LayMonHoc '"  + nienKhoa + "', " + hocKy;
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbMonHoc.DataSource = dt;
            cmbMonHoc.DisplayMember = "TENMH";
            cmbMonHoc.ValueMember = "MAMH";
        }
        private void taiNhom(String nienKhoa, int hocKy, String monHoc)
        {
            string cmd = "EXEC dbo.SP_LayNhom '" + nienKhoa + "', " + hocKy +", '" + monHoc + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbNhom.DataSource = dt;
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString().Equals("System.Data.DataRowView"))
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
                    this.sP_LayLTCTableAdapter.Connection.ConnectionString = Program.connstr;
                    taiNienKhoa();
                }
            }
        }
        private bool checkTaiLTC()
        {
            if (cmbMonHoc.SelectedValue == null || cmbNhom.Text.Equals(""))
            {
                MessageBox.Show("Hãy chọn môn học và nhóm", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnTaiLTC_Click(object sender, EventArgs e)
        {
            if (checkTaiLTC())
                this.sP_LayLTCTableAdapter.Fill(this.dS_SV.SP_LayLTC, cmbNienKhoa.SelectedValue.ToString().Trim(), int.Parse(spinHK.Text.Substring(0, 1)), int.Parse(cmbNhom.Text), cmbMonHoc.SelectedValue.ToString().Trim());
            else
                MessageBox.Show("Không tìm thấy lớp tín chỉ", "", MessageBoxButtons.OK);
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            taiNhom(cmbNienKhoa.Text, int.Parse(spinHK.Text.Substring(0, 1)), cmbMonHoc.SelectedValue.ToString().Trim());
        }
        private void spinHK_EditValueChanged(object sender, EventArgs e)
        {
            taiMonHoc(cmbNienKhoa.Text, int.Parse(spinHK.Text.Substring(0,1)));
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            maLTC = ((DataRowView)bdsSpLTC[0])["MALTC"].ToString();
            String query = "EXEC SP_LayDSDK " + maLTC;
            dtDSDK = Program.ExecSqlDataTable(query);
            
            if (dtDSDK != null)
                gcDSDangKy.DataSource = dtDSDK;
            if (dtDSDK.Rows.Count > 0)
            {
                btnTaiLTC.Enabled = false;
                cmbKhoa.Enabled = cmbNienKhoa.Enabled = cmbMonHoc.Enabled = spinHK.Enabled = cmbNhom.Enabled = false;
                btnGhiDiem.Enabled = true;
                btnNhapDiem.Enabled = false;
                gcDSDangKy.Enabled = true;
            } else
            {
                MessageBox.Show("Không có sinh viên nào để nhập điểm", "", MessageBoxButtons.OK);
            }
        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MALTC", typeof(int));
                dt.Columns.Add("MASV", typeof(string));
                dt.Columns.Add("DIEM_CC", typeof(int));
                dt.Columns.Add("DIEM_GK", typeof(float));
                dt.Columns.Add("DIEM_CK", typeof(float));
                int iMaLTC = int.Parse(maLTC);
                for (int i = 0; i < dtDSDK.Rows.Count; i++)
                {
                    dt.Rows.Add(iMaLTC, dtDSDK.Rows[i][0], dtDSDK.Rows[i][2], dtDSDK.Rows[i][3], dtDSDK.Rows[i][4]);
                }
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.KetNoi();

                SqlCommand cmd = new SqlCommand("SP_CapNhapDiem", Program.conn);
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(para);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ghi điểm thành công", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi điểm thất bại", "", MessageBoxButtons.OK);
            } 
            finally
            {
                btnTaiLTC.Enabled = true;
                cmbKhoa.Enabled = cmbNienKhoa.Enabled = cmbMonHoc.Enabled = spinHK.Enabled = cmbNhom.Enabled = true;
                btnGhiDiem.Enabled = false;
                btnNhapDiem.Enabled = true;
                gcDSDangKy.Enabled = false;
            }
        }
        private void gvDSDangKy_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            MessageBox.Show(e.Value.ToString());
            try
            {
                int value = Convert.ToInt32(e.Value);
                if (value > 10 || value < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm Không Hợp lệ: 0 <= Điểm <= 10";
                }
            }
            catch { }
        }

    }
}
