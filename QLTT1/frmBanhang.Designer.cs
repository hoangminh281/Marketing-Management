namespace QLTT1
{
    partial class frmBanhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanhang));
            this.dS = new QLTT1.DS();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QLTT1.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QLTT1.DSTableAdapters.TableAdapterManager();
            this.bdsBanhang = new System.Windows.Forms.BindingSource(this.components);
            this.bANHANGTableAdapter = new QLTT1.DSTableAdapters.BANHANGTableAdapter();
            this.gcBanhang = new DevExpress.XtraGrid.GridControl();
            this.gvBanhang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLG_BAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctThongtingiaohang = new DevExpress.XtraEditors.GroupControl();
            this.txtNgayban = new DevExpress.XtraEditors.DateEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblThongbao = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSoluongton = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThanhtien = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManv = new DevExpress.XtraEditors.TextEdit();
            this.txtMasp = new DevExpress.XtraEditors.TextEdit();
            this.txtDongia = new DevExpress.XtraEditors.TextEdit();
            this.txtSoluongban = new DevExpress.XtraEditors.TextEdit();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBanhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBanhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBanhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctThongtingiaohang)).BeginInit();
            this.gctThongtingiaohang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayban.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayban.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluongton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluongban.Properties)).BeginInit();
            this.SuspendLayout();
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
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANHANGTableAdapter = null;
            this.tableAdapterManager.CHAMCONGTableAdapter = null;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.GIAOHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTT1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsBanhang
            // 
            this.bdsBanhang.DataMember = "BANHANG";
            this.bdsBanhang.DataSource = this.dS;
            // 
            // bANHANGTableAdapter
            // 
            this.bANHANGTableAdapter.ClearBeforeFill = true;
            // 
            // gcBanhang
            // 
            this.gcBanhang.DataSource = this.bdsBanhang;
            this.gcBanhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBanhang.Location = new System.Drawing.Point(0, 0);
            this.gcBanhang.MainView = this.gvBanhang;
            this.gcBanhang.Name = "gcBanhang";
            this.gcBanhang.Size = new System.Drawing.Size(1053, 199);
            this.gcBanhang.TabIndex = 55;
            this.gcBanhang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBanhang});
            this.gcBanhang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcBanhang_KeyDown);
            // 
            // gvBanhang
            // 
            this.gvBanhang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colMASP,
            this.colNGAYBAN,
            this.colSOLG_BAN,
            this.colDONGIA});
            this.gvBanhang.GridControl = this.gcBanhang;
            this.gvBanhang.Name = "gvBanhang";
            this.gvBanhang.OptionsBehavior.Editable = false;
            this.gvBanhang.OptionsBehavior.ReadOnly = true;
            this.gvBanhang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvBanhang.OptionsView.ShowAutoFilterRow = true;
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
            // colNGAYBAN
            // 
            this.colNGAYBAN.Caption = "Ngày bán";
            this.colNGAYBAN.FieldName = "NGAYBAN";
            this.colNGAYBAN.Name = "colNGAYBAN";
            this.colNGAYBAN.Visible = true;
            this.colNGAYBAN.VisibleIndex = 2;
            // 
            // colSOLG_BAN
            // 
            this.colSOLG_BAN.Caption = "Số lượng bán";
            this.colSOLG_BAN.FieldName = "SOLG_BAN";
            this.colSOLG_BAN.Name = "colSOLG_BAN";
            this.colSOLG_BAN.Visible = true;
            this.colSOLG_BAN.VisibleIndex = 3;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 4;
            // 
            // gctThongtingiaohang
            // 
            this.gctThongtingiaohang.Controls.Add(this.btnRefresh);
            this.gctThongtingiaohang.Controls.Add(this.txtNgayban);
            this.gctThongtingiaohang.Controls.Add(this.statusStrip1);
            this.gctThongtingiaohang.Controls.Add(this.txtSoluongton);
            this.gctThongtingiaohang.Controls.Add(this.label9);
            this.gctThongtingiaohang.Controls.Add(this.txtThanhtien);
            this.gctThongtingiaohang.Controls.Add(this.label5);
            this.gctThongtingiaohang.Controls.Add(this.txtManv);
            this.gctThongtingiaohang.Controls.Add(this.txtMasp);
            this.gctThongtingiaohang.Controls.Add(this.txtDongia);
            this.gctThongtingiaohang.Controls.Add(this.txtSoluongban);
            this.gctThongtingiaohang.Controls.Add(this.btnThoat);
            this.gctThongtingiaohang.Controls.Add(this.btnHuongdan);
            this.gctThongtingiaohang.Controls.Add(this.btnLast);
            this.gctThongtingiaohang.Controls.Add(this.btnNext);
            this.gctThongtingiaohang.Controls.Add(this.btnThem);
            this.gctThongtingiaohang.Controls.Add(this.btnPrev);
            this.gctThongtingiaohang.Controls.Add(this.btnFirst);
            this.gctThongtingiaohang.Controls.Add(this.cmbTensp);
            this.gctThongtingiaohang.Controls.Add(this.cmbTennv);
            this.gctThongtingiaohang.Controls.Add(this.label8);
            this.gctThongtingiaohang.Controls.Add(this.label7);
            this.gctThongtingiaohang.Controls.Add(this.label6);
            this.gctThongtingiaohang.Controls.Add(this.label4);
            this.gctThongtingiaohang.Controls.Add(this.label3);
            this.gctThongtingiaohang.Controls.Add(this.label2);
            this.gctThongtingiaohang.Controls.Add(this.label1);
            this.gctThongtingiaohang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctThongtingiaohang.Location = new System.Drawing.Point(0, 199);
            this.gctThongtingiaohang.Name = "gctThongtingiaohang";
            this.gctThongtingiaohang.Size = new System.Drawing.Size(1053, 370);
            this.gctThongtingiaohang.TabIndex = 56;
            this.gctThongtingiaohang.Text = "Thông tin giao hàng";
            // 
            // txtNgayban
            // 
            this.txtNgayban.EditValue = null;
            this.txtNgayban.Location = new System.Drawing.Point(95, 32);
            this.txtNgayban.Name = "txtNgayban";
            this.txtNgayban.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayban.Properties.Appearance.Options.UseFont = true;
            this.txtNgayban.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayban.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayban.Size = new System.Drawing.Size(193, 24);
            this.txtNgayban.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblThongbao});
            this.statusStrip1.Location = new System.Drawing.Point(2, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip1.TabIndex = 53;
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
            // txtSoluongton
            // 
            this.txtSoluongton.Enabled = false;
            this.txtSoluongton.Location = new System.Drawing.Point(657, 145);
            this.txtSoluongton.Name = "txtSoluongton";
            this.txtSoluongton.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluongton.Properties.Appearance.Options.UseFont = true;
            this.txtSoluongton.Properties.Mask.EditMask = "n0";
            this.txtSoluongton.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoluongton.Size = new System.Drawing.Size(352, 24);
            this.txtSoluongton.TabIndex = 52;
            this.txtSoluongton.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(560, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 51;
            this.label9.Text = "Số lượng tồn:";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Enabled = false;
            this.txtThanhtien.Location = new System.Drawing.Point(146, 225);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhtien.Properties.Appearance.Options.UseFont = true;
            this.txtThanhtien.Size = new System.Drawing.Size(352, 24);
            this.txtThanhtien.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Thành tiền:";
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(657, 65);
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
            this.txtMasp.Location = new System.Drawing.Point(657, 102);
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
            this.txtDongia.Location = new System.Drawing.Point(147, 185);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Properties.Appearance.Options.UseFont = true;
            this.txtDongia.Properties.Mask.EditMask = "$###,###0";
            this.txtDongia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDongia.Size = new System.Drawing.Size(352, 24);
            this.txtDongia.TabIndex = 21;
            this.txtDongia.EditValueChanged += new System.EventHandler(this.txtDongia_EditValueChanged);
            // 
            // txtSoluongban
            // 
            this.txtSoluongban.Location = new System.Drawing.Point(147, 145);
            this.txtSoluongban.Name = "txtSoluongban";
            this.txtSoluongban.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluongban.Properties.Appearance.Options.UseFont = true;
            this.txtSoluongban.Properties.Mask.EditMask = "###,0";
            this.txtSoluongban.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoluongban.Size = new System.Drawing.Size(352, 24);
            this.txtSoluongban.TabIndex = 20;
            this.txtSoluongban.EditValueChanged += new System.EventHandler(this.txtSoluongban_EditValueChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(391, 261);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 39);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuongdan
            // 
            this.btnHuongdan.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuongdan.Appearance.Options.UseFont = true;
            this.btnHuongdan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongdan.Image")));
            this.btnHuongdan.Location = new System.Drawing.Point(276, 261);
            this.btnHuongdan.Name = "btnHuongdan";
            this.btnHuongdan.Size = new System.Drawing.Size(108, 39);
            this.btnHuongdan.TabIndex = 24;
            this.btnHuongdan.Text = "Hướng dẫn";
            this.btnHuongdan.Click += new System.EventHandler(this.btnHuongdan_Click);
            // 
            // btnLast
            // 
            this.btnLast.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Appearance.Options.UseFont = true;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLast.Location = new System.Drawing.Point(905, 183);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(108, 26);
            this.btnLast.TabIndex = 29;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(791, 183);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 26);
            this.btnNext.TabIndex = 28;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Enabled = false;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(48, 261);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 39);
            this.btnThem.TabIndex = 22;
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
            this.btnPrev.Location = new System.Drawing.Point(677, 183);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(108, 26);
            this.btnPrev.TabIndex = 27;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Appearance.Options.UseFont = true;
            this.btnFirst.Enabled = false;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFirst.Location = new System.Drawing.Point(563, 183);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(108, 26);
            this.btnFirst.TabIndex = 26;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // cmbTensp
            // 
            this.cmbTensp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTensp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTensp.FormattingEnabled = true;
            this.cmbTensp.Location = new System.Drawing.Point(147, 105);
            this.cmbTensp.Name = "cmbTensp";
            this.cmbTensp.Size = new System.Drawing.Size(352, 25);
            this.cmbTensp.TabIndex = 19;
            this.cmbTensp.SelectedIndexChanged += new System.EventHandler(this.cmbTensp_SelectedIndexChanged);
            // 
            // cmbTennv
            // 
            this.cmbTennv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTennv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTennv.FormattingEnabled = true;
            this.cmbTennv.Location = new System.Drawing.Point(147, 65);
            this.cmbTennv.Name = "cmbTennv";
            this.cmbTennv.Size = new System.Drawing.Size(352, 25);
            this.cmbTennv.TabIndex = 18;
            this.cmbTennv.SelectedIndexChanged += new System.EventHandler(this.cmbTennv_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(560, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mã sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(560, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số lượng bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 68);
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
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ngày bán:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(162, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 39);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmBanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 569);
            this.Controls.Add(this.gctThongtingiaohang);
            this.Controls.Add(this.gcBanhang);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanhang";
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBanhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBanhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBanhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctThongtingiaohang)).EndInit();
            this.gctThongtingiaohang.ResumeLayout(false);
            this.gctThongtingiaohang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayban.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayban.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluongton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluongban.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DS dS;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsBanhang;
        private DSTableAdapters.BANHANGTableAdapter bANHANGTableAdapter;
        private DevExpress.XtraGrid.GridControl gcBanhang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBanhang;
        private DevExpress.XtraEditors.GroupControl gctThongtingiaohang;
        private DevExpress.XtraEditors.DateEdit txtNgayban;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblThongbao;
        private DevExpress.XtraEditors.TextEdit txtSoluongton;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtThanhtien;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtManv;
        private DevExpress.XtraEditors.TextEdit txtMasp;
        private DevExpress.XtraEditors.TextEdit txtDongia;
        private DevExpress.XtraEditors.TextEdit txtSoluongban;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMASP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLG_BAN;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}