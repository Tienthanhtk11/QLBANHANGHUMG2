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
    public partial class frmHoaDon_ADD : Form
    {
        private Boolean flag = true;
        public frmHoaDon_ADD()
        {
            InitializeComponent();
            btnOK.Text = "&Thêm";
            flag = true;
        }
        public frmHoaDon_ADD(string ma, string nv, string kh, string tt, DateTime ngay, string mh, string slm)
        {
            InitializeComponent();
            btnOK.Text = "&Sửa";
            flag = false;
            txtMaHD.Text = ma;
            cbNhanVien.Text = nv;
            cbMatHang.Text = mh;
            cbNhanVien.Text = nv;
            dtNgayNhap.Value = ngay;
            txtThanhTien.Text = tt;
            txtSoLuong.Text = slm;
            txtMaHD.Enabled = false;
        }
        private void frmHoaDon_ADD_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadCombobox(cbNhanVien, "HoTen", "MaNV", "Select * from NHANVIEN");
            MethodLoad.LoadCombobox(cbMatHang, "TenHang", "MaHang", "Select * from HangHoa");
            MethodLoad.LoadCombobox(cbKH, "TenKH", "MaKH", "Select * from KHACHHANG");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "" && txtThanhTien.Text.Trim() != "" && txtSoLuong.Text.Trim() != "")
            {
                if (flag)
                {
                    string sql = "insert into HOADON values(N'" + txtMaHD.Text.Trim() + "',N'" + dtNgayNhap.Value.ToString("MM/dd/yyyy") + "',N'" + cbNhanVien.SelectedValue.ToString() + "',N'" + cbKH.SelectedValue.ToString() + "',N'" + cbMatHang.SelectedValue.ToString() + "','" + txtSoLuong.Text.Trim() + "','0')";
                    try
                    {
                        int temp = Unility.AExcuteSQL("select SoLuongCon from HANGHOA where MaHang = '" + cbMatHang.SelectedValue.ToString() + "'");
                        if ((int.Parse(txtSoLuong.Text) > temp))
                        {
                            MessageBox.Show("Số lượng sản phẩm ("+cbMatHang.Text +" = "+ temp + ") không đủ để cung cấp cho đơn hàng");
                        }
                        else
                        {
                            Unility.ExcuteSQL(sql);
                            MessageBox.Show("Thêm Thành Công");
                            Clear();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại" + ex.ToString());
                    }

                }
                else
                {
                    string sql = "update HOADON set NgayLapHD = N'" + dtNgayNhap.Value.ToString("MM/dd/yyyy") + "', MaNV = N'" + cbNhanVien.SelectedValue.ToString() + "',MaKH = N'" + cbKH.SelectedValue.ToString() + "',MaHang = N'" + cbMatHang.SelectedValue.ToString() + "',ThanhTien = N'" + txtThanhTien.Text.Trim() + "',SoLuongMua = '" + txtSoLuong.Text.Trim() + "' where SoHD = N'" + txtMaHD.Text.Trim() + "'";
                    try
                    {
                        int temp = Unility.AExcuteSQL("select SoLuongCon from HANGHOA where MaHang = '" + cbMatHang.SelectedValue.ToString() + "'");
                        if ((int.Parse(txtSoLuong.Text) > temp))
                        {
                            MessageBox.Show("Số lượng sản phẩm (" + cbMatHang.Text + " = " + temp + ") không đủ để cung cấp cho đơn hàng");
                        }
                        else
                        {
                            Unility.ExcuteSQL(sql);
                            MessageBox.Show("Sửa Thành Công");
                            this.Dispose();
                        }
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
            txtThanhTien.Text = txtMaHD.Text = "";
            cbNhanVien.SelectedIndex = cbMatHang.SelectedIndex = cbKH.SelectedIndex = 0;
        }
    }
}
