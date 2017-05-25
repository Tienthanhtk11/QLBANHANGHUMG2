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
    public class tb_DangNhapBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_DangNhapDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string TenTaiKhoan)
        {
            return tb_DangNhapDAL.layDuLieuSoDieuKien(TenTaiKhoan);
        }
        public static void them(tb_DangNhapDBO obj)
        {
            tb_DangNhapDAL.them(obj);
        }
        public static void sua(tb_DangNhapDBO obj)
        {
            tb_DangNhapDAL.sua(obj);
        }
        public static void xoa(string TenTaiKhoan)
        {
            tb_DangNhapDAL.xoa(TenTaiKhoan);
        }
        public static int kiemTraTonTai(string TenTaiKhoan)
        {
            return tb_DangNhapDAL.kiemTraTonTai(TenTaiKhoan);
        }
        public static int kiemTraTonTai(DBO.tb_DangNhapDBO obj)
        {
            return tb_DangNhapDAL.kiemTraTonTai(obj);
        }
        public static int DangNhap(string TenDangNhap, string matKhau)
        {
            return tb_DangNhapDAL.DangNhap(TenDangNhap, matKhau);
        }
        public static int Quyen(string TenDangNhap)
        {
            return tb_DangNhapDAL.Quyen(TenDangNhap);
        }
        public static DataTable taiKhoan(string TenDangNhap, string matKhau)
        {
            return tb_DangNhapDAL.taiKhoan(TenDangNhap, matKhau);
        }
        public static void DoiMK(string TenTaiKhoan,string MK)
        {
            tb_DangNhapDAL.DoiMK(TenTaiKhoan,MK);
        }
    }
}
