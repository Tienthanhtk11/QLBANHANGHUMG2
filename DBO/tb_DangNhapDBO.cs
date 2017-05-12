using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_DangNhapDBO
    {
        string _TenDangNhap, _MatKhau, _MaNhanVien;
        int _Role;

        public string TenDangNhap
        {
            get
            {
                return _TenDangNhap;
            }

            set
            {
                _TenDangNhap = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }

            set
            {
                _MatKhau = value;
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

        public int Role
        {
            get
            {
                return _Role;
            }

            set
            {
                _Role = value;
            }
        }
    }
}
