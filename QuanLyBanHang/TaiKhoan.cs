using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
namespace QuanLyBanHang
{
    public class TaiKhoan
    {
        string _TenDangNhap = "", _MatKhau = "", _MaNhanVien = "";
        int _Role = 0;
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

        public TaiKhoan(tb_DangNhapDBO temnp)
        {
            TenDangNhap = temnp.TenDangNhap;
            MatKhau = temnp.MatKhau;
            MaNhanVien = temnp.MaNhanVien;
            Role = temnp.Role;
        }
        public TaiKhoan()
        {
            string TenDangNhap = "", MatKhau = "", MaNhanVien = "";
            int Role = 0;
        }
        public void Clear()
        {
            string TenDangNhap = "", MatKhau = "", MaNhanVien = "";
            int Role = 0;
        }
    }
}
