namespace QLTT1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangnhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.lblTtnv = new DevExpress.XtraBars.BarStaticItem();
            this.btnNhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnSanpham = new DevExpress.XtraBars.BarButtonItem();
            this.btnChamcong = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaohang = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanhang = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangluong = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonno = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpChucnang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDangnhap,
            this.btnDangxuat,
            this.lblTtnv,
            this.btnNhanvien,
            this.btnSanpham,
            this.btnChamcong,
            this.btnGiaohang,
            this.btnBanhang,
            this.btnBangluong,
            this.btnTonno,
            this.btnLogin});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.rpChucnang});
            this.ribbon.Size = new System.Drawing.Size(589, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Caption = "Đăng nhập";
            this.btnDangnhap.Glyph = global::QLTT1.Properties.Resources.icons8_Enter_40;
            this.btnDangnhap.Id = 1;
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangnhap_ItemClick);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Caption = "Đăng xuất";
            this.btnDangxuat.Glyph = global::QLTT1.Properties.Resources.icons8_Sign_Out_48;
            this.btnDangxuat.Id = 2;
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangxuat_ItemClick);
            // 
            // lblTtnv
            // 
            this.lblTtnv.Caption = "###";
            this.lblTtnv.Id = 4;
            this.lblTtnv.Name = "lblTtnv";
            this.lblTtnv.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Caption = "Danh sách nhân viên";
            this.btnNhanvien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.Glyph")));
            this.btnNhanvien.Id = 10;
            this.btnNhanvien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.LargeGlyph")));
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanvien_ItemClick);
            // 
            // btnSanpham
            // 
            this.btnSanpham.Caption = "Danh mục sản phẩm";
            this.btnSanpham.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSanpham.Glyph")));
            this.btnSanpham.Id = 11;
            this.btnSanpham.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSanpham.LargeGlyph")));
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSanpham_ItemClick);
            // 
            // btnChamcong
            // 
            this.btnChamcong.Caption = "Bảng chấm công";
            this.btnChamcong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnChamcong.Glyph")));
            this.btnChamcong.Id = 12;
            this.btnChamcong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnChamcong.LargeGlyph")));
            this.btnChamcong.Name = "btnChamcong";
            this.btnChamcong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChamcong_ItemClick);
            // 
            // btnGiaohang
            // 
            this.btnGiaohang.Caption = "Giao hàng";
            this.btnGiaohang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGiaohang.Glyph")));
            this.btnGiaohang.Id = 13;
            this.btnGiaohang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGiaohang.LargeGlyph")));
            this.btnGiaohang.Name = "btnGiaohang";
            this.btnGiaohang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnGiaohang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaohang_ItemClick);
            // 
            // btnBanhang
            // 
            this.btnBanhang.Caption = "Bán hàng";
            this.btnBanhang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBanhang.Glyph")));
            this.btnBanhang.Id = 14;
            this.btnBanhang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBanhang.LargeGlyph")));
            this.btnBanhang.Name = "btnBanhang";
            this.btnBanhang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnBanhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanhang_ItemClick);
            // 
            // btnBangluong
            // 
            this.btnBangluong.Caption = "Bảng lương nhân viên";
            this.btnBangluong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBangluong.Glyph")));
            this.btnBangluong.Id = 15;
            this.btnBangluong.Name = "btnBangluong";
            this.btnBangluong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBangluong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangluong_ItemClick);
            // 
            // btnTonno
            // 
            this.btnTonno.Caption = "Tình hình tồn nợ";
            this.btnTonno.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTonno.Glyph")));
            this.btnTonno.Id = 16;
            this.btnTonno.Name = "btnTonno";
            this.btnTonno.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTonno.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonno_ItemClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Quản lý tài khoản";
            this.btnLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogin.Glyph")));
            this.btnLogin.Id = 17;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup8});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangnhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangxuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // rpChucnang
            // 
            this.rpChucnang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.rpChucnang.Name = "rpChucnang";
            this.rpChucnang.Text = "Chức năng";
            this.rpChucnang.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanvien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSanpham);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnChamcong);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnGiaohang);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBanhang);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnBangluong);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnTonno);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lblTtnv);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 556);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(589, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 587);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý tiếp thị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpChucnang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDangnhap;
        private DevExpress.XtraBars.BarButtonItem btnDangxuat;
        private DevExpress.XtraBars.BarStaticItem lblTtnv;
        private DevExpress.XtraBars.BarButtonItem btnNhanvien;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnSanpham;
        private DevExpress.XtraBars.BarButtonItem btnChamcong;
        private DevExpress.XtraBars.BarButtonItem btnGiaohang;
        private DevExpress.XtraBars.BarButtonItem btnBanhang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnBangluong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnTonno;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
    }
}