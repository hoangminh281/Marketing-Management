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
    public partial class frmBangluong : Form
    {
        public frmBangluong()
        {
            InitializeComponent();
        }

        private void frmBangluong_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
            for (int i = year - 10; i <= year + 5; i++)
            {
                cmbNam.Items.Add(i);
            }
            cmbThang.SelectedIndex = cmbThang.FindString(DateTime.Now.Month.ToString());
            cmbNam.SelectedIndex = cmbNam.FindString(year.ToString());
            this.rptView.RefreshReport();
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            rptLuongnvtheothang report = new rptLuongnvtheothang();
            String query = "EXEC SP_LUONGNVTRONGTHANG " + cmbThang.Text + "," + cmbNam.Text;
            DataTable dt = Program.ExecSqlDataTable(query);
            report.SetDataSource(dt);
            report.SetParameterValue("THANG", cmbThang.Text);
            report.SetParameterValue("NAM", cmbNam.Text);
            report.SetParameterValue("CHINHANH", Program.tenchinhanh);
            rptView.ReportSource = report;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
