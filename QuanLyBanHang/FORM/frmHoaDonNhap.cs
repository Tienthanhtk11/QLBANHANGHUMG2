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
    public partial class frmHoaDonNhap : Form
    {
        string mahoadonnhap, manhacungcap, manhanvien, ngaylap;
        string flag = "them";
        public frmHoaDonNhap()
        {
            InitializeComponent();
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
        }
        public frmHoaDonNhap(string ma, string mancc, string manv, string ngaylap)
        {
            InitializeComponent();
            txtMaHD.Text = ma;
            cbbMaNCC.Text = mancc;
            cbbMaNV.Text = manv;
            dtNgayNhap.Value = Convert.ToDateTime(ngaylap);
            txtMaHD.ReadOnly = true;
            flag = "sua";

        }
        private void frmHoaDon_ADD_Load(object sender, EventArgs e)
        {
           
            MethodLoad.LoadCombobox(cbbMaNCC, tb_NhaCungCapBLL.layDuLieu(), "Mã nhà cung cấp", "Tên nhà cung cấp");
            MethodLoad.LoadCombobox(cbbMaNV, tb_NhanVienBLL.layDuLieu(), "Mã nhân viên", "Tên nhân viên");
            cbbMaNV.SelectedIndex = 0;
            cbbMaNCC.SelectedIndex = 0;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "")
            {
                tb_HoaDonNhapDBO obj = new tb_HoaDonNhapDBO();
                obj.MaHoaDonNhap = txtMaHD.Text;
                obj.MaNhaCungCap = cbbMaNCC.SelectedValue.ToString();
                obj.MaNhanVien = cbbMaNV.SelectedValue.ToString();
                obj.NgayLap = dtNgayNhap.Value;

                if (flag == "them")
                {
                    if (tb_HoaDonNhapBLL.kiemTraTonTai(obj.MaHoaDonNhap) == 1)
                    {
                        MessageBox.Show("Thông Báo Đã tồn tại!");
                    }
                    else
                    {
                        tb_HoaDonNhapBLL.them(obj);
                        MessageBox.Show("Thêm thành công!");
                        this.Dispose();
                    }
                }
                else if (flag == "sua")
                {
                    tb_HoaDonNhapBLL.sua(obj);
                    MessageBox.Show("Sửa thành công!");
                    this.Dispose();
                }
            }
        }
      
        private void Clear()
        {

        }
    }
}
