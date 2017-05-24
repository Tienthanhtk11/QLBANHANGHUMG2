using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QuanLyBanHang.ThongKe
{
    public partial class HoaDonNhap : Form
    {
        public HoaDonNhap()
        {
            InitializeComponent();
            Text = "HÓA ĐƠN NHẬP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = BLL.tb_HoaDonNhapBLL.thongke(dateTimePicker1, dateTimePicker2);
            MethodLoad.LoadDatagridview(dataGridView1, dt);
        }

        private void btnXuatEx_Click(object sender, EventArgs e)
        {

            int n = 6;
            int[] x = new int[n];
            int[] y = new int[n];
            string[] vanban = new string[n];

            //x là dòng, y là cột
            int i = 0; x[i] = 1; y[i] = 5; vanban[i] = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            i++; x[i] = 2; y[i] = 5; vanban[i] = "Độc lập - Tự do - Hạnh phúc";
            i++; x[i] = 1; y[i] = 1; vanban[i] = Program.tenCongTy;
            i++; x[i] = 2; y[i] = 1; vanban[i] = Program.slogan;
            i++; x[i] = 5; y[i] = 3; vanban[i] = string.Format("Từ ngày {0} đến ngày {1}", dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            i++; x[i] = 4; y[i] = 3; vanban[i] = Text;

            Export.ToExcel(dataGridView1, x, y, vanban);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tb_HoaDonNhapBLL.timKiem(txtTimKiem.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tb_HoaDonNhapBLL.timKiem(txtTimKiem.Text);
        }
    }
}
