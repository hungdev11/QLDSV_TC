using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_TC
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlCommand sqlcmd = new SqlCommand();
        //=====================================================mode lấy tk của user window===================================
        public static String constr_publisher = "Data Source=HUNG-PHAN; Initial Catalog=QLDSV_TC; Integrated Security=true";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = ""; //thực sự là mã nhân viên: do ta gán username chính là mã nhân viên
        public static String mlogin = "";
        public static String pass = "";
        public static String userNameSinhVien = "";
        //public static String passSV = "";

        public static String database = "QLDSV_TC";
        public static String remoteLogin = "HTKN"; //kết nối site khác
        public static String remotePass = "1234"; //kết nối site khác
        public static String mloginDN = ""; //loginname hiện tại
        public static String passDN = "";//pass hiện tại
        public static String mGroup = ""; //khoa-pgv-pkt
        public static String mHoten = "";
        public static int mPhongBan = 0;//khoa cntt hay vt

        public static String mloginDefaultSV = "SINHVIEN";
        public static String passDefaultSV = "1234";

        public static BindingSource bdsDSPM = new BindingSource();//dùng để giữ ds phân mảnh khi login
        public static formMain frmChinh;
        public static views.formLogin frmLogin;
        public static views.formLop frmLop;
        public static views.formMonHoc frmMH;
        public static views.formLTC frmLTC;
        public static views.formNhapDiem frmNhapDiem;

        public static views.formDKLTC frmDKLTC;
        public static views.formXemDiem frmXemDiem;
        public static views.formHocPhi frmHocPhi;

        //report
        public static views.formDSHocPhi frmrpDSHocPhi;
        public static views.formTongKetDiem frmrpTongKetDiem;
        public static views.formBangDiemLTC frmBangDiemLTC;
        public static views.formRPDSLTC frmRPDSLTC;
        public static views.formRP_LTC frmRP_DSSV_DKLTC;
        public static views.formPhieuDiem frmPhieuDiem;





        /* public static formClassRegistration frmRegister;
         public static formScores frmScores;
         public static formManagerSubject frmSubject;*/

        public static int chiPhi = 480000;  //tiền học/1 tín


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mlogin + ";password=" + Program.pass;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu. \nBạn xem lại username và password.\n " + e.Message);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strCmd)
        {
            SqlDataReader myreader;
            SqlCommand sqlCmd = new SqlCommand(strCmd, Program.conn);
            sqlCmd.CommandType = CommandType.Text;

            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.ConnectionString = Program.connstr;
                conn.Open();
                myreader = sqlCmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException e)
            {
                Program.conn.Close();
                MessageBox.Show("Lỗi: " + e.Message);
                return null;
            }

        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand sqlCmd = new SqlCommand(strLenh, conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();

                return ex.State == 0 ? -1 : ex.State;
            }
        }

        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);
            if (dataReader == null)
                return -1;

            dataReader.Read();
            int result = dataReader.GetInt32(0);
            dataReader.Close();
            return result;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.frmChinh = new formMain();
            Application.Run(Program.frmChinh);
        }
    }
}
