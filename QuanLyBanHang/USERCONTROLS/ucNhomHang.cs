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
    public partial class ucNhomHang : UserControl
    {
        string manhomhang, tennhomhang;
        public ucNhomHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            frmNhomHang fm = new frmNhomHang();
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void Fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataNhomHang.DataSource = tb_NhomHangBLL.layDuLieu();
        }

        private void ucNhomHang_Load(object sender, EventArgs e)
        {
            dataNhomHang.DataSource = tb_NhomHangBLL.layDuLieu();
            dataNhomHang_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmNhomHang fm = new frmNhomHang(manhomhang, tennhomhang);
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không?", " Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tb_NhomHangBLL.xoa(manhomhang);
                dataNhomHang.DataSource = tb_NhomHangBLL.layDuLieu();
            }
        }

        private void dataNhomHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           manhomhang  = dataNhomHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tennhomhang = dataNhomHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }
    }
}
