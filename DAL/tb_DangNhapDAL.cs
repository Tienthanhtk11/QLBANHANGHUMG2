using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_DangNhapDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT TenDangNhap 'Tên đăng nhập',MatKhau 'Mật khẩu',tb_NhanVien.TenNhanVien 'Nhân viên',tb_DangNhap.Role 'Quyền'  FROM tb_DangNhap join tb_NhanVien on tb_DangNhap.MaNhanVien = tb_NhanVien.MaNhanVien");
        }
        public static DataTable layDuLieuSoDieuKien(string TenDangNhap)
        {
            return Unility.GetDataTable(string.Format("SELECT TenDangNhap 'Tên đăng nhập',MatKhau 'Mật khẩu',tb_NhanVien.TenNhanVien 'Nhân viên',tb_DangNhap.Role 'Quyền'  FROM tb_DangNhap join tb_NhanVien on tb_DangNhap.MaNhanVien = tb_NhanVien.MaNhanVien where TenDangNhap = '{0}'", TenDangNhap));
        }
        public static void them(tb_DangNhapDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_DangNhap (TenDangNhap,MatKhau,MaNhanVien,Role) VALUES(N'{0}',N'{1}',N'{2}',N'{3}')", obj.TenDangNhap, obj.MatKhau, obj.MaNhanVien, obj.Role));
        }
        public static void sua(tb_DangNhapDBO obj)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_DangNhap SET MatKhau = N'{1}' ,MaNhanVien = N'{2}',Role = N'{3}' WHERE  TenDangNhap = N'{0}'", obj.TenDangNhap, obj.MatKhau, obj.MaNhanVien, obj.Role));
        }
        public static void xoa(string TenDangNhap)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_DangNhap WHERE TenDangNhap = N'{0}'", TenDangNhap));
        }
        public static int kiemTraTonTai(string TenDangNhap)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_DangNhap WHERE TenDangNhap = N'{0}'", TenDangNhap));
        }
        public static int DangNhap(string TenDangNhap,string matKhau)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_DangNhap WHERE TenDangNhap = N'{0}' and MatKhau = '{1}'", TenDangNhap,matKhau));
        }
        public static int Quyen(string TenDangNhap)
        {
            return Unility.AExcuteSQL(string.Format("SELECT sum(Role) FROM tb_DangNhap WHERE TenDangNhap = N'{0}'", TenDangNhap));
        }
        public static DataTable taiKhoan(string TenDangNhap, string matKhau)
        {
            return Unility.GetDataTable(string.Format("SELECT * FROM tb_DangNhap WHERE TenDangNhap = N'{0}' and MatKhau = '{1}'", TenDangNhap, matKhau));
        }
        public static void DoiMK(string TenTaiKhoan, string MK)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_DangNhap SET MatKhau = N'{1}' WHERE  TenDangNhap = N'{0}'", TenTaiKhoan,MK));
        }
        
    }
}
