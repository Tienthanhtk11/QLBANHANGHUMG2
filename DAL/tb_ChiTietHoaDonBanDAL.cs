using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_ChiTietHoaDonBanDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT MaCTHDB 'Mã chi tiết hóa đơn bán',MaHoaDonBan 'Mã hóa đơn',tb_MatHang.TenMatHang 'Mặt hàng',DonGia 'Đơn giá',SoLuong 'Số lượng'  FROM tb_ChiTietHoaDonBan join tb_MatHang on tb_ChiTietHoaDonBan.MaMatHang = tb_MatHang.MaMatHang");
        }
        public static DataTable layDuLieuSoDieuKien(string TenChiTietHoaDonBan)
        {
            return Unility.GetDataTable(string.Format("SELECT MaCTHDB 'Mã chi tiết hóa đơn bán',MaHoaDonBan 'Mã hóa đơn',tb_MatHang.TenMatHang 'Mặt hàng',SoLuong 'Số lượng',DonGia 'Đơn giá'  FROM tb_ChiTietHoaDonBan join tb_MatHang on tb_ChiTietHoaDonBan.MaMatHang = tb_MatHang.MaMatHang where MaHoaDonBan = '{0}'", TenChiTietHoaDonBan));
        }
        public static void them(tb_ChiTietHoaDonBanDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_ChiTietHoaDonBan (MaCTHDB,MaHoaDonBan,MaMatHang,DonGia,SoLuong) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", obj.MaCTHDB, obj.MaHoaDonBan, obj.MaMatHang, obj.DonGia, obj.SoLuong));
        }
        public static void sua(tb_ChiTietHoaDonBanDBO obj, string MaMatHang)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_ChiTietHoaDonBan SET MaMatHang = N'{5}' ,DonGia = N'{3}',SoLuong = N'{4}' WHERE MaCTHDB=N'{0}' and MaHoaDonBan = N'{1}' and MaMatHang = N'{2}'", obj.MaCTHDB, obj.MaHoaDonBan, obj.MaMatHang, obj.DonGia, obj.SoLuong, MaMatHang));
        }
        public static void xoa(tb_ChiTietHoaDonBanDBO obj)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_ChiTietHoaDonBan WHERE MaCTHDB=N'{0}' and MaHoaDonBan = N'{1}' and MaMatHang = N'{2}'", obj.MaCTHDB, obj.MaHoaDonBan, obj.MaMatHang));
        }
        public static int kiemTraTonTai(tb_ChiTietHoaDonBanDBO obj)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_ChiTietHoaDonBan WHERE MaCTHDB=N'{0}' and MaHoaDonBan = N'{1}' and MaMatHang = N'{2}'", obj.MaCTHDB, obj.MaHoaDonBan, obj.MaMatHang));
        }
    }
}
