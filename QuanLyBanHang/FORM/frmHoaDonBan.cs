using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBO;
using BLL;

namespace QuanLyBanHang.FORM
{
    public partial class frmHoaDonBan : Form
    {

        string mahoadonban, makhachhang, manhanvien, tongthanhtoan, dathanhtoan, ngaylap;
        string flag = "them";
        public frmHoaDonBan()
        {
            InitializeComponent();
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if ( txtMaHoaDon.Text != "" || txtTongThanhToan.Text != "" )
            {
                tb_HoaDonBanDBO obj = new tb_HoaDonBanDBO();
                obj.MaHoaDonBan = txtMaHoaDon.Text;
                obj.MaKhachHang = cbbKhachHang.SelectedValue.ToString();
                obj.MaNhanVien = cbbNhanVien.SelectedValue.ToString();
                obj.TongThanhToan =Convert.ToDouble(txtTongThanhToan.Text);
                obj.DaThanhToan =Convert.ToBoolean(cbbDaThanhToan.SelectedIndex);
                obj.NgayLap = dtNgayLap.Value;

                if (flag == "them")
                {
                    if (tb_HoaDonBanBLL.kiemTraTonTai(obj.MaHoaDonBan) == 1)
                    {
                        MessageBox.Show("Thông Báo Đã tồn tại!");
                    }
                    else
                    {
                        tb_HoaDonBanBLL.them(obj);
                        MessageBox.Show("Thêm thành công!");
                        this.Dispose();
                    }
                }
                else if (flag == "sua")
                {
                    tb_HoaDonBanBLL.sua(obj);
                    MessageBox.Show("Sửa thành công!");
                    this.Dispose();
                }
            }
        }

        public frmHoaDonBan(String Mahoadonban, String Makhachhang, String Manhanvien, String Tongthanhtoan, String Dathanhtoan, String Ngaylap)
        {
            InitializeComponent();
            txtMaHoaDon.Text = Mahoadonban;
            cbbKhachHang.Text = Makhachhang;
            cbbNhanVien.Text = Manhanvien;
            txtTongThanhToan.Text = Tongthanhtoan;
            cbbDaThanhToan.SelectedIndex = Dathanhtoan.Contains("rue") ? 1 : 0;
            dtNgayLap.Value = Convert.ToDateTime(Ngaylap);
            txtMaHoaDon.ReadOnly = true;
            flag = "sua";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            //cbbDaThanhToan.SelectedIndex = 0;
            MethodLoad.LoadCombobox(cbbKhachHang, tb_KhachHangBLL.layDuLieu(), "Mã khách hàng", "Tên khách hàng");
            MethodLoad.LoadCombobox(cbbNhanVien, tb_NhanVienBLL.layDuLieu(), "Mã nhân viên", "Tên nhân viên");
        }
    }
}
