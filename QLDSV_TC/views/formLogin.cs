using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.views
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        private SqlConnection conn_publisher = new SqlConnection();
        String loginNameSV = "";
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();

            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);

            conn_publisher.Close();
            Program.bdsDSPM.DataSource = dt;
            comBoxPhongBan.DataSource = Program.bdsDSPM;
            comBoxPhongBan.DisplayMember = "TENCN";
            comBoxPhongBan.ValueMember = "TENSERVER";
        }
        private int KetNoi_CSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.constr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối\n" + e.Message);
                return 0;
            }
        }
        private void comBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = comBoxPhongBan.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void hienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (hienMatKhau.Checked)
                txtBMatKhau.Properties.UseSystemPasswordChar = false;
            else
                txtBMatKhau.Properties.UseSystemPasswordChar = true;
        }

        private void checkIsSV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsSV.Checked)
            {
                txtBMatKhau.Visible = false;
                hienMatKhau.Visible = false;
                Program.pass = Program.passDefaultSV;
                txtBMatKhau.Text = Program.pass;
                label3.Visible = false;
            }
            else
            {
                txtBMatKhau.Visible = true;
                hienMatKhau.Visible = true;
                label3.Visible = true;
                txtBMatKhau.Text = null;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtBTaiKhoan.Text.Trim() == "" || txtBMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = checkIsSV.Checked ? Program.mloginDefaultSV : txtBTaiKhoan.Text; //Login để vào server lần đầu tiên
            Program.pass = txtBMatKhau.Text;

            if (Program.KetNoi() == 0) // khong ton tai login
                return;
            else if (Program.KetNoi() != 0 && !checkIsSV.Checked) // nguoi login là giang vien
            {
                String strCmd = "EXEC [dbo].[SP_LayThongTinNhanVienTuLogin] '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }
            else if (Program.KetNoi() != 0 && checkIsSV.Checked) // sinh vien login
            {
                Program.mlogin = Program.mloginDefaultSV; // password mặc định đã có sau khi nhấn check sinh viên
                Program.userNameSinhVien = txtBTaiKhoan.Text; // ma sinh vien
                String strCmd = "EXEC [dbo].[SP_LayThongTinSinhVien] @TENLOGIN = '" + Program.mlogin + "', @MASINHVIEN = '" + Program.userNameSinhVien + "'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }

            Program.mPhongBan = comBoxPhongBan.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passDN = Program.pass;

            if (!Program.myReader.HasRows)
            {
                return;
            }
            Program.myReader.Read();
            try
            {
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1); // Dang nhap sai ho ten bang null -> exception = khong ton tai sinh vien o phan manh
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.frmChinh = new formMain();
                Program.frmChinh.statusMa.Text = "MÃ: " + Program.username.ToUpper();
                Program.frmChinh.statusTen.Text = "TÊN: " + Program.mHoten;
                Program.frmChinh.statusNhom.Text = "QUYỀN: " + Program.mGroup;
                //this.Visible = false;
                Thread.Sleep(500);
                Program.frmChinh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ \n Vui long kiem tra lại \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            if (Program.frmChinh != null)
            {
                Program.frmChinh.Close();
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGoc() == 0) return;
            LayDSPM("SELECT * FROM [dbo].[V_DS_PHANMANH]");
            comBoxPhongBan.SelectedIndex = 0;
            Program.servername = comBoxPhongBan.SelectedValue.ToString();
            txtBMatKhau.Properties.UseSystemPasswordChar = true;
        }
        /*public void loadAgain()
        {
            comBoxPhongBan.SelectedItem = Program.mGroup;
            Program.servername = comBoxPhongBan.SelectedValue.ToString();
            txtBTaiKhoan.Text = null;
            txtBMatKhau.Text = null;
            txtBTaiKhoan.Focus();

        }*/
    }
}
