using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC.reports
{
    public partial class XtrPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public XtrPhieuDiem()
        {
            InitializeComponent();
        }
        public XtrPhieuDiem(String masv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource1.Fill();
        }

    }
}
