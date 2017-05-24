
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
    public class tb_ChiTietHoaDonNhapBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_ChiTietHoaDonNhapDAL.layDuLieu();
        }
        public static DataTable layDuLieuTimkiem(string k)
        {
            return tb_ChiTietHoaDonNhapDAL.layDuLieuTimkiem(k);
        }
        public static DataTable layDuLieuSoHD(string TenChiTietHoaDonNhap)
        {
            return tb_ChiTietHoaDonNhapDAL.layDuLieuSoDieuKien(TenChiTietHoaDonNhap);
        }
        public static void them(tb_ChiTietHoaDonNhapDBO obj)
        {
            tb_ChiTietHoaDonNhapDAL.them(obj);
        }
        public static void sua(tb_ChiTietHoaDonNhapDBO obj,string MaMatHangCu)
        {
            tb_ChiTietHoaDonNhapDAL.sua(obj, MaMatHangCu);
        }
        public static void xoa(tb_ChiTietHoaDonNhapDBO obj)
        {
            tb_ChiTietHoaDonNhapDAL.xoa(obj);
        }
        public static int kiemTraTonTai(tb_ChiTietHoaDonNhapDBO obj)
        {
            return tb_ChiTietHoaDonNhapDAL.kiemTraTonTai(obj);
        }
        public static DataTable timKiem(string MaCTHDN)
        {
            return tb_ChiTietHoaDonNhapDAL.timKiem(MaCTHDN);
        }
    }
}
