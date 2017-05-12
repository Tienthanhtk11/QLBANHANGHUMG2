using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_MatHangDBO
    {
        string _MaMatHang, _TenMatHang, _MaNhaCungCap, _MaNhomHang, _DVT;
        double _GiaBan;
        DateTime _NgayCapNhat;

        public string MaMatHang
        {
            get
            {
                return _MaMatHang;
            }

            set
            {
                _MaMatHang = value;
            }
        }

        public string TenMatHang
        {
            get
            {
                return _TenMatHang;
            }

            set
            {
                _TenMatHang = value;
            }
        }

        public string MaNhaCungCap
        {
            get
            {
                return _MaNhaCungCap;
            }

            set
            {
                _MaNhaCungCap = value;
            }
        }

        public string MaNhomHang
        {
            get
            {
                return _MaNhomHang;
            }

            set
            {
                _MaNhomHang = value;
            }
        }

        public string DVT
        {
            get
            {
                return _DVT;
            }

            set
            {
                _DVT = value;
            }
        }

        public double GiaBan
        {
            get
            {
                return _GiaBan;
            }

            set
            {
                _GiaBan = value;
            }
        }

        public DateTime NgayCapNhat
        {
            get
            {
                return _NgayCapNhat;
            }

            set
            {
                _NgayCapNhat = value;
            }
        }
    }
}
