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
namespace QuanLyBanHang.FORM
{
    public partial class frmNhomHang : Form
    {
        string manhomhang,tennhomhang;
        string flag = "them";
        public frmNhomHang()
        {
            InitializeComponent();
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
        }
        public frmNhomHang(String MaNhomHang, String TenNhomHang)
        {
            InitializeComponent();
            txtMaNhomHang.Text = MaNhomHang;
            txtTenNhomHang.Text = TenNhomHang;

            txtMaNhomHang.ReadOnly = true;
            flag = "sua";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (txtMaNhomHang.Text != "" || txtTenNhomHang.Text != "")
            {
                tb_NhomHangDBO obj = new tb_NhomHangDBO();
                obj.MaNhomHang = txtMaNhomHang.Text;
                obj.TenNhomHang = txtTenNhomHang.Text;

                if (flag == "them")
                {
                    if (tb_NhomHangBLL.kiemTraTonTai(obj.MaNhomHang) == 1)
                    {
                        MessageBox.Show("Thông Báo Đã tồn tại!");
                    }
                    else
                    {
                        tb_NhomHangBLL.them(obj);
                        MessageBox.Show("Thêm thành công!");
                        this.Dispose();
                    }
                }
                else if (flag == "sua")
                {
                    tb_NhomHangBLL.sua(obj);
                    MessageBox.Show("Sửa thành công!");
                    this.Dispose();
                }
            }
        }

        private void frmNhomHang_Load(object sender, EventArgs e)
        {
    
        }
    }
}
