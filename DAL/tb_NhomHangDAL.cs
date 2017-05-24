using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_NhomHangDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT MaNhomHang 'Mã nhóm hàng',TenNhomHang 'Tên nhóm hàng' FROM tb_NhomHang");
        }
        public static DataTable layDuLieuSoDieuKien(string MaNhomHang)
        {
            return Unility.GetDataTable(string.Format("SELECT MaNhomHang 'Mã nhóm hàng',TenNhomHang 'Tên nhóm hàng' FROM tb_NhomHang where MaNhomHang = '{0}'", MaNhomHang));
        }
        public static void them(tb_NhomHangDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_NhomHang (MaNhomHang,TenNhomHang) VALUES(N'{0}',N'{1}')", obj.MaNhomHang, obj.TenNhomHang));
        }
        public static void sua(tb_NhomHangDBO obj)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_NhomHang SET TenNhomHang = N'{1}' WHERE MaNhomHang = N'{0}'", obj.MaNhomHang, obj.TenNhomHang));
        }
        public static void xoa(string MaNhomHang)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_NhomHang WHERE MaNhomHang =N'{0}'", MaNhomHang));
        }
        public static int kiemTraTonTai(string MaNhomHang)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_NhomHang WHERE MaNhomHang =N'{0}'", MaNhomHang));
        }

        public static DataTable timKiem(string MaNhomHang)
        {

            return Unility.GetDataTable("SELECT MaNhomHang 'Mã nhóm hàng',TenNhomHang 'Tên nhóm hàng' FROM tb_NhomHang where MaNhomHang like '%"+MaNhomHang+ "%' or TenNhomHang like '%"+ MaNhomHang + "%'");
        }
    }
}
