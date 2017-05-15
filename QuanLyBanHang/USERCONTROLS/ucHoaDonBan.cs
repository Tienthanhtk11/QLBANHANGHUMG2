using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using QuanLyBanHang.FORM;
namespace QuanLyBanHang.USERCONTROLS
{
    public partial class ucHoaDonBan : UserControl
    {
     
        string mahoadonban, makhachhang, manhanvien, tongthanhtoan, dathanhtoan, ngaylap;

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan fm = new frmHoaDonBan();
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmHoaDonBan fm = new frmHoaDonBan(mahoadonban, makhachhang, manhanvien, tongthanhtoan, dathanhtoan, ngaylap);
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", " Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tb_HoaDonBanBLL.xoa(mahoadonban);
                dataHoaDonBan.DataSource = tb_HoaDonBanBLL.layDuLieu();
            }
        }

        private void Fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataHoaDonBan.DataSource = tb_HoaDonBanBLL.layDuLieu();
        }

        private void dataHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mahoadonban = dataHoaDonBan.Rows[e.RowIndex].Cells[0].Value.ToString();
            makhachhang = dataHoaDonBan.Rows[e.RowIndex].Cells[1].Value.ToString();
            manhanvien = dataHoaDonBan.Rows[e.RowIndex].Cells[2].Value.ToString();
            tongthanhtoan = dataHoaDonBan.Rows[e.RowIndex].Cells[4].Value.ToString();
            dathanhtoan = dataHoaDonBan.Rows[e.RowIndex].Cells[5].Value.ToString();
            ngaylap = dataHoaDonBan.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void ucHoaDonBan_Load(object sender, EventArgs e)
        {
           MethodLoad.LoadDatagridview(dataHoaDonBan,  tb_HoaDonBanBLL.layDuLieu());
           dataHoaDonBan_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        public ucHoaDonBan()
        {
            InitializeComponent();

        }
    }
}
