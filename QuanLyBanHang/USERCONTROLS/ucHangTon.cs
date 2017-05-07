using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.USERCONTROLS
{
    public partial class ucHangTon : UserControl
    {
        public ucHangTon()
        {
            InitializeComponent();
        }

        private void ucHangTon_Load(object sender, EventArgs e)
        {
            Default.SetDefaultDataGridView(dtgTonDu);
            MethodLoad.LoadDatagridview(dtgTonDu, "select hh.MaHang,hh.TenHang,nc.TenNCC,nh.TenNhom,hh.DVT,hh.SoLuongCon from HANGHOA hh join NHACC nc on hh.MaNCC = nc.MaNCC join NHOMHANG nh on hh.MaNhom = nh.MaNhom  where SoLuongCon > 0");
        }
        

        private void xuâtFileExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodLoad.Excell(dtgTonDu,(int)MethodLoad.form.SoHangTonKho,null);
        }

        private void TaiLaiok_Click(object sender, EventArgs e)
        {
            ucHangTon_Load(sender, e);
        }

        private void Inok_Click(object sender, EventArgs e)
        {
            MethodLoad.InDt(dtgTonDu);
        }
    }
}
