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
    public partial class ucBCMatHangBanDuocNhieu : UserControl
    {
        public ucBCMatHangBanDuocNhieu()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string Sql = "select top(" + cbSMH.Text.Trim() + ") hh.MaHang 'Mã hàng',hh.TenHang 'Tên hàng', sum(hd.SoLuongMua) 'Số lượng bán' from HOADON hd join HANGHOA hh on hd.MaHang = hh.MaHang where hd.NgayLapHD between '" + dt1.Value.ToShortDateString() + "' and '" + dt1.Value.ToShortDateString() + "' group by hh.MaHang,hh.TenHang";
            MethodLoad.LoadDatagridview(dtBC, Sql);
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodLoad.InDt(dtBC);
        }

        private void xuấtFileExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] temp ={ dt1.Value.ToShortDateString(), dt2.Value.ToShortDateString() };
            MethodLoad.Excell(dtBC, (int)MethodLoad.form.SoHangbanDuoc,temp);
        }

        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucBCMatHangBanDuocNhieu_Load(sender, e);
        }

        private void ucBCMatHangBanDuocNhieu_Load(object sender, EventArgs e)
        {
            Default.SetDefaultDataGridView(dtBC);
            DataTable temp = Unility.getDataTable("Select * from HANGHOA");
            for(int i = 0; i <= temp.Rows.Count; i++)
            {
                cbSMH.Items.Add(i);
            }
            cbSMH.SelectedIndex = 0;
            cbSMH.Text = "";
            label4.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            cbSMH.Focus();
        }

        private void cbSMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = cbSMH.Text.Length == 0;
        }

        private void cbSMH_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = cbSMH.Text.Length == 0;
        }
    }
}
