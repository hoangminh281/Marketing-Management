using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace QLTT1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        public static String servername = ""; //ten server MINH-PC
        public static String username = ""; //ten nguoi dung
        public static String mlogin = ""; //ten dang nhap dung de ket noi lan khac
        public static String password = ""; // mat khau dang nhap dung de ket noi lan khac
        public static String mloginDN = ""; //ten dang nhap luc dang nhap dau tien
        public static String passwordDN = ""; //mat khau luc dang nhap dau tien

        public static String mHoten;
        public static String mGroup;
        public static int mChinhanh;
        public static String tenchinhanh;
        public static String remotelogin = "SUPPORT_CONNECT";
        public static String remotepassword = "123";
        public static String remotelogin_CT = "SUPPORT_CONNECT_CT";
        public static String remotepassword_CT = "123";

        public static String database = "QLTT";
        public static BindingSource bds_DSPM = new BindingSource();
        public enum status { none, insert, update, delete };

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername +
                    ";Initial Catalog=" + Program.database +
                    ";User ID=" + Program.mlogin +
                    ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                //MessageBox.Show("Lỗi kết nối database. Vui lòng kiểm tra lại tài khoản, mật khẩu.\n" + e.Message, "", MessageBoxButtons.OK);
                throw new Exception(frmDangnhap.cannotConnectDBException);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strlenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strlenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String strlenh)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(strlenh, Program.conn);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public static int ExecNonQuery(String strlenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strlenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            return 0;
        }

        public static String DateFormat(String date)
        {
            String[] arrNgaysinh = date.Split(new char[] { '/', ' '});
            return String.Join("-", new String[] { arrNgaysinh[2], arrNgaysinh[1], arrNgaysinh[0] });
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new frmMain());
        }
    }
}
