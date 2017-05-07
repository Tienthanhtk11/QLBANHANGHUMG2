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
    public partial class ucNhapKho : UserControl
    {
        private int rows = 0;
        public ucNhapKho()
        {
            InitializeComponent();
        }

        private void ucNhapKho_Load(object sender, EventArgs e)
        {
            Default.SetDefaultDataGridView(dtNhapKho);
            //MethodLoad.LoadCombobox(cbNhaCC, "TenHang", "MaHang", "select * from HANGHOA");
            //cbNhaCC.Text = "";
            //lblNCC.Visible = true;
            MethodLoad.LoadDatagridview(dtNhapKho, @"SELECT [MaHoaDonNhap] '#SHĐ'
                                                          , tb_NhaCungCap.[MaNhaCungCap] 'Mã NCC'
                                                          , TenNhaCungCap 'Tên nhà cung cấp'
                                                          , tb_NhanVien.[MaNhanVien] 'Mã NV'
                                                          , TenNhanVien 'Tên nhân viên'
                                                          ,[NgayLap] 'Ngày lập'
                                                      FROM[dbo].[tb_HoaDonNhap]
                                                      join tb_NhanVien on[tb_HoaDonNhap].MaNhanVien = tb_NhanVien.MaNhanVien
                                                      join tb_NhaCungCap on[tb_HoaDonNhap].[MaNhaCungCap] = tb_NhaCungCap.[MaNhaCungCap]");

        }

        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucNhapKho_Load(sender,e);
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapKho frm = new frmNhapKho();
            frm.FormClosed += Dongform;
            frm.ShowDialog();
        }
        private void Dongform(object sender, FormClosedEventArgs e)
        {
            ucNhapKho_Load(sender, e);
        }
        private void sửaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dtNhapKho.Rows[rows].Cells[0].Value.ToString();
            string tenH = dtNhapKho.Rows[rows].Cells[1].Value.ToString();
            string NguoiNhap = dtNhapKho.Rows[rows].Cells[2].Value.ToString();
            DateTime ngay = DateTime.Parse(dtNhapKho.Rows[rows].Cells[3].Value.ToString());
            string sl = dtNhapKho.Rows[rows].Cells[4].Value.ToString();
            string dongia = dtNhapKho.Rows[rows].Cells[5].Value.ToString();
            string phivc = dtNhapKho.Rows[rows].Cells[6].Value.ToString();
            string tongtien = dtNhapKho.Rows[rows].Cells[7].Value.ToString();
            string mota = dtNhapKho.Rows[rows].Cells[8].Value.ToString();

            frmNhapKho frm = new frmNhapKho(ma, tenH, NguoiNhap, ngay, sl, dongia, phivc, tongtien, mota);
            frm.FormClosed += Dongform;
            frm.ShowDialog();
        }

        private void xóaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Unility.ExcuteSQL("Delete NHAPHANG where MaHangNhap = N'" + dtNhapKho.Rows[rows].Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Xóa thành công");
                    ucNhapKho_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại: " + ex.ToString());
                }
            }
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodLoad.InDt(dtNhapKho);
        }

        private void dtNhapKho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rows = e.RowIndex;
        }

        private void xuấtFileExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodLoad.Excell(dtNhapKho, (int)MethodLoad.form.NhapKho,null);
        }

        private void ucNhapKho_Resize(object sender, EventArgs e)
        {
            if (dtNhapKho.Width <= 550)
                dtNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            else
                dtNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNCC.Visible= false;
            MethodLoad.LoadDatagridview(dtNhapKho, "select nh.MaHangNhap,hh.TenHang,nh.NguoiNhap,nh.NgayNhap,nh.SoLuong,nh.DonGia,nh.PhiVanChuyen,nh.TongTien,nh.MoTa from NHAPHANG nh join HANGHOA hh on nh.MaHang = hh.MaHang where nh.MaHang = '" + cbNhaCC.SelectedValue.ToString()+"'");
        }

        private void cbNhaCC_TextChanged(object sender, EventArgs e)
        {
            lblNCC.Visible = cbNhaCC.Text.Length == 0;
        }

        private void lblNCC_Click(object sender, EventArgs e)
        {
            cbNhaCC.Focus();
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
