using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    MethodLoad.LoadDatagridview(dataGridView1, 
                        BLL.tb_ChiTietHoaDonBanBLL.layDuLieuTimkiem(textBox1.Text));
                    break;
                case 1:
                    MethodLoad.LoadDatagridview(dataGridView1,
                        BLL.tb_ChiTietHoaDonNhapBLL.layDuLieuTimkiem(textBox1.Text));
                    break;
                case 2:
                    MethodLoad.LoadDatagridview(dataGridView1,
                        BLL.tb_HoaDonBanBLL.layDuLieuTimkiem(textBox1.Text));
                    break;
                case 3:
                    MethodLoad.LoadDatagridview(dataGridView1,
                        BLL.tb_HoaDonNhapBLL.layDuLieuTimkiem(textBox1.Text));
                    break;
                case 4:
                    MethodLoad.LoadDatagridview(dataGridView1,
                        BLL.tb_KhachHangBLL.layDuLieuTimkiem(textBox1.Text));
                    break;
                case 5:
                    MethodLoad.LoadDatagridview(dataGridView1,
                        BLL.tb_MatHangBLL.layDuLieuTimkiem(textBox1.Text));
                    break;
                default:
                    break;
                
            }

            textBox2.Text = comboBox1.Text + " " + textBox1.Text ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
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
            i++; x[i] = 5; y[i] = 3; vanban[i] = "";//string.Format("Từ ngày {0} đến ngày {1}", dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            i++; x[i] = 4; y[i] = 3; vanban[i] = textBox2.Text;

            ThongKe.Export.ToExcel(dataGridView1, x, y, vanban);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btnXuatEx.Enabled = textBox2.Text.Length != 0;
        }
    }
}
