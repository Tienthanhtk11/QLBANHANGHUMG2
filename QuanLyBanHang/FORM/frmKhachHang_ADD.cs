using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.FORM
{
    public partial class frmKhachHang_ADD : Form
    {
        Boolean flag = true;
        public frmKhachHang_ADD()
        {
            InitializeComponent();
            btnOKKH.Text = "&Thêm";
            flag = true;
        }
        public frmKhachHang_ADD(String MaKH, String TenKH, String GioiTinh, String DiaChi, String SoDienThoai)
        {
            InitializeComponent();
            btnOKKH.Text = "&Sửa";
            flag = false;
            txtMaKH.Text = MaKH;
            txtTenKH.Text = TenKH;
            cbbGioiTinhKH.Text = GioiTinh;
            txtSDTKH.Text = SoDienThoai;
            txtDCKH.Text = DiaChi;
            txtMaKH.Enabled = false;
        }

        private void Clear()
        {
            txtDCKH.Text = "";
            txtMaKH.Text = "";
            txtSDTKH.Text = "";
            txtTenKH.Text = "";
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
            if (txtDCKH.Text.Trim() != "" && txtMaKH.Text.Trim() != "" && txtSDTKH.Text.Trim() != "" && txtTenKH.Text.Trim() != "")
            {
                if (flag)
                {
                    string sql = "insert into KHACHHANG values(N'" + txtMaKH.Text.Trim() + "',N'" + txtTenKH.Text.Trim() + "',N'" + cbbGioiTinhKH.Text.Trim() + "',N'" + txtDCKH.Text.Trim() + "',N'" + txtSDTKH.Text.Trim() + "')";

                    try
                    {
                        Unility.ExcuteSQL(sql);
                        MessageBox.Show("Thêm Thành Công");
                        Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại" + ex.ToString());
                    }

                }
                else
                {
                    string sql = "update KHACHHANG set TenKH = N'" + txtTenKH.Text.Trim() + "', GioiTinh = N'" + cbbGioiTinhKH.Text.Trim() + "',DiaChi = N'" + txtDCKH.Text.Trim() + "',SoDT = N'" + txtSDTKH.Text.Trim() + "' where MaKH ='"+txtMaKH.Text.Trim()+"'";
                    try
                    {
                        Unility.ExcuteSQL(sql);
                        MessageBox.Show("Sửa Thành Công");
                        this.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thất bại" + ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }
    }
}
