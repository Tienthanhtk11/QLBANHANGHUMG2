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
    public partial class frmNhapKho : Form
    {
        private Boolean flag = true;
        public frmNhapKho()
        {
            InitializeComponent();
            btnOK.Text = "&Thêm";
            flag = true;
        }
        public frmNhapKho(string ma, string tenH, string NguoiNhap,DateTime ngay, string sl, string dongia, string phivc, string tongtien,string mota)
        {
            InitializeComponent();
            btnOK.Text = "&Sửa";
            flag = false;
            txtMaHD.Text = ma;
            cbHangHoa.Text = tenH;
            txtNguoiNhap.Text = NguoiNhap;
            dtNgayNhap.Value = ngay;
            txtSL.Text = sl;
            txtDongia.Text = dongia;
            txtPhiVC.Text = phivc;
            txtMT.Text = mota;
            txtTongTien.Text = tongtien;
            txtMaHD.Enabled = false;
            cbHangHoa.Enabled = false;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "" && txtNguoiNhap.Text.Trim() !=
                "" && txtSL.Text.Trim() != "" && txtDongia.Text.Trim() != "" && txtPhiVC.Text.Trim() !=
                "" && txtMT.Text.Trim() != "" && txtTongTien.Text.Trim() != "")
            {
                if (flag)
                {
                    string sql = "insert into NHAPHANG values(N'" + txtMaHD.Text.Trim() + "',N'" + cbHangHoa.SelectedValue.ToString() + "',N'" + txtNguoiNhap.Text.Trim() + "',N'" + txtMT.Text.Trim() +
                        "','" + txtSL.Text.Trim() + "',N'" + txtDongia.Text.Trim() +
                        "',N'" + txtPhiVC.Text.Trim() + "',N'" + txtTongTien.Text.Trim() + "','" + dtNgayNhap.Value.ToString("MM/dd/yyyy") + "')";
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
                    string sql = "update NHAPHANG set NgayNhap = N'" + dtNgayNhap.Value.ToString("MM/dd/yyyy") + "',NguoiNhap = N'" + txtNguoiNhap.Text.Trim() + "',MoTa = N'" + txtMT.Text.Trim() + "',SoLuong = N'" + txtSL.Text.Trim() + "', DonGia = N'" + txtDongia.Text.Trim() + "',PhiVanChuyen = N'" + txtPhiVC.Text.Trim() + "',TongTien = N'" + txtTongTien.Text.Trim() + "' where MaHangNhap = N'" + txtMaHD.Text.Trim() + "'";
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadCombobox(cbHangHoa, "TenHang", "MaHang", "select * from HANGHOA");
        }
        private void Clear()
        {
            txtMaHD.Text = "";
            cbHangHoa.SelectedItem = 0;
            txtNguoiNhap.Text = "";
            dtNgayNhap.Value = DateTime.Now;
            txtSL.Text = "";
            txtDongia.Text = "";
            txtPhiVC.Text = "";
            txtMT.Text = "";
            txtTongTien.Text = "";
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            TongTien();
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            TongTien();
        }

        private void txtPhiVC_TextChanged(object sender, EventArgs e)
        {
            TongTien();
        }
        private void TongTien()
        {
            if (txtDongia.Text.Trim() != "" && txtSL.Text.Trim() != "" && txtPhiVC.Text.Trim() != "")
            {
                float tong = 0;
                float dg = float.Parse(txtDongia.Text.Trim());
                int sl = int.Parse(txtSL.Text.Trim());
                float pvc = float.Parse(txtPhiVC.Text.Trim());
                tong = dg * sl + pvc;
                txtTongTien.Text = tong.ToString();
            }
        }
    }
}
