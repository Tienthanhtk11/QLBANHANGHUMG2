using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_NhanVienDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT MaNhanVien 'Mã nhân viên' , TenNhanVien 'Tên nhân viên' ,tb_PhongBan.TenPhongBan 'Phòng ban',NgaySinh 'Ngày sinh', GioiTinh 'Giới tính',SDT 'Số điện thoại', DiaChi 'Địa chỉ' FROM tb_NhanVien join tb_PhongBan on tb_NhanVien.MaPhongBan = tb_PhongBan.MaPhongBan");
        }
        public static DataTable layDuLieuSoDieuKien(string MaNV)
        {
            return Unility.GetDataTable(string.Format("SELECT MaNhanVien 'Mã nhân viên' , TenNhanVien 'Tên nhân viên' ,tb_PhongBan.TenPhongBan 'Phòng ban',CONVERT(nvarchar,NgaySinh,103) 'Ngày sinh', GioiTinh 'Giới tính',SDT 'Số điện thoại', DiaChi 'Địa chỉ' FROM tb_NhanVien join tb_PhongBan on tb_NhanVien.MaPhongBan = tb_PhongBan.MaPhongBan where MaNhanVien = '{0}'", MaNV));
        }
        public static void them(tb_NhanVienDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_NhanVien (MaNhanVien,TenNhanVien,NgaySinh,GioiTinh,DiaChi,SDT,MaPhongBan) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", obj.MaNhanVien,obj.TenNhanVien,obj.NgaySinh,obj.GioiTinh,obj.DiaChi,obj.SDT,obj.MaPhongBan));
        }
        public static void sua(tb_NhanVienDBO obj)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_NhanVien SET TenNhanVien=N'{1}',NgaySinh=N'{2}',GioiTinh=N'{3}',DiaChi=N'{4}',SDT=N'{5}',MaPhongBan=N'{6}' WHERE MaNhanVien = N'{0}'", obj.MaNhanVien, obj.TenNhanVien, obj.NgaySinh, obj.GioiTinh, obj.DiaChi, obj.SDT, obj.MaPhongBan));
        }
        public static void xoa(string MaNV)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_NhanVien WHERE MaNhanVien =N'{0}'", MaNV));
        }
        public static int kiemTraTonTai(string MaNV)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_NhanVien WHERE MaNhanVien =N'{0}'", MaNV));
        }

        public static DataTable timKiem(string MaNhanVien)
        {
            return Unility.GetDataTable("SELECT MaNhanVien 'Mã nhân viên' , TenNhanVien 'Tên nhân viên' ,tb_PhongBan.TenPhongBan 'Phòng ban',NgaySinh 'Ngày sinh', GioiTinh 'Giới tính',SDT 'Số điện thoại', DiaChi 'Địa chỉ' FROM tb_NhanVien join tb_PhongBan on tb_NhanVien.MaPhongBan = tb_PhongBan.MaPhongBan where MaNhanVien like '%"+ MaNhanVien + "%' or TenNhanVien like '%"+ MaNhanVien + "%'");
        }
    }
}
