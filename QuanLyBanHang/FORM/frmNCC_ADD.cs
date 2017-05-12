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
    public partial class frmNCC_ADD : Form
    {
        string flag = "them";
        public frmNCC_ADD()
        {
            InitializeComponent();
            
        }

        public frmNCC_ADD(String MaNCC, String Ten, String sdt, String dc)
        {
            InitializeComponent();
            txtMaNhaCC.Text = MaNCC;
            txtTenNhaCC.Text = Ten;
            txtSDTNhaCC.Text = sdt;
            txtDCNhaCC.Text = dc;
            txtMaNhaCC.ReadOnly = true;
            flag = "sua";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCC.Text != "" || txtDCNhaCC.Text != "" || txtSDTNhaCC.Text != "" || txtTenNhaCC.Text != "")
            {
                tb_NhaCungCapDBO obj = new tb_NhaCungCapDBO();
                obj.MaNhaCungCap = txtMaNhaCC.Text;
                obj.TenNhaCungCap = txtTenNhaCC.Text;
                obj.SDT = txtSDTNhaCC.Text;
                obj.DiaChi = txtDCNhaCC.Text;
            

                if (flag == "them")
                {
                    if (tb_NhaCungCapBLL.kiemTraTonTai(obj.MaNhaCungCap) == 1)
                    {
                        MessageBox.Show("Thông Báo Đã tồn tại!");
                    }
                    else
                    {
                        tb_NhaCungCapBLL.them(obj);
                        MessageBox.Show("Thêm thành công!");
                        this.Dispose();
                    }
                }
                else if (flag == "sua")
                {
                    tb_NhaCungCapBLL.sua(obj);
                    MessageBox.Show("Sửa thành công!");
                    this.Dispose();
                }
            }
        }
        private void Clear()
        {

        }

        private void frmNCC_ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
