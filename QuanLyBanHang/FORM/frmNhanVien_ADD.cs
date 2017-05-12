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
    public partial class frmNhanVien_ADD : Form
    {
        string flag = "them";
        public frmNhanVien_ADD()
        {
            InitializeComponent();
        }
        public frmNhanVien_ADD(String MaNV, String HoTen, String NgaySinh, String GioiTinh, String DiaChi,String SoDienThoai, String MaPhongBan)
        {
            InitializeComponent();
            txtMaNhanVien.Text = MaNV;
            txtHoTen.Text = HoTen;
            cbbGioiTinh.Text = GioiTinh;
            cbbPhongBan.Text = MaPhongBan;
            txtDiaChi.Text = DiaChi;
            txtSoDienThoai.Text = SoDienThoai;
            dtNgaySinh.Value = Convert.ToDateTime(NgaySinh);
            txtMaNhanVien.ReadOnly = true;
            flag = "sua";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != "" || txtHoTen.Text != "" || txtMaNhanVien.Text != "" || txtSoDienThoai.Text != "")
            {
                tb_NhanVienDBO obj = new tb_NhanVienDBO();
                obj.MaNhanVien = txtMaNhanVien.Text;
                obj.TenNhanVien = txtHoTen.Text;
                obj.GioiTinh = cbbGioiTinh.Text;
                obj.MaPhongBan = cbbPhongBan.SelectedValue.ToString();
                obj.DiaChi = txtDiaChi.Text;
                obj.SDT = txtSoDienThoai.Text;
                obj.NgaySinh = dtNgaySinh.Value;

                if (flag == "them")
                {
                    if (tb_NhanVienBLL.kiemTraTonTai(obj.MaNhanVien) == 1)
                    {
                        MessageBox.Show("Thông Báo Đã tồn tại!");
                    }
                    else
                    {
                        tb_NhanVienBLL.them(obj);
                        MessageBox.Show("Thêm thành công!");
                        this.Dispose();
                    }
                }
                else if (flag == "sua")
                {
                    tb_NhanVienBLL.sua(obj);
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

        }

        private void frmNhanVien_ADD_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadCombobox(cbbPhongBan, tb_PhongBanBLL.layDuLieu(), "Mã phòng ban", "Tên phòng ban");
        }
    }
}
