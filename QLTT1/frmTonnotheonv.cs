using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT1
{
    public partial class frmTonnotheonv : Form
    {
        private String manv;
        public frmTonnotheonv(String manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void frmTonnotheonv_Load(object sender, EventArgs e)
        {
            String query = "EXEC SP_TINHHINHTONNOTHEONV '" + manv + "'";
            DataTable dt = Program.ExecSqlDataTable(query);
            dt.Columns.Add("TIENNO");
            int sum = 0;
            foreach (DataRow row in dt.Rows)
            {
                row["TIENNO"] = int.Parse(row["SOLG_TON"].ToString()) * int.Parse(row["DONGIA"].ToString());
                sum += int.Parse(row["TIENNO"].ToString());
            }
            String[] rows = new string[dt.Columns.Count];
            //rows[dt.Columns.Count - 2] = "Tổng tiền nợ:";
            rows[dt.Columns.Count - 1] = String.Concat(sum);
            dt.Rows.Add(rows);
            gcTonnotheonv.DataSource = dt;
        }
    }
}
