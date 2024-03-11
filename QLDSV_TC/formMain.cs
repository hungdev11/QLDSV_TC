using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            if (Program.mGroup.Equals("PGV"))
            {
                rpgQuanLyKhoa.Visible = true;
                rpgQuanLyKhoa.Enabled = true;
                ribbonPageBaoCao.Visible = false;
                rpgBaoCaoKhoa.Enabled = false;
                //barBtnTaoLogin.Enabled = true;
                ribbonControl1.SelectedPage = ribbonPageQuanLy;
            }/*
            else if ((Program.mGroup.Equals("KHOA")))
            {
                ribbonQuanLyKhoa_PGV.Visible = true;
                ribbonQuanLyKhoa_PGV.Enabled = true;
                reportPagePGV_Khoa.Visible = true;
                reportPagePGV_Khoa.Enabled = true;
                barBtnTaoLogin.Enabled = true;
                ribbon.SelectedPage = ribbonPageQuanLy;
            }
            else if (Program.mGroup.Equals("SINHVIEN"))
            {
                ribbonPageSinhVien.Visible = true;
                ribbonPageBaoCao.Visible = false;
                ribbonPageQuanLy.Visible = false;
                barBtnTaoLogin.Visibility = BarItemVisibility.Never;
                ribbon.SelectedPage = ribbonPageSinhVien;
            }
            else if (Program.mGroup.Equals("PKT"))
            {
                ribbonQuanLyPKT.Visible = true;
                ribbonQuanLyPKT.Enabled = true;
                reportPagePKT.Visible = true;
                reportPagePKT.Enabled = true;
                barBtnTaoLogin.Enabled = true;
            }*/
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void btnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.formLop));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmLop = new views.formLop();
                Program.frmLop.MdiParent = this;
                Program.frmLop.Show();

            }
        }
        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.formMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmMH = new views.formMonHoc();
                Program.frmMH.MdiParent = this;
                Program.frmMH.Show();

            }
        }

        private void btnLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.formLTC));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmLTC = new views.formLTC();
                Program.frmLTC.MdiParent = this;
                Program.frmLTC.Show();

            }
        }
    }
}
