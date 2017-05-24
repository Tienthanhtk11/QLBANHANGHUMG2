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
    public class tb_NhanVienBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_NhanVienDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string MaNV)
        {
            return tb_NhanVienDAL.layDuLieuSoDieuKien(MaNV);
        }
        public static void them(tb_NhanVienDBO obj)
        {
            tb_NhanVienDAL.them(obj);
        }
        public static void sua(tb_NhanVienDBO obj)
        {
            tb_NhanVienDAL.sua(obj);
        }
        public static void xoa(string MaNV)
        {
            tb_NhanVienDAL.xoa(MaNV);
        }
        public static int kiemTraTonTai(string MaNV)
        {
            return tb_NhanVienDAL.kiemTraTonTai(MaNV);
        }
        public static DataTable timKiem(string MaNhanVien)
        {
            return tb_NhanVienDAL.timKiem(MaNhanVien);
        }
    }
}
