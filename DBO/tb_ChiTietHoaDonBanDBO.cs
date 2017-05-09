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

        public string MaCTHDB { get => _MaCTHDB; set => _MaCTHDB = value; }
        public string MaHoaDonBan { get => _MaHoaDonBan; set => _MaHoaDonBan = value; }
        public string MaMatHang { get => _MaMatHang; set => _MaMatHang = value; }
        public double DonGia { get => _DonGia; set => _DonGia = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
    }
}
