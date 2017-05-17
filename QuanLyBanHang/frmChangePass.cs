using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DBO;
namespace QuanLyBanHang
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }
        static TaiKhoan TkC = new TaiKhoan();
        public frmChangePass(TaiKhoan Tk)
        {
            InitializeComponent();
            TkC = Tk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text.Trim() == TkC.MatKhau)
            {
                if (txtMKMoi.Text.Trim() == txtRMK.Text.Trim())
                {
                    if (txtMKCu.Text.Trim() == txtMKMoi.Text.Trim())
                    {
                        lb.Text = "Mật khẩu không có gì thay dổi";
                    }
                    else
                    {
                        tb_DangNhapBLL.DoiMK(TkC.TenDangNhap, txtMKMoi.Text.Trim());
                        DataTable temp = tb_DangNhapBLL.taiKhoan(TkC.TenDangNhap, txtMKMoi.Text.Trim());
                        tb_DangNhapDBO tempTK = new tb_DangNhapDBO();
                        tempTK.TenDangNhap = temp.Rows[0][0].ToString();
                        tempTK.MatKhau = temp.Rows[0][1].ToString();
                        tempTK.MaNhanVien = temp.Rows[0][2].ToString();
                        tempTK.Role = int.Parse(temp.Rows[0][3].ToString());
                        lb.Text = "Đổi mật khẩu thành công";
                        TkC = new TaiKhoan(tempTK);
                    }
                }
                else
                {
                    lb.Text = "Mật khẩu không trùng lặp";
                }
            }
            else
            {
                lb.Text = "Nhập sai!";
            }
        }
    }
}
