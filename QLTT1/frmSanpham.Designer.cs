namespace QLTT1
{
    partial class frmSanpham
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
            System.Windows.Forms.Label hUEHONGLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label tENSPLabel;
            System.Windows.Forms.Label mASPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanpham));
            this.dS = new QLTT1.DS();
            this.bdsSanpham = new System.Windows.Forms.BindingSource(this.components);
            this.SANPHAMTableAdapter = new QLTT1.DSTableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new QLTT1.DSTableAdapters.TableAdapterManager();
            this.gcSanpham = new DevExpress.XtraGrid.GridControl();
            this.gvSanpham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUEHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblThongbao = new DevExpress.XtraEditors.LabelControl();
            this.gcChitietsp = new DevExpress.XtraEditors.GroupControl();
            this.txtHuehong = new DevExpress.XtraEditors.SpinEdit();
            this.txtDvt = new DevExpress.XtraEditors.TextEdit();
            this.txtTensp = new DevExpress.XtraEditors.TextEdit();
            this.txtMasp = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnPhuchoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnRedo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            hUEHONGLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            tENSPLabel = new System.Windows.Forms.Label();
            mASPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChitietsp)).BeginInit();
            this.gcChitietsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHuehong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDvt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTensp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hUEHONGLabel
            // 
            hUEHONGLabel.AutoSize = true;
            hUEHONGLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hUEHONGLabel.Location = new System.Drawing.Point(88, 200);
            hUEHONGLabel.Name = "hUEHONGLabel";
            hUEHONGLabel.Size = new System.Drawing.Size(68, 17);
            hUEHONGLabel.TabIndex = 6;
            hUEHONGLabel.Text = "Huê hồng:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dVTLabel.Location = new System.Drawing.Point(88, 150);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(76, 17);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính:";
            // 
            // tENSPLabel
            // 
            tENSPLabel.AutoSize = true;
            tENSPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENSPLabel.Location = new System.Drawing.Point(88, 100);
            tENSPLabel.Name = "tENSPLabel";
            tENSPLabel.Size = new System.Drawing.Size(94, 17);
            tENSPLabel.TabIndex = 2;
            tENSPLabel.Text = "Tên sản phẩm:";
            // 
            // mASPLabel
            // 
            mASPLabel.AutoSize = true;
            mASPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASPLabel.Location = new System.Drawing.Point(88, 50);
            mASPLabel.Name = "mASPLabel";
            mASPLabel.Size = new System.Drawing.Size(91, 17);
            mASPLabel.TabIndex = 0;
            mASPLabel.Text = "Mã sản phẩm:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSanpham
            // 
            this.bdsSanpham.DataMember = "SANPHAM";
            this.bdsSanpham.DataSource = this.dS;
            // 
            // SANPHAMTableAdapter
            // 
            this.SANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANHANGTableAdapter = null;
            this.tableAdapterManager.CHAMCONGTableAdapter = null;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.GIAOHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = this.SANPHAMTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLTT1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcSanpham
            // 
            this.gcSanpham.DataSource = this.bdsSanpham;
            this.gcSanpham.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcSanpham.Location = new System.Drawing.Point(0, 0);
            this.gcSanpham.MainView = this.gvSanpham;
            this.gcSanpham.Name = "gcSanpham";
            this.gcSanpham.Size = new System.Drawing.Size(710, 741);
            this.gcSanpham.TabIndex = 1;
            this.gcSanpham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanpham});
            // 
            // gvSanpham
            // 
            this.gvSanpham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASP,
            this.colTENSP,
            this.colDVT,
            this.colHUEHONG});
            this.gvSanpham.GridControl = this.gcSanpham;
            this.gvSanpham.Name = "gvSanpham";
            this.gvSanpham.OptionsBehavior.Editable = false;
            this.gvSanpham.OptionsBehavior.ReadOnly = true;
            this.gvSanpham.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvSanpham.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMASP
            // 
            this.colMASP.Caption = "Mã sản phẩm";
            this.colMASP.FieldName = "MASP";
            this.colMASP.Name = "colMASP";
            this.colMASP.Visible = true;
            this.colMASP.VisibleIndex = 0;
            // 
            // colTENSP
            // 
            this.colTENSP.Caption = "Tên sản phẩm";
            this.colTENSP.FieldName = "TENSP";
            this.colTENSP.Name = "colTENSP";
            this.colTENSP.Visible = true;
            this.colTENSP.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colHUEHONG
            // 
            this.colHUEHONG.Caption = "Huê hồng";
            this.colHUEHONG.FieldName = "HUEHONG";
            this.colHUEHONG.Name = "colHUEHONG";
            this.colHUEHONG.Visible = true;
            this.colHUEHONG.VisibleIndex = 3;
            // 
            // lblThongbao
            // 
            this.lblThongbao.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongbao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblThongbao.Location = new System.Drawing.Point(716, 306);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(0, 17);
            this.lblThongbao.TabIndex = 15;
            // 
            // gcChitietsp
            // 
            this.gcChitietsp.Controls.Add(hUEHONGLabel);
            this.gcChitietsp.Controls.Add(this.txtHuehong);
            this.gcChitietsp.Controls.Add(dVTLabel);
            this.gcChitietsp.Controls.Add(this.txtDvt);
            this.gcChitietsp.Controls.Add(tENSPLabel);
            this.gcChitietsp.Controls.Add(this.txtTensp);
            this.gcChitietsp.Controls.Add(mASPLabel);
            this.gcChitietsp.Controls.Add(this.txtMasp);
            this.gcChitietsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcChitietsp.Enabled = false;
            this.gcChitietsp.Location = new System.Drawing.Point(710, 0);
            this.gcChitietsp.Name = "gcChitietsp";
            this.gcChitietsp.Size = new System.Drawing.Size(652, 249);
            this.gcChitietsp.TabIndex = 16;
            this.gcChitietsp.Text = "Chi tiết sản phẩm";
            // 
            // txtHuehong
            // 
            this.txtHuehong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSanpham, "HUEHONG", true));
            this.txtHuehong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHuehong.Location = new System.Drawing.Point(185, 197);
            this.txtHuehong.Name = "txtHuehong";
            this.txtHuehong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuehong.Properties.Appearance.Options.UseFont = true;
            this.txtHuehong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHuehong.Properties.Mask.EditMask = "n0";
            this.txtHuehong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHuehong.Size = new System.Drawing.Size(392, 24);
            this.txtHuehong.TabIndex = 4;
            // 
            // txtDvt
            // 
            this.txtDvt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSanpham, "DVT", true));
            this.txtDvt.Location = new System.Drawing.Point(185, 147);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDvt.Properties.Appearance.Options.UseFont = true;
            this.txtDvt.Size = new System.Drawing.Size(392, 24);
            this.txtDvt.TabIndex = 3;
            // 
            // txtTensp
            // 
            this.txtTensp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSanpham, "TENSP", true));
            this.txtTensp.Location = new System.Drawing.Point(185, 97);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensp.Properties.Appearance.Options.UseFont = true;
            this.txtTensp.Size = new System.Drawing.Size(392, 24);
            this.txtTensp.TabIndex = 2;
            // 
            // txtMasp
            // 
            this.txtMasp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSanpham, "MASP", true));
            this.txtMasp.Location = new System.Drawing.Point(185, 47);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.Properties.Appearance.Options.UseFont = true;
            this.txtMasp.Size = new System.Drawing.Size(392, 24);
            this.txtMasp.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnPhuchoi);
            this.groupControl2.Controls.Add(this.btnUndo);
            this.groupControl2.Controls.Add(this.btnRedo);
            this.groupControl2.Controls.Add(this.btnThoat);
            this.groupControl2.Controls.Add(this.btnRefresh);
            this.groupControl2.Controls.Add(this.btnGhi);
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Controls.Add(this.btnSua);
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(710, 249);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(652, 51);
            this.groupControl2.TabIndex = 17;
            this.groupControl2.Text = "Chức năng";
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhuchoi.Appearance.Options.UseFont = true;
            this.btnPhuchoi.Enabled = false;
            this.btnPhuchoi.Image = ((System.Drawing.Image)(resources.GetObject("btnPhuchoi.Image")));
            this.btnPhuchoi.Location = new System.Drawing.Point(274, 23);
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.Size = new System.Drawing.Size(88, 23);
            this.btnPhuchoi.TabIndex = 33;
            this.btnPhuchoi.Text = "Phục hồi";
            this.btnPhuchoi.Click += new System.EventHandler(this.btnPhuchoi_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Appearance.Options.UseFont = true;
            this.btnUndo.Enabled = false;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(368, 23);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(61, 23);
            this.btnUndo.TabIndex = 32;
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.Appearance.Options.UseFont = true;
            this.btnRedo.Enabled = false;
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.Location = new System.Drawing.Point(435, 23);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(61, 23);
            this.btnRedo.TabIndex = 31;
            this.btnRedo.Text = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(583, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(61, 23);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(502, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Appearance.Options.UseFont = true;
            this.btnGhi.Enabled = false;
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.Location = new System.Drawing.Point(140, 23);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(61, 23);
            this.btnGhi.TabIndex = 28;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(207, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 23);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(73, 23);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 23);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(6, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 23);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gcChitietsp);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.gcSanpham);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSanpham";
            this.Text = "Sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChitietsp)).EndInit();
            this.gcChitietsp.ResumeLayout(false);
            this.gcChitietsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHuehong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDvt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTensp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bdsSanpham;
        private DSTableAdapters.SANPHAMTableAdapter SANPHAMTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSanpham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanpham;
        private DevExpress.XtraGrid.Columns.GridColumn colMASP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENSP;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colHUEHONG;
        private DevExpress.XtraEditors.LabelControl lblThongbao;
        private DevExpress.XtraEditors.GroupControl gcChitietsp;
        private DevExpress.XtraEditors.SpinEdit txtHuehong;
        private DevExpress.XtraEditors.TextEdit txtDvt;
        private DevExpress.XtraEditors.TextEdit txtTensp;
        private DevExpress.XtraEditors.TextEdit txtMasp;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnPhuchoi;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnRedo;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}