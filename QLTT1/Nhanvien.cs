using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT1
{
    class Nhanvien
    {
        private String manvMoi;//ma nhan vien moi

        private String manv;//ma nhan vien cu
        private String ho;
        private String ten;
        private String ngaysinh;
        private String mucluong;
        private String dctt;
        private String dcll;
        private String sdt;
        private String macn;
        //private String trangthai;
        private Program.status status;

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Ho
        {
            get
            {
                return ho;
            }

            set
            {
                ho = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Mucluong
        {
            get
            {
                return mucluong;
            }

            set
            {
                mucluong = value;
            }
        }

        public string Dctt
        {
            get
            {
                return dctt;
            }

            set
            {
                dctt = value;
            }
        }

        public string Dcll
        {
            get
            {
                return dcll;
            }

            set
            {
                dcll = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Macn
        {
            get
            {
                return macn;
            }

            set
            {
                macn = value;
            }
        }

        /*public string Trangthai
        {
            get
            {
                return trangthai;
            }

            set
            {
                trangthai = value;
            }
        }*/

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

        public string ManvMoi
        {
            get
            {
                return manvMoi;
            }

            set
            {
                manvMoi = value;
            }
        }

        public Nhanvien()
        {
            manvMoi =
            Manv =
            Ho =
            Ten =
            Ngaysinh =
            Mucluong =
            Dctt =
            Dcll =
            Sdt =
            Macn = "";
            //Trangthai = "";
            status = Program.status.none;
        }
        public Nhanvien(String manv, String ho, String ten, String ngaysinh, String mucluong, String dctt, String dcll, String sdt, String macn/*, String trangthai*/)
        {
            this.manvMoi =
            this.manv = manv;
            this.ho = ho;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.mucluong = mucluong;
            this.dctt = dctt;
            this.dcll = dcll;
            this.sdt = sdt;
            this.macn = macn;
            //this.trangthai = trangthai;
        }
        public Nhanvien(String manvMoi, String manv, String ho, String ten, String ngaysinh, String mucluong, String dctt, String dcll, String sdt, String macn/*, String trangthai*/, Program.status status)
        {
            this.manvMoi = manvMoi;
            this.manv = manv;
            this.ho = ho;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.mucluong = mucluong;
            this.dctt = dctt;
            this.dcll = dcll;
            this.sdt = sdt;
            this.macn = macn;
            //this.trangthai = trangthai;
            this.status = status;
        }
        public String sqlQuery()
        {
            switch (this.status)
            {
                case Program.status.delete:
                    //return "INSERT INTO NHANVIEN([MANV],[HO],[TEN],[NGAYSINH],[MUCLUONG],[DC_THUONGTRU],[DC_LIENLAC],[SODT],[MACN],[TRANGTHAI]) VALUES ('" + this.manv + "',N'" + this.ho + "',N'" + this.ten + "','" + this.ngaysinh + "','" + this.mucluong + "',N'" + this.dctt + "',N'" + this.dcll + "','" + this.sdt + "','" + this.macn + "','" + this.trangthai + "')";
                    return "EXEC SP_THEMNHANVIEN '" + this.manv + "'";
                case Program.status.update:
                    return "EXEC SP_SUANHANVIEN '" + this.manv + "',N'" + this.ho + "',N'" + this.ten + "','" + this.ngaysinh + "'," + this.mucluong + ",N'" + this.dctt + "',N'" + this.dcll + "'," + this.sdt + ",'" + this.macn + "','"/* + this.trangthai + ",'"*/ + this.manvMoi + "'";
                case Program.status.insert:
                    //return "DELETE FROM NHANVIEN WHERE MANV='" + this.manv + "'";
                    return "EXEC SP_XOANHANVIEN '" + this.manv + "'";
                default: return null;
            }
        }
        public void clear()
        {
            manvMoi =
            Manv =
            Ho =
            Ten =
            Ngaysinh =
            Mucluong =
            Dctt =
            Dcll =
            Sdt =
            Macn = "";
            //Trangthai = "";
            status = Program.status.none;
        }
        public Nhanvien clone()
        {
            return new Nhanvien(manvMoi, Manv, Ho, Ten, Ngaysinh, Mucluong, Dctt, Dcll, Sdt, Macn/*, Trangthai*/, status);
        }
        public bool isNull()
        {
            if (manvMoi == "" && Manv == "" && Ho == "" && Ten == "" && Ngaysinh == "" && Mucluong == "" && Dctt == "" && Dcll == "" && Sdt == "" && Macn == "" /*&& Trangthai == ""*/ && status == Program.status.none)
            {
                return true;
            }
            return false;
        }
    }
}