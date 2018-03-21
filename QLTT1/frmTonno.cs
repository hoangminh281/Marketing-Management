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
    public partial class frmTonno : Form
    {
        public frmTonno()
        {
            InitializeComponent();
        }

        private void frmTonno_Load(object sender, EventArgs e)
        {
            rptTinhhinhtonno report = new rptTinhhinhtonno();
            String query = "EXEC SP_TINHHINHTONNO";
            report.SetDataSource(Program.ExecSqlDataTable(query));
            rptView.ReportSource = report;
        }
    }
}
