using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_NhaCungCapDBO
    {
        string _MaNhaCungCap, _TenNhaCungCap, _DiaChi, _SDT;

        public string MaNhaCungCap { get => _MaNhaCungCap; set => _MaNhaCungCap = value; }
        public string TenNhaCungCap { get => _TenNhaCungCap; set => _TenNhaCungCap = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}
