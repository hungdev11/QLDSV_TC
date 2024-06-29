using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC.reports
{
    public partial class XtrDSLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public XtrDSLTC()
        {
            InitializeComponent();
        }
        public XtrDSLTC(String nienkhoa, int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Fill();
        }

    }
}
