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
    public partial class frmPhongBan : Form
    {
        string maphongban, tenphongban;
        string flag = "them";
        public frmPhongBan()
        {
            InitializeComponent();
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
        }
        public frmPhongBan(String MaPhongBan, String TenPhongBan)
        {
            InitializeComponent();
            txtMaPhongBan.Text = MaPhongBan;
            txtTenPhongBan.Text = TenPhongBan;

            txtMaPhongBan.ReadOnly = true;
            flag = "sua";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaPhongBan.Text != "" || txtTenPhongBan.Text != "")
            {
                tb_PhongBanDBO obj = new tb_PhongBanDBO();
                obj.MaPhongBan = txtMaPhongBan.Text;
                obj.TenPhongBan = txtTenPhongBan.Text;

                if (flag == "them")
                {
                    if (tb_PhongBanBLL.kiemTraTonTai(obj.MaPhongBan) == 1)
                    {
                        MessageBox.Show("Thông Báo Đã tồn tại!");
                    }
                    else
                    {
                        tb_PhongBanBLL.them(obj);
                        MessageBox.Show("Thêm thành công!");
                        this.Dispose();
                    }
                }
                else if (flag == "sua")
                {
                    tb_PhongBanBLL.sua(obj);
                    MessageBox.Show("Sửa thành công!");
                    this.Dispose();
                }
            }
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {

        }
    }
}
