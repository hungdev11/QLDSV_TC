using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLDSV_TC.reports
{
    public partial class XtrDiemTongKetKhoaHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public XtrDiemTongKetKhoaHoc()
        {
            InitializeComponent();
        }
        public XtrDiemTongKetKhoaHoc(String maLop)
        {
            try
            {
                InitializeComponent();
                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
                this.sqlDataSource1.Fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


    }
}
