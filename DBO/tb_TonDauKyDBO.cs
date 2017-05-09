using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_TonDauKyDBO
    {
        string _MaMatHang;
        DateTime _NgayCapNhat;
        int _SoLuong;
        double _GiaTriTon;

        public string MaMatHang { get => _MaMatHang; set => _MaMatHang = value; }
        public DateTime NgayCapNhat { get => _NgayCapNhat; set => _NgayCapNhat = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public double GiaTriTon { get => _GiaTriTon; set => _GiaTriTon = value; }
    }
}
