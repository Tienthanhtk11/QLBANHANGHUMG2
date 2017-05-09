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
    public class tb_NhaCungCapBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_NhaCungCapDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string MaNCC)
        {
            return tb_NhaCungCapDAL.layDuLieuSoDieuKien(MaNCC);
        }
        public static void them(tb_NhaCungCapDBO obj)
        {
            tb_NhaCungCapDAL.them(obj);
        }
        public static void sua(tb_NhaCungCapDBO obj)
        {
            tb_NhaCungCapDAL.sua(obj);
        }
        public static void xoa(string MaNCC)
        {
            tb_NhaCungCapDAL.xoa(MaNCC);
        }
        public static int kiemTraTonTai(string MaNCC)
        {
            return tb_NhaCungCapDAL.kiemTraTonTai(MaNCC);
        }
    }
}
