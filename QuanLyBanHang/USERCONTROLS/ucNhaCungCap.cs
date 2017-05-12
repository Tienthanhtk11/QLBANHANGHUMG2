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
    public partial class ucNhaCungCap : UserControl
    {
        int rows = 0;
        string manhacungcap, tennhacungcap, diachi, sodienthoai;
        public ucNhaCungCap()
        {
            InitializeComponent();
        }

        private void ucNhaCungCap_Load(object sender, EventArgs e)
        {
            dataNhaCungCap.DataSource = tb_NhaCungCapBLL.layDuLieu();
            dataNhaCungCap_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
          
        }

        private void dtgNCC_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tảiLạiF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thêmNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void DongTab(object sender, FormClosedEventArgs e)
        {
        }

        private void sửaNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void xóaNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void xuấtRaFileExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dtgNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNCC_ADD fm = new frmNCC_ADD();
            fm.FormClosed += Fm_FormClosed; 
            fm.ShowDialog();
        }

        private void dataNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            manhacungcap = dataNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString();
            tennhacungcap = dataNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
            diachi = dataNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString();
            sodienthoai = dataNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString();
          
        }

        private void Fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataNhaCungCap.DataSource = tb_NhaCungCapBLL.layDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmNCC_ADD fm = new frmNCC_ADD(manhacungcap, tennhacungcap, diachi, sodienthoai);
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", " Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tb_NhaCungCapBLL.xoa(manhacungcap);
                dataNhaCungCap.DataSource = tb_NhaCungCapBLL.layDuLieu();
            }
        }
    }
}
