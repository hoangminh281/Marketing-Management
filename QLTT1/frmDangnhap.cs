using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLTT1
{
    public partial class frmDangnhap : DevExpress.XtraEditors.XtraForm
    {
        public const String argumentEmptyException = "Loi khong duoc de trong";
        public const String argumentOutOfRangeException = "Loi chua ki tu dac biet";
        public const String cannotConnectDBException = "Loi ket noi khong duoc";

        public void TestDangnhap(String taikhoan, String matkhau, int chinhanh)
        {
            txtLogin.Text = taikhoan;
            txtPass.Text = matkhau;
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            cmbTENCN.SelectedIndex = chinhanh;
            try
            {
                btnDangnhap_Click(new object(), new EventArgs());
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw ex;
            }
        }
        public frmDangnhap()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
        }

        private void cmbTENCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbTENCN.SelectedValue.ToString();
            }
            catch { }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPass.Text == "")
            {
                throw new ArgumentOutOfRangeException("", argumentEmptyException);
            }
            if (!Regex.IsMatch(txtLogin.Text.Trim(), @"^[a-zA-Z0-9]+$"))
            {
                throw new ArgumentOutOfRangeException("", argumentOutOfRangeException);
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0)
            {
                throw new Exception(cannotConnectDBException);
            }
            Program.mChinhanh = cmbTENCN.SelectedIndex;
            Program.tenchinhanh = cmbTENCN.Text;
            Program.bds_DSPM = bdsPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            SqlDataReader myReader;
            String strlenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            myReader.Read();

            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login không có quyền truy cập dữ liệu");
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            this.Close();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnhide_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void btnUnhide_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void frmDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.username == "") Application.Exit();
        }
    }
}