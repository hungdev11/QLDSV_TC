using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public void beforeLogin()
        {
            ribbonPageQuanLy.Visible = false;
            ribbonPageSinhVien.Visible = false;
            ribbonBaoCao.Visible = false;

            rbpQuanLyKhoa.Visible = false;
            rbpBaoCaoKhoa.Visible = false;
            rbpSV.Visible = false;

            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnCreatAcc.Enabled = false;
        }
        public void afterLogin()
        {
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            btnCreatAcc.Enabled = true;

            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("KHOA"))
            {
                ribbonPageQuanLy.Visible = true;
                ribbonPageSinhVien.Visible = false;
                ribbonBaoCao.Visible = true;

                rbpQuanLyKhoa.Visible = true;
                rbpBaoCaoKhoa.Visible = true;
                rbpSV.Visible = false;

                rbpHocPhi.Visible = false;

                btnCreatAcc.Enabled = true;
            }
            else if (Program.mGroup.Equals("SV"))
            {
                ribbonPageQuanLy.Visible = false;
                ribbonPageSinhVien.Visible = true;
                ribbonBaoCao.Visible = false;

                rbpQuanLyKhoa.Visible = false;
                rbpBaoCaoKhoa.Visible = false;
                rbpHocPhi.Visible = false;

                rbpSV.Visible = true;

                btnCreatAcc.Enabled = false;
            }
            else if (Program.mGroup.Equals("PKT"))
            {
                btnCreatAcc.Enabled = true;

                ribbonPageQuanLy.Visible = true;
                ribbonPageSinhVien.Visible = false;
                ribbonBaoCao.Visible = true;

                rbpBaoCaoKhoa.Visible = true;
                rbpSV.Visible = false;

                rbpQuanLyKhoa.Visible = false;
                rbpHocPhi.Visible = true;
            }
        }
        public formMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            if (Program.mlogin.Equals(""))
            {
                beforeLogin();
            }
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

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frmLogin = new views.formLogin();
            Program.frmLogin.Show();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.conn.Close();
            Program.frmLogin.Show();

            if (Program.frmLop != null)
            {
                Program.frmLop.Close();
            }
            if (Program.frmMH != null)
            {
                Program.frmMH.Close();
            }
            if (Program.frmLTC != null)
            {
                Program.frmLTC.Close();
            }
            if (Program.frmNhapDiem != null)
            {
                Program.frmNhapDiem.Close();
            }
            if (Program.frmDKLTC != null)
            {
                Program.frmDKLTC.Close();
            }
            if (Program.frmXemDiem != null)
            {
                Program.frmXemDiem.Close();
            }
            Program.mloginDN = Program.passDN = Program.mGroup = "";
            beforeLogin();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.formNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmNhapDiem = new views.formNhapDiem();
                Program.frmNhapDiem.MdiParent = this;
                Program.frmNhapDiem.Show();
            }
        }

        private void btnCreatAcc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new views.formTaoTK().Show();
        }

        private void btnDKLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.formDKLTC));
            if (frm != null) frm.Activate();
            else
            {
                new views.formDKLTC().Show();
                Program.frmDKLTC = new views.formDKLTC();
                Program.frmDKLTC.MdiParent = this;
                Program.frmDKLTC.Show();
            }
        }

        private void btnXemDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.formXemDiem));
            if (frm != null) frm.Activate();
            else
            {
                new views.formDKLTC().Show();
                Program.frmXemDiem = new views.formXemDiem();
                Program.frmXemDiem.MdiParent = this;
                Program.frmXemDiem.Show();
            }
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.formHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                new views.formHocPhi().Show();
                Program.frmHocPhi = new views.formHocPhi();
                Program.frmHocPhi.MdiParent = this;
                Program.frmHocPhi.Show();
            }
        }
    }
}
