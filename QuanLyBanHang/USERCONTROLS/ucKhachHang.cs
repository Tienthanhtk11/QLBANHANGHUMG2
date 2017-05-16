using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.FORM;
using BLL;
namespace QuanLyBanHang.USERCONTROLS
{
    public partial class ucKhachHang : UserControl
    {
        int rows = 0;
        string makhachhang, tenkhachhang, diachi, sodienthoai;
        public ucKhachHang()
        {
            InitializeComponent();
        }
        private void DongTab(object sender, FormClosedEventArgs e)
        {
        }
        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataKhachHang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadDatagridview(dataKhachHang, tb_KhachHangBLL.layDuLieu());
            dataKhachHang_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void thêmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sửaHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void xóaHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmKhachHang_ADD fm = new frmKhachHang_ADD();
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void dataKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            makhachhang = dataKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenkhachhang = dataKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            diachi = dataKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            sodienthoai = dataKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataKhachHang.DataSource = tb_KhachHangBLL.layDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmKhachHang_ADD fm = new frmKhachHang_ADD(makhachhang, tenkhachhang, diachi, sodienthoai);
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không?", " Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tb_KhachHangBLL.xoa(makhachhang);
                dataKhachHang.DataSource = tb_KhachHangBLL.layDuLieu();
            }
        }
    }
}
