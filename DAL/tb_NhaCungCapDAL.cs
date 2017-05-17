using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_NhaCungCapDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT MaNhaCungCap 'Mã nhà cung cấp' ,TenNhaCungCap 'Tên nhà cung cấp' ,DiaChi 'Địa chỉ' ,SDT 'Số điện thoại' FROM tb_NhaCungCap");
        }
        public static DataTable layDuLieuSoDieuKien(string MaNCC)
        {
            return Unility.GetDataTable(string.Format("SELECT MaNhaCungCap 'Mã nhà cung cấp' ,TenNhaCungCap 'Tên nhà cung cấp' ,DiaChi 'Địa chỉ' ,SDT 'Số điện thoại' FROM tb_NhaCungCap where MaNhaCungCap = '{0}'", MaNCC));
        }
        public static void them(tb_NhaCungCapDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_NhaCungCap (MaNhaCungCap ,TenNhaCungCap ,DiaChi ,SDT) VALUES(N'{0}',N'{1}',N'{2}',N'{3}')", obj.MaNhaCungCap, obj.TenNhaCungCap, obj.DiaChi, obj.SDT));
        }
        public static void sua(tb_NhaCungCapDBO obj)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_NhaCungCap SET TenNhaCungCap = N'{1}' ,DiaChi = N'{2}',SDT = N'{3}' WHERE  MaNhaCungCap = N'{0}'", obj.MaNhaCungCap, obj.TenNhaCungCap, obj.DiaChi, obj.SDT));
        }
        public static void xoa(string MaNCC)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_NhaCungCap WHERE MaNhaCungCap =N'{0}'", MaNCC));
        }
        public static int kiemTraTonTai(string MaNCC)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_NhaCungCap WHERE MaNhaCungCap =N'{0}'", MaNCC));
        }

        public static DataTable thongKe()
        {
            string sql = string.Format(@"SELECT [tb_NhaCungCap].[MaNhaCungCap] 'MÃ NCC'
                                                ,[TenNhaCungCap] 'TÊN NCC'
                                                ,[DiaChi] 'ĐỊA CHỈ'
                                                ,[SDT] 'SỐ ĐIỆN THOẠI'
	                                            ,COUNT(tb_MatHang.MaMatHang ) 'SỐ MẶT HÀNG CUNG CẤP'
	                                            ,COUNT(tb_HoaDonNhap.MaNhaCungCap ) 'SỐ GIAO DỊCH'
                                            FROM [dbo].[tb_NhaCungCap]
                                            join tb_MatHang on tb_MatHang.MaMatHang = [tb_NhaCungCap].MaNhaCungCap
                                            join tb_HoaDonNhap on tb_HoaDonNhap.MaNhaCungCap =  [tb_NhaCungCap].MaNhaCungCap
                                            Group by  [tb_NhaCungCap].[MaNhaCungCap]
                                                ,[TenNhaCungCap]
                                                ,[DiaChi]
                                                ,[SDT]");

            return Unility.GetDataTable(sql);
        }
    }
}
