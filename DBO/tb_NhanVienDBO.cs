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

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _GioiTinh;
            }

            set
            {
                _GioiTinh = value;
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

        public string MaPhongBan
        {
            get
            {
                return _MaPhongBan;
            }

            set
            {
                _MaPhongBan = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public string SDT
        {
            get
            {
                return _SDT;
            }

            set
            {
                _SDT = value;
            }
        }

        public string TenNhanVien
        {
            get
            {
                return _TenNhanVien;
            }

            set
            {
                _TenNhanVien = value;
            }
        }
    }
}
