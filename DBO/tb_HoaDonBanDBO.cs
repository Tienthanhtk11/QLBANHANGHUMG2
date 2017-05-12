using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_HoaDonBanDBO
    {
        string _MaHoaDonBan, _MaKhachHang, _MaNhanVien;
        double _TongThanhToan;
        Boolean _DaThanhToan;
        DateTime _NgayLap;

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

        public string MaKhachHang
        {
            get
            {
                return _MaKhachHang;
            }

            set
            {
                _MaKhachHang = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return _MaNhanVien;
            }

            set
            {
                _MaNhanVien = value;
            }
        }

        public double TongThanhToan
        {
            get
            {
                return _TongThanhToan;
            }

            set
            {
                _TongThanhToan = value;
            }
        }

        public bool DaThanhToan
        {
            get
            {
                return _DaThanhToan;
            }

            set
            {
                _DaThanhToan = value;
            }
        }

        public DateTime NgayLap
        {
            get
            {
                return _NgayLap;
            }

            set
            {
                _NgayLap = value;
            }
        }
    }
}
