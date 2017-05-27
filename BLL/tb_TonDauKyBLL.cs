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
    public class tb_TonDauKyBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_TonDauKyDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string maMatHang)
        {
            return tb_TonDauKyDAL.layDuLieuSoDieuKien(maMatHang);
        }
        public static void them(tb_TonDauKyDBO obj)
        {
            tb_TonDauKyDAL.them(obj);
        }
        public static void sua(tb_TonDauKyDBO obj)
        {
            tb_TonDauKyDAL.sua(obj);
        }
        public static void xoa(string maMatHang)
        {
            tb_TonDauKyDAL.xoa(maMatHang);
        }
        public static int kiemTraTonTai(string maMatHang)
        {
            return tb_TonDauKyDAL.kiemTraTonTai(maMatHang);
        }
        public static DataTable layDuLieuBCTonDauKy(DateTime tuNgay, DateTime denNgay)
        {
            return tb_TonDauKyDAL.layDuLieuBCTonDauKy(tuNgay, denNgay);
        }
        public static DataTable layDuLieuBCHienTai()
        {
            return tb_TonDauKyDAL.layDuLieuBCHienTai();
        }
        public static DataTable timKiem(string MaMatHang)
        {
            return tb_TonDauKyDAL.timKiem(MaMatHang);
        }

        public static DataTable tdk(DateTime d1, DateTime d2)
        {
            return tb_TonDauKyDAL.tdk(d1, d2);
        }
    }
}
