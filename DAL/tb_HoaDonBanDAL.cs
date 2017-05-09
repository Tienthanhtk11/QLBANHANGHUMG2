using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_HoaDonBanDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT MaHoaDonBan 'Mã hóa đơn bán',tb_KhachHang.TenKhachHang 'Khách hàng' ,tb_NhanVien.TenNhanVien 'Nhân viên' ,NgayLap 'Ngày nhập',TongThanhToan 'Tổng thanh toán',DaThanhToan 'Đã thanh toán' FROM tb_HoaDonBan join tb_KhachHang on tb_HoaDonBan.MaKhachHang = tb_KhachHang.MaKhachHang join tb_NhanVien on tb_HoaDonBan.MaNhanVien =tb_NhanVien.MaNhanVien");
        }
        public static DataTable layDuLieuSoDieuKien(string MaHDB)
        {
            return Unility.GetDataTable(string.Format("SELECT MaHoaDonBan 'Mã hóa đơn bán',tb_KhachHang.TenKhachHang 'Khách hàng' ,tb_NhanVien.TenNhanVien 'Nhân viên' ,NgayLap 'Ngày nhập',TongThanhToan 'Tổng thanh toán',DaThanhToan 'Đã thanh toán' FROM tb_HoaDonBan join tb_KhachHang on tb_HoaDonBan.MaKhachHang = tb_KhachHang.MaKhachHang join tb_NhanVien on tb_HoaDonBan.MaNhanVien =tb_NhanVien.MaNhanVien where MaHoaDonBan = '{0}'", MaHDB));
        }
        public static void them(tb_HoaDonBanDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_HoaDonBan (MaHoaDonBan,MaKhachHang,MaNhanVien,NgayLap,TongThanhToan,DaThanhToan)VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", obj.MaHoaDonBan, obj.MaKhachHang, obj.MaNhanVien, obj.NgayLap,obj.TongThanhToan,obj.DaThanhToan));
        }
        public static void sua(tb_HoaDonBanDBO obj)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_HoaDonBan SET MaKhachHang = N'{1}' ,MaNhanVien = N'{2}',NgayLap = N'{3}',TongThanhToan = N'{4}',DaThanhToan = N'{5}' WHERE  MaHoaDonBan = N'{0}'", obj.MaHoaDonBan, obj.MaKhachHang, obj.MaNhanVien, obj.NgayLap, obj.TongThanhToan, obj.DaThanhToan));
        }
        public static void xoa(string MaHDB)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_HoaDonBan WHERE MaHoaDonBan = N'{0}'", MaHDB));
        }
        public static int kiemTraTonTai(string MaHDB)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_HoaDonBan WHERE MaHoaDonBan = N'{0}'", MaHDB));
        }
    }
}
