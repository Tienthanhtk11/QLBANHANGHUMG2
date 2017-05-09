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
    public class tb_NhomHangBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_NhomHangDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string MaNhomHang)
        {
            return tb_NhomHangDAL.layDuLieuSoDieuKien(MaNhomHang);
        }
        public static void them(tb_NhomHangDBO obj)
        {
            tb_NhomHangDAL.them(obj);
        }
        public static void sua(tb_NhomHangDBO obj)
        {
            tb_NhomHangDAL.sua(obj);
        }
        public static void xoa(string MaNhomHang)
        {
            tb_NhomHangDAL.xoa(MaNhomHang);
        }
        public static int kiemTraTonTai(string MaNhomHang)
        {
            return tb_NhomHangDAL.kiemTraTonTai(MaNhomHang);
        }
    }
}
