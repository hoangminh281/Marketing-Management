namespace QLTT1
{
    partial class frmGiaohang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaohang));
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLTT1.DS();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new QLTT1.DSTableAdapters.SANPHAMTableAdapter();
            this.nHANVIENTableAdapter = new QLTT1.DSTableAdapters.NHANVIENTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblThongbao = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableAdapterManager = new QLTT1.DSTableAdapters.TableAdapterManager();
            this.bdsGiaohang = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOHANGTableAdapter = new QLTT1.DSTableAdapters.GIAOHANGTableAdapter();
            this.gcGiaohang = new DevExpress.XtraGrid.GridControl();
            this.gvGiaohang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGIAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLG_GIAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLG_TON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTonnotheonv = new DevExpress.XtraEditors.SimpleButton();
            this.txtNgaygiao = new DevExpress.XtraEditors.DateEdit();
            this.txtManv = new DevExpress.XtraEditors.TextEdit();
            this.txtMasp = new DevExpress.XtraEditors.TextEdit();
            this.txtDongia = new DevExpress.XtraEditors.TextEdit();
            this.txtSoluongton = new DevExpress.XtraEditors.TextEdit();
            this.txtSoluonggiao = new DevExpress.XtraEditors.TextEdit();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuongdan = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTensp = new System.Windows.Forms.ComboBox();
            this.cmbTennv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaohang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaohang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaohang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaygiao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaygiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluongton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluonggiao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dS;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblThongbao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1308, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblThongbao
            // 
            this.lblThongbao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongbao.ForeColor = System.Drawing.Color.Red;
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(16, 17);
            this.lblThongbao.Text = "#";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANHANGTableAdapter = null;
            this.tableAdapterManager.CHAMCONGTableAdapter = null;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.GIAOHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.SANPHAMTableAdapter = this.sANPHAMTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLTT1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsGiaohang
            // 
            this.bdsGiaohang.DataMember = "GIAOHANG";
            this.bdsGiaohang.DataSource = this.dS;
            // 
            // gIAOHANGTableAdapter
            // 
            this.gIAOHANGTableAdapter.ClearBeforeFill = true;
            // 
            // gcGiaohang
            // 
            this.gcGiaohang.DataSource = this.bdsGiaohang;
            this.gcGiaohang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGiaohang.Location = new System.Drawing.Point(0, 0);
            this.gcGiaohang.MainView = this.gvGiaohang;
            this.gcGiaohang.Name = "gcGiaohang";
            this.gcGiaohang.Size = new System.Drawing.Size(1308, 220);
            this.gcGiaohang.TabIndex = 1;
            this.gcGiaohang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGiaohang});
            this.gcGiaohang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcGiaohang_KeyDown);
            // 
            // gvGiaohang
            // 
            this.gvGiaohang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colMASP,
            this.colNGAYGIAO,
            this.colSOLG_GIAO,
            this.colDONGIA,
            this.colSOLG_TON});
            this.gvGiaohang.GridControl = this.gcGiaohang;
            this.gvGiaohang.Name = "gvGiaohang";
            this.gvGiaohang.OptionsBehavior.Editable = false;
            this.gvGiaohang.OptionsBehavior.ReadOnly = true;
            this.gvGiaohang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvGiaohang.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colMASP
            // 
            this.colMASP.Caption = "Mã sản phẩm";
            this.colMASP.FieldName = "MASP";
            this.colMASP.Name = "colMASP";
            this.colMASP.Visible = true;
            this.colMASP.VisibleIndex = 1;
            // 
            // colNGAYGIAO
            // 
            this.colNGAYGIAO.Caption = "Ngày giao";
            this.colNGAYGIAO.FieldName = "NGAYGIAO";
            this.colNGAYGIAO.Name = "colNGAYGIAO";
            this.colNGAYGIAO.Visible = true;
            this.colNGAYGIAO.VisibleIndex = 2;
            // 
            // colSOLG_GIAO
            // 
            this.colSOLG_GIAO.Caption = "Số lượng giao";
            this.colSOLG_GIAO.FieldName = "SOLG_GIAO";
            this.colSOLG_GIAO.Name = "colSOLG_GIAO";
            this.colSOLG_GIAO.Visible = true;
            this.colSOLG_GIAO.VisibleIndex = 3;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 4;
            // 
            // colSOLG_TON
            // 
            this.colSOLG_TON.Caption = "Số lượng tồn";
            this.colSOLG_TON.FieldName = "SOLG_TON";
            this.colSOLG_TON.Name = "colSOLG_TON";
            this.colSOLG_TON.Visible = true;
            this.colSOLG_TON.VisibleIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnTonnotheonv);
            this.groupControl1.Controls.Add(this.txtNgaygiao);
            this.groupControl1.Controls.Add(this.txtManv);
            this.groupControl1.Controls.Add(this.txtMasp);
            this.groupControl1.Controls.Add(this.txtDongia);
            this.groupControl1.Controls.Add(this.txtSoluongton);
            this.groupControl1.Controls.Add(this.txtSoluonggiao);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnHuongdan);
            this.groupControl1.Controls.Add(this.btnLast);
            this.groupControl1.Controls.Add(this.btnNext);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.btnPrev);
            this.groupControl1.Controls.Add(this.btnFirst);
            this.groupControl1.Controls.Add(this.cmbTensp);
            this.groupControl1.Controls.Add(this.cmbTennv);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 220);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1308, 276);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin giao hàng";
            // 
            // btnTonnotheonv
            // 
            this.btnTonnotheonv.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTonnotheonv.Appearance.Options.UseFont = true;
            this.btnTonnotheonv.Image = ((System.Drawing.Image)(resources.GetObject("btnTonnotheonv.Image")));
            this.btnTonnotheonv.Location = new System.Drawing.Point(226, 232);
            this.btnTonnotheonv.Name = "btnTonnotheonv";
            this.btnTonnotheonv.Size = new System.Drawing.Size(85, 39);
            this.btnTonnotheonv.TabIndex = 48;
            this.btnTonnotheonv.Text = "Tồn nợ";
            this.btnTonnotheonv.Click += new System.EventHandler(this.btnTonnotheonv_Click);
            // 
            // txtNgaygiao
            // 
            this.txtNgaygiao.EditValue = new System.DateTime(2017, 11, 21, 10, 54, 50, 0);
            this.txtNgaygiao.Location = new System.Drawing.Point(98, 31);
            this.txtNgaygiao.Name = "txtNgaygiao";
            this.txtNgaygiao.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaygiao.Properties.Appearance.Options.UseFont = true;
            this.txtNgaygiao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaygiao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaygiao.Size = new System.Drawing.Size(180, 24);
            this.txtNgaygiao.TabIndex = 10;
            this.txtNgaygiao.EditValueChanged += new System.EventHandler(this.txtNgaygiao_EditValueChanged);
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(657, 75);
            this.txtManv.Name = "txtManv";
            this.txtManv.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.Properties.Appearance.Options.UseFont = true;
            this.txtManv.Properties.Mask.EditMask = "n0";
            this.txtManv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtManv.Size = new System.Drawing.Size(352, 24);
            this.txtManv.TabIndex = 47;
            this.txtManv.TabStop = false;
            // 
            // txtMasp
            // 
            this.txtMasp.Enabled = false;
            this.txtMasp.Location = new System.Drawing.Point(657, 112);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.Properties.Appearance.Options.UseFont = true;
            this.txtMasp.Properties.Mask.EditMask = "n0";
            this.txtMasp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMasp.Size = new System.Drawing.Size(352, 24);
            this.txtMasp.TabIndex = 46;
            this.txtMasp.TabStop = false;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(147, 195);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Properties.Appearance.Options.UseFont = true;
            this.txtDongia.Properties.Mask.EditMask = "$###,###0";
            this.txtDongia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDongia.Size = new System.Drawing.Size(352, 24);
            this.txtDongia.TabIndex = 14;
            this.txtDongia.EditValueChanged += new System.EventHandler(this.txtDongia_EditValueChanged);
            // 
            // txtSoluongton
            // 
            this.txtSoluongton.Enabled = false;
            this.txtSoluongton.Location = new System.Drawing.Point(657, 155);
            this.txtSoluongton.Name = "txtSoluongton";
            this.txtSoluongton.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluongton.Properties.Appearance.Options.UseFont = true;
            this.txtSoluongton.Properties.Mask.EditMask = "n0";
            this.txtSoluongton.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoluongton.Size = new System.Drawing.Size(352, 24);
            this.txtSoluongton.TabIndex = 43;
            this.txtSoluongton.TabStop = false;
            // 
            // txtSoluonggiao
            // 
            this.txtSoluonggiao.Location = new System.Drawing.Point(147, 155);
            this.txtSoluonggiao.Name = "txtSoluonggiao";
            this.txtSoluonggiao.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluonggiao.Properties.Appearance.Options.UseFont = true;
            this.txtSoluonggiao.Properties.Mask.EditMask = "###,0";
            this.txtSoluonggiao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoluonggiao.Size = new System.Drawing.Size(352, 24);
            this.txtSoluonggiao.TabIndex = 13;
            this.txtSoluonggiao.EditValueChanged += new System.EventHandler(this.txtSoluonggiao_EditValueChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(430, 232);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 39);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuongdan
            // 
            this.btnHuongdan.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuongdan.Appearance.Options.UseFont = true;
            this.btnHuongdan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongdan.Image")));
            this.btnHuongdan.Location = new System.Drawing.Point(317, 232);
            this.btnHuongdan.Name = "btnHuongdan";
            this.btnHuongdan.Size = new System.Drawing.Size(107, 39);
            this.btnHuongdan.TabIndex = 27;
            this.btnHuongdan.Text = "Hướng dẫn";
            this.btnHuongdan.Click += new System.EventHandler(this.btnHuongdan_Click);
            // 
            // btnLast
            // 
            this.btnLast.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Appearance.Options.UseFont = true;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLast.Location = new System.Drawing.Point(905, 193);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(108, 26);
            this.btnLast.TabIndex = 25;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(791, 193);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 26);
            this.btnNext.TabIndex = 24;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Enabled = false;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(44, 232);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 39);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Appearance.Options.UseFont = true;
            this.btnPrev.Enabled = false;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.Location = new System.Drawing.Point(677, 193);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(108, 26);
            this.btnPrev.TabIndex = 23;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Appearance.Options.UseFont = true;
            this.btnFirst.Enabled = false;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFirst.Location = new System.Drawing.Point(563, 193);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(108, 26);
            this.btnFirst.TabIndex = 22;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // cmbTensp
            // 
            this.cmbTensp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTensp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTensp.FormattingEnabled = true;
            this.cmbTensp.Location = new System.Drawing.Point(147, 115);
            this.cmbTensp.Name = "cmbTensp";
            this.cmbTensp.Size = new System.Drawing.Size(352, 25);
            this.cmbTensp.TabIndex = 12;
            this.cmbTensp.SelectedIndexChanged += new System.EventHandler(this.cmbTensp_SelectedIndexChanged);
            // 
            // cmbTennv
            // 
            this.cmbTennv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTennv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTennv.FormattingEnabled = true;
            this.cmbTennv.Location = new System.Drawing.Point(147, 75);
            this.cmbTennv.Name = "cmbTennv";
            this.cmbTennv.Size = new System.Drawing.Size(352, 25);
            this.cmbTennv.TabIndex = 11;
            this.cmbTennv.SelectedIndexChanged += new System.EventHandler(this.cmbTennv_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(560, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mã sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(560, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số lượng tồn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số lượng giao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ngày giao:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(130, 232);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 39);
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmGiaohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 533);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcGiaohang);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaohang";
            this.Text = "Giao hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaohang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaohang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaohang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaohang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaygiao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaygiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluongton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluonggiao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS dS;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private DSTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblThongbao;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsGiaohang;
        private DSTableAdapters.GIAOHANGTableAdapter gIAOHANGTableAdapter;
        private DevExpress.XtraGrid.GridControl gcGiaohang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGiaohang;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMASP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGIAO;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLG_GIAO;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLG_TON;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit txtNgaygiao;
        private DevExpress.XtraEditors.TextEdit txtManv;
        private DevExpress.XtraEditors.TextEdit txtMasp;
        private DevExpress.XtraEditors.TextEdit txtDongia;
        private DevExpress.XtraEditors.TextEdit txtSoluongton;
        private DevExpress.XtraEditors.TextEdit txtSoluonggiao;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnHuongdan;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private System.Windows.Forms.ComboBox cmbTensp;
        private System.Windows.Forms.ComboBox cmbTennv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTonnotheonv;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}