﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DBO;
using System.Data;

namespace BLL
{
    public class tb_TonDauKyBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_TonDauKyDAL.layDuLieu();
        }
        public static DataTable layDuLieuSoHD(string maMatHang)
        {
            return tb_TonDauKyDAL.layDuLieuSoDieuKien(maMatHang);
        }
        public static void them(tb_TonDauKyDBO obj)
        {
            tb_TonDauKyDAL.them(obj);
        }
        public static void sua(tb_TonDauKyDBO obj)
        {
            tb_TonDauKyDAL.sua(obj);
        }
        public static void xoa(string maMatHang)
        {
            tb_TonDauKyDAL.xoa(maMatHang);
        }
        public static int kiemTraTonTai(string maMatHang)
        {
            return tb_TonDauKyDAL.kiemTraTonTai(maMatHang);
        }
    }
}