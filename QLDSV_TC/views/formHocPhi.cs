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
    public partial class formHocPhi : Form
    {
        private String maSV = "";
        private int viTriHP = -1;
        private int viTriCTHP = -1;
        private String flagMode = "";
        public formHocPhi()
        {
            InitializeComponent();
            txtMaLop.Enabled = txtTenSV.Enabled = daDong.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            SVIF.Enabled = false;
        }
        private void formHocPhi_Load(object sender, EventArgs e)
        {

        }
        private void fillInfo()
        {
            nienKhoa.Text = " ";
            hocKy.Value = 1;
            hocPhi.Value = 0;
            daDong.Value = 0;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flagMode = "ADD";
            viTriHP = bdsHocPhi.Position;
            bdsHocPhi.AddNew();
            fillInfo();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            SVIF.Enabled = true;
            nienKhoa.Enabled = hocKy.Enabled = true;
            traCuu.Enabled = false;
            gcCTHP.Enabled = gcHocPhi.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTriHP = bdsHocPhi.Position;
            flagMode = "EDIT";

            SVIF.Enabled = true;
            nienKhoa.Enabled = hocKy.Enabled = true;
            traCuu.Enabled = false;
            gcCTHP.Enabled = gcHocPhi.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin học phí này ko?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {  
                try
                {
                    String nienkhoa = nienKhoa.Text.Trim();
                    int hocky = (int)hocKy.Value;
                    int hocphi = (int)hocPhi.Value;
                    string cmd = "EXEC [dbo].[SP_XoaHocPhi] '" + maSV + "' , '" + nienkhoa + "' , " + hocky + "";
                    if (Program.ExecSqlNonQuery(cmd) != 0)
                        return;

                    this.sP_TaiHocPhiTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_TaiHocPhiTableAdapter.Fill(this.dS_HP.SP_TaiHocPhi, maSV);

                    gcHocPhi.Enabled = gcCTHP.Enabled = true;
                    traCuu.Enabled = true;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                    btnGhi.Enabled = btnPhucHoi.Enabled = false;
                    SVIF.Enabled = false;
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Học Phí, bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHocPhi.CancelEdit();
            this.sP_TaiHocPhiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_TaiHocPhiTableAdapter.Fill(this.dS_HP.SP_TaiHocPhi, maSV);

            gcHocPhi.Enabled = gcCTHP.Enabled = true;
            traCuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            SVIF.Enabled = false;

            if (bdsHocPhi.Count == 0)
            {

                bdsCTHocPhi.DataSource = null;
                gcCTHP.Enabled = false;
                return;
            }

            bdsHocPhi.Position = viTriHP;
            taiCTDongHocPhi();
        }
        private bool checkHocPhiInput()
        {
            if (nienKhoa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Niên khóa không được để trống", "", MessageBoxButtons.OK);
                nienKhoa.Focus();
                return false;
            }
            else if (hocKy.Text.Trim().Equals(""))
            {
                MessageBox.Show("Học kỳ không được để trống", "", MessageBoxButtons.OK);
                hocKy.Focus();
                return false;
            }
            else if (hocPhi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Học phí không được để trống", "", MessageBoxButtons.OK);
                hocPhi.Focus();
                return false;
            }
            return true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkHocPhiInput())
            {
                String nienkhoa = nienKhoa.Text.Trim();
                int hocky = (int)hocKy.Value;
                int hocphi = (int)hocPhi.Value;
                string cmd = null;
                if (flagMode.Equals("ADD"))
                    cmd = "EXEC [dbo].[SP_ThemHocPhi] '" + maSV + "' , '" + nienkhoa + "' , " + hocky + " ," + hocphi + "";
                else
                    cmd = "EXEC [dbo].[SP_SuaHocPhi] '" + maSV + "' , '" + nienkhoa + "' , " + hocky + " ," + hocphi + "";
                try
                {
                    if (Program.ExecSqlNonQuery(cmd) != 0)
                        return;

                    this.sP_TaiHocPhiTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_TaiHocPhiTableAdapter.Fill(this.dS_HP.SP_TaiHocPhi, maSV);
                    taiCTDongHocPhi();


                    gcHocPhi.Enabled = gcCTHP.Enabled = true;
                    traCuu.Enabled = true;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                    btnGhi.Enabled = btnPhucHoi.Enabled = false;
                    SVIF.Enabled = false;
                    MessageBox.Show("Học Phí đã được cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    //modeFlag = modeFlag.Substring(1);
                    MessageBox.Show("Lỗi ghi học phí: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }       
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (traCuu.Enabled == false)
            {
                if (MessageBox.Show("Dữ liệu chưa được cập nhật! Bạn có muốn thoát không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.Close();
            }
            else
                this.Close();
        }
        private void taiThongTinSV()
        {
            try
            {
                string command = "EXEC SP_LayThongTinSV " + "'" + traCuuSV.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(command);

                if (Program.myReader == null) return;

                Program.myReader.Read();
                txtTenSV.Text = Program.myReader.GetString(1);
                txtMaLop.Text = Program.myReader.GetString(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải thông tin của sinh viên" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Program.myReader.Close();
            }
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                taiThongTinSV();
                maSV = traCuuSV.Text.Trim();
                this.sP_TaiHocPhiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_TaiHocPhiTableAdapter.Fill(this.dS_HP.SP_TaiHocPhi, maSV);
                gcHocPhi.DataSource = bdsHocPhi;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }
        private void taiCTDongHocPhi()
        {
            viTriHP = bdsHocPhi.Position;
            String nienkhoa = ((DataRowView)bdsHocPhi[viTriHP])["NIENKHOA"].ToString();
            String hocky = ((DataRowView)bdsHocPhi[viTriHP])["HOCKY"].ToString();

            this.sP_TaiCTHocPhiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_TaiCTHocPhiTableAdapter.Fill(this.dS_HP.SP_TaiCTHocPhi, maSV, nienkhoa, int.Parse(hocky));
            gcCTHP.DataSource = bdsCTHocPhi;
        }

        private void gcHocPhi_Click(object sender, EventArgs e)
        {
            taiCTDongHocPhi();
        }
    }
}
