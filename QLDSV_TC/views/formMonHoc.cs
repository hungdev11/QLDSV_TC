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
    public partial class formMonHoc : Form
    {
        private String modeFlag = "";
        private int viTri;
        private String cacheTenMonHoc = "";

        public formMonHoc()
        {
            InitializeComponent();
        }
        private void formMonHoc_Load(object sender, EventArgs e)
        {
            infoMH.Enabled = false;
            dS_SV.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_SV.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS_SV.MONHOC);
            // TODO: This line of code loads data into the 'dS_SV.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.dS_SV.LOPTINCHI);

            if (bdsMonHoc.Count > 0)
            {
                btnXoa.Enabled = btnSua.Enabled = true;
            } else
            {
                btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsMonHoc.Position;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = false;
            infoMH.Enabled = true;
            gcMH.Enabled = false;
            bdsMonHoc.AddNew();
            soTietLT.Value = 0;
            soTietTH.Value = 0;
            modeFlag = "ADD";
        }
        private bool checkMHInput()
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMH.Focus();
                return false;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMH.Focus();
                return false;
            }
            if (soTietLT.Value < 0)
            {
                MessageBox.Show("Số tiết lý Thuyết phải lớn hơn hoặc bằng 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                soTietLT.Focus();
                return false;
            }
            if (soTietTH.Value < 0)
            {
                MessageBox.Show("Số tiết thực hành phải lớn hơn hoặc bằng 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                soTietTH.Focus();
                return false;
            }
            if ((soTietLT.Value + soTietTH.Value) <= 0 || (soTietLT.Value + soTietTH.Value) % 15 != 0)
            {
                MessageBox.Show("Số Tiết LT + Số Tiết TH phải lơn hơn 0 và là bội số của 15 (1 tín chỉ)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                soTietLT.Focus();
                return false;
            }
            if (modeFlag.Equals("ADD"))
            {
                string query = " DECLARE @return_value INT " +

                          " EXEC @return_value = [dbo].[SP_CHECKID] " +

                          " @ID = N'" + txtMaMH.Text.Trim() + "',  " +

                          " @Type = N'MAMONHOC' " +

                          " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã Môn Học đã tồn tại. Mời bạn nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMH.Focus();
                    return false;
                }
            }
            if (modeFlag == "ADD" || (modeFlag == "EDIT" && !cacheTenMonHoc.Equals( txtTenMH.Text.Trim())))
            {
                string query2 = " DECLARE @return_value INT " +

                          " EXEC @return_value = [dbo].[SP_CHECKNAME] " +

                          " @Name = N'" + txtTenMH.Text.Trim() + "',  " +

                          " @Type = N'TENMONHOC' " +

                          " SELECT  'Return Value' = @return_value ";
                int result2 = Program.CheckDataHelper(query2);
                if (result2 == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (result2 == 1)
                {
                    MessageBox.Show("Tên Môn Học đã tồn tại. Mời bạn nhập tên khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenMH.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLTC.Count >0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã mở lớp tín chỉ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này không ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string mamh = "";
                try
                {
                    mamh = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS_SV.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mONHOCTableAdapter.Fill(this.dS_SV.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", mamh);
                    return;
                }
            }
            if (bdsMonHoc.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = false;
            else
            {
                btnXoa.Enabled = btnSua.Enabled = true;
            }
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            modeFlag = "EDIT";
            viTri = bdsMonHoc.Position;
            infoMH.Enabled = true;
            gcMH.Enabled = false;
            txtMaMH.Enabled = false;
            cacheTenMonHoc = txtTenMH.Text.Trim();
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            infoMH.Enabled = false;
            bdsMonHoc.CancelEdit();

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS_SV.MONHOC);
            bdsMonHoc.Position = viTri;

            infoMH.Enabled = false;

            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = true;

            gcMH.Enabled = true;
            modeFlag = "";
            cacheTenMonHoc = "";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkMHInput())
            {
                try
                {
                    bdsMonHoc.EndEdit();
                    bdsMonHoc.ResetCurrentItem();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS_SV.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = true;

                infoMH.Enabled = false;
                gcMH.Enabled = true;
                modeFlag = "";
                cacheTenMonHoc = "";
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
