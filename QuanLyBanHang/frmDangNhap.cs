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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (Unility.AExcuteSQL(string.Format("select count(*) from TAIKHOAN where Name = '{0}' and Pass = '{1}'", txtDN.Text, txtMK.Text)) == 1)
                {
                    frmMain f = new frmMain();
                    f.Show();
                   Hide();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi kết nối \n"+ex.Message); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
