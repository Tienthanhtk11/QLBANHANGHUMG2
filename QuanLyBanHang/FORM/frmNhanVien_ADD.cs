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
           
        }
        public frmNhanVien_ADD(String MaNV, String MaThe, String HoTen, String GioiTinh, DateTime NgaySinh, String NgoaiTru, String SoDT,String QueQuan)
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

        private void frmHangHoa_ADD_Load(object sender, EventArgs e)
        {
      
        }
    }
}
