using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.USERCONTROLS;
using DBO;
using BLL;
namespace QuanLyBanHang.FORM
{
    public partial class frmHangHoa_ADD : Form
    {
        string flag = "them";
        public frmHangHoa_ADD()
        {
            InitializeComponent();

        }
        public frmHangHoa_ADD(String MaHang, String TenHang, String TenNhaCungCap, String TenNhomHang, String DonViTinh, String GiaBan, String NgayCapNhat)
        {
            InitializeComponent();
            txtMaHang.Text = MaHang;
            txtTenHang.Text = TenHang;
            cbbNhaCC.Text = TenNhaCungCap;
            cbbNhomHang.Text = TenNhomHang;
            txtDonViTinh.Text = DonViTinh;
            txtGiaBan.Text = GiaBan;
            dtNgayCapNhat.Value = Convert.ToDateTime(NgayCapNhat);
            txtMaHang.ReadOnly = true;
            flag = "sua";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text!=""||txtDonViTinh.Text!=""||txtGiaBan.Text!=""||txtTenHang.Text!="")
            {
                tb_MatHangDBO obj = new tb_MatHangDBO();
                obj.MaMatHang = txtMaHang.Text;
                obj.TenMatHang = txtTenHang.Text;
                obj.MaNhaCungCap = cbbNhaCC.SelectedValue.ToString();
                obj.MaNhomHang = cbbNhomHang.SelectedValue.ToString();
                obj.DVT = txtDonViTinh.Text;
                obj.GiaBan = Convert.ToDouble(txtGiaBan.Text);
                obj.NgayCapNhat = Convert.ToDateTime(dtNgayCapNhat.Value);

                if (flag == "them")
                {
                    if (tb_MatHangBLL.kiemTraTonTai(obj.MaMatHang) == 1)
                    {
                        MessageBox.Show("Thông Báo Đã tồn tại!");
                    }
                    else
                    {
                        tb_MatHangBLL.them(obj);
                        MessageBox.Show("Thêm thành công!");
                        this.Dispose();
                    }
                } else if (flag == "sua")
                {
                    tb_MatHangBLL.sua(obj);
                    MessageBox.Show("Sửa thành công!");
                    this.Dispose();
                }
            }
        }
        private void Clear()
        {

        }

        private void frmHangHoa_ADD_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadCombobox(cbbNhaCC,tb_NhaCungCapBLL.layDuLieu(), "Mã nhà cung cấp", "Tên nhà cung cấp");
            MethodLoad.LoadCombobox(cbbNhomHang, tb_NhomHangBLL.layDuLieu(), "Mã nhóm hàng", "Tên nhóm hàng");
            
        }
    }
}
