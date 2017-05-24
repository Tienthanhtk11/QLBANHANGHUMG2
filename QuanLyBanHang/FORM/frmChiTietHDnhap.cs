using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BLL;
namespace QuanLyBanHang.FORM
{
    public partial class frmChiTietHDnhap : Form
    {
        private string mahoadonnhap;

        public frmChiTietHDnhap()
        {
            InitializeComponent();
        }

        public frmChiTietHDnhap(string mahoadonnhap)
        {
            InitializeComponent();
            this.mahoadonnhap = mahoadonnhap;
        }

        private void frmChiTietHDnhap_Load(object sender, EventArgs e)
        {
            Text = "Chi tiết hóa đơn nhập " + mahoadonnhap;
            txtMaHD.Text = mahoadonnhap;
            BLL.tb_MatHangBLL.loadCb(cbMatHang);
            btnTaiLai_Click(sender, e);

           
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void cbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaHang.Text = cbMatHang.SelectedValue.ToString();
            //Thread.Sleep(3000);
            //txtDG.Text = BLL.tb_MatHangBLL.layDonGia(cbMatHang.SelectedValue.ToString());
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCTHD.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSL.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDG.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbMatHang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            MethodLoad.LoadDatagridview(dataGridView1, BLL.tb_ChiTietHoaDonNhapBLL.layDuLieuSoHD(mahoadonnhap));
            dataGridView1.Columns[1].Visible = false;
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double sl = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString());
                double dg = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());
                sum += sl * dg;

                lbTong.Text = sum.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DBO.tb_ChiTietHoaDonNhapDBO obj = new DBO.tb_ChiTietHoaDonNhapDBO
            {
                DonGia = Convert.ToDouble(txtDG.Text),
                MaCTHDN = txtMaCTHD.Text,
                SoLuong = Convert.ToInt16(txtSL.Text),
                MaHoaDonNhap = txtMaHD.Text,
                MaMatHang = cbMaHang.Text
            };
            if (BLL.tb_ChiTietHoaDonNhapBLL.kiemTraTonTai(obj) == 0)
            {
                BLL.tb_ChiTietHoaDonNhapBLL.them(obj);
                btnTaiLai_Click(sender, e);
            }
            else
                MessageBox.Show("Đã trùng");

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DBO.tb_ChiTietHoaDonNhapDBO obj = new DBO.tb_ChiTietHoaDonNhapDBO
            {
                DonGia = Convert.ToDouble(txtDG.Text),
                MaCTHDN = txtMaCTHD.Text,
                SoLuong = Convert.ToInt16(txtSL.Text),
                MaHoaDonNhap = txtMaHD.Text,
                MaMatHang = cbMaHang.Text
            };
            BLL.tb_ChiTietHoaDonNhapBLL.xoa(obj);
            BLL.tb_ChiTietHoaDonNhapBLL.them(obj);

            btnTaiLai_Click(sender, e);

            //if (BLL.tb_ChiTietHoaDonNhapBLL.kiemTraTonTai(obj) == 0)
            //    BLL.tb_ChiTietHoaDonNhapBLL.them(obj);
            //else
            //    MessageBox.Show("Đã trùng");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Xoá chứ?","Thông báo",MessageBoxButtons.YesNo))
            {
                DBO.tb_ChiTietHoaDonNhapDBO obj = new DBO.tb_ChiTietHoaDonNhapDBO
                {
                    DonGia = Convert.ToDouble(txtDG.Text),
                    MaCTHDN = txtMaCTHD.Text,
                    SoLuong = Convert.ToInt16(txtSL.Text),
                    MaHoaDonNhap = txtMaHD.Text,
                    MaMatHang = cbMaHang.Text
                };
                BLL.tb_ChiTietHoaDonNhapBLL.xoa(obj);

                btnTaiLai_Click(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tb_ChiTietHoaDonNhapBLL.timKiem(txtTimKiem.Text);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tb_ChiTietHoaDonNhapBLL.timKiem(txtTimKiem.Text);
        }
    }
}
