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
    public class tb_HoaDonNhapBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_HoaDonNhapDAL.layDuLieu();
        }
        public static DataTable layDuLieuBaoCao(DateTime tuNgay, DateTime denNgay)
        {
            return tb_HoaDonNhapDAL.layDuLieuBaoCao(tuNgay, denNgay);
        }
        public static DataTable layDuLieuTimkiem(string k)
        {
            return tb_HoaDonNhapDAL.layDuLieuTimkiem(k);
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

        public static DataTable thongke(DateTimePicker d1, DateTimePicker d2)
        {
            return tb_HoaDonNhapDAL.thongKe(d1.Value, d2.Value);
        }
        public static DataTable timKiem(string MaHoaDonNhap)
        {
            return tb_HoaDonNhapDAL.timKiem(MaHoaDonNhap);
        }
    }
}
