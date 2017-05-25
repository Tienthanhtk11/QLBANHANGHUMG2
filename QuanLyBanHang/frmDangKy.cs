using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBO.tb_DangNhapDBO obj = new DBO.tb_DangNhapDBO();
            obj.TenDangNhap = txtTK.Text;
            obj.MatKhau = txtMK.Text;
            obj.MaNhanVien = txtMaNV.Text;
            obj.Role = 2;

            if (txtMK.Text!= txtRMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp nhau");
                return;
            }
            if (BLL.tb_DangNhapBLL.kiemTraTonTai(obj.TenDangNhap)==1)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }
            if (BLL.tb_NhanVienBLL.kiemTraTonTai(obj.MaNhanVien) == 0)
            {
                MessageBox.Show("Không phải nhân viên trong công ty, không thể đăng ký");
                return;
            }

            BLL.tb_DangNhapBLL.them(obj);
            MessageBox.Show(string.Format("Đăng ký thành công! Tài khoản {0}, mật khẩu {1}.",obj.TenDangNhap,obj.MatKhau));
            this.Close();
        }
    }
}
