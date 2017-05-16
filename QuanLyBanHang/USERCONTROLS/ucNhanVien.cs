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
using DBO;
namespace QuanLyBanHang.USERCONTROLS
{
    public partial class ucNhanVien : UserControl
    {
        int rows = 0;
        string manhanvien, tennhanvien, ngaysinh, gioitinh, diachi, sodienthoai, maphongban;
        public ucNhanVien()
        {
            InitializeComponent();
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

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void DongTab(object sender, FormClosedEventArgs e)
        {
        }
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadDatagridview(dataNhanVien, tb_NhanVienBLL.layDuLieu());
            dataNhanVien_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gioitinh = dataNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            sodienthoai = dataNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            manhanvien = dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            tennhanvien = dataNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            ngaysinh = dataNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            diachi = dataNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            maphongban = dataNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataNhanVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVien_ADD fm = new frmNhanVien_ADD();
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void Fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataNhanVien.DataSource = tb_NhanVienBLL.layDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmNhanVien_ADD fm = new frmNhanVien_ADD(manhanvien, tennhanvien, ngaysinh,gioitinh, diachi, sodienthoai, maphongban);
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không?", " Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tb_NhanVienBLL.xoa(manhanvien);
                dataNhanVien.DataSource = tb_NhanVienBLL.layDuLieu();
            }
        }
    }
}
