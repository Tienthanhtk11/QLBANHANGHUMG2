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
    public partial class ucHoaDonNhap : UserControl
    {
    
        string mahoadonnhap, manhacungcap, manhanvien, ngaylap;
        private int rows = 0;
        public ucHoaDonNhap()
        {
            InitializeComponent();
        }

        private void ucNhapKho_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadDatagridview(dataHoaDonNhap, tb_HoaDonNhapBLL.layDuLieu());
            dataHoaDonNhap_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        } 

        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void Dongform(object sender, FormClosedEventArgs e)
        {
        }
        private void sửaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void xóaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dtNhapKho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void xuấtFileExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ucNhapKho_Resize(object sender, EventArgs e)
        {
        }

        private void cbNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbNhaCC_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblNCC_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap fm = new frmHoaDonNhap();
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void Fm_FormClosed(object sender, FormClosedEventArgs e)
        {
             dataHoaDonNhap.DataSource = tb_HoaDonNhapBLL.layDuLieu();
        }

        private void dataHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mahoadonnhap = dataHoaDonNhap.Rows[e.RowIndex].Cells[0].Value.ToString();
            manhacungcap = dataHoaDonNhap.Rows[e.RowIndex].Cells[1].Value.ToString();
            manhanvien = dataHoaDonNhap.Rows[e.RowIndex].Cells[2].Value.ToString();
            ngaylap = dataHoaDonNhap.Rows[e.RowIndex].Cells[3].Value.ToString();
         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           frmHoaDonNhap fm = new frmHoaDonNhap(mahoadonnhap, manhacungcap, manhanvien, ngaylap);
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", " Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tb_HoaDonNhapBLL.xoa(mahoadonnhap);
                dataHoaDonNhap.DataSource = tb_HoaDonNhapBLL.layDuLieu();
            }
        }

        private void dtNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
