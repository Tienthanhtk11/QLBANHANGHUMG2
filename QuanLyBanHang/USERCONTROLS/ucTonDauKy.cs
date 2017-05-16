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
    public partial class ucTonDauKy : UserControl
    {
        string mamathang, soluong, giatriton;
        string ngaycapnhat;
        public ucTonDauKy()
        {
            InitializeComponent();
        }

        private void ucHangTon_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadDatagridview(dataTonDauKy, tb_TonDauKyBLL.layDuLieu());
            try { dataTonDauKy_CellClick(sender, new DataGridViewCellEventArgs(0, 0)); } catch { };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmTonDauKy fm = new frmTonDauKy();
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void Fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataTonDauKy.DataSource = tb_TonDauKyBLL.layDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmTonDauKy fm = new frmTonDauKy(mamathang, ngaycapnhat,soluong,giatriton);
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không?", " Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tb_TonDauKyBLL.xoa(mamathang);
                dataTonDauKy.DataSource = tb_TonDauKyBLL.layDuLieu();
            }
        }

        private void dataTonDauKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           mamathang = dataTonDauKy.Rows[e.RowIndex].Cells[0].Value.ToString();
            ngaycapnhat =dataTonDauKy.Rows[e.RowIndex].Cells[2].Value.ToString();
            soluong = dataTonDauKy.Rows[e.RowIndex].Cells[3].Value.ToString();
            giatriton = dataTonDauKy.Rows[e.RowIndex].Cells[4].Value.ToString();
            //MessageBox.Show(ngaycapnhat);
        }

        private void xuâtFileExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void TaiLaiok_Click(object sender, EventArgs e)
        {
        }

        private void Inok_Click(object sender, EventArgs e)
        {
        }
    }
}
