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
        public formMonHoc()
        {
            InitializeComponent();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void formMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SV.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS_SV.MONHOC);

            panelControl1.Enabled = false;

        }

        private void mONHOCDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = gvMonHoc.Rows[e.RowIndex];  //tracking mouse click
                txtMaMH.Text = clickedRow.Cells[0].Value.ToString();
                txtTenMH.Text = clickedRow.Cells[1].Value.ToString();
                txtTLT.Text = clickedRow.Cells[2].Value.ToString();
                txtTTH.Text = clickedRow.Cells[3].Value.ToString();
                clickedRow.ReadOnly = false;
            }
        }
    }
}
