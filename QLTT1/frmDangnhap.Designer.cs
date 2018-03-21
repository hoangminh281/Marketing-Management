namespace QLTT1
{
    partial class frmDangnhap
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
            System.Windows.Forms.Label tENCNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangnhap));
            this.dS_DSPM = new QLTT1.DS_DSPM();
            this.bdsPM = new System.Windows.Forms.BindingSource();
            this.v_DS_PHANMANHTableAdapter = new QLTT1.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLTT1.DS_DSPMTableAdapters.TableAdapterManager();
            this.cmbTENCN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnhide = new DevExpress.XtraEditors.SimpleButton();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(38, 50);
            tENCNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(61, 17);
            tENCNLabel.TabIndex = 14;
            tENCNLabel.Text = "TENCN:";
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "V_DS_PHANMANH";
            this.bdsPM.DataSource = this.dS_DSPM;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLTT1.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbTENCN
            // 
            this.cmbTENCN.DataSource = this.bdsPM;
            this.cmbTENCN.DisplayMember = "TENCN";
            this.cmbTENCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTENCN.FormattingEnabled = true;
            this.cmbTENCN.Location = new System.Drawing.Point(131, 47);
            this.cmbTENCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTENCN.Name = "cmbTENCN";
            this.cmbTENCN.Size = new System.Drawing.Size(399, 25);
            this.cmbTENCN.TabIndex = 4;
            this.cmbTENCN.ValueMember = "TENSERVER";
            this.cmbTENCN.SelectedIndexChanged += new System.EventHandler(this.cmbTENCN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(131, 113);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(302, 25);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "dhp";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(131, 173);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(302, 25);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "123456";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Appearance.Options.UseFont = true;
            this.btnDangnhap.Location = new System.Drawing.Point(94, 176);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangnhap.TabIndex = 2;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(254, 176);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnUnhide
            // 
            this.btnUnhide.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnhide.Appearance.Options.UseFont = true;
            this.btnUnhide.Image = ((System.Drawing.Image)(resources.GetObject("btnUnhide.Image")));
            this.btnUnhide.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUnhide.Location = new System.Drawing.Point(331, 132);
            this.btnUnhide.Name = "btnUnhide";
            this.btnUnhide.Size = new System.Drawing.Size(25, 25);
            this.btnUnhide.TabIndex = 15;
            this.btnUnhide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUnhide_MouseDown);
            this.btnUnhide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUnhide_MouseUp);
            // 
            // frmDangnhap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 225);
            this.Controls.Add(this.btnUnhide);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(tENCNLabel);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTENCN);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangnhap";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangnhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource bdsPM;
        private DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTENCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.SimpleButton btnDangnhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnUnhide;
    }
}