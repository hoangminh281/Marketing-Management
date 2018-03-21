using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLTT1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmDangnhap f = new frmDangnhap();
            f.ShowDialog();
            lblTtnv.Caption = "Mã nv: " + Program.username + "  Họ tên: " + Program.mHoten + "  Nhóm: " + Program.mGroup;
            if (Program.username != "")
            {
                btnDangnhap.Enabled = false;
                btnDangxuat.Enabled = true;
                btnLogin.Enabled = true;
                rpChucnang.Visible = true;
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype) return f;
            }
            return null;
        }

        private void btnDangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangnhap f = new frmDangnhap();
            f.ShowDialog();
            lblTtnv.Caption = "Mã nv: " + Program.username + "  Họ tên: " + Program.mHoten + "  Nhóm: " + Program.mGroup;
            if (Program.mGroup == "USER") btnLogin.Enabled = false;
            if (Program.username != "")
            {
                btnDangnhap.Enabled = false;
                btnDangxuat.Enabled = true;
                btnLogin.Enabled = true;
                rpChucnang.Visible = true;
            }
        }

        private void btnDangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.conn.Close();
            lblTtnv.Caption = "";
            btnDangnhap.Enabled = true;
            btnDangxuat.Enabled = false;
            Program.mGroup = Program.username = Program.mHoten = Program.mlogin = Program.password = "";
            btnLogin.Enabled = false;
            rpChucnang.Visible = false;
        }

        private void btnNhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanvien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanvien f = new frmNhanvien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSanpham_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSanpham));
            if (frm != null) frm.Activate();
            else
            {
                frmSanpham f = new frmSanpham();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChamcong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChamcong));
            if (frm != null) frm.Activate();
            else
            {
                frmChamcong f = new frmChamcong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGiaohang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiaohang));
            if (frm != null) frm.Activate();
            else
            {
                frmGiaohang f = new frmGiaohang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBanhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBanhang));
            if (frm != null) frm.Activate();
            else
            {
                frmBanhang f = new frmBanhang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangluong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBangluong));
            if (frm != null) frm.Activate();
            else
            {
                frmBangluong f = new frmBangluong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTonno_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTonno));
            if (frm != null) frm.Activate();
            else
            {
                frmTonno f = new frmTonno();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLoginManager));
            if (frm != null) frm.Activate();
            else
            {
                frmLoginManager f = new frmLoginManager();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}