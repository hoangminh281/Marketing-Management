using System;
using System.Data;
using System.Windows.Forms;

namespace QLTT1
{
    public partial class frmGiaohang : Form
    {
        public frmGiaohang()
        {
            InitializeComponent();
        }

        private void frmGiaohang_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            this.gIAOHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOHANGTableAdapter.Fill(this.dS.GIAOHANG);

            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);

            this.sANPHAMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sANPHAMTableAdapter.Fill(this.dS.SANPHAM);

            txtNgaygiao.Text = DateTime.Now.ToShortDateString();

            foreach (DataRow dr in this.dS.NHANVIEN)
            {
                cmbTennv.Items.Add(dr["HO"] + " " + dr["TEN"]);
            }
            cmbTennv.SelectedIndex = 0;
            foreach (DataRow dr in this.dS.SANPHAM)
            {
                cmbTensp.Items.Add(dr["TENSP"]);

            }
            cmbTensp.SelectedIndex = 0;
            //phan quyen chi nhanh CONGTY
            if (Program.mGroup == "CONGTY")
            {
                txtSoluonggiao.Enabled =
                    txtDongia.Enabled =
                    btnHuongdan.Enabled = false;
                gcGiaohang.KeyDown -= gcGiaohang_KeyDown;
            }
        }

        private void cmbTennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtManv.Text = this.dS.NHANVIEN[cmbTennv.SelectedIndex]["MANV"].ToString();
            if (cmbTennv.SelectedIndex == 0)
            {
                btnFirst.Enabled =
                    btnPrev.Enabled = false;
                btnNext.Enabled =
                    btnLast.Enabled = true;
            }
            else if (cmbTennv.SelectedIndex >= (cmbTennv.Items.Count - 1))
            {
                btnFirst.Enabled =
                    btnPrev.Enabled = true;
                btnLast.Enabled =
                    btnNext.Enabled = false;
            }
            else
            {
                btnFirst.Enabled =
                    btnPrev.Enabled =
                    btnLast.Enabled =
                    btnNext.Enabled = true;
            }
            txtSoluonggiao.Text = txtDongia.Text = "";
            kiemtrasp();
        }

        private void cmbTensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMasp.Text = this.dS.SANPHAM[cmbTensp.SelectedIndex]["MASP"].ToString();//doi masp truoc khi kiem tra
            txtSoluonggiao.Text = txtDongia.Text = "";
            kiemtrasp();
        }

        private void txtSoluonggiao_EditValueChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            txtSoluongton.Text = txtSoluonggiao.Text;
            if (txtSoluonggiao.Text != "0" && txtSoluonggiao.Text != "" && txtDongia.Text != "$0" && txtDongia.Text != "") btnThem.Enabled = true;
        }
        private void txtDongia_EditValueChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            if (txtSoluonggiao.Text != "0" && txtSoluonggiao.Text != "" && txtDongia.Text != "$0" && txtDongia.Text != "") btnThem.Enabled = true;
        }

        private void kiemtrasp()
        {
            //phan quyen cho CONGTY
            if (Program.mGroup != "CONGTY")
                txtSoluonggiao.Enabled =
                            txtDongia.Enabled = true;
            //
            lblThongbao.Text = "";
            int pos = 0;
            foreach (DataRowView row in bdsGiaohang)
            {
                if (row["MANV"].ToString() == txtManv.Text && row["MASP"].ToString() == txtMasp.Text && txtNgaygiao.DateTime.Equals(DateTime.Parse(row["NGAYGIAO"].ToString())))
                {
                    txtSoluonggiao.Text = row["SOLG_GIAO"].ToString();
                    txtSoluongton.Text = row["SOLG_TON"].ToString();
                    txtDongia.Text = row["DONGIA"].ToString();
                    lblThongbao.Text = "Sản phẩm '" + cmbTensp.Text.Trim() + "' đã được giao cho nhân viên '" + cmbTennv.Text.Trim() + "'";
                    btnThem.Enabled = false;
                    txtSoluonggiao.Enabled =
                        txtDongia.Enabled = false;
                    bdsGiaohang.Position = pos;
                    return;
                }
                pos++;
            }
            txtSoluonggiao.Text = txtDongia.Text = "";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            cmbTennv.SelectedIndex = 0;
            btnNext.Enabled =
                btnLast.Enabled = true;
            btnPrev.Enabled = false;
            if (cmbTennv.SelectedIndex <= 0) btnFirst.Enabled = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            cmbTennv.SelectedIndex--;
            btnNext.Enabled =
                btnLast.Enabled = true;
            if (cmbTennv.SelectedIndex <= 0)
                btnPrev.Enabled =
                    btnFirst.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cmbTennv.SelectedIndex++;
            btnPrev.Enabled =
            btnFirst.Enabled = true;
            if (cmbTennv.SelectedIndex >= (cmbTennv.Items.Count - 1))
                btnNext.Enabled =
                    btnLast.Enabled = false;
        }


        private void btnLast_Click(object sender, EventArgs e)
        {
            cmbTennv.SelectedIndex = cmbTennv.Items.Count - 1;
            btnPrev.Enabled =
                btnFirst.Enabled = true;
            btnNext.Enabled = false;
            if (cmbTennv.SelectedIndex >= (cmbTennv.Items.Count - 1)) btnNext.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String query = "DECLARE @ret INT EXEC SP_NHAPGIAOHANG " + txtNgaygiao.DateTime.Day + ", " + txtNgaygiao.DateTime.Month + ", " + txtNgaygiao.DateTime.Year + ", '" + txtManv.Text + "', '" + txtMasp.Text + "', " + txtSoluonggiao.Text + ", " + txtDongia.Text + ", @ret OUTPUT SELECT @ret";
            if (Program.ExecSqlDataTable(query).Rows[0][0].Equals("-1"))
            {
                lblThongbao.Text = "Sản phẩm '" + cmbTensp.Text.Trim() + "' đã được giao cho nhân viên '" + cmbTennv.Text.Trim() + "'";
                return;
            }
            btnThem.Enabled = false;
            txtSoluonggiao.Enabled = txtDongia.Enabled = false;
            //refresh bang giaohang
            this.gIAOHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOHANGTableAdapter.Fill(this.dS.GIAOHANG);
            //tim vi tri moi pt moi
            for (int i = 0; i < gvGiaohang.DataRowCount; i++)
            {
                if (gvGiaohang.GetDataRow(i)["MANV"].ToString() == txtManv.Text && gvGiaohang.GetDataRow(i)["MASP"].ToString() == txtMasp.Text && txtNgaygiao.DateTime.Equals(DateTime.Parse(gvGiaohang.GetDataRow(i)["NGAYGIAO"].ToString())))
                {
                    gvGiaohang.FocusedRowHandle = i;
                }
            }
        }

        private void btnHuongdan_Click(object sender, EventArgs e)
        {
            String st = "B1. Chọn tên nhân viên.\nB2. Chọn tên sản phẩm.\nB3. Nhập số lượng giao.\nB4. Nhập đơn giá.\nB5. Chọn chức năng muốn sử dụng.";
            MessageBox.Show(st, "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNgaygiao_EditValueChanged(object sender, EventArgs e)
        {
            kiemtrasp();
        }

        private void gcGiaohang_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.KeyCode.Equals(Keys.Delete)) return;
            if (MessageBox.Show("Bạn thật sự muốn xóa đơn giao hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int vitri = bdsGiaohang.Position;
            bdsGiaohang.RemoveCurrent();
            gIAOHANGTableAdapter.Update(dS.GIAOHANG);
            bdsGiaohang.Position = vitri;
        }

        private void btnTonnotheonv_Click(object sender, EventArgs e)
        {
            Form frm = null;
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                if (f.GetType() == typeof(frmTonnotheonv)) frm = f;
            }
            if (frm != null) frm.Close();
            frmTonnotheonv fTonno = new frmTonnotheonv(txtManv.Text);
            fTonno.MdiParent = this.ParentForm;
            fTonno.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.gIAOHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOHANGTableAdapter.Fill(this.dS.GIAOHANG);
        }
    }
}
