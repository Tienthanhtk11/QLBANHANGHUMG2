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
    public partial class ucQuanLyHangHoa : UserControl
    {
        int rows = 0;
        string mahang,tenhang,tennhacungcap,tennhomhang,donvitinh,giaban,ngaycapnhat;
        public ucQuanLyHangHoa()
        {
            InitializeComponent();
        }

        private void thêmĐơnLẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void DongTab(object sender, FormClosedEventArgs e)
        {
        }
        private void ucQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadDatagridview(dataHangHoa, tb_MatHangBLL.layDuLieu());
            dataHangHoa_CellEnter(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nhậpTừExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemTrướcBảnInToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void dataHangHoa_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            mahang = dataHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenhang = dataHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            tennhacungcap = dataHangHoa.Rows[e.RowIndex].Cells[2].Value.ToString();
            tennhomhang = dataHangHoa.Rows[e.RowIndex].Cells[3].Value.ToString();
            donvitinh = dataHangHoa.Rows[e.RowIndex].Cells[4].Value.ToString();
            giaban = dataHangHoa.Rows[e.RowIndex].Cells[5].Value.ToString();
            ngaycapnhat = dataHangHoa.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void lblNhomH_Click(object sender, EventArgs e)
        {
        }

        private void lblNCC_Click(object sender, EventArgs e)
        {
        }

        private void cbNhomHang_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbNCC_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataHangHoa.DataSource = tb_MatHangBLL.timKiem(txtTimKiem.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataHangHoa.DataSource = tb_MatHangBLL.timKiem(txtTimKiem.Text);
        }

        private void cbNhomHang_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHangHoa_ADD fm = new frmHangHoa_ADD();
            fm.FormClosed += Fm_FormClosed; 
            fm.ShowDialog();
        }

        private void Fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataHangHoa.DataSource = tb_MatHangBLL.layDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmHangHoa_ADD fm = new frmHangHoa_ADD(mahang,tenhang,tennhacungcap,tennhomhang,donvitinh,giaban,ngaycapnhat);
            fm.FormClosed += Fm_FormClosed;
            fm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không?"," Thông báo!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                tb_MatHangBLL.xoa(mahang);
                dataHangHoa.DataSource = tb_MatHangBLL.layDuLieu();
            }
      
        }
    }
}
