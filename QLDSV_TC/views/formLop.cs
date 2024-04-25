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
        private int viTri = 0;
        private int viTriSV = 0;
        private String modeFlag = ""; // flag them, sua, xoa LOP
        private String modeFlagSV = ""; // flag them, sua, xoa SINH VIEN
        private String catcheTenLOP = "";

        public formLop()
        {
            InitializeComponent();
        }
        private void formLop_Load(object sender, EventArgs e)
        {            
            lopInfo.Enabled = false;
            SVInfo.Enabled = false;

            dS_SV.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS_SV.DANGKY);

            // TODO: This line of code loads data into the 'dS_SV.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS_SV.LOP);
            // TODO: This line of code loads data into the 'dS_SV.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.dS_SV.SINHVIEN);

            Program.bdsDSPM.Filter = "TENCN NOT LIKE 'Kế Toán%'";
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.servername;
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;


            if (Program.mGroup == "PGV")
            {
                panelChonKhoa.Enabled = true;
            }
            else
            {
                panelChonKhoa.Enabled = false;
            }
            if (bdsLop.Count > 0)
            {
                btnXoa.Enabled = btnSua.Enabled = groupBtnSV.Enabled = true;
                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                btnUndoSV.Enabled = btnGhiSV.Enabled = false;
            }
        }
        private void clearLopInfo()
        {
            txtMaLop.Text = txtKhoaHoc.Text = txtTenLop.Text = "";
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

                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS_SV.SINHVIEN);
                }
            }
            catch (Exception) { }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frmLop.Close();
        }
        

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLop.Position;
            bdsLop.AddNew();
            try
            {
                DataTable dt = Program.ExecSqlDataTable("EXEC SP_LayMaKhoa");
                String makhoa = dt.Rows[0][0].ToString();
                txtMaKhoa.Text = makhoa;
            }
            catch

            {
                bdsLop.CancelEdit();
                MessageBox.Show("Lỗi kết nối server!");
                return;
            }
            modeFlag = "ADD";
            clearLopInfo();
            gcLop.Enabled = false;
            lopInfo.Enabled = true;

            txtMaKhoa.Enabled = false;
            panelChonKhoa.Enabled = false;
            groupBtnSV.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            
            //panelThongTinLop.Enabled = true;

        }
        private bool checkLopInput()
        {
            if (txtMaLop.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã lớp không được để trống", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }
            else if (txtTenLop.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên lớp không được để trống", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            else if (txtKhoaHoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Khóa học lớp không được để trống", "", MessageBoxButtons.OK);
                txtKhoaHoc.Focus();
                return false;
            }
            if (modeFlag.Equals("ADD"))
            {
                string kiemTraMaLop = " DECLARE @return_value INT " +         //Kiểm tra mã lớp có tồn tại hay không?
                               " EXEC @return_value = [dbo].[SP_CHECKID] " +
                               " @ID = N'" + txtMaLop.Text.Trim() + "',  " +
                               " @Type = N'MALOP' " +
                               " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(kiemTraMaLop);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau!", "", MessageBoxButtons.OK);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã Lớp đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Mã Lớp đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (modeFlag == "ADD" || (modeFlag == "EDIT") && !catcheTenLOP.Equals(txtTenLop.Text.Trim()) )    ///Tranh loi khi sua mà ten lop van giu nguyen -> tim trong db bi trung
            {
                string kiemTraTenLop = " DECLARE @return_value INT " +
                              " EXEC @return_value = [dbo].[SP_CHECKNAME] " +
                              " @Name = N'" + txtTenLop.Text.Trim() + "',  " +
                              " @Type = N'TENLOP' " +
                              " SELECT  'Return Value' = @return_value ";

                int result2 = Program.CheckDataHelper(kiemTraTenLop);
                if (result2 == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "", MessageBoxButtons.OK);
                    return false;
                }
                if (result2 == 1)
                {
                    MessageBox.Show("Tên Lớp đã tồn tại. Mời bạn nhập tên khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (result2 == 2)
                {
                    MessageBox.Show("Tên Lớp đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xoa loi -> load lai LOP nen co the vi tri tro chuot cu se bi thay doi
            String maLop = "";
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            DialogResult xacNhanXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacNhanXoa.Equals(DialogResult.OK))
            {
                try
                {
                    maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS_SV.LOP);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp, bạn hãy thử lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS_SV.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", maLop); 
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLop.Position;
            modeFlag = "EDIT";
            catcheTenLOP = txtTenLop.Text.Trim();

            gcLop.Enabled = false;
            lopInfo.Enabled = true;

            txtMaKhoa.Enabled = false;
            panelChonKhoa.Enabled = false;
            groupBtnSV.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            modeFlag = "";
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS_SV.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS_SV.SINHVIEN);

            bdsLop.Position = viTri;
            gcLop.Enabled = groupBtnSV.Enabled = true;
            
            lopInfo.Enabled = false;
            cmbKhoa.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            catcheTenLOP = "";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkLopInput())
            {
                try
                {
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    modeFlag = "!" + modeFlag;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS_SV.LOP);
                }
                catch (Exception ex)
                {
                    modeFlag = modeFlag.Substring(1);
                    MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                gcLop.Enabled = groupBtnSV.Enabled = true;
                
                lopInfo.Enabled = false;
                cmbKhoa.Enabled = true;

                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
                catcheTenLOP = "";
            }
        }

        // button controll SINH VIEN
        private bool checkSVInput()
        {
            if (txtMaSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }
            else if (txtHoSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Họ của sinh viên không được để trống", "", MessageBoxButtons.OK);
                 txtHoSV.Focus();
                return false;
            }
            else if (txtTenSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên của sinh viên không được để trống", "", MessageBoxButtons.OK);
                txtTenSV.Focus();
                return false;
            } else if (ngaySinh.DateTime.Year < 1997 || ngaySinh.DateTime.Year > DateTime.Now.Year - 17)
            {
                MessageBox.Show("Hãy chọn lại ngày sinh khác", "", MessageBoxButtons.OK);
                return false;
            } 
            if (modeFlagSV.Equals("ADD"))
            {
                string query = " DECLARE @return_value INT " +

                               " EXEC @return_value = [dbo].[SP_CHECKID] " +

                               " @ID = N'" + txtMaSV.Text.Trim() + "',  " +

                               " @Type = N'MASV' " +

                               " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "", MessageBoxButtons.OK);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            viTriSV = bdsSV.Position;
            bdsSV.AddNew();

            modeFlagSV = "ADD";
            
            SVInfo.Enabled = true;
            phai.Checked = false;

            daNghiHoc.Checked = false;
            daNghiHoc.Enabled = false;

            txtMaLopSV.Text = txtMaLop.Text;
            txtMaLopSV.Enabled = false;

            gcLop.Enabled = false;
            gcSV.Enabled = false;
            panelChonKhoa.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;

            groupBtnSV.Enabled = true;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = false;
            btnGhiSV.Enabled = btnUndoSV.Enabled = true;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            //xoa loi -> load lai SINH VIEN nen co the vi tri tro chuot cu se bi thay doi
            String maSV = "";
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên vì sinh viên đã đăng ki lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }
            DialogResult xacNhanXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacNhanXoa.Equals(DialogResult.OK))
            {
                try
                {
                    maSV = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS_SV.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên, bạn hãy thử lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS_SV.SINHVIEN);
                    bdsSV.Position = bdsLop.Find("MASV", maSV);
                    return;
                }
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            viTriSV = bdsSV.Position;
            modeFlagSV = "EDIT";

            SVInfo.Enabled = true;
            txtMaLopSV.Enabled = false;
            txtMaSV.Enabled = false;

            gcLop.Enabled = false;
            gcSV.Enabled = false;

            panelChonKhoa.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;

            groupBtnSV.Enabled = true;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = false;
            btnGhiSV.Enabled = btnUndoSV.Enabled = true;
            daNghiHoc.Enabled = true;
        }

        private void btnUndoSV_Click(object sender, EventArgs e)
        {
            bdsSV.CancelEdit();
            modeFlagSV = "";
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS_SV.SINHVIEN);

            bdsSV.Position = viTriSV;
            SVInfo.Enabled = false;
            txtMaSV.Enabled = true;

            gcLop.Enabled = true;
            gcSV.Enabled = true;

            panelChonKhoa.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = true;

            groupBtnSV.Enabled = true;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = true;
            btnGhiSV.Enabled = btnUndoSV.Enabled = false;
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            if (checkSVInput())
            {
                try
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    modeFlagSV = "!" + modeFlagSV;
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS_SV.SINHVIEN);
                }
                catch (Exception ex)
                {
                    modeFlagSV = modeFlagSV.Substring(1);
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                SVInfo.Enabled = false;
                gcLop.Enabled = true;
                gcSV.Enabled = true;
                txtMaSV.Enabled = true;

                panelChonKhoa.Enabled = true;

                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
                btnThoat.Enabled = true;

                groupBtnSV.Enabled = true;
                btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = true;
                btnGhiSV.Enabled = btnUndoSV.Enabled = false;
            }
        }
    }
}
