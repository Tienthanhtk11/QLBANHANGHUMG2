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
    public class tb_PhongBanBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_PhongBanDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string MaPhongBan)
        {
            return tb_PhongBanDAL.layDuLieuSoDieuKien(MaPhongBan);
        }
        public static void them(tb_PhongBanDBO obj)
        {
            tb_PhongBanDAL.them(obj);
        }
        public static void sua(tb_PhongBanDBO obj)
        {
            tb_PhongBanDAL.sua(obj);
        }
        public static void xoa(string MaPhongBan)
        {
            tb_PhongBanDAL.xoa(MaPhongBan);
        }
        public static int kiemTraTonTai(string MaPhongBan)
        {
            return tb_PhongBanDAL.kiemTraTonTai(MaPhongBan);
        }
        public static DataTable timKiem(string MaPhongBan)
        {
            return tb_PhongBanDAL.timKiem(MaPhongBan);
        }
    }
}
