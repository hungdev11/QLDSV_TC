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
        private int viTri = 0;

        public formLTC()
        {
            InitializeComponent();
            cmbTenGV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTenMH.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void formLTC_Load(object sender, EventArgs e)
        {
           
            dS_SV.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_SV.DSGV' table. You can move, or remove it, as needed.
            this.dSGVTableAdapter.Fill(this.dS_SV.DSGV);
            // TODO: This line of code loads data into the 'dS_SV.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS_SV.MONHOC);
            // TODO: This line of code loads data into the 'dS_SV.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.dS_SV.LOPTINCHI);
            // TODO: This line of code loads data into the 'dS_SV.DANGKY' table. You can move, or remove it, as needed.
            this.dANGKYTableAdapter.Fill(this.dS_SV.DANGKY);

            Program.bdsDSPM.Filter = "TENCN not LIKE 'Kế Toán%'  ";
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.servername;
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;

            txtMaKhoa.Enabled = false;
            //    cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
            {
                panelChonKhoa.Enabled = true;
            }
            else
            {
                panelChonKhoa.Enabled = false;
            }
            if (bdsLTC.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = false;
            else
            {
                btnXoa.Enabled = btnSua.Enabled = true; 
                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                infoLTC.Enabled = false;
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
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frmLTC.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLTC.Position;
            bdsLTC.AddNew();
            try
            {
                DataTable dt = Program.ExecSqlDataTable("EXEC SP_LayMaKhoa");
                String makhoa = dt.Rows[0][0].ToString();
                txtMaKhoa.Text = makhoa;
                //dt = Program.ExecSqlDataTable("EXEC SP_LayMaLTCMoiNhat");
                //int maLTC = maLTC = Convert.ToInt32(dt.Rows[0][0]) + 1;
            }
            catch
            {
                bdsLTC.CancelEdit();
                MessageBox.Show("Lỗi kết nối server!");
                return;
            }
            infoLTC.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            cmbKhoa.Enabled = false;
            gcLTC.Enabled = false;
            huyLop.Enabled = false;
            txtMaGV.Enabled = txtMaMH.Enabled = false;
            huyLop.Checked = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDangky.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp tín chỉ vì đã có sinh viên đăng kí ", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa lớp tín chỉ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLTC.RemoveCurrent();
                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTINCHITableAdapter.Update(this.dS_SV.LOPTINCHI);
                    if (bdsLTC.Count == 0)
                        btnXoa.Enabled = btnSua.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp, bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTINCHITableAdapter.Fill(this.dS_SV.LOPTINCHI);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLTC.Position;
            infoLTC.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            cmbKhoa.Enabled = false;
            gcLTC.Enabled = false;
            txtMaGV.Enabled = txtMaMH.Enabled = false;
            huyLop.Checked = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS_SV.LOPTINCHI);
            bdsLTC.Position = viTri;
            infoLTC.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            cmbKhoa.Enabled = true;
            gcLTC.Enabled = true;
            huyLop.Enabled = true;
            txtMaGV.Enabled = txtMaMH.Enabled = true;
        }
        private bool checkLTCInput()
        {
            if (txtNienKhoa.Text.Trim().Equals(""))
            {
                MessageBox.Show("vui lòng điền niên khóa!", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return false;
            }
            if (hocKy.Text.Trim().Equals(""))
            {
                MessageBox.Show("vui lòng chọn học kỳ!", "", MessageBoxButtons.OK);
                hocKy.Focus();
                return false;
            }

            if (txtMaMH.Text.Trim().Equals(""))
            {
                MessageBox.Show("vui lòng chọn môn học!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return false;
            }
            if (txtMaGV.Text.Trim().Equals(""))
            {
                MessageBox.Show("vui lòng chọn giáo viên!", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return false;
            }
            if (nhom.Text.Trim().Equals(""))
            {
                MessageBox.Show("vui lòng chọn nhóm!", "", MessageBoxButtons.OK);
                nhom.Focus();
                return false;
            }

            if (soSVToiThieu.Text.Trim().Equals(""))
            {
                MessageBox.Show("vui lòng nhập số sinh viên tối thiểu!", "", MessageBoxButtons.OK);
                soSVToiThieu.Focus();
                return false;
            }
            return true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkLTCInput())
            {
                return;
            }
            try
            {
                bdsLTC.EndEdit();
                bdsLTC.ResetCurrentItem();
                this.lOPTINCHITableAdapter.Update(this.dS_SV.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            infoLTC.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            cmbKhoa.Enabled = true;
            gcLTC.Enabled = true;
            txtMaGV.Enabled = txtMaMH.Enabled = true;
        }

        private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTenMH.SelectedValue != null)
                    txtMaMH.Text = cmbTenMH.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void cmbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTenGV.SelectedValue != null)
                    txtMaGV.Text = cmbTenGV.SelectedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
