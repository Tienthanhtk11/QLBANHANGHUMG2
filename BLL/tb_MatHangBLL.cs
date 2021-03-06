﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DBO;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class tb_MatHangBLL
    {
        public static DataTable layDuLieu()
        {
            return tb_MatHangDAL.layDuLieu();
        }
        public static DataTable layDuLieuRutGon()
        {
            return tb_MatHangDAL.layDuLieuRutGon();
        }
        public static DataTable layDuLieuTimkiem(string k)
        {
            return tb_MatHangDAL.layDuLieuTimkiem(k);
        }
        public static DataTable layDuLieuSoHD(string MaMH)
        {
            return tb_MatHangDAL.layDuLieuSoDieuKien(MaMH);
        }
        public static void them(tb_MatHangDBO obj)
        {
            tb_MatHangDAL.them(obj);
        }

        public static DataTable thongke(DateTimePicker d1, DateTimePicker d2)
        {
            return tb_MatHangDAL.thongKe(d1.Value, d2.Value);
        }

        public static void sua(tb_MatHangDBO obj)
        {
            tb_MatHangDAL.sua(obj);
        }
        public static void xoa(string MaMH)
        {
            tb_MatHangDAL.xoa(MaMH);
        }
        public static int kiemTraTonTai(string MaMH)
        {
            return tb_MatHangDAL.kiemTraTonTai(MaMH);
        }
        public static void loadCb(ComboBox x)
        {
            x.DataSource = layDuLieu();
            x.DisplayMember = "Tên mặt hàng";
            x.ValueMember = "Mã mặt hàng";
            try { x.SelectedIndex = 1; x.SelectedIndex = 0; } catch { };
        }

        public static string layDonGia(string MaMH)
        {
            return tb_MatHangDAL.layDonGia(MaMH);
        }
        public static DataTable timKiem(string MaMatHang)
        {
            return tb_MatHangDAL.timKiem(MaMatHang);
        }

    }
    
}
