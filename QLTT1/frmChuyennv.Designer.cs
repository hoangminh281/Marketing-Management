namespace QLTT1
{
    partial class frmChuyennv
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.dS = new QLTT1.DS();
            this.bdsNhanvien = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QLTT1.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QLTT1.DSTableAdapters.TableAdapterManager();
            this.gcChuyennv = new DevExpress.XtraGrid.GridControl();
            this.gvChuyennv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUCLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDC_THUONGTRU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDC_LIENLAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChuyennv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuyennv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnChuyen);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cmbChinhanh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(892, 60);
            this.groupControl1.TabIndex = 36;
            this.groupControl1.Text = "Chọn chi nhánh";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(731, 27);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(630, 27);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(75, 23);
            this.btnChuyen.TabIndex = 2;
            this.btnChuyen.Text = "Chuyển đổi";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh:";
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(153, 27);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(438, 25);
            this.cmbChinhanh.TabIndex = 0;
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanvien
            // 
            this.bdsNhanvien.DataMember = "NHANVIEN";
            this.bdsNhanvien.DataSource = this.dS;
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
            // gcChuyennv
            // 
            this.gcChuyennv.DataSource = this.bdsNhanvien;
            this.gcChuyennv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChuyennv.Location = new System.Drawing.Point(0, 60);
            this.gcChuyennv.MainView = this.gvChuyennv;
            this.gcChuyennv.Name = "gcChuyennv";
            this.gcChuyennv.Size = new System.Drawing.Size(892, 388);
            this.gcChuyennv.TabIndex = 37;
            this.gcChuyennv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChuyennv});
            // 
            // gvChuyennv
            // 
            this.gvChuyennv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colMUCLUONG,
            this.colDC_THUONGTRU,
            this.colDC_LIENLAC,
            this.colSODT,
            this.colMACN,
            this.colTRANGTHAI});
            this.gvChuyennv.GridControl = this.gcChuyennv;
            this.gvChuyennv.Name = "gvChuyennv";
            this.gvChuyennv.OptionsBehavior.Editable = false;
            this.gvChuyennv.OptionsBehavior.ReadOnly = true;
            this.gvChuyennv.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvChuyennv.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colMUCLUONG
            // 
            this.colMUCLUONG.Caption = "Mức lương";
            this.colMUCLUONG.FieldName = "MUCLUONG";
            this.colMUCLUONG.Name = "colMUCLUONG";
            this.colMUCLUONG.Visible = true;
            this.colMUCLUONG.VisibleIndex = 4;
            // 
            // colDC_THUONGTRU
            // 
            this.colDC_THUONGTRU.Caption = "Địa chỉ thường trú";
            this.colDC_THUONGTRU.FieldName = "DC_THUONGTRU";
            this.colDC_THUONGTRU.Name = "colDC_THUONGTRU";
            this.colDC_THUONGTRU.Visible = true;
            this.colDC_THUONGTRU.VisibleIndex = 5;
            // 
            // colDC_LIENLAC
            // 
            this.colDC_LIENLAC.Caption = "Địa chỉ liên lạc";
            this.colDC_LIENLAC.FieldName = "DC_LIENLAC";
            this.colDC_LIENLAC.Name = "colDC_LIENLAC";
            this.colDC_LIENLAC.Visible = true;
            this.colDC_LIENLAC.VisibleIndex = 6;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 7;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 8;
            // 
            // colTRANGTHAI
            // 
            this.colTRANGTHAI.Caption = "Trạng thái";
            this.colTRANGTHAI.FieldName = "TRANGTHAI";
            this.colTRANGTHAI.Name = "colTRANGTHAI";
            this.colTRANGTHAI.Visible = true;
            this.colTRANGTHAI.VisibleIndex = 9;
            // 
            // frmChuyennv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 448);
            this.Controls.Add(this.gcChuyennv);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChuyennv";
            this.Text = "Chuyển nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChuyennv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChuyennv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuyennv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsNhanvien;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnChuyen;
        private DevExpress.XtraGrid.GridControl gcChuyennv;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChuyennv;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMUCLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDC_THUONGTRU;
        private DevExpress.XtraGrid.Columns.GridColumn colDC_LIENLAC;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAI;
    }
}