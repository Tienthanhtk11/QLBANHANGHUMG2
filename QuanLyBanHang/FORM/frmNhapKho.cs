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
            
        }
        public frmNhapKho(string ma, string tenH, string NguoiNhap,DateTime ngay, string sl, string dongia, string phivc, string tongtien,string mota)
        {
            InitializeComponent();
            
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            
        }
        private void Clear()
        {
           
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhiVC_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void TongTien()
        {
           
        }
    }
}
