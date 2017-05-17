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
    public class tb_ChiTietHoaDonBanBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_ChiTietHoaDonBanDAL.layDuLieu();
        }
        public static DataTable layDuLieuTimkiem(string k)
        {
            return tb_ChiTietHoaDonBanDAL.layDuLieuTimkiem(k);
        }
        public static DataTable layDuLieuSoHD(string TenChiTietHoaDonBan)
        {
            return tb_ChiTietHoaDonBanDAL.layDuLieuSoDieuKien(TenChiTietHoaDonBan);
        }
        public static void them(tb_ChiTietHoaDonBanDBO obj)
        {
            tb_ChiTietHoaDonBanDAL.them(obj);
        }
        public static void sua(tb_ChiTietHoaDonBanDBO obj, string MaMatHangCu)
        {
            tb_ChiTietHoaDonBanDAL.sua(obj, MaMatHangCu);
        }
        public static void xoa(tb_ChiTietHoaDonBanDBO obj)
        {
            tb_ChiTietHoaDonBanDAL.xoa(obj);
        }
        public static int kiemTraTonTai(tb_ChiTietHoaDonBanDBO obj)
        {
            return tb_ChiTietHoaDonBanDAL.kiemTraTonTai(obj);
        }
    }
}
