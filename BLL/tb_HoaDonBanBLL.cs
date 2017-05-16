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
    public class tb_HoaDonBanBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_HoaDonBanDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string MaHDB)
        {
            return tb_HoaDonBanDAL.layDuLieuSoDieuKien(MaHDB);
        }
        public static void them(tb_HoaDonBanDBO obj)
        {
            tb_HoaDonBanDAL.them(obj);
        }
        public static void sua(tb_HoaDonBanDBO obj)
        {
            tb_HoaDonBanDAL.sua(obj);
        }
        public static void xoa(string MaHDB)
        {
            tb_HoaDonBanDAL.xoa(MaHDB);
        }
        public static int kiemTraTonTai(string MaHDB)
        {
            return tb_HoaDonBanDAL.kiemTraTonTai(MaHDB);
        }
        public static DataTable layDuLieuBaoCao(DateTime tuNgay, DateTime denNgay)
        {
            return tb_HoaDonBanDAL.layDuLieuBaoCao(tuNgay, denNgay);
        }
    }
}
