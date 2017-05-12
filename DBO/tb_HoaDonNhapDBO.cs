using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_HoaDonNhapDBO
    {
        string _MaHoaDonNhap, _MaNhaCungCap, _MaNhanVien;
        DateTime _NgayLap;

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

        public string MaNhaCungCap
        {
            get
            {
                return _MaNhaCungCap;
            }

            set
            {
                _MaNhaCungCap = value;
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
