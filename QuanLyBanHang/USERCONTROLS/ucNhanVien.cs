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
    public partial class ucNhanVien : UserControl
    {
        int rows = 0;
        public ucNhanVien()
        {
            InitializeComponent();
        }

        private void thêmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien_ADD f= new frmNhanVien_ADD();
            f.FormClosed += DongTab;
            f.ShowDialog();
        }

        private void sửaHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string manhanvien = dataNhanVien.Rows[rows].Cells[0].Value.ToString();
                string mathe = dataNhanVien.Rows[rows].Cells[1].Value.ToString();
                string hoten = dataNhanVien.Rows[rows].Cells[2].Value.ToString();
                string gioitinh = dataNhanVien.Rows[rows].Cells[3].Value.ToString();
                string ngaysinh = dataNhanVien.Rows[rows].Cells[4].Value.ToString();
                string ngoaitru = dataNhanVien.Rows[rows].Cells[5].Value.ToString();
                string sodienthoai = dataNhanVien.Rows[rows].Cells[6].Value.ToString();
                string quequan = dataNhanVien.Rows[rows].Cells[7].Value.ToString();
                frmNhanVien_ADD frm = new frmNhanVien_ADD(manhanvien, mathe, hoten, gioitinh, Convert.ToDateTime(ngaysinh), ngoaitru, sodienthoai, quequan);
                frm.FormClosed += DongTab;
                frm.ShowDialog();
            }catch(Exception ex)
            {

            }
        }

        private void xóaHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Unility.ExcuteSQL("Delete NHANVIEN where MaNV = N'" + dataNhanVien.Rows[rows].Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Xóa thành công");
                    ucNhanVien_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhân viên đang thực hiện giao dịch không thể xóa");
                }
            }
        }

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucNhanVien_Load(sender, e);
        }
        private void DongTab(object sender, FormClosedEventArgs e)
        {
            ucNhanVien_Load(sender, e);
        }
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            Default.SetDefaultDataGridView(dataNhanVien);
            MethodLoad.LoadDatagridview(dataNhanVien, @"SELECT [MaNhanVien] 'Mã nhân viên'
                                                              ,[TenNhanVien] 'Tên nhân viên'
                                                              ,[NgaySinh] 'Ngày sinh'
                                                              ,[GioiTinh] 'Giới tính'
                                                              ,[DiaChi] 'Địa chỉ'
                                                              ,[SDT] 'Số điện thoại'
                                                              , TenPhongBan 'Phòng ban'
                                                          FROM[dbo].[tb_NhanVien]
                                                          inner join tb_PhongBan on[tb_NhanVien].MaPhongBan = tb_PhongBan.MaPhongBan");
        }

        private void dataNhanVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rows = e.RowIndex;
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
