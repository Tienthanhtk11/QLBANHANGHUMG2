using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.FORM;
using BLL;

namespace QuanLyBanHang.USERCONTROLS
{
    public partial class ucNhomHang : UserControl
    {
        public ucNhomHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmNhomHang().ShowDialog();
        }

        private void ucNhomHang_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadDatagridview(dataGridView1, tb_NhomHangBLL.layDuLieu());
        }
    }
}
