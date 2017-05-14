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
    public partial class ucPhongBan : UserControl
    {
        string maphongban, tenphongban;
        public ucPhongBan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            frmPhongBan fm = new frmPhongBan();
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void Fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataPhongBan.DataSource = tb_PhongBanBLL.layDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmPhongBan fm = new frmPhongBan(maphongban, tenphongban);
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", " Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tb_PhongBanBLL.xoa(maphongban);
                dataPhongBan.DataSource = tb_PhongBanBLL.layDuLieu();
            }
        }

        private void dataPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maphongban = dataPhongBan.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenphongban = dataPhongBan.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void ucPhongBan_Load(object sender, EventArgs e)
        {
            dataPhongBan.DataSource = tb_PhongBanBLL.layDuLieu();
            dataPhongBan_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        }
    }
}
