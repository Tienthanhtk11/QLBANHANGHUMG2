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
            
        }
        public frmNCC_ADD(String MaNCC, String Ten, String lh, String dc, String sdt)
        {
            InitializeComponent();
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }
        private void Clear()
        {

        }
    }
}
