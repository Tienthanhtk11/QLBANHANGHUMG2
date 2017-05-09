using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_NhanVienDBO
    {
        string _MaNhanVien, _TenNhanVien, _GioiTinh, _DiaChi, _SDT, _MaPhongBan;
        DateTime _NgaySinh;

        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string MaPhongBan { get => _MaPhongBan; set => _MaPhongBan = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
    }
}
