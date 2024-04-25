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
    public partial class formXemDiem : Form
    {
        public formXemDiem()
        {
            InitializeComponent();
            txtMaSV.Enabled = txtMaLop.Enabled = txtTenSV.Enabled = false;
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
        private void taiBangDiem()
        {
            string cmd = "EXEC [dbo].[SP_DiemSV] '" + Program.username + "'";
            DataTable tableDiemSV = Program.ExecSqlDataTable(cmd);
            this.gcXemDiem.DataSource = tableDiemSV;

        }

        private void formXemDiem_Load(object sender, EventArgs e)
        {
            taiThongTinSV();
            taiBangDiem();
        }
    }
}
