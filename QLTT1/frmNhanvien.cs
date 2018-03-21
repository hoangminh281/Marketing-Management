using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT1
{
    public partial class frmNhanvien : Form
    {
        private int vitri;
        private String maCN = "";
        private Nhanvien nv = new Nhanvien();
        private Stack<Nhanvien> stackUndo = new Stack<Nhanvien>();
        private Stack<Nhanvien> stackRedo = new Stack<Nhanvien>();

        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;

            this.CHINHANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CHINHANHTableAdapter.Fill(this.dS.CHINHANH);

            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.dS.NHANVIEN);

            this.dS.EnforceConstraints = true;

            maCN = ((DataRowView)bdsNhanvien[0]).Row["MACN"].ToString();

            cmbChinhanh.DataSource = Program.bds_DSPM;
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            //phan quyen chi nhanh CONGTY
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
                btnThem.Enabled =
                    btnSua.Enabled =
                    btnXoa.Enabled = 
                    btnChuyennv.Enabled = false;
            }
            else if (Program.mGroup == "USER")
            {
                btnChuyennv.Enabled = false;
            }
            //khong co du lieu thi khong cho xoa
            if (bdsNhanvien.Count == 0) btnXoa.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhanvien.AddNew();//them hang trang
            txtTrangthai.SelectedIndex = 0;//gan gia tri ban dau la 0
            txtMacn.Text = maCN;//gan gia tri ban dau la macn cua hang dau tien
            //tuy chinh menu
            gcNhanvien.Enabled =
                btnThem.Enabled =
                btnSua.Enabled =
                btnXoa.Enabled =
                btnUndo.Enabled =
                btnRedo.Enabled =
                btnRefresh.Enabled =
                btnThoat.Enabled = false;
            gcThongtinnv.Enabled =
            btnGhi.Enabled =
            btnPhuchoi.Enabled = txtTrangthai.Enabled = true;
            //cap nhat nv dang dung la insert
            nv.Status = Program.status.insert;
            vitri = bdsNhanvien.Position;
            txtManv.Focus();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTrangthai.Enabled = false;
            btnThem.Enabled =
             btnSua.Enabled =
            btnXoa.Enabled =
            btnThoat.Enabled =
            btnUndo.Enabled =
            btnRedo.Enabled =
            btnRefresh.Enabled =
            gcNhanvien.Enabled = false;
            btnGhi.Enabled =
            btnPhuchoi.Enabled =
            gcThongtinnv.Enabled = true;
            txtManv.Focus();
            vitri = bdsNhanvien.Position;
            nv.Manv = ((DataRowView)bdsNhanvien[vitri]).Row[0].ToString();
            nv.Ho = ((DataRowView)bdsNhanvien[vitri]).Row[1].ToString();
            nv.Ten = ((DataRowView)bdsNhanvien[vitri]).Row[2].ToString();
            nv.Ngaysinh = Program.DateFormat(((DataRowView)bdsNhanvien[vitri]).Row[3].ToString());
            nv.Mucluong = ((DataRowView)bdsNhanvien[vitri]).Row[4].ToString();
            nv.Dctt = ((DataRowView)bdsNhanvien[vitri]).Row[5].ToString();
            nv.Dcll = ((DataRowView)bdsNhanvien[vitri]).Row[6].ToString();
            nv.Sdt = ((DataRowView)bdsNhanvien[vitri]).Row[7].ToString();
            nv.Macn = ((DataRowView)bdsNhanvien[vitri]).Row[8].ToString();
            //nv.Trangthai = ((DataRowView)bdsNhanvien[vitri]).Row[9].ToString();
            nv.Status = Program.status.update;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtManv.Text.Trim() == "")
            {
                lblThongbao.Text = "#Mã nhân viên không được thiếu";
                txtManv.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                lblThongbao.Text = "#Họ nhân viên không được thiếu";
                txtHo.Focus();
                return;
            }
            if (!Regex.IsMatch(txtHo.Text.Trim(), @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠ-ỹ]+$"))
            {
                lblThongbao.Text = "#Họ nhân viên chỉ chứa kí tự và blank";
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                lblThongbao.Text = "#Tên nhân viên không được thiếu";
                txtTen.Focus();
                return;
            }
            if (!Regex.IsMatch(txtTen.Text.Trim(), @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠ-ỹ]+$"))
            {
                lblThongbao.Text = "#Tên nhân viên chỉ chứa kí tự và blank";
                txtTen.Focus();
                return;
            }
            if (txtNgaysinh.Text.Trim() == "")
            {
                lblThongbao.Text = "#Ngày sinh nhân viên không được thiếu";
                txtNgaysinh.Focus();
                return;
            }
            if (txtMacn.Text.Trim() == "")
            {
                lblThongbao.Text = "#Mã chi nhánh không được thiếu";
                txtMacn.Focus();
                return;
            }
            if (txtSodt.Text.Trim() == "")
            {
                lblThongbao.Text = "#Số điện thoại nhân viên không được thiếu";
                txtSodt.Focus();
                return;
            }
            if (txtMucluong.Text.Trim() == "") txtMucluong.Text = "0";
            String mucluong = txtMucluong.Text;
            if (mucluong.Contains('.'))
            {
                mucluong = mucluong.Remove(mucluong.IndexOf('.'));
            }
            if (int.Parse(mucluong) <= 0)
            {
                lblThongbao.Text = "#Lương là phải có và là số dương. Bạn xem lại.";
                txtMucluong.Focus();
                return;
            }
            if (txtTrangthai.Text.Trim() == "")
            {
                lblThongbao.Text = "#Trạng thái nhân viên không được thiếu";
                txtTrangthai.Focus();
                return;
            }
            if (txtDctt.Text.Trim() == "")
            {
                lblThongbao.Text = "#Địa chỉ thường trú nhân viên không được thiếu";
                txtDctt.Focus();
                return;
            }
            if (txtDcll.Text.Trim() == "")
            {
                lblThongbao.Text = "#Địa chỉ liên lạc nhân viên không được thiếu";
                txtDcll.Focus();
                return;
            }
            try
            {
                //kiem tra trung manv
                if (nv.Status == Program.status.update || nv.Status == Program.status.insert)
                    if (!nv.Manv.Trim().Equals(txtManv.Text.Trim()) || nv.Status == Program.status.insert)
                    {
                        String query = "EXEC SP_TIMNV_SS " + txtManv.Text;
                        DataTable dt = Program.ExecSqlDataTable(query);
                        if (dt.Rows.Count != 0)
                        {
                            lblThongbao.Text = "#Mã nhân viên bị trùng ở chi nhánh khác";
                            txtManv.Focus();
                            return;
                        }
                    }
                bdsNhanvien.EndEdit();
                bdsNhanvien.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    NHANVIENTableAdapter.Update(dS.NHANVIEN);
                    if (nv.Status == Program.status.insert)
                    {
                        nv.ManvMoi = nv.Manv = ((DataRowView)bdsNhanvien[vitri]).Row[0].ToString();
                        /*nv.Ho = ((DataRowView)bdsNhanvien[vitri]).Row[1].ToString();
                        nv.Ten = ((DataRowView)bdsNhanvien[vitri]).Row[2].ToString();
                        nv.Ngaysinh = Program.DateFormat(((DataRowView)bdsNhanvien[vitri]).Row[3].ToString());
                        nv.Mucluong = ((DataRowView)bdsNhanvien[vitri]).Row[4].ToString();
                        nv.Dctt = ((DataRowView)bdsNhanvien[vitri]).Row[5].ToString();
                        nv.Dcll = ((DataRowView)bdsNhanvien[vitri]).Row[6].ToString();
                        nv.Sdt = ((DataRowView)bdsNhanvien[vitri]).Row[7].ToString();
                        nv.Macn = ((DataRowView)bdsNhanvien[vitri]).Row[8].ToString();
                        nv.Trangthai = ((DataRowView)bdsNhanvien[vitri]).Row[9].ToString();*/
                    }
                    else if (nv.Status == Program.status.update) nv.ManvMoi = ((DataRowView)bdsNhanvien[vitri]).Row[0].ToString();
                    //lay vi tri nv moi
                    bdsNhanvien.Position = bdsNhanvien.Find("MANV", nv.ManvMoi);
                    stackUndo.Push(nv.clone());
                    stackRedo.Clear();
                    nv.clear();
                    btnUndo.Enabled = true;
                    lblThongbao.Text = "";
                    btnGhi.Enabled =
                        btnPhuchoi.Enabled =
                        gcThongtinnv.Enabled =
                        btnRedo.Enabled = false;

                    btnThem.Enabled =
                        btnUndo.Enabled =
                        btnSua.Enabled =
                        btnXoa.Enabled =
                        btnRefresh.Enabled =
                        btnThoat.Enabled =
                        gcNhanvien.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("CONSTRAIN")) lblThongbao.Text = "#Nhân viên này đã lập phiếu, không thể sửa mã nhân viên\n" + ex.Message;
                else if(ex.Message.Contains("MANV")) lblThongbao.Text = "#Mã nhân viên bị trùng.\n" + ex.Message;
                else lblThongbao.Text = "#Lỗi Ghi nhân viên. Bạn kiểm tra lại thông tin nhân viên trước khi ghi.\n" + ex.Message;
                txtManv.Focus();
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    vitri = bdsNhanvien.Position;
                    nv.ManvMoi = nv.Manv = ((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row["MANV"].ToString();
                    /*nv.Ho = ((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row[1].ToString();
                    nv.Ten = ((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row[2].ToString();
                    nv.Ngaysinh = Program.DateFormat(((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row[3].ToString());
                    nv.Mucluong = ((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row[4].ToString();
                    nv.Dctt = ((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row[5].ToString();
                    nv.Dcll = ((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row[6].ToString();
                    nv.Sdt = ((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row[7].ToString();
                    nv.Macn = ((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row[8].ToString();
                    nv.Trangthai = ((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row[9].ToString();*/
                    nv.Status = Program.status.delete;
                    /*bdsNhanvien.RemoveCurrent();
                    NHANVIENTableAdapter.Update(dS.NHANVIEN);*/
                    //chuyen trang thai 1 -> 0
                    if ("0".Equals(((DataRowView)bdsNhanvien[bdsNhanvien.Position]).Row["TRANGTHAI"].ToString()))
                    {
                        lblThongbao.Text = "#Nhân viên này đã được xóa rồi";
                        nv.clear();
                        return;
                    }
                    String query = "EXEC SP_XOANHANVIEN '" + nv.Manv + "'";
                    Program.ExecNonQuery(query);
                    btnRefresh_ItemClick(sender, e);
                    //ket thuc
                    stackUndo.Push(nv.clone());
                    stackRedo.Clear();
                    nv.clear();
                    btnUndo.Enabled = true;
                    btnRedo.Enabled = false;  
                }
                catch (Exception ex)
                {
                    btnRefresh_ItemClick(sender, e);
                    lblThongbao.Text = "#Lỗi xóa nhân viên.\n" + ex.Message;
                }
                bdsNhanvien.Position = vitri;
            }
            if (bdsNhanvien.Count == 0) btnXoa.Enabled = false;
        }
        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stackUndo.Count == 0) return;
            nv = stackUndo.Pop();
            if (nv.isNull()) return;
            //undo
            vitri = bdsNhanvien.Find("MANV", nv.ManvMoi);
            //khong tim thay manv
            if (vitri==-1)
            {
                stackUndo.Push(nv);
                return;
            }
            Program.ExecNonQuery(nv.sqlQuery());
            switch (nv.Status)
            {
                case Program.status.insert:
                    nv.Status = Program.status.delete;
                    btnRefresh_ItemClick(sender, e);
                    bdsNhanvien.Position = vitri;
                    break;
                case Program.status.delete:
                    nv.Status = Program.status.insert;
                    btnRefresh_ItemClick(sender, e);
                    vitri = bdsNhanvien.Find("MANV", nv.ManvMoi);
                    bdsNhanvien.Position = vitri;
                    break;
                case Program.status.update:
                    nv.ManvMoi = nv.Manv;
                    nv.Manv = ((DataRowView)bdsNhanvien[vitri]).Row[0].ToString();
                    nv.Ho = ((DataRowView)bdsNhanvien[vitri]).Row[1].ToString();
                    nv.Ten = ((DataRowView)bdsNhanvien[vitri]).Row[2].ToString();
                    nv.Ngaysinh = Program.DateFormat(((DataRowView)bdsNhanvien[vitri]).Row[3].ToString());
                    nv.Mucluong = ((DataRowView)bdsNhanvien[vitri]).Row[4].ToString();
                    nv.Dctt = ((DataRowView)bdsNhanvien[vitri]).Row[5].ToString();
                    nv.Dcll = ((DataRowView)bdsNhanvien[vitri]).Row[6].ToString();
                    nv.Sdt = ((DataRowView)bdsNhanvien[vitri]).Row[7].ToString();
                    nv.Macn = ((DataRowView)bdsNhanvien[vitri]).Row[8].ToString();
                    //nv.Trangthai = ((DataRowView)bdsNhanvien[vitri]).Row[9].ToString();
                    btnRefresh_ItemClick(sender, e);
                    vitri = bdsNhanvien.Find("MANV", nv.ManvMoi);
                    bdsNhanvien.Position = vitri;
                    break;
            }
            stackRedo.Push(nv.clone());
            nv.clear();
            if (stackUndo.Count == 0) btnUndo.Enabled = false;
            btnRedo.Enabled = true;
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stackRedo.Count == 0) return;
            nv = stackRedo.Pop();
            if (nv.isNull()) return;
            //redo
            vitri = bdsNhanvien.Find("MANV", nv.ManvMoi);
            //khong tim thay manv
            if (vitri == -1)
            {
                stackUndo.Push(nv);
                return;
            }
            Program.ExecNonQuery(nv.sqlQuery());
            switch (nv.Status)
            {
                case Program.status.insert:
                    nv.Status = Program.status.delete;
                    btnRefresh_ItemClick(sender, e);
                    bdsNhanvien.Position = vitri;
                    break;
                case Program.status.delete:
                    nv.Status = Program.status.insert;
                    btnRefresh_ItemClick(sender, e);
                    vitri = bdsNhanvien.Find("MANV", nv.ManvMoi);
                    bdsNhanvien.Position = vitri;
                    break;
                case Program.status.update:
                    nv.ManvMoi = nv.Manv;
                    nv.Manv = ((DataRowView)bdsNhanvien[vitri]).Row[0].ToString();
                    nv.Ho = ((DataRowView)bdsNhanvien[vitri]).Row[1].ToString();
                    nv.Ten = ((DataRowView)bdsNhanvien[vitri]).Row[2].ToString();
                    nv.Ngaysinh = Program.DateFormat(((DataRowView)bdsNhanvien[vitri]).Row[3].ToString());
                    nv.Mucluong = ((DataRowView)bdsNhanvien[vitri]).Row[4].ToString();
                    nv.Dctt = ((DataRowView)bdsNhanvien[vitri]).Row[5].ToString();
                    nv.Dcll = ((DataRowView)bdsNhanvien[vitri]).Row[6].ToString();
                    nv.Sdt = ((DataRowView)bdsNhanvien[vitri]).Row[7].ToString();
                    nv.Macn = ((DataRowView)bdsNhanvien[vitri]).Row[8].ToString();
                    //nv.Trangthai = ((DataRowView)bdsNhanvien[vitri]).Row[9].ToString();
                    btnRefresh_ItemClick(sender, e);
                    vitri = bdsNhanvien.Find("MANV", nv.ManvMoi);
                    bdsNhanvien.Position = vitri;
                    break;
            }
            stackUndo.Push(nv.clone());
            nv.clear();
            if (stackRedo.Count == 0) btnRedo.Enabled = false;
            btnUndo.Enabled = true;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stackUndo.Count > 0) btnUndo.Enabled = true;
            if (stackRedo.Count > 0) btnRedo.Enabled = true;
            bdsNhanvien.CancelEdit();
            bdsNhanvien.Position = vitri;
            gcNhanvien.Enabled = true;
            gcThongtinnv.Enabled = false;
            btnThem.Enabled =
                btnSua.Enabled =
                btnXoa.Enabled =
                btnThoat.Enabled =
                btnRefresh.Enabled = true;
            btnPhuchoi.Enabled =
                btnGhi.Enabled = false;
            nv.clear();
            lblThongbao.Text = "";
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dS.EnforceConstraints = false;
            this.CHINHANHTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.CHINHANH' table. You can move, or remove it, as needed.
            this.CHINHANHTableAdapter.Fill(this.dS.CHINHANH);
            // TODO: This line of code loads data into the 'dS.CHINHANH' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
            this.dS.EnforceConstraints = true;
            lblThongbao.Text = "";
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChinhanh.SelectedValue.ToString();
            if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
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
                this.dS.EnforceConstraints = false;

                this.CHINHANHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CHINHANHTableAdapter.Fill(this.dS.CHINHANH);

                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.dS.NHANVIEN);

                this.dS.EnforceConstraints = true;
            }
        }

        private void btnIndsnv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnChuyennv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = null;
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                if (f.GetType() == typeof(frmChuyennv)) frm = f;
            }
            if (frm != null) frm.Activate();
            else
            {
                frmChuyennv f = new frmChuyennv();
                f.MdiParent = this.ParentForm;
                f.Show();
            }
        }
    }
}
