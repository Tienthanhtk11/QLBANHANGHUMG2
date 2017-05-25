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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (tb_DangNhapBLL.DangNhap(txtDN.Text.Trim(), txtMK.Text.Trim()) == 1) {
                TaiKhoan TTTK = new TaiKhoan();
                DataTable temp = tb_DangNhapBLL.taiKhoan(txtDN.Text.Trim(), txtMK.Text.Trim());
                tb_DangNhapDBO tempTK = new tb_DangNhapDBO();
                tempTK.TenDangNhap = temp.Rows[0][0].ToString();
                tempTK.MatKhau = temp.Rows[0][1].ToString();
                tempTK.MaNhanVien = temp.Rows[0][2].ToString();
                tempTK.Role = int.Parse(temp.Rows[0][3].ToString());
                TTTK = new TaiKhoan(tempTK);
                frmMain frm = new frmMain(TTTK);
                frm.Show();
                frm.Shown += Frm_Shown;
                //frm.FormClosed += Frm_FormClosed;
            } else {
                lb.Text = "Sai tên đăng nhập và mật khẩu. vui lòng kiểm tra lại";
            }
        }

        private void Frm_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangNhap form2 = new frmDangNhap();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDangNhap form2 = new frmDangNhap();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmDangKy().ShowDialog();
        }
    }
}
