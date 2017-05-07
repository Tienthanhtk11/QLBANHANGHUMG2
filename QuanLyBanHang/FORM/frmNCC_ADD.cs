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
    public partial class frmNCC_ADD : Form
    {
        Boolean flag = true;
        public frmNCC_ADD()
        {
            InitializeComponent();
            btnOK.Text = "&Thêm";
            flag = true;
        }
        public frmNCC_ADD(String MaNCC, String Ten, String lh, String dc, String sdt)
        {
            InitializeComponent();
            btnOK.Text = "&Sửa";
            flag = false;
            txtMa.Text = MaNCC;
            txtLH.Text = lh;
            txtDC.Text = dc;
            txtSDT.Text = sdt;
            txtTen.Text = Ten;
            txtMa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() != "" && txtSDT.Text.Trim() != "" && txtTen.Text.Trim() != "" && txtLH.Text.Trim() != "" && txtDC.Text.Trim() != "")
            {
                if (flag)
                {
                    string sql = "insert into NHACC values(N'" + txtMa.Text.Trim() + "',N'" + txtTen.Text.Trim() + "',N'" + txtLH.Text.Trim() + "',N'" + txtDC.Text.Trim() + "',N'" + txtSDT.Text.Trim() + "')";
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
                    string sql = "update NHACC set TenNCC = N'"+txtTen.Text.Trim()+ "', LienHe = N'" + txtLH.Text.Trim() + "', DiaChi = N'" + txtDC.Text.Trim() + "',SoDT = N'" + txtSDT.Text.Trim() + "' where MaNCC = N'"+txtMa.Text.Trim()+"'";
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
            }else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }
        private void Clear()
        {
            txtMa.Text = "";
            txtLH.Text = "";
            txtDC.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";
        }
    }
}
