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

        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }

            set
            {
                _SoLuong = value;
            }
        }

        public double GiaTriTon
        {
            get
            {
                return _GiaTriTon;
            }

            set
            {
                _GiaTriTon = value;
            }
        }
    }
}
