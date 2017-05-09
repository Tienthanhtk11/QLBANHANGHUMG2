using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DBO;
using System.Data;

namespace BLL
{
    public class tb_HoaDonNhapBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_HoaDonNhapDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string MaHDN)
        {
            return tb_HoaDonNhapDAL.layDuLieuSoDieuKien(MaHDN);
        }
        public static void them(tb_HoaDonNhapDBO obj)
        {
            tb_HoaDonNhapDAL.them(obj);
        }
        public static void sua(tb_HoaDonNhapDBO obj)
        {
            tb_HoaDonNhapDAL.sua(obj);
        }
        public static void xoa(string MaHDN)
        {
            tb_HoaDonNhapDAL.xoa(MaHDN);
        }
        public static int kiemTraTonTai(string MaHDN)
        {
            return tb_HoaDonNhapDAL.kiemTraTonTai(MaHDN);
        }
    }
}
