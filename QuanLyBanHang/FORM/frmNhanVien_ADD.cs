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
    public partial class frmNhanVien_ADD : Form
    {
        Boolean flag = true;
        public frmNhanVien_ADD()
        {
            InitializeComponent();
            btnOK.Text = "&Thêm";
            flag = true;
        }
        public frmNhanVien_ADD(String MaNV, String MaThe, String HoTen, String GioiTinh, DateTime NgaySinh, String NgoaiTru, String SoDT,String QueQuan)
        {
            InitializeComponent();
            btnOK.Text = "&Sửa";
            flag = false;
            txtMaNhanVien.Text = MaNV;
            txtMaThe.Text = MaThe;
            txtHoTen.Text = HoTen;
            cbbGioiTinh.Text = GioiTinh;
            dtNgaySinh.Value = Convert.ToDateTime(NgaySinh);
            txtNgoaiTru.Text = NgoaiTru;
            txtSoDienThoai.Text = SoDT;
            txtQueQuan.Text = QueQuan;

            txtMaNhanVien.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() != "" && txtHoTen.Text.Trim() != "" && txtMaThe.Text.Trim() != "" && txtNgoaiTru.Text.Trim() != "" && txtQueQuan.Text.Trim() != "" && txtSoDienThoai.Text.Trim() != "")
            {
                if (flag)
                {
                    string sql = "insert into NHANVIEN values(N'" + txtMaNhanVien.Text.Trim() + "',N'" + txtMaThe.Text.Trim() + "',N'" + txtHoTen.Text.Trim() + "',N'" + cbbGioiTinh.Text.Trim() + "','"+dtNgaySinh.Value.ToString()+"',N'" + txtNgoaiTru.Text.Trim() + "','" + txtSoDienThoai.Text.Trim() + "','" + txtQueQuan.Text.Trim() + "')";

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
                    string sql = "update NHANVIEN set MaThe=N'"+txtMaThe.Text.ToString()+"',HoTen = N'" + txtHoTen.Text.Trim() + "', GioiTinh = N'" + cbbGioiTinh.Text.ToString() + "',NgaySinh = N'" + dtNgaySinh.Value.ToShortDateString() + "',NgoaiTru = N'" + txtNgoaiTru.Text.Trim() + "',SDT ='" + txtSoDienThoai.Text.Trim() + "',QueQuan='" + txtQueQuan.Text.Trim() + "' where MaNV = N'" + txtMaNhanVien.Text.Trim() + "'";
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
        private void Clear()
        {
            txtHoTen.Text = "";
            txtMaNhanVien.Text = "";
            txtMaThe.Text = "";
            txtNgoaiTru.Text = "";
            txtQueQuan.Text = "";
            txtSoDienThoai.Text = "";
        }

        private void frmHangHoa_ADD_Load(object sender, EventArgs e)
        {
      
        }
    }
}
