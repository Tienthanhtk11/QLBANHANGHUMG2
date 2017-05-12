using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_ChiTietHoaDonNhapDBO
    {
        string _MaCTHDN, _MaHoaDonNhap, _MaMatHang;
        double _DonGia;
        int _SoLuong;

        public string MaCTHDN
        {
            get
            {
                return _MaCTHDN;
            }

            set
            {
                _MaCTHDN = value;
            }
        }

        public string MaHoaDonNhap
        {
            get
            {
                return _MaHoaDonNhap;
            }

            set
            {
                _MaHoaDonNhap = value;
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
