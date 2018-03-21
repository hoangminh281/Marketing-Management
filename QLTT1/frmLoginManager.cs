using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTT1
{
    public partial class frmLoginManager : Form
    {
        public frmLoginManager()
        {
            InitializeComponent();
        }

        private void frmTaologin_Load(object sender, EventArgs e)
        {
            cmbChinhanh.DataSource = Program.bds_DSPM;
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            this.v_DS_MANVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_MANVTableAdapter.Fill(this.dS_DSMANV.V_DS_MANV);
            cmbTennv_SelectedIndexChanged(sender, e);
            txtManv.ReadOnly = true;
            txtMatkhau.Properties.PasswordChar = '*';
            if (Program.mGroup == "CONGTY")
            {
                cmbQuyenhan.Items.Add("CONGTY");
            }
            else if (Program.mGroup == "CHINHANH")
            {
                cmbChinhanh.Enabled = false;
                cmbQuyenhan.Items.AddRange(new String[] { "CHINHANH", "USER" });
            }
            cmbQuyenhan.SelectedIndex = 0;
        }

        private void cmbTennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTennv.SelectedIndex == -1) return;
            txtManv.Text = ((DataRowView)bdsV_DSMANV[cmbTennv.SelectedIndex])["MANV"].ToString();
        }

        private void tswLogin_Toggled(object sender, EventArgs e)
        {
            if (tswLogin.IsOn)
            {
                btnBatdau.Text = "Xóa tài khoản";
                lblMatkhau.Enabled =
                    lblQuyenhan.Enabled =
                    txtMatkhau.Enabled =
                    cmbQuyenhan.Enabled =
                    btnUnhide.Enabled = false;
            }
            else
            {
                btnBatdau.Text = "Tạo tài khoản";
                lblMatkhau.Enabled =
                    lblQuyenhan.Enabled =
                    txtMatkhau.Enabled =
                    cmbQuyenhan.Enabled =
                    btnUnhide.Enabled = true;
            }
        }

        private void btnBatdau_Click(object sender, EventArgs e)
        {
            if (!tswLogin.IsOn)
            {
                String query = "EXEC SP_TAOLOGIN '" + txtTendn.Text + "','" + txtMatkhau.Text + "','" + txtManv.Text.Trim() + "','" + cmbQuyenhan.SelectedItem.ToString() + "'";
                if (Program.ExecNonQuery(query) == 0)
                    MessageBox.Show("Tạo tài khoản thành công");
            }
            else
            {
                String query = "EXEC SP_XOALOGIN '" + txtTendn.Text + "','" + txtManv.Text + "'";
                if (Program.ExecNonQuery(query) == 0)
                    MessageBox.Show("Xóa tài khoản thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnhide_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatkhau.Properties.PasswordChar = '\0';
        }

        private void btnUnhide_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatkhau.Properties.PasswordChar = '*';
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView" || Program.servername == cmbChinhanh.SelectedValue.ToString()) return;
            Program.servername = cmbChinhanh.SelectedValue.ToString();
            if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin_CT;
                Program.password = Program.remotepassword_CT;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối chi nhánh mới.", "", MessageBoxButtons.OK);
            }
            else
            {
                this.v_DS_MANVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_DS_MANVTableAdapter.Fill(this.dS_DSMANV.V_DS_MANV);
                cmbTennv.SelectedIndex = 0;
                txtTendn.Text = txtMatkhau.Text = "";
            }
        }
    }
}
