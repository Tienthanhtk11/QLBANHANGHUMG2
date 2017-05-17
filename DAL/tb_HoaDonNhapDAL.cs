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
		public static DataTable layDuLieuBaoCao(DateTime tuNgay, DateTime denNgay)
		{
			return Unility.GetDataTable(string.Format("SELECT tb_HoaDonNhap.MaHoaDonNhap 'Mã hóa đơn nhập',tb_NhaCungCap.TenNhaCungCap 'Nhà cung cấp',tb_NhanVien.TenNhanVien 'Nhân viên',NgayLap 'Ngày lập', count(tb_ChiTietHoaDonNhap.MaMatHang) 'Số mặt hàng nhập',sum(tb_ChiTietHoaDonNhap.SoLuong) 'Số lượng nhập',sum(tb_ChiTietHoaDonNhap.DonGia) 'Tổng đơn giá hóa đơn' FROM tb_HoaDonNhap join tb_NhaCungCap on tb_HoaDonNhap.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap join tb_NhanVien on tb_HoaDonNhap.MaNhanVien =tb_NhanVien.MaNhanVien join tb_ChiTietHoaDonNhap on tb_HoaDonNhap.MaHoaDonNhap = tb_ChiTietHoaDonNhap.MaHoaDonNhap where NgayLap BETWEEN '{0}' AND '{1}' group by tb_HoaDonNhap.MaHoaDonNhap,tb_NhaCungCap.TenNhaCungCap,tb_NhanVien.TenNhanVien,tb_HoaDonNhap.NgayLap", tuNgay, denNgay));
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
		public static DataTable thongKe(DateTime d1, DateTime d2)
		{
			string sql = string.Format(@"SELECT [tb_HoaDonNhap].[MaHoaDonNhap] 'Mã hóa đơn'
											  ,tb_NhaCungCap.TenNhaCungCap 'Tên NCC'
											  --,tb_NhaCungCap.[MaNhaCungCap] 'Mã NCC'
											  ,tb_NhanVien.TenNhanVien 'Tên nhân viên'
											  --,tb_NhanVien.[MaNhanVien] 'Mã NV'
											  ,[NgayLap] 'Ngày lập'
											  ,Count(MaMatHang) 'Số mặt hàng'
											  ,SUM(SoLuong) 'Tổng lượng bán'
											  ,SUM(DonGia * SoLuong) 'Giá trị'
										FROM [dbo].[tb_HoaDonNhap]
										  inner join tb_NhaCungCap on tb_NhaCungCap.MaNhaCungCap = [tb_HoaDonNhap].MaNhaCungCap
										  inner join tb_NhanVien on tb_NhanVien.MaNhanVien = [tb_HoaDonNhap].MaNhanVien
										  inner join tb_ChiTietHoaDonNhap on tb_ChiTietHoaDonNhap.MaHoaDonNhap = [tb_HoaDonNhap].MaHoaDonNhap
										WHERE
										  NgayLap between '{0}' and '{1}'
										GROUP BY
											[tb_HoaDonNhap].[MaHoaDonNhap] 
											,tb_NhaCungCap.TenNhaCungCap 
											,tb_NhaCungCap.[MaNhaCungCap] 
											,tb_NhanVien.TenNhanVien 
											,tb_NhanVien.[MaNhanVien] 
											,[NgayLap]",
										d1.ToString("yyyy/MM/dd"),
										d2.ToString("yyyy/MM/dd"));

			return Unility.GetDataTable(sql);
		}
	}
}
