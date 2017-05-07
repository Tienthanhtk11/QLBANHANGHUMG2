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
    public partial class ucXuatKho : UserControl
    {
        int rows = 0;
        public ucXuatKho()
        {
            InitializeComponent();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon_ADD frm = new frmHoaDon_ADD();
            frm.FormClosed += Dongform;
            frm.ShowDialog();
        }

        private void Dongform(object sender, FormClosedEventArgs e)
        {
            ucXuatKho_Load(sender, e);
        }

        private void ucXuatKho_Load(object sender, EventArgs e)
        {
            //MethodLoad.LoadCombobox(cbNhaCC,"TenKH","MaKH","select * from KHACHHANG");
            //cbNhaCC.Text = "";
            Default.SetDefaultDataGridView(dtXuatKho);
            MethodLoad.LoadDatagridview(dtXuatKho, @"SELECT [MaHoaDonBan] '#SHĐ'
                                                          ,[tb_HoaDonBan].MaKhachHang 'MKH'
                                                          , TenKhachHang 'Tên khách hàng'
                                                          ,[tb_HoaDonBan].MaNhanVien 'MNV'
                                                          , TenNhanVien 'Tên nhân viên'
                                                          ,[NgayLap] 'Ngày lập'
                                                          ,[TongThanhToan] 'Tổng thanh toán'
                                                          , CASE WHEN[DaThanhToan] = 1 THEN 'Đã thanh toán' ELSE 'Chưa thanh toán' END 'Trạng thái'
                                                      FROM[dbo].[tb_HoaDonBan]
                                                      join tb_KhachHang on[tb_HoaDonBan].MaKhachHang = tb_KhachHang.MaKhachHang
                                                      join tb_NhanVien on[tb_HoaDonBan].MaNhanVien = tb_NhanVien.MaNhanVien");
        }

        private void sửaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dtXuatKho.Rows[rows].Cells[0].Value.ToString();
            string nv = dtXuatKho.Rows[rows].Cells[1].Value.ToString();
            string kh = dtXuatKho.Rows[rows].Cells[2].Value.ToString();
            string mh = dtXuatKho.Rows[rows].Cells[3].Value.ToString();
            string slm = dtXuatKho.Rows[rows].Cells[4].Value.ToString();
            string tt = dtXuatKho.Rows[rows].Cells[5].Value.ToString();
            DateTime ngay = DateTime.Parse(dtXuatKho.Rows[rows].Cells[6].Value.ToString());
            frmHoaDon_ADD frm = new frmHoaDon_ADD(ma,nv,kh,tt,ngay,mh,slm);
            frm.FormClosed += Dongform;
            frm.ShowDialog();
        }

        private void xóaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Unility.ExcuteSQL("Delete HOADON where SoHD = N'" + dtXuatKho.Rows[rows].Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Xóa thành công");
                    ucXuatKho_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại: " + ex.ToString());
                }
            }
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodLoad.InDt(dtXuatKho);
        }

        private void xuấtFileExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodLoad.Excell(dtXuatKho,(int)MethodLoad.form.XuatKho,null);
        }

        private void dtXuatKho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rows = e.RowIndex;
        }

        private void lblNCC_Click(object sender, EventArgs e)
        {
            cbNhaCC.Focus();
        }

        private void cbNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNCC.Visible = false;
            MethodLoad.LoadDatagridview(dtXuatKho, "select h.SoHD 'Số hóa đơn',nv.HoTen 'Nhân viên',kh.TenKH 'Khách hàng',hh.TenHang 'Mặt hàng',h.SoLuongMua 'Số lượng mua',h.ThanhTien 'ThanhTien' ,h.NgayLapHD 'Ngày lập' from HOADON h join NHANVIEN nv on h.MaNV = nv.MaNV join HANGHOA hh on h.MaHang = hh.MaHang join KHACHHANG kh on h.MaKH = kh.MaKH where h.MaKH = '" + cbNhaCC.SelectedValue.ToString()+"'");

        }

        private void cbNhaCC_TextChanged(object sender, EventArgs e)
        {
            lblNCC.Visible = cbNhaCC.Text.Length == 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            thêmToolStripMenuItem_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sửaHóaĐơnToolStripMenuItem_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xóaHóaĐơnToolStripMenuItem_Click(sender, e);
        }
    }
}
