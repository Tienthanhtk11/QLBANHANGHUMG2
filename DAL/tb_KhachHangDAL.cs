using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_KhachHangDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT MaKhachHang 'Mã khách hàng',TenKhachHang 'Tên khách hàng',DiaChi 'Địa chỉ',SDT 'Số điện thoại' FROM tb_KhachHang");
        }
        public static DataTable layDuLieuSoDieuKien(string MaKH)
        {
            return Unility.GetDataTable(string.Format("SELECT MaKhachHang 'Mã khách hàng',TenKhachHang 'Tên khách hàng',DiaChi 'Địa chỉ',SDT 'Số điện thoại' FROM tb_KhachHang where MaKhachHang = '{0}'", MaKH));
        }
        public static void them(tb_KhachHangDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_KhachHang (MaKhachHang ,TenKhachHang ,DiaChi ,SDT) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", obj.MaKhachHang, obj.TenKhachHang, obj.DiaChi, obj.SDT));
        }
        public static void sua(tb_KhachHangDBO obj)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_KhachHang SET TenKhachHang = N'{1}' ,DiaChi = N'{2}',SDT = N'{3}' WHERE  MaKhachHang = N'{0}'", obj.MaKhachHang, obj.TenKhachHang, obj.DiaChi, obj.SDT));
        }
        public static void xoa(string MaKH)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_KhachHang WHERE MaKhachHang = N'{0}'", MaKH));
        }
        public static int kiemTraTonTai(string MaKH)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_KhachHang WHERE MaKhachHang = N'{0}'", MaKH));
        }
        public static DataTable thongKe(DateTime d1, DateTime d2)
        {
            string sql = string.Format(@"SELECT [tb_KhachHang].[MaKhachHang] 'MÃ KH'
                                          ,[TenKhachHang] 'Tên khách hàng'
                                          ,[DiaChi] 'Địa chỉ'
                                          ,[SDT] 'SĐT'
	                                      ,count(MaHoaDonBan) 'Số giao dịch'
	                                      ,case when sum(tb_HoaDonBan.TongThanhToan) is not null 
			                                    then sum(tb_HoaDonBan.TongThanhToan) 
			                                    else '0'
		                                    end 'Doanh thu mang lại'
                                      FROM [dbo].[tb_KhachHang]
                                      full outer join tb_HoaDonBan on tb_HoaDonBan.MaKhachHang = [tb_KhachHang].MaKhachHang
                                      WHERE
                                      NgayLap between '{0}' and '{1}'
                                      GROUP BY 
                                      [tb_KhachHang].[MaKhachHang]
                                          ,[TenKhachHang]
                                          ,[DiaChi]
                                          ,[SDT]",
                                        d1.ToString("yyyy/MM/dd"),
                                        d2.ToString("yyyy/MM/dd"));

            return Unility.GetDataTable(sql);
        }
    }
}
