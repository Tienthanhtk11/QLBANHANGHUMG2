using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_NhomHangDBO
    {
        string _MaNhomHang, _TenNhomHang;

        public string MaNhomHang { get => _MaNhomHang; set => _MaNhomHang = value; }
        public string TenNhomHang { get => _TenNhomHang; set => _TenNhomHang = value; }
    }
}
