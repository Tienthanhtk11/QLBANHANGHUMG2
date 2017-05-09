﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_ChiTietHoaDonNhapDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT MaCTHDN 'Mã chi tiết hóa đơn',MaHoaDonNhap 'Mã hóa đơn',tb_MatHang.TenMatHang 'Mặt hàng',DonGia 'Đơn giá',SoLuong 'Số lượng'  FROM tb_ChiTietHoaDonNhap join tb_MatHang on tb_ChiTietHoaDonNhap.MaMatHang = tb_MatHang.MaMatHang");
        }
        public static DataTable layDuLieuSoDieuKien(string TenChiTietHoaDonNhap)
        {
            return Unility.GetDataTable(string.Format("SELECT MaCTHDN 'Mã chi tiết hóa đơn',MaHoaDonNhap 'Mã hóa đơn',tb_MatHang.TenMatHang 'Mặt hàng',DonGia 'Đơn giá',SoLuong 'Số lượng'  FROM tb_ChiTietHoaDonNhap join tb_MatHang on tb_ChiTietHoaDonNhap.MaMatHang = tb_MatHang.MaMatHang where MaHoaDonNhap = '{0}'", TenChiTietHoaDonNhap));
        }
        public static void them(tb_ChiTietHoaDonNhapDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_ChiTietHoaDonNhap (MaCTHDN,MaHoaDonNhap,MaMatHang,DonGia,SoLuong) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", obj.MaCTHDN, obj.MaHoaDonNhap, obj.MaMatHang, obj.DonGia,obj.SoLuong));
        }
        public static void sua(tb_ChiTietHoaDonNhapDBO obj, string MaMatHang)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_ChiTietHoaDonNhap SET MaMatHang = N'{5}' ,DonGia = N'{3}',SoLuong = N'{4}' WHERE MaCTHDN=N'{0}' and MaHoaDonNhap = N'{1}' and MaMatHang = N'{2}'", obj.MaCTHDN, obj.MaHoaDonNhap, obj.MaMatHang, obj.DonGia, obj.SoLuong, MaMatHang));
        }
        public static void xoa(tb_ChiTietHoaDonNhapDBO obj)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_ChiTietHoaDonNhap WHERE MaCTHDN=N'{0}' and MaHoaDonNhap = N'{1}' and MaMatHang = N'{2}'", obj.MaCTHDN, obj.MaHoaDonNhap, obj.MaMatHang));
        }
        public static int kiemTraTonTai(tb_ChiTietHoaDonNhapDBO obj)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_ChiTietHoaDonNhap WHERE MaCTHDN=N'{0}' and MaHoaDonNhap = N'{1}' and MaMatHang = N'{2}'", obj.MaCTHDN, obj.MaHoaDonNhap, obj.MaMatHang));
        }
    }
}
