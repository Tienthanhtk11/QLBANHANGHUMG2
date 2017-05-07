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
namespace QuanLyBanHang.FORM
{
    public partial class frmHangHoa_ADD : Form
    {
        Boolean flag = true;
        public frmHangHoa_ADD()
        {
            InitializeComponent();
            btnOK.Text = "&Thêm";
            flag = true;
        }
        public frmHangHoa_ADD(String MaHang, String TenHang, String TenNhom, String MaNCC, String DonViTinh,String SoLuong,String DonGia)
        {
            InitializeComponent();
            btnOK.Text = "&Sửa";
            flag = false;
            txtMaHang.Text = MaHang;
            txtTenHang.Text = TenHang;
            cbbNhomHang.Text = TenNhom;
            cbbNhaCC.Text = MaNCC;
            txtDonViTinh.Text = DonViTinh;
            txtSoLuong.Text = SoLuong;
            txtDonGia.Text = DonGia;
            txtMaHang.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text.Trim() != "" && txtDonGia.Text.Trim() != "" && txtDonViTinh.Text.Trim() != "" && txtSoLuong.Text.Trim() != "" && txtTenHang.Text.Trim() != "")
            {
                if (flag)
                {
                    string sql = "insert into HANGHOA values(N'" + txtMaHang.Text.Trim() + "',N'" + txtTenHang.Text.Trim() + "',N'" + cbbNhomHang.SelectedValue.ToString() + "',N'" + cbbNhaCC.SelectedValue.ToString() + "',N'" + txtDonViTinh.Text.Trim() + "','"+txtSoLuong.Text.Trim()+"','"+txtDonGia.Text.Trim()+"')";

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
                    string sql = "update HANGHOA set TenHang = N'" + txtTenHang.Text.Trim() + "', MaNhom = N'" + cbbNhomHang.SelectedValue.ToString() + "',MaNCC = N'" + cbbNhaCC.SelectedValue.ToString() + "',DVT = N'" + txtDonViTinh.Text.Trim() + "',SoLuongCon ='"+txtSoLuong.Text.Trim()+"',DonGia='"+txtDonGia.Text.Trim()+"' where MaHang = N'" + txtMaHang.Text.Trim() + "'";
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
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            txtMaHang.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
        }

        private void frmHangHoa_ADD_Load(object sender, EventArgs e)
        {
            //MethodLoad.LoadCombobox(cbbNhomHang, "TenNhom", "MaNhom", "select * from NHOMHANG");
           // MethodLoad.LoadCombobox(cbbNhaCC, "TenNCC", "MaNCC", "select * from NhaCC");
        }
    }
}
