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
    public partial class frmTonDauKy : Form
    {
        string mamathang, ngaycapnhat, soluong, giatriton;
        string flag = "them";
        public frmTonDauKy()
        {
            InitializeComponent();
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public frmTonDauKy(String MaMatHang, DateTime NgayCapNhat, String SoLuong, String GiaTriTon)
        {
            InitializeComponent();
            txtMaHT.Text = MaMatHang;
            txtGiaTriTon.Text = GiaTriTon;
            txtSoLuong.Text = SoLuong;
            dtNgayCapNhat.Value = NgayCapNhat;
            txtMaHT.ReadOnly = true;
            flag = "sua";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtGiaTriTon.Text != "" || txtMaHT.Text != "" || txtSoLuong.Text != "")
            {
                tb_TonDauKyDBO obj = new tb_TonDauKyDBO();
                obj.MaMatHang = txtMaHT.Text;
                obj.GiaTriTon = Convert.ToDouble(txtGiaTriTon.Text);
                obj.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                obj.NgayCapNhat = dtNgayCapNhat.Value;

                if (flag == "them")
                {
                    if (tb_TonDauKyBLL.kiemTraTonTai(obj.MaMatHang) == 1)
                    {
                        MessageBox.Show("Thông Báo Đã tồn tại!");
                    }
                    else
                    {
                        tb_TonDauKyBLL.them(obj);
                        MessageBox.Show("Thêm thành công!");
                        this.Dispose();
                    }
                }
                else if (flag == "sua")
                {
                    tb_TonDauKyBLL.sua(obj);
                    MessageBox.Show("Sửa thành công!");
                    this.Dispose();
                }
            }
        }

        private void frmTonDauKy_Load(object sender, EventArgs e)
        {

        }
    }
}
