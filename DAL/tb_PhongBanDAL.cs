using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBO;
using System.Data;

namespace DAL
{
    public class tb_PhongBanDAL
    {
        public static DataTable layDuLieu()
        {
            return Unility.GetDataTable("SELECT MaPhongBan 'Mã phòng ban',TenPhongBan 'Tên phòng ban' FROM tb_PhongBan");
        }
        public static DataTable layDuLieuSoDieuKien(string MaPhongBan)
        {
            return Unility.GetDataTable(string.Format("SELECT MaPhongBan 'Mã phòng ban',TenPhongBan 'Tên phòng ban' FROM tb_PhongBan where MaPhongBan = '{0}'", MaPhongBan));
        }
        public static void them(tb_PhongBanDBO obj)
        {
            Unility.ExcuteSQL(string.Format("INSERT INTO tb_PhongBan (MaPhongBan,TenPhongBan) VALUES(N'{0}',N'{1}')", obj.MaPhongBan,obj.TenPhongBan));
        }
        public static void sua(tb_PhongBanDBO obj)
        {
            Unility.ExcuteSQL(string.Format("UPDATE tb_PhongBan SET TenPhongBan = N'{1}' WHERE MaPhongBan = N'{0}'", obj.MaPhongBan, obj.TenPhongBan));
        }
        public static void xoa(string MaPhongBan)
        {
            Unility.ExcuteSQL(string.Format("DELETE FROM tb_PhongBan WHERE MaPhongBan =N'{0}'", MaPhongBan));
        }
        public static int kiemTraTonTai(string MaPhongBan)
        {
            return Unility.AExcuteSQL(string.Format("SELECT count(*) FROM tb_PhongBan WHERE MaPhongBan =N'{0}'", MaPhongBan));
        }
    }
}
