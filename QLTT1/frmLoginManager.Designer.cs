namespace QLTT1
{
    partial class frmLoginManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginManager));
            this.tswLogin = new DevExpress.XtraEditors.ToggleSwitch();
            this.gcTaotaikhoan = new DevExpress.XtraEditors.GroupControl();
            this.btnUnhide = new DevExpress.XtraEditors.SimpleButton();
            this.cmbQuyenhan = new System.Windows.Forms.ComboBox();
            this.txtMatkhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTendn = new DevExpress.XtraEditors.TextEdit();
            this.txtManv = new DevExpress.XtraEditors.TextEdit();
            this.cmbTennv = new System.Windows.Forms.ComboBox();
            this.bdsV_DSMANV = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSMANV = new QLTT1.DS_DSMANV();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.lblQuyenhan = new DevExpress.XtraEditors.LabelControl();
            this.lblMatkhau = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBatdau = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.v_DS_MANVTableAdapter = new QLTT1.DS_DSMANVTableAdapters.V_DS_MANVTableAdapter();
            this.dS_DSPM = new QLTT1.DS_DSPM();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLTT1.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tswLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaotaikhoan)).BeginInit();
            this.gcTaotaikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsV_DSMANV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSMANV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tswLogin
            // 
            this.tswLogin.Location = new System.Drawing.Point(591, 280);
            this.tswLogin.Name = "tswLogin";
            this.tswLogin.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tswLogin.Properties.Appearance.Options.UseFont = true;
            this.tswLogin.Properties.OffText = "Xóa login";
            this.tswLogin.Properties.OnText = "Tạo login";
            this.tswLogin.Size = new System.Drawing.Size(146, 28);
            this.tswLogin.TabIndex = 0;
            this.tswLogin.Toggled += new System.EventHandler(this.tswLogin_Toggled);
            // 
            // gcTaotaikhoan
            // 
            this.gcTaotaikhoan.Controls.Add(this.btnUnhide);
            this.gcTaotaikhoan.Controls.Add(this.cmbQuyenhan);
            this.gcTaotaikhoan.Controls.Add(this.txtMatkhau);
            this.gcTaotaikhoan.Controls.Add(this.txtTendn);
            this.gcTaotaikhoan.Controls.Add(this.txtManv);
            this.gcTaotaikhoan.Controls.Add(this.cmbTennv);
            this.gcTaotaikhoan.Controls.Add(this.label1);
            this.gcTaotaikhoan.Controls.Add(this.cmbChinhanh);
            this.gcTaotaikhoan.Controls.Add(this.lblQuyenhan);
            this.gcTaotaikhoan.Controls.Add(this.lblMatkhau);
            this.gcTaotaikhoan.Controls.Add(this.labelControl2);
            this.gcTaotaikhoan.Controls.Add(this.labelControl1);
            this.gcTaotaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTaotaikhoan.Location = new System.Drawing.Point(0, 0);
            this.gcTaotaikhoan.Name = "gcTaotaikhoan";
            this.gcTaotaikhoan.Size = new System.Drawing.Size(851, 246);
            this.gcTaotaikhoan.TabIndex = 2;
            this.gcTaotaikhoan.Text = "Thông tin tài khoản";
            // 
            // btnUnhide
            // 
            this.btnUnhide.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnhide.Appearance.Options.UseFont = true;
            this.btnUnhide.Image = ((System.Drawing.Image)(resources.GetObject("btnUnhide.Image")));
            this.btnUnhide.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUnhide.Location = new System.Drawing.Point(592, 146);
            this.btnUnhide.Name = "btnUnhide";
            this.btnUnhide.Size = new System.Drawing.Size(25, 25);
            this.btnUnhide.TabIndex = 16;
            this.btnUnhide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUnhide_MouseDown);
            this.btnUnhide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUnhide_MouseUp);
            // 
            // cmbQuyenhan
            // 
            this.cmbQuyenhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbQuyenhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuyenhan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuyenhan.FormattingEnabled = true;
            this.cmbQuyenhan.Location = new System.Drawing.Point(147, 188);
            this.cmbQuyenhan.Name = "cmbQuyenhan";
            this.cmbQuyenhan.Size = new System.Drawing.Size(438, 25);
            this.cmbQuyenhan.TabIndex = 10;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(147, 148);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatkhau.Size = new System.Drawing.Size(439, 24);
            this.txtMatkhau.TabIndex = 9;
            // 
            // txtTendn
            // 
            this.txtTendn.Location = new System.Drawing.Point(147, 108);
            this.txtTendn.Name = "txtTendn";
            this.txtTendn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendn.Properties.Appearance.Options.UseFont = true;
            this.txtTendn.Size = new System.Drawing.Size(439, 24);
            this.txtTendn.TabIndex = 8;
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(591, 69);
            this.txtManv.Name = "txtManv";
            this.txtManv.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.Properties.Appearance.Options.UseFont = true;
            this.txtManv.Size = new System.Drawing.Size(111, 24);
            this.txtManv.TabIndex = 7;
            this.txtManv.ToolTip = "Mã nhân viên";
            // 
            // cmbTennv
            // 
            this.cmbTennv.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbTennv.DataSource = this.bdsV_DSMANV;
            this.cmbTennv.DisplayMember = "HOTEN";
            this.cmbTennv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTennv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTennv.FormattingEnabled = true;
            this.cmbTennv.Location = new System.Drawing.Point(147, 68);
            this.cmbTennv.Name = "cmbTennv";
            this.cmbTennv.Size = new System.Drawing.Size(438, 25);
            this.cmbTennv.TabIndex = 6;
            this.cmbTennv.SelectedIndexChanged += new System.EventHandler(this.cmbTennv_SelectedIndexChanged);
            // 
            // bdsV_DSMANV
            // 
            this.bdsV_DSMANV.DataMember = "V_DS_MANV";
            this.bdsV_DSMANV.DataSource = this.dS_DSMANV;
            // 
            // dS_DSMANV
            // 
            this.dS_DSMANV.DataSetName = "DS_DSMANV";
            this.dS_DSMANV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chi nhánh:";
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(147, 24);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(438, 25);
            this.cmbChinhanh.TabIndex = 4;
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // lblQuyenhan
            // 
            this.lblQuyenhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyenhan.Location = new System.Drawing.Point(39, 190);
            this.lblQuyenhan.Name = "lblQuyenhan";
            this.lblQuyenhan.Size = new System.Drawing.Size(75, 17);
            this.lblQuyenhan.TabIndex = 3;
            this.lblQuyenhan.Text = "Quyền hạn:";
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(39, 150);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(68, 17);
            this.lblMatkhau.TabIndex = 2;
            this.lblMatkhau.Text = "Mật khẩu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(39, 110);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên đăng nhập:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(39, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên nhân viên:";
            // 
            // btnBatdau
            // 
            this.btnBatdau.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatdau.Appearance.Options.UseFont = true;
            this.btnBatdau.Location = new System.Drawing.Point(213, 269);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.Size = new System.Drawing.Size(127, 42);
            this.btnBatdau.TabIndex = 2;
            this.btnBatdau.Text = "Tạo tài khoản";
            this.btnBatdau.Click += new System.EventHandler(this.btnBatdau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(392, 269);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 42);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // v_DS_MANVTableAdapter
            // 
            this.v_DS_MANVTableAdapter.ClearBeforeFill = true;
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.dS_DSPM;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // frmLoginManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 341);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBatdau);
            this.Controls.Add(this.gcTaotaikhoan);
            this.Controls.Add(this.tswLogin);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoginManager";
            this.Text = "Tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaologin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tswLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaotaikhoan)).EndInit();
            this.gcTaotaikhoan.ResumeLayout(false);
            this.gcTaotaikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsV_DSMANV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSMANV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch tswLogin;
        private DevExpress.XtraEditors.GroupControl gcTaotaikhoan;
        private DevExpress.XtraEditors.LabelControl lblQuyenhan;
        private DevExpress.XtraEditors.LabelControl lblMatkhau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBatdau;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private System.Windows.Forms.ComboBox cmbTennv;
        private DevExpress.XtraEditors.TextEdit txtManv;
        private DevExpress.XtraEditors.TextEdit txtMatkhau;
        private DevExpress.XtraEditors.TextEdit txtTendn;
        private System.Windows.Forms.ComboBox cmbQuyenhan;
        private DS_DSMANV dS_DSMANV;
        private System.Windows.Forms.BindingSource bdsV_DSMANV;
        private DS_DSMANVTableAdapters.V_DS_MANVTableAdapter v_DS_MANVTableAdapter;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnUnhide;
    }
}