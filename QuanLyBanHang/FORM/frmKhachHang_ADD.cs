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
    public partial class frmKhachHang_ADD : Form
    {
        string flag = "them";
        public frmKhachHang_ADD()
        {
            InitializeComponent();

        }
        public frmKhachHang_ADD(String MaKH, String TenKH, String SoDienThoai, String DiaChi)
        {
            InitializeComponent();
            txtMaKH.Text = MaKH;
            txtTenKH.Text = TenKH;
            txtSDTKH.Text = SoDienThoai;
            txtDCKH.Text = DiaChi;
            txtMaKH.ReadOnly = true;
            flag = "sua";
        }

        private void Clear()
        {

        }

        private void frmHangHoa_ADD_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHuyBoKH_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOKKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" || txtSDTKH.Text != "" || txtDCKH.Text != "" || txtTenKH.Text != "")
            {
                tb_KhachHangDBO obj = new tb_KhachHangDBO();
                obj.MaKhachHang = txtMaKH.Text;
                obj.TenKhachHang = txtTenKH.Text;
                obj.SDT = txtSDTKH.Text;
                obj.DiaChi = txtDCKH.Text;

                if (flag == "them")
                {
                    if (tb_KhachHangBLL.kiemTraTonTai(obj.MaKhachHang) == 1)
                    {
                        MessageBox.Show("Thông Báo Đã tồn tại!");
                    }
                    else
                    {
                        tb_KhachHangBLL.them(obj);
                        MessageBox.Show("Thêm thành công!");
                        this.Dispose();
                    }
                }
                else if (flag == "sua")
                {
                    tb_KhachHangBLL.sua(obj);
                    MessageBox.Show("Sửa thành công!");
                    this.Dispose();
                }
            }
        }

        private void frmKhachHang_ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
