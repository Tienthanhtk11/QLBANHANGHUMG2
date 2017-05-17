using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DBO;
using System.Data;
using System.Windows.Forms;

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
        public static DataTable thongke(DateTimePicker d1, DateTimePicker d2)
        {
            return tb_KhachHangDAL.thongKe(d1.Value, d2.Value);
        }
    }
}
