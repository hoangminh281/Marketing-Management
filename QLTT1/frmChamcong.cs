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
    public partial class frmChamcong : Form
    {
        private String thang = "";
        private String nam = "";
        public frmChamcong()
        {
            InitializeComponent();
        }

        private void frmChamcong_Load(object sender, EventArgs e)
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
        }

        private void btnBatdau_Click(object sender, EventArgs e)
        {
            thang = cmbThang.GetItemText(this.cmbThang.SelectedItem);
            nam = cmbNam.GetItemText(this.cmbNam.SelectedItem);
            String query = "EXEC SP_DSCHAMCONGTHEOTHANG " + thang + "," + nam;
            gcChamcong.DataSource = Program.ExecSqlDataTable(query);
            gcChamcong.Visible = true;
            gvChamcong.FocusedColumn = gvChamcong.Columns[2];
            gvChamcong.ShowEditor();
            gvChamcong.CellValueChanged += gvChamcong_CellValueChanged;
            //phan quyen chi nhanh CONGTY
            if (Program.mGroup == "CONGTY")
            {
                colNgaycong.OptionsColumn.AllowEdit = false;
                colNgaycong.OptionsColumn.ReadOnly = true;
            }
        }

        //this.gvChamcong.CellValueChanged += gvChamcong_CellValueChanged;
        private void gvChamcong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int vitri = gvChamcong.FocusedRowHandle;
            String manv = gvChamcong.GetRowCellValue(vitri, "MANV").ToString();
            String ngaycong = gvChamcong.GetRowCellValue(vitri, "NGAYCONG").ToString();
            String query = "EXEC SP_NHAPCHAMCONGTHEOTHANG " + thang + ", " + nam + ", '" + manv + "', " + ngaycong;
            Program.ExecNonQuery(query);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
