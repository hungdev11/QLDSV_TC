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
    public partial class formTaoTK : Form
    {
        public formTaoTK()
        {
            InitializeComponent();
            cmbDSGV.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMK.Properties.UseSystemPasswordChar = true;
            txtMK2.Properties.UseSystemPasswordChar = true;
        }
        private void formTaoTK_Load(object sender, EventArgs e)
        {
            this.dSGVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSGVTableAdapter.Fill(this.dS_SV.DSGV);
            if (Program.mGroup == "KHOA" || Program.mGroup == "PGV")
            {
                if (Program.mGroup == "KHOA")
                {
                    groupROLE.SelectedIndex = 2;
                    groupROLE.Properties.Items[0].Enabled = false;
                    groupROLE.Properties.Items[1].Enabled = false;
                }
                else
                {
                    groupROLE.SelectedIndex = 0;
                    groupROLE.Properties.Items[1].Enabled = false;
                }
            }
            else
            {
                groupROLE.SelectedIndex = 1;
                groupROLE.Properties.Items[0].Enabled = false;
                groupROLE.Properties.Items[2].Enabled = false;
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            txtMK.Text = "1234";
            txtMK2.Text = "1234";
            if (txtTK.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông Báo", MessageBoxButtons.OK);
                txtTK.Focus();
            }
            else if (!txtMK.Text.Equals(txtMK2.Text))
            {
                MessageBox.Show("Hãy nhập lại mật khẩu", "Thông Báo", MessageBoxButtons.OK);
                txtMK.Focus();
            }
            else
            {
                try
                {
                    string query = " DECLARE @return_value INT " +
                          " EXEC @return_value = [dbo].[SP_TAOLOGIN] '" + txtTK.Text + "','" + txtMK.Text + "','"
                          + cmbDSGV.SelectedValue.ToString() + "', '" + groupROLE.EditValue.ToString() +
                          "'; SELECT  'Return Value' = @return_value ";

                    int tmp = Program.CheckDataHelper(query);

                    if (tmp == 1)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông Báo", MessageBoxButtons.OK);
                        txtTK.Focus();
                    }
                    else if (tmp == 2)
                    {
                        MessageBox.Show("Giáo viên đã có tài khoản", "Thông Báo", MessageBoxButtons.OK);
                        txtTK.Focus();
                    }
                    else if (tmp == 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công", "Thông Báo", MessageBoxButtons.OK);
                        txtTK.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Vui Lòng Kiểm Tra Lại", "Thông Báo", MessageBoxButtons.OK);
                        txtTK.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tạo tài khoản", "Thông báo", MessageBoxButtons.OK);
                    txtTK.Text = "";
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (hienMatKhau.Checked)
            {
                txtMK.Properties.UseSystemPasswordChar = false;
                txtMK2.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.Properties.UseSystemPasswordChar = true;
                txtMK2.Properties.UseSystemPasswordChar = true;
            }
                
        }
    }
}
