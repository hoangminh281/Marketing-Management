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
    public partial class frmSanpham : Form
    {
        private static int vitri;
        private static Sanpham sp = new Sanpham();
        private static Stack<Sanpham> stackUndo = new Stack<Sanpham>();
        private static Stack<Sanpham> stackRedo = new Stack<Sanpham>();

        public frmSanpham()
        {
            InitializeComponent();
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            this.SANPHAMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SANPHAMTableAdapter.Fill(this.dS.SANPHAM);

            //phan quyen chi nhanh CONGTY
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled =
                    btnSua.Enabled =
                    btnXoa.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bdsSanpham.AddNew();
            txtMasp.Focus();
            vitri = bdsSanpham.Position;
            gcSanpham.Enabled =
            btnThem.Enabled =
                btnSua.Enabled =
                btnXoa.Enabled =
                btnThoat.Enabled =
                btnUndo.Enabled =
                btnRefresh.Enabled =
                btnRedo.Enabled = false;
            gcChitietsp.Enabled =
            btnGhi.Enabled =
            btnPhuchoi.Enabled = true;
            vitri = bdsSanpham.Position;
            sp.Status = Program.status.insert;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled =
              btnSua.Enabled =
             btnXoa.Enabled =
             btnThoat.Enabled =
             btnUndo.Enabled =
             btnRedo.Enabled =
             btnRefresh.Enabled =
             gcSanpham.Enabled = false;
            btnGhi.Enabled =
            btnPhuchoi.Enabled =
            gcChitietsp.Enabled = true;
            txtMasp.Focus();
            vitri = bdsSanpham.Position;
            sp.Masp = ((DataRowView)bdsSanpham[vitri]).Row[0].ToString();
            sp.Tensp = ((DataRowView)bdsSanpham[vitri]).Row[1].ToString();
            sp.Donvitinh = ((DataRowView)bdsSanpham[vitri]).Row[2].ToString();
            sp.Huehong = ((DataRowView)bdsSanpham[vitri]).Row[3].ToString();
            sp.Status = Program.status.update;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMasp.Text.Trim() == "")
            {
                lblThongbao.Text = "#Mã sản phẩm không được thiếu";
                txtMasp.Focus();
                return;
            }
            if (txtTensp.Text.Trim() == "")
            {
                lblThongbao.Text = "#Tên sản phẩm không được thiếu";
                txtTensp.Focus();
                return;
            }
            if (txtDvt.Text.Trim() == "")
            {
                lblThongbao.Text = "#Đơn vị tính không được thiếu";
                txtDvt.Focus();
                return;
            }
            if (txtHuehong.Text.Trim() == "")
            {
                lblThongbao.Text = "#Huê hồng không được thiếu";
                txtHuehong.Focus();
                return;
            }
            try
            {
                bdsSanpham.EndEdit();
                bdsSanpham.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    SANPHAMTableAdapter.Update(dS.SANPHAM);
                    if (sp.Status == Program.status.insert)
                    {
                        sp.MaspMoi = sp.Masp = ((DataRowView)bdsSanpham[vitri]).Row[0].ToString();
                        sp.Tensp = ((DataRowView)bdsSanpham[vitri]).Row[1].ToString();
                        sp.Donvitinh = ((DataRowView)bdsSanpham[vitri]).Row[2].ToString();
                        sp.Huehong = ((DataRowView)bdsSanpham[vitri]).Row[3].ToString();
                    }
                    else if (sp.Status == Program.status.update) sp.MaspMoi = ((DataRowView)bdsSanpham[vitri]).Row[0].ToString();
                    stackUndo.Push(sp.clone());
                    stackRedo.Clear();
                    sp.clear();
                    btnUndo.Enabled = true;
                    lblThongbao.Text = "";
                    btnGhi.Enabled =
                        btnPhuchoi.Enabled =
                        gcChitietsp.Enabled =
                        btnRedo.Enabled = false;

                    btnThem.Enabled =
                        btnUndo.Enabled =
                        btnSua.Enabled =
                        btnXoa.Enabled =
                        btnRefresh.Enabled =
                        btnThoat.Enabled =
                        gcSanpham.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MASP")) lblThongbao.Text = "#Mã sản phẩm bị trùng.\n" + ex.Message;
                else lblThongbao.Text = "#Lỗi ghi sản phẩm. Bạn kiểm tra lại thông tin nhân viên trước khi ghi.\n" + ex.Message;
                txtMasp.Focus();
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa sản phẩm này ?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    vitri = bdsSanpham.Position;
                    sp.MaspMoi = sp.Masp = ((DataRowView)bdsSanpham[bdsSanpham.Position]).Row[0].ToString();
                    sp.Tensp = ((DataRowView)bdsSanpham[bdsSanpham.Position]).Row[1].ToString();
                    sp.Donvitinh = ((DataRowView)bdsSanpham[bdsSanpham.Position]).Row[2].ToString();
                    sp.Huehong = ((DataRowView)bdsSanpham[bdsSanpham.Position]).Row[3].ToString();
                    sp.Status = Program.status.delete;
                    bdsSanpham.RemoveCurrent();
                    SANPHAMTableAdapter.Update(dS.SANPHAM);
                    stackUndo.Push(sp.clone());
                    stackRedo.Clear();
                    sp.clear();
                    btnUndo.Enabled = true;
                    btnRedo.Enabled = false;
                    bdsSanpham.Position = vitri;
                }
                catch (Exception ex)
                {
                    btnRefresh_Click(sender, e);
                    lblThongbao.Text = "#Lỗi xóa sản phẩm.\n" + ex.Message;
                    bdsSanpham.Position = vitri;
                }
            }
            if (bdsSanpham.Count == 0) btnXoa.Enabled = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (stackUndo.Count == 0) return;
            sp = stackUndo.Pop();
            if (sp.isNull()) return;
            //undo
            vitri = bdsSanpham.Find("MASP", sp.MaspMoi);
            Program.ExecNonQuery(sp.sqlQuery());
            switch (sp.Status)
            {
                case Program.status.insert:
                    sp.Status = Program.status.delete;
                    btnRefresh_Click(sender, e);
                    bdsSanpham.Position = vitri;
                    break;
                case Program.status.delete:
                    sp.Status = Program.status.insert;
                    btnRefresh_Click(sender, e);
                    vitri = bdsSanpham.Find("MASP", sp.MaspMoi);
                    bdsSanpham.Position = vitri;
                    break;
                case Program.status.update:
                    sp.MaspMoi = sp.Masp;
                    sp.Masp = ((DataRowView)bdsSanpham[vitri]).Row[0].ToString();
                    sp.Tensp = ((DataRowView)bdsSanpham[vitri]).Row[1].ToString();
                    sp.Donvitinh = ((DataRowView)bdsSanpham[vitri]).Row[2].ToString();
                    sp.Huehong = ((DataRowView)bdsSanpham[vitri]).Row[3].ToString();
                    btnRefresh_Click(sender, e);
                    vitri = bdsSanpham.Find("MASP", sp.MaspMoi);
                    bdsSanpham.Position = vitri;
                    break;
            }
            stackRedo.Push(sp.clone());
            sp.clear();
            if (stackUndo.Count == 0) btnUndo.Enabled = false;
            btnRedo.Enabled = true;
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (stackRedo.Count == 0) return;
            sp = stackRedo.Pop();
            if (sp.isNull()) return;
            //undo
            vitri = bdsSanpham.Find("MASP", sp.MaspMoi);
            Program.ExecNonQuery(sp.sqlQuery());
            switch (sp.Status)
            {
                case Program.status.insert:
                    sp.Status = Program.status.delete;
                    btnRefresh_Click(sender, e);
                    bdsSanpham.Position = vitri;
                    break;
                case Program.status.delete:
                    sp.Status = Program.status.insert;
                    btnRefresh_Click(sender, e);
                    vitri = bdsSanpham.Find("MASP", sp.MaspMoi);
                    bdsSanpham.Position = vitri;
                    break;
                case Program.status.update:
                    sp.MaspMoi = sp.Masp;
                    sp.Masp = ((DataRowView)bdsSanpham[vitri]).Row[0].ToString();
                    sp.Tensp = ((DataRowView)bdsSanpham[vitri]).Row[1].ToString();
                    sp.Donvitinh = ((DataRowView)bdsSanpham[vitri]).Row[2].ToString();
                    sp.Huehong = ((DataRowView)bdsSanpham[vitri]).Row[3].ToString();
                    btnRefresh_Click(sender, e);
                    vitri = bdsSanpham.Find("MASP", sp.MaspMoi);
                    bdsSanpham.Position = vitri;
                    break;
            }
            stackUndo.Push(sp.clone());
            sp.clear();
            if (stackRedo.Count == 0) btnRedo.Enabled = false;
            btnUndo.Enabled = true;
        }
        private void btnPhuchoi_Click(object sender, EventArgs e)
        {
            if (stackUndo.Count > 0) btnUndo.Enabled = true;
            if (stackRedo.Count > 0) btnRedo.Enabled = true;
            bdsSanpham.CancelEdit();
            bdsSanpham.Position = vitri;
            gcSanpham.Enabled = true;
            gcChitietsp.Enabled = false;
            btnThem.Enabled =
                btnSua.Enabled =
                btnXoa.Enabled =
                btnThoat.Enabled = true;
            btnPhuchoi.Enabled =
                btnGhi.Enabled = false;
            sp.clear();
            lblThongbao.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.SANPHAMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SANPHAMTableAdapter.Fill(this.dS.SANPHAM);
            lblThongbao.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
