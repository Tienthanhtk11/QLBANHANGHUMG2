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
            return Unility.GetDataTable("SELECT tb_TonDauKy.MaMatHang 'Mã mặt hàng',tb_MatHang.TenMatHang 'Tên mặt hàng',CONVERT(nvarchar,tb_TonDauKy.NgayCapNhat,103) 'Ngày cập nhật',SoLuong 'Số lượng',GiaTriTon 'Giá trị tồn'  FROM tb_TonDauKy join tb_MatHang on tb_TonDauKy.MaMatHang = tb_MatHang.MaMatHang");
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
    }
}