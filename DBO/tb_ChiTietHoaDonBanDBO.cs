using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_ChiTietHoaDonBanDBO
    {
        string _MaCTHDB, _MaHoaDonBan, _MaMatHang;
        double _DonGia;
        int _SoLuong;

        public string MaCTHDB
        {
            get
            {
                return _MaCTHDB;
            }

            set
            {
                _MaCTHDB = value;
            }
        }

        public string MaHoaDonBan
        {
            get
            {
                return _MaHoaDonBan;
            }

            set
            {
                _MaHoaDonBan = value;
            }
        }

        public string MaMatHang
        {
            get
            {
                return _MaMatHang;
            }

            set
            {
                _MaMatHang = value;
            }
        }

        public double DonGia
        {
            get
            {
                return _DonGia;
            }

            set
            {
                _DonGia = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }

            set
            {
                _SoLuong = value;
            }
        }
    }
}
