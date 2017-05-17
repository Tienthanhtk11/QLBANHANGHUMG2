using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.FORM;
using QuanLyBanHang.USERCONTROLS;

namespace QuanLyBanHang
{
    static class Program
    {
        public static string tenCongTy = "XÍ NGHIỆP XĂNG DẦU TOÀN THIẾU";
        public static string slogan = "Bán 10 lít xăng thu về 1 lít!";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ThongKe.HoaDonNhap());
        }
    }
}
