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
    public partial class frmBanhang : Form
    {
        private DataTable dt;
        private DataTable dtsp;

        public frmBanhang()
        {
            InitializeComponent();
        }

        private void frmBanhang_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            this.bANHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANHANGTableAdapter.Fill(this.dS.BANHANG);
            //phan quyen cho nhom CONGTY
            if (Program.mGroup == "CONGTY")
            {
                gctThongtingiaohang.Enabled = false;
                return;
            }
            txtNgayban.Text = DateTime.Now.ToShortDateString();

            String query = "EXEC SP_DSNVGIAOHANGCONHANG";
            dt = Program.ExecSqlDataTable(query);
            if (dt.Rows.Count == 0)
            {
                cmbTensp.Items.Clear();
                txtSoluongban.Enabled = txtDongia.Enabled = false;
                btnThem.Enabled = false;
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                cmbTennv.Items.Add(row["HOTEN"]);
            }
            cmbTennv.SelectedIndex = 0;
        }

        private void cmbTennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //biding manv theo tennv
            txtManv.Text = dt.Rows[cmbTennv.SelectedIndex]["MANV"].ToString();
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
            //xoa ten sp
            cmbTensp.Items.Clear();
            //lay sp theo nv dang chon
            String query = "EXEC SP_DSSPGIAOHANGTHEOMANV '" + txtManv.Text + "'";
            dtsp = Program.ExecSqlDataTable(query);
            if (dtsp == null) return;
            foreach (DataRow row in dtsp.Rows)
            {
                cmbTensp.Items.Add(row["TENSP"]);
            }
            cmbTensp.SelectedIndex = 0;
        }

        private void cmbTensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtsp == null) return;
            txtMasp.Text = dtsp.Rows[cmbTensp.SelectedIndex]["MASP"].ToString();
            txtSoluongton.Text = dtsp.Rows[cmbTensp.SelectedIndex]["SOLG_TON"].ToString();
        }

        private void txtSoluongban_EditValueChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            lblThongbao.Text = "";
            String slban = txtSoluongban.Text;
            String slton = txtSoluongton.Text;
            String dongia = txtDongia.Text;

            //kiem tra format
            if (slban.Contains(',')) slban = slban.Replace(",", "");
            if (slton.Contains(',')) slton = slton.Replace(",", "");

            if (!("".Equals(slban) || "".Equals(dongia)))
            {
                if (dongia.Contains(',')) dongia = dongia.Replace(",", "");
                if (dongia.Contains('$')) dongia = dongia.Replace("$", "");
                Int64 i = Int64.Parse(slban) * Int64.Parse(dongia);
                //thanh tien
                txtThanhtien.Text = string.Concat(i);
            }

            //kiem tra sl ban < sl ton hoac bang 0
            if (int.Parse(slban) > int.Parse(slton) || "0".Equals(txtSoluongban.Text))
            {
                lblThongbao.Text = "Số lượng bán phải nhỏ hơn số lượng tồn và lớn hơn 0.";
                return;
            }

            //kiem tra don gia
            if ("".Equals(txtDongia.Text)) return;
            if ("$0".Equals(txtDongia.Text))
            {
                lblThongbao.Text = "Đơn giá phải lớn hơn 0.";
                return;
            }

            btnThem.Enabled = true;
        }
        private void txtDongia_EditValueChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            lblThongbao.Text = "";
            String slban = txtSoluongban.Text;
            String dongia = txtDongia.Text;

            if (!("".Equals(slban) || "".Equals(dongia)))
            {
                //kiem tra format
                if (slban.Contains(',')) slban = slban.Replace(",", "");
                if (dongia.Contains(',')) dongia = dongia.Replace(",", "");
                if (dongia.Contains('$')) dongia = dongia.Replace("$", "");
                Int64 i = Int64.Parse(slban) * Int64.Parse(dongia);
                //thanh tien
                txtThanhtien.Text = string.Concat(i);
            }
            //kiem tra dongia bang 0
            if ("$0".Equals(dongia))
            {
                lblThongbao.Text = "Đơn giá phải lớn hơn 0.";
                return;
            }
            if ("".Equals(txtSoluongban.Text)) return;
            //kiem tra sl ban > sl ton
            if (int.Parse(txtSoluongban.Text) > int.Parse(txtSoluongton.Text) || "0".Equals(txtSoluongban.Text))
            {
                lblThongbao.Text = "Số lượng bán phải nhỏ hơn số lượng tồn và lớn hơn 0.";
                return;
            }

            btnThem.Enabled = true;
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
            String query = "DECLARE @ret INT EXEC SP_NHAPBANHANG " + txtNgayban.DateTime.Day + ", " + txtNgayban.DateTime.Month + ", " + txtNgayban.DateTime.Year + ", '" + txtManv.Text + "', '" + txtMasp.Text + "', " + txtSoluongban.Text + ", " + txtDongia.Text + ", @ret OUTPUT SELECT @ret";
            DataTable dtThem = Program.ExecSqlDataTable(query);
            switch (dtThem.Rows[0][0].ToString())
            {
                case "0":
                    int pos = bdsBanhang.Position;//luu vi tri cursor
                    //refresh ban hang
                    this.bANHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bANHANGTableAdapter.Fill(this.dS.BANHANG);
                    //luu vi tri cmbtennv
                    int vitri = cmbTennv.SelectedIndex;
                    int vitrisp = cmbTensp.SelectedIndex;
                    cmbTennv.Items.Clear(); //xoa cmb ten nv
                    query = "EXEC SP_DSNVGIAOHANGCONHANG";
                    dt = Program.ExecSqlDataTable(query);
                    //dieu khien menu
                    if (dt.Rows.Count==0)
                    {
                        cmbTensp.Items.Clear();
                        txtSoluongban.Enabled = txtDongia.Enabled = false;
                        btnThem.Enabled = false;
                        return;
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbTennv.Items.Add(row["HOTEN"]); //them item
                    }
                    if (vitri == cmbTennv.Items.Count) vitri -= 1; //neu vitri cuoi ds nv thi giam 1
                    cmbTennv.SelectedIndex = vitri; // nap vi tri
                    if (vitrisp == cmbTensp.Items.Count) vitrisp -= 1; //neu vitri cuoi ds sp thi giam 1
                    cmbTensp.SelectedIndex = vitrisp; // nap vi tri
                    txtSoluongban_EditValueChanged(sender, e); //kiem tra so luong ban
                    //tim vi tri moi pt moi
                    for (int i = 0; i < gvBanhang.DataRowCount; i++)
                    {
                        if (gvBanhang.GetDataRow(i)["MANV"].ToString() == txtManv.Text && gvBanhang.GetDataRow(i)["MASP"].ToString() == txtMasp.Text && txtNgayban.DateTime.Equals(DateTime.Parse(gvBanhang.GetDataRow(i)["NGAYBAN"].ToString())))
                        {
                            bdsBanhang.Position = i;
                            return;
                        }
                    }
                    bdsBanhang.Position = pos;
                    break;
                case "-1":
                    lblThongbao.Text = "Không tìm thấy đơn giao hàng";
                    btnThem.Enabled = false;
                    break;
                case "-2":
                    lblThongbao.Text = "số lượng bán lớn hơn số lượng giao";
                    btnThem.Enabled = false;
                    break;
            }
        }

        private void btnHuongdan_Click(object sender, EventArgs e)
        {
            String st = "B1. Chọn tên nhân viên.\nB2. Chọn tên sản phẩm.\nB3. Nhập số lượng bán.\nB4. Nhập đơn giá.\nB5. Chọn chức năng muốn sử dụng.";
            MessageBox.Show(st, "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcBanhang_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.KeyCode.Equals(Keys.Delete)) return;
            if (MessageBox.Show("Bạn thật sự muốn xóa đơn bán hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int vitri = bdsBanhang.Position;
            bdsBanhang.RemoveCurrent();
            bANHANGTableAdapter.Update(dS.BANHANG);
            bdsBanhang.Position = vitri;
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            //refresh ban hang
            this.bANHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANHANGTableAdapter.Fill(this.dS.BANHANG);
            //luu vi tri cmbtennv
            int vitri = cmbTennv.SelectedIndex;
            int vitrisp = cmbTensp.SelectedIndex;
            cmbTennv.Items.Clear(); //xoa cmb ten nv
            String query = "EXEC SP_DSNVGIAOHANGCONHANG";
            dt = Program.ExecSqlDataTable(query);
            //dieu khien menu
            if (dt.Rows.Count == 0)
            {
                cmbTensp.Items.Clear();
                txtSoluongban.Enabled = txtDongia.Enabled = false;
                btnThem.Enabled = false;
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                cmbTennv.Items.Add(row["HOTEN"]); //them item
            }
            if (vitri == cmbTennv.Items.Count) vitri -= 1; //neu vitri cuoi ds nv thi giam 1
            cmbTennv.SelectedIndex = vitri; // nap vi tri
            if (vitrisp == cmbTensp.Items.Count) vitrisp -= 1; //neu vitri cuoi ds sp thi giam 1
            cmbTensp.SelectedIndex = vitrisp; // nap vi tri
            //tim vi tri moi pt moi
            for (int i = 0; i < gvBanhang.DataRowCount; i++)
            {
                if (gvBanhang.GetDataRow(i)["MANV"].ToString() == txtManv.Text && gvBanhang.GetDataRow(i)["MASP"].ToString() == txtMasp.Text && txtNgayban.DateTime.Equals(DateTime.Parse(gvBanhang.GetDataRow(i)["NGAYBAN"].ToString())))
                {
                    bdsBanhang.Position = i;
                    return;
                }
            }
        }
    }
}
