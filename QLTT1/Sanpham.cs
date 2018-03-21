using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT1
{
    class Sanpham
    {
        private String maspMoi;

        private String masp;
        private String tensp;
        private String donvitinh;
        private String huehong;
        private Program.status status;

        public Program.status Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string MaspMoi
        {
            get
            {
                return maspMoi;
            }

            set
            {
                maspMoi = value;
            }
        }

        public string Masp
        {
            get
            {
                return masp;
            }

            set
            {
                masp = value;
            }
        }

        public string Tensp
        {
            get
            {
                return tensp;
            }

            set
            {
                tensp = value;
            }
        }

        public string Donvitinh
        {
            get
            {
                return donvitinh;
            }

            set
            {
                donvitinh = value;
            }
        }

        public string Huehong
        {
            get
            {
                return huehong;
            }

            set
            {
                huehong = value;
            }
        }

        public Sanpham()
        {
            MaspMoi =
            Masp =
            Tensp =
            Donvitinh =
            Huehong = "";
            status = Program.status.none;
        }
        public Sanpham(String ma, String ten, String donvi, String hong, Program.status status)
        {
            Masp = ma;
            Tensp = ten;
            Donvitinh = donvi;
            Huehong = hong;
            this.status = status;
        }

        public Sanpham(String maMoi, String ma, String ten, String donvi, String hong, Program.status status)
        {
            maspMoi = maMoi;
            Masp = ma;
            Tensp = ten;
            Donvitinh = donvi;
            Huehong = hong;
            this.status = status;
        }

        public String sqlQuery()
        {
            switch (this.status)
            {
                case Program.status.delete:
                    return "INSERT INTO SANPHAM([MASP],[TENSP],[DVT],[HUEHONG]) VALUES ('" + this.masp + "',N'" + this.tensp + "',N'" + this.donvitinh + "','" + this.huehong + "')";
                case Program.status.update:
                    return "UPDATE SANPHAM SET [MASP]='" + this.masp + "',[TENSP]=N'" + this.tensp + "',[DVT]=N'" + this.donvitinh + "',[HUEHONG]='" + this.huehong + "'WHERE [MASP]='" + this.maspMoi + "'";
                case Program.status.insert:
                    return "DELETE FROM SANPHAM WHERE MASP='" + this.masp + "'";
                default: return null;
            }
        }

        public void clear()
        {
            Masp =
            Tensp =
            Donvitinh =
            Huehong = "";
            this.status = Program.status.none;
        }

        public Sanpham clone()
        {
            return new Sanpham(maspMoi, masp, tensp, donvitinh, huehong, status);
        }
        public bool isNull()
        {
            if (maspMoi == "" && tensp == "" && donvitinh == "" && huehong == "" && status == Program.status.none)
            {
                return true;
            }
            return false;
        }
    }
}
