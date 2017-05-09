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
    public class tb_KhachHangBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_KhachHangDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string MaKH)
        {
            return tb_KhachHangDAL.layDuLieuSoDieuKien(MaKH);
        }
        public static void them(tb_KhachHangDBO obj)
        {
            tb_KhachHangDAL.them(obj);
        }
        public static void sua(tb_KhachHangDBO obj)
        {
            tb_KhachHangDAL.sua(obj);
        }
        public static void xoa(string MaKH)
        {
            tb_KhachHangDAL.xoa(MaKH);
        }
        public static int kiemTraTonTai(string MaKH)
        {
            return tb_KhachHangDAL.kiemTraTonTai(MaKH);
        }
    }
}
