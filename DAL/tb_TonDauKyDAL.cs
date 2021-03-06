﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;
namespace DAL
{
    public class tb_TonDauKyDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT tb_TonDauKy.MaMatHang 'Mã mặt hàng',tb_MatHang.TenMatHang 'Tên mặt hàng',tb_TonDauKy.NgayCapNhat 'Ngày cập nhật',tb_TonDauKy.SoLuong 'Số lượng',GiaTriTon 'Giá trị tồn'  FROM tb_TonDauKy join tb_MatHang on tb_TonDauKy.MaMatHang = tb_MatHang.MaMatHang");
        }
        public static DataTable layDuLieuSoDieuKien(string maMatHang)
        {
            return Unility.GetDataTable(string.Format("SELECT tb_TonDauKy.MaMatHang 'Mã mặt hàng',tb_MatHang.TenMatHang 'Tên mặt hàng',CONVERT(nvarchar,tb_TonDauKy.NgayCapNhat,103) 'Ngày cập nhật',SoLuong 'Số lượng',GiaTriTon 'Giá trị tồn'  FROM tb_TonDauKy join tb_MatHang on tb_TonDauKy.MaMatHang = tb_MatHang.MaMatHang where tb_TonDauKy.MaMatHang = '{0}'", maMatHang));
        }
        public static void them(tb_TonDauKyDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_TonDauKy (MaMatHang,NgayCapNhat,SoLuong,GiaTriTon)VALUES(N'{0}',N'{1}',N'{2}',N'{3}')", obj.MaMatHang, obj.NgayCapNhat.ToString("yyyy-MM-dd"), obj.SoLuong.ToString(), obj.GiaTriTon.ToString()));
        }
        public static void sua(tb_TonDauKyDBO obj)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_TonDauKy SET NgayCapNhat =N'{1}' ,SoLuong = N'{2}' ,GiaTriTon = N'{3}' WHERE MaMatHang =N'{0}'", obj.MaMatHang, obj.NgayCapNhat.ToString("yyyy-MM-dd"), obj.SoLuong.ToString(), obj.GiaTriTon.ToString()));
        }
        public static void xoa(string MaMatHang)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_TonDauKy WHERE MaMatHang =N'{0}'", MaMatHang));
        }
        public static int kiemTraTonTai(string MaMatHang)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_TonDauKy WHERE MaMatHang =N'{0}'", MaMatHang));
        }
        public static DataTable layDuLieuBCTonDauKy(DateTime tuNgay, DateTime denNgay)
        {
            return Unility.GetDataTable(string.Format("select tb_MatHang.TenMatHang 'Mặt hàng', tb_TonDauKy.NgayCapNhat 'Ngày báo cáo', tb_TonDauKy.SoLuong 'Số lượng',tb_MatHang.DVT 'Đơn vị', tb_TonDauKy.GiaTriTon 'Tổng giá trị' from tb_TonDauKy join tb_MatHang on tb_TonDauKy.MaMatHang = tb_MatHang.MaMatHang where tb_TonDauKy.NgayCapNhat BETWEEN '{0}' AND '{1}'", tuNgay, denNgay));
        }
        public static DataTable layDuLieuBCHienTai()
        {
            return Unility.GetDataTable("select TenMatHang 'Mặt hàng', GETDATE() 'Ngày báo cáo', SoLuong 'Số lượng',DVT 'Đơn vị', (GiaBan * SoLUONG) 'Tổng giá trị' from tb_MatHang where tb_MatHang.SoLuong > 0");
        }
        public static DataTable timKiem(string MaMatHang)
        {
            return Unility.GetDataTable("SELECT tb_TonDauKy.MaMatHang 'Mã mặt hàng',tb_MatHang.TenMatHang 'Tên mặt hàng',tb_TonDauKy.NgayCapNhat 'Ngày cập nhật',tb_TonDauKy.SoLuong 'Số lượng',GiaTriTon 'Giá trị tồn'  FROM tb_TonDauKy join tb_MatHang on tb_TonDauKy.MaMatHang = tb_MatHang.MaMatHang where tb_TonDauKy.MaMatHang like '%" + MaMatHang+ "%' or tb_MatHang.TenMatHang like '%" + MaMatHang + "%'");
        }
        public static DataTable tdk(DateTime d1, DateTime d2)
        {
            string sql = string.Format(@"SELECT	  tb_MatHang.MaMatHang 'MÃ HÀNG'
		                    , tb_MatHang.TenMatHang 'TÊN HÀNG'
		                    , CASE
			                    WHEN SUM(tb_ChiTietHoaDonNhap.SOLUONG) IS NULL
			                    THEN 0
			                    ELSE SUM(tb_ChiTietHoaDonNhap.SOLUONG)
		                        END 'SỐ LƯỢNG NHẬP'
		                    , CASE
			                    WHEN SUM(tb_ChiTietHoaDonBan.SOLUONG) IS NULL
			                    THEN 0
			                    ELSE SUM(tb_ChiTietHoaDonBan.SOLUONG)
		                        END 'SỐ LƯỢNG BÁN'
		                    , CASE
			                    WHEN SUM(tb_ChiTietHoaDonNhap.SOLUONG) IS NULL
			                    THEN 0
			                    ELSE SUM(tb_ChiTietHoaDonNhap.SOLUONG)
		                        END
		                        -
		                        CASE
			                    WHEN SUM(tb_ChiTietHoaDonBan.SOLUONG) IS NULL
			                    THEN 0
			                    ELSE SUM(tb_ChiTietHoaDonBan.SOLUONG)
		                        END 'HÀNG TỒN TRONG THÁNG'
                            , 
		                        case when (CASE
			                    WHEN SUM(tb_ChiTietHoaDonBan.SOLUONG) IS NULL
			                    THEN 0
			                    ELSE SUM(tb_ChiTietHoaDonBan.SOLUONG)
		                        END != 0)
		                        then
		                        (sum(tb_ChiTietHoaDonNhap.DONGIA * tb_ChiTietHoaDonNhap.SOLUONG)
		                        - sum(tb_ChiTietHoaDonBan.DONGIA * tb_ChiTietHoaDonBan.SOLUONG)) 
		                        else sum(tb_ChiTietHoaDonNhap.DONGIA * tb_ChiTietHoaDonNhap.SOLUONG)
		                        end 'GÍA TRỊ TỒN'
                    FROM tb_MatHang
                    FULL OUTER JOIN tb_ChiTietHoaDonBan ON tb_ChiTietHoaDonBan.MaMatHang = tb_MatHang.MaMatHang
                    FULL OUTER JOIN tb_ChiTietHoaDonNhap ON tb_ChiTietHoaDonNhap.MaMatHang = tb_MatHang.MaMatHang
                    FULL OUTER JOIN tb_HoaDonBan ON tb_HoaDonBan.MaHoaDonBan = tb_ChiTietHoaDonBan.MaHoaDonBan
                    FULL OUTER JOIN tb_HoaDonNhap ON tb_HoaDonNhap.MaHoaDonNhap = tb_ChiTietHoaDonNhap.MaHoaDonNhap
                    WHERE (
		                    tb_HoaDonBan.NgayLap BETWEEN '{0}' AND '{1}' AND
		                    tb_HoaDonNhap.NgayLap BETWEEN '{0}' AND '{1}'
	                        ) OR 
	                        (
	                        tb_HoaDonBan.NgayLap IS NULL AND
		                    tb_HoaDonNhap.NgayLap BETWEEN '{0}' AND '{1}'
	                        )

                    GROUP BY tb_MatHang.MaMatHang,
                    tb_MatHang.TenMatHang", d1, d2);
            return Unility.GetDataTable(sql);
        }
    }
}
