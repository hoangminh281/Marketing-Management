namespace QLTT1
{
    partial class frmTonnotheonv
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
            this.gcTonnotheonv = new DevExpress.XtraGrid.GridControl();
            this.gvTonnotheonv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaygiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSolg_ton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienno = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcTonnotheonv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonnotheonv)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTonnotheonv
            // 
            this.gcTonnotheonv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTonnotheonv.Location = new System.Drawing.Point(0, 0);
            this.gcTonnotheonv.MainView = this.gvTonnotheonv;
            this.gcTonnotheonv.Name = "gcTonnotheonv";
            this.gcTonnotheonv.Size = new System.Drawing.Size(635, 383);
            this.gcTonnotheonv.TabIndex = 0;
            this.gcTonnotheonv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTonnotheonv});
            // 
            // gvTonnotheonv
            // 
            this.gvTonnotheonv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasp,
            this.colTensp,
            this.colNgaygiao,
            this.colSolg_ton,
            this.colDongia,
            this.colTienno});
            this.gvTonnotheonv.GridControl = this.gcTonnotheonv;
            this.gvTonnotheonv.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TIENNO", this.colTienno, "{0:c2}")});
            this.gvTonnotheonv.Name = "gvTonnotheonv";
            this.gvTonnotheonv.OptionsBehavior.Editable = false;
            this.gvTonnotheonv.OptionsBehavior.ReadOnly = true;
            this.gvTonnotheonv.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvTonnotheonv.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMasp
            // 
            this.colMasp.Caption = "Mã sản phẩm";
            this.colMasp.FieldName = "MASP";
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = true;
            this.colMasp.VisibleIndex = 0;
            // 
            // colTensp
            // 
            this.colTensp.Caption = "Tên sản phẩm";
            this.colTensp.FieldName = "TENSP";
            this.colTensp.Name = "colTensp";
            this.colTensp.Visible = true;
            this.colTensp.VisibleIndex = 1;
            // 
            // colNgaygiao
            // 
            this.colNgaygiao.Caption = "Ngày giao";
            this.colNgaygiao.FieldName = "NGAYGIAO";
            this.colNgaygiao.Name = "colNgaygiao";
            this.colNgaygiao.Visible = true;
            this.colNgaygiao.VisibleIndex = 2;
            // 
            // colSolg_ton
            // 
            this.colSolg_ton.Caption = "Số lượng tồn";
            this.colSolg_ton.FieldName = "SOLG_TON";
            this.colSolg_ton.Name = "colSolg_ton";
            this.colSolg_ton.Visible = true;
            this.colSolg_ton.VisibleIndex = 3;
            // 
            // colDongia
            // 
            this.colDongia.Caption = "Đơn giá";
            this.colDongia.FieldName = "DONGIA";
            this.colDongia.Name = "colDongia";
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 4;
            // 
            // colTienno
            // 
            this.colTienno.Caption = "Tiền nợ";
            this.colTienno.FieldName = "TIENNO";
            this.colTienno.Name = "colTienno";
            this.colTienno.Visible = true;
            this.colTienno.VisibleIndex = 5;
            // 
            // frmTonnotheonv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 383);
            this.Controls.Add(this.gcTonnotheonv);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTonnotheonv";
            this.Text = "Danh sách tồn nợ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTonnotheonv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcTonnotheonv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonnotheonv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTonnotheonv;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTonnotheonv;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaygiao;
        private DevExpress.XtraGrid.Columns.GridColumn colSolg_ton;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraGrid.Columns.GridColumn colTienno;
    }
}