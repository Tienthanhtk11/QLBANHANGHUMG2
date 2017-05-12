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

        public string TenNhaCungCap
        {
            get
            {
                return _TenNhaCungCap;
            }

            set
            {
                _TenNhaCungCap = value;
            }
        }
    }
}
