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

        public string MaHoaDonNhap { get => _MaHoaDonNhap; set => _MaHoaDonNhap = value; }
        public string MaNhaCungCap { get => _MaNhaCungCap; set => _MaNhaCungCap = value; }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public DateTime NgayLap { get => _NgayLap; set => _NgayLap = value; }
    }
}
