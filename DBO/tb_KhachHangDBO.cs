using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_KhachHangDBO
    {
        string _MaKhachHang, _TenKhachHang, _DiaChi, _SDT;

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

        public string TenKhachHang
        {
            get
            {
                return _TenKhachHang;
            }

            set
            {
                _TenKhachHang = value;
            }
        }
    }
}
