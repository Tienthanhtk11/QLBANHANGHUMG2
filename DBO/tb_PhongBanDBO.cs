using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO
{
    public class tb_PhongBanDBO
    {
        string _MaPhongBan, _TenPhongBan;

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

        public string TenPhongBan
        {
            get
            {
                return _TenPhongBan;
            }

            set
            {
                _TenPhongBan = value;
            }
        }
    }
}
