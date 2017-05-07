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
namespace QuanLyBanHang.USERCONTROLS
{
    public partial class ucKhachHang : UserControl
    {
        int rows = 0;
        public ucKhachHang()
        {
            InitializeComponent();
        }
        private void DongTab(object sender, FormClosedEventArgs e)
        {
            ucKhachHang_Load(sender, e);
        }
        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataKhachHang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rows = e.RowIndex;
        }

        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            Default.SetDefaultDataGridView(dataKhachHang);
            MethodLoad.LoadDatagridview(dataKhachHang, @"SELECT [MaKhachHang] 'Mã khách hàng'
                                                              ,[TenKhachHang] 'Tên khách hàng'
                                                              ,[DiaChi] 'Địa chỉ'
                                                              ,[SDT] 'Số điện thoại'
                                                          FROM[dbo].[tb_KhachHang]");
        }

        private void thêmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang_ADD f = new frmKhachHang_ADD();
            f.FormClosed += DongTab;
            f.ShowDialog();
        }

        private void sửaHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string makhachhang = dataKhachHang.Rows[rows].Cells[0].Value.ToString();
                string tenkhachhang = dataKhachHang.Rows[rows].Cells[1].Value.ToString();
                string gioitinh = dataKhachHang.Rows[rows].Cells[2].Value.ToString();
                string diachi = dataKhachHang.Rows[rows].Cells[3].Value.ToString();
                string sodienthoai = dataKhachHang.Rows[rows].Cells[4].Value.ToString();
                frmKhachHang_ADD frm = new frmKhachHang_ADD(makhachhang, tenkhachhang, gioitinh, diachi, sodienthoai);
                frm.FormClosed += DongTab;
                frm.ShowDialog();
            }
            catch { }
        }

        private void xóaHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Unility.ExcuteSQL("Delete KHACHHANG where MaKH = N'" + dataKhachHang.Rows[rows].Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Xóa thành công");
                    ucKhachHang_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khách hàng đang thực hiện giao dịch không thể xóa");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            thêmHàngHóaToolStripMenuItem_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sửaHàngHóaToolStripMenuItem_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xóaHàngHóaToolStripMenuItem_Click(sender, e);
        }
    }
}
