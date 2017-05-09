using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_HoaDonNhapDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT MaHoaDonNhap 'Mã hóa đơn nhập',tb_NhaCungCap.TenNhaCungCap 'Nhà cung cấp',tb_NhanVien.TenNhanVien 'Nhân viên',NgayLap 'Ngày lập' FROM tb_HoaDonNhap join tb_NhaCungCap on tb_HoaDonNhap.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap join tb_NhanVien on tb_HoaDonNhap.MaNhanVien =tb_NhanVien.MaNhanVien");
        }
        public static DataTable layDuLieuSoDieuKien(string MaHDN)
        {
            return Unility.GetDataTable(string.Format("SELECT MaHoaDonNhap 'Mã hóa đơn nhập',tb_NhaCungCap.TenNhaCungCap 'Nhà cung cấp',tb_NhanVien.TenNhanVien 'Nhân viên',NgayLap 'Ngày lập' FROM tb_HoaDonNhap join tb_NhaCungCap on tb_HoaDonNhap.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap join tb_NhanVien on tb_HoaDonNhap.MaNhanVien =tb_NhanVien.MaNhanVien where MaHoaDonNhap = '{0}'", MaHDN));
        }
        public static void them(tb_HoaDonNhapDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_HoaDonNhap (MaHoaDonNhap ,MaNhaCungCap ,MaNhanVien ,NgayLap) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", obj.MaHoaDonNhap, obj.MaNhaCungCap, obj.MaNhanVien, obj.NgayLap));
        }
        public static void sua(tb_HoaDonNhapDBO obj)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_HoaDonNhap SET MaNhaCungCap = N'{1}' ,MaNhanVien = N'{2}',NgayLap = N'{3}' WHERE  MaHoaDonNhap = N'{0}'", obj.MaHoaDonNhap, obj.MaNhaCungCap, obj.MaNhanVien, obj.NgayLap));
        }
        public static void xoa(string MaHDN)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_HoaDonNhap WHERE MaHoaDonNhap = N'{0}'", MaHDN));
        }
        public static int kiemTraTonTai(string MaHDN)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_HoaDonNhap WHERE MaHoaDonNhap = N'{0}'", MaHDN));
        }
    }
}
