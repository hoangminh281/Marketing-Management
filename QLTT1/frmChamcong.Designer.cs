namespace QLTT1
{
    partial class frmChamcong
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBatdau = new DevExpress.XtraEditors.SimpleButton();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDC_LIENLAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDC_THUONGTRU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUCLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChamcong = new DevExpress.XtraGrid.GridControl();
            this.gvChamcong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaycong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChamcong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChamcong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnBatdau);
            this.groupControl1.Controls.Add(this.cmbNam);
            this.groupControl1.Controls.Add(this.cmbThang);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(854, 61);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chấm công";
            // 
            // btnBatdau
            // 
            this.btnBatdau.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatdau.Appearance.Options.UseFont = true;
            this.btnBatdau.Location = new System.Drawing.Point(640, 27);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.Size = new System.Drawing.Size(75, 23);
            this.btnBatdau.TabIndex = 3;
            this.btnBatdau.Text = "Bắt đầu";
            this.btnBatdau.Click += new System.EventHandler(this.btnBatdau_Click);
            // 
            // cmbNam
            // 
            this.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(399, 26);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(216, 25);
            this.cmbNam.TabIndex = 2;
            // 
            // cmbThang
            // 
            this.cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(106, 26);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(208, 25);
            this.cmbThang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            // 
            // colDC_LIENLAC
            // 
            this.colDC_LIENLAC.FieldName = "DC_LIENLAC";
            this.colDC_LIENLAC.Name = "colDC_LIENLAC";
            // 
            // colDC_THUONGTRU
            // 
            this.colDC_THUONGTRU.FieldName = "DC_THUONGTRU";
            this.colDC_THUONGTRU.Name = "colDC_THUONGTRU";
            // 
            // colMUCLUONG
            // 
            this.colMUCLUONG.FieldName = "MUCLUONG";
            this.colMUCLUONG.Name = "colMUCLUONG";
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            // 
            // gcChamcong
            // 
            this.gcChamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChamcong.Location = new System.Drawing.Point(0, 61);
            this.gcChamcong.MainView = this.gvChamcong;
            this.gcChamcong.Name = "gcChamcong";
            this.gcChamcong.Size = new System.Drawing.Size(854, 376);
            this.gcChamcong.TabIndex = 1;
            this.gcChamcong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChamcong});
            this.gcChamcong.Visible = false;
            // 
            // gvChamcong
            // 
            this.gvChamcong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colManv,
            this.colHoten,
            this.colNgaycong});
            this.gvChamcong.GridControl = this.gcChamcong;
            this.gvChamcong.Name = "gvChamcong";
            this.gvChamcong.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvChamcong.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvChamcong.OptionsView.ShowAutoFilterRow = true;
            // 
            // colManv
            // 
            this.colManv.Caption = "Mã nhân viên";
            this.colManv.FieldName = "MANV";
            this.colManv.Name = "colManv";
            this.colManv.OptionsColumn.AllowEdit = false;
            this.colManv.OptionsColumn.ReadOnly = true;
            this.colManv.OptionsColumn.TabStop = false;
            this.colManv.Visible = true;
            this.colManv.VisibleIndex = 0;
            // 
            // colHoten
            // 
            this.colHoten.Caption = "Họ & Tên";
            this.colHoten.FieldName = "HOTEN";
            this.colHoten.Name = "colHoten";
            this.colHoten.OptionsColumn.AllowEdit = false;
            this.colHoten.OptionsColumn.ReadOnly = true;
            this.colHoten.OptionsColumn.TabStop = false;
            this.colHoten.Visible = true;
            this.colHoten.VisibleIndex = 1;
            // 
            // colNgaycong
            // 
            this.colNgaycong.Caption = "Số ngày công";
            this.colNgaycong.FieldName = "NGAYCONG";
            this.colNgaycong.Name = "colNgaycong";
            this.colNgaycong.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNgaycong.Visible = true;
            this.colNgaycong.VisibleIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(741, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmChamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 437);
            this.Controls.Add(this.gcChamcong);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChamcong";
            this.Text = "Chấm công";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChamcong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChamcong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChamcong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnBatdau;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colDC_LIENLAC;
        private DevExpress.XtraGrid.Columns.GridColumn colDC_THUONGTRU;
        private DevExpress.XtraGrid.Columns.GridColumn colMUCLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.GridControl gcChamcong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChamcong;
        private DevExpress.XtraGrid.Columns.GridColumn colHoten;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaycong;
        private DevExpress.XtraGrid.Columns.GridColumn colManv;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}