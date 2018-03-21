using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTT1
{
    public partial class frmChuyennv : Form
    {
        public frmChuyennv()
        {
            InitializeComponent();
        }

        private void frmChuyennv_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
            BindingSource bdsPM = new BindingSource(Program.bds_DSPM.DataSource, Program.bds_DSPM.DataMember);
            cmbChinhanh.DataSource = bdsPM;
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            if (MessageBox.Show("Bạn thật sự muốn chuyển nhân viên này","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    String query = "EXEC SP_CHUYENNV '" + ((DataRowView)bdsNhanvien[bdsNhanvien.Position])["MANV"].ToString().Trim() + "','" + cmbChinhanh.SelectedValue.ToString().Trim() + "'";
                    if (Program.ExecNonQuery(query) == 0)
                        MessageBox.Show("Chuyển nhân viên thành công");
                    int vitri = bdsNhanvien.Position;
                    this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                    bdsNhanvien.Position = vitri;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChinhanh.SelectedIndex == Program.mChinhanh) btnChuyen.Enabled = false;
            else btnChuyen.Enabled = true;
        }
    }
}
