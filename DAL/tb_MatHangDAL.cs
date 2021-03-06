﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
	public class tb_MatHangDAL
	{
		public static DataTable layDuLieu()
		{
			return Unility.GetDataTable("SELECT MaMatHang 'Mã mặt hàng',TenMatHang 'Tên mặt hàng',tb_NhaCungCap.TenNhaCungCap 'Nhà cung cấp',tb_NhomHang.TenNhomHang 'Nhóm hàng',DVT 'Đơn vị tính',GiaBan 'Giá bán',NgayCapNhat 'Ngày cập nhật' FROM tb_MatHang join tb_NhaCungCap on tb_MatHang.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap join tb_NhomHang on tb_MatHang.MaNhomHang = tb_NhomHang.MaNhomHang");
		}

        public static DataTable layDuLieuRutGon()
        {
            return Unility.GetDataTable(string.Format(@"SELECT MaMatHang 'Mã mặt hàng',
                                                        TenMatHang 'Tên mặt hàng',
                                                        DVT 'Đơn vị tính',
                                                        GiaBan 'Giá bán'
                                                        FROM tb_MatHang 
                                                        join tb_NhaCungCap on tb_MatHang.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap 
                                                        join tb_NhomHang on tb_MatHang.MaNhomHang = tb_NhomHang.MaNhomHang"));
        }

        public static DataTable layDuLieuTimkiem(string k)
        {
            return Unility.GetDataTable(string.Format(@"SELECT MaMatHang 'Mã mặt hàng',
                                                        TenMatHang 'Tên mặt hàng',
                                                        tb_NhaCungCap.TenNhaCungCap 'Nhà cung cấp',
                                                        tb_NhomHang.TenNhomHang 'Nhóm hàng',
                                                        DVT 'Đơn vị tính',
                                                        GiaBan 'Giá bán',
                                                        NgayCapNhat 'Ngày cập nhật' 
                                                        FROM tb_MatHang 
                                                        join tb_NhaCungCap on tb_MatHang.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap 
                                                        join tb_NhomHang on tb_MatHang.MaNhomHang = tb_NhomHang.MaNhomHang
                                                        WHERE 
                                                         MaMatHang like N'%{0}%' or
                                                        TenMatHang like N'%{0}%' or
                                                        tb_NhaCungCap.TenNhaCungCap like N'%{0}%' or
                                                        tb_NhomHang.TenNhomHang like N'%{0}%' or
                                                        DVT like N'%{0}%' or
                                                        GiaBan like N'%{0}%' or
                                                        NgayCapNhat like N'%{0}%'
                                                        ", k));
        }

        public static DataTable layDuLieuSoDieuKien(string MaMH)
		{
			return Unility.GetDataTable(string.Format("SELECT MaMatHang 'Mã mặt hàng',TenMatHang 'Tên mặt hàng',tb_NhaCungCap.TenNhaCungCap 'Nhà cung cấp',tb_NhomHang.TenNhomHang 'Nhóm hàng',DVT 'Đơn vị tính',GiaBan 'Giá bán',CONVERT(nvarchar,NgayCapNhat,103) 'Ngày cập nhật' FROM tb_MatHang join tb_NhaCungCap on tb_MatHang.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap join tb_NhomHang on tb_MatHang.MaNhomHang = tb_NhomHang.MaNhomHang where MaMatHang = '{0}'", MaMH));
		}
		public static void them(tb_MatHangDBO obj)
		{
			Unility.ExcuteSQL(string.Format("INSERT INTO tb_MatHang (MaMatHang ,TenMatHang ,MaNhaCungCap ,MaNhomHang ,DVT ,GiaBan ,NgayCapNhat) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')",obj.MaMatHang,obj.TenMatHang, obj.MaNhaCungCap, obj.MaNhomHang, obj.DVT, obj.GiaBan,obj.NgayCapNhat));
		}

		public static string layDonGia(string maMH)
		{
			string x = string.Format("SELECT GiaBan from tb_MatHang WHERE MaMatHang =N'{0}'", maMH);
			try { return Unility.GetDataTable(x).Rows[0][0].ToString(); } catch { return ""; };
		}

		public static void sua(tb_MatHangDBO obj)
		{
			Unility.ExcuteSQL(string.Format("UPDATE tb_MatHang SET TenMatHang = N'{1}' ,MaNhaCungCap = N'{2}',MaNhomHang = N'{3}',DVT = N'{4}',GiaBan = N'{5}',NgayCapNhat = N'{6}' WHERE  MaMatHang = N'{0}'", obj.MaMatHang, obj.TenMatHang, obj.MaNhaCungCap, obj.MaNhomHang, obj.DVT, obj.GiaBan, obj.NgayCapNhat));
		}
		public static void xoa(string MaMH)
		{
			Unility.ExcuteSQL(string.Format("DELETE FROM tb_MatHang WHERE MaMatHang =N'{0}'", MaMH));
		}
		public static int kiemTraTonTai(string MaMH)
		{
			return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_MatHang WHERE MaMatHang =N'{0}'", MaMH));
		}

		public static DataTable thongKe(DateTime d1, DateTime d2)
		{
			string sql = string.Format(@"SELECT 
										MaMatHang 'Mã mặt hàng',
										TenMatHang 'Tên mặt hàng',
										tb_NhaCungCap.TenNhaCungCap 'Nhà cung cấp',
										tb_NhomHang.TenNhomHang 'Nhóm hàng',
										tb_MatHang.DVT 'Đơn vị tính',
										NgayCapNhat 'Ngày cập nhật',
										GiaBan 'Giá bán',
										tb_MatHang.SoLuong 'Số lượng',
										GiaBan * SoLuong 'Giá trị'
									FROM 
										tb_MatHang 
										join tb_NhaCungCap on tb_MatHang.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap 
										join tb_NhomHang on tb_MatHang.MaNhomHang = tb_NhomHang.MaNhomHang
									WHERE
										NgayCapNhat between '{0}' and '{1}'",
										d1.ToString("yyyy/MM/dd"),
										d2.ToString("yyyy/MM/dd"));

			return Unility.GetDataTable(sql);
		}

        public static DataTable timKiem(string MaMatHang)
        {
            return Unility.GetDataTable("SELECT MaMatHang 'Mã mặt hàng',TenMatHang 'Tên mặt hàng',tb_NhaCungCap.TenNhaCungCap 'Nhà cung cấp',tb_NhomHang.TenNhomHang 'Nhóm hàng',DVT 'Đơn vị tính',GiaBan 'Giá bán',NgayCapNhat 'Ngày cập nhật' FROM tb_MatHang join tb_NhaCungCap on tb_MatHang.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap join tb_NhomHang on tb_MatHang.MaNhomHang = tb_NhomHang.MaNhomHang where MaMatHang like '%"+MaMatHang+ "%' or TenMatHang like '%"+ MaMatHang + "%'");
        }
    }
}
