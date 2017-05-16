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
    public partial class frmChiTietHDban : Form
    {
        private string mahdban;

        public frmChiTietHDban()
        {
            InitializeComponent();
        }

        public frmChiTietHDban(string v)
        {
            InitializeComponent();
            this.mahdban = v;
        }

        private void frmChiTietHDban_Load(object sender, EventArgs e)
        {
            Text = "Chi tiết hóa đơn bán " + mahdban;
            txtMaHD.Text = mahdban;
            BLL.tb_MatHangBLL.loadCb(cbMatHang);
            btnTaiLai_Click(sender, e);
            //-------------------
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
            MethodLoad.LoadDatagridview(dataGridView1, BLL.tb_ChiTietHoaDonBanBLL.layDuLieuSoHD(mahdban));
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
            DBO.tb_ChiTietHoaDonBanDBO obj = new DBO.tb_ChiTietHoaDonBanDBO
            {
                DonGia = Convert.ToDouble(txtDG.Text),
                MaCTHDB = txtMaCTHD.Text,
                SoLuong = Convert.ToInt16(txtSL.Text),
                MaHoaDonBan = txtMaHD.Text,
                MaMatHang = cbMaHang.Text
            };
            if (BLL.tb_ChiTietHoaDonBanBLL.kiemTraTonTai(obj) == 0)
            {
                BLL.tb_ChiTietHoaDonBanBLL.them(obj);
                btnTaiLai_Click(sender, e);
            }
            else
                MessageBox.Show("Đã trùng mã chi tiết HĐ");


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DBO.tb_ChiTietHoaDonBanDBO obj = new DBO.tb_ChiTietHoaDonBanDBO
            {
                DonGia = Convert.ToDouble(txtDG.Text),
                MaCTHDB = txtMaCTHD.Text,
                SoLuong = Convert.ToInt16(txtSL.Text),
                MaHoaDonBan = txtMaHD.Text,
                MaMatHang = cbMaHang.Text
            };
            BLL.tb_ChiTietHoaDonBanBLL.xoa(obj);
            BLL.tb_ChiTietHoaDonBanBLL.them(obj);

            btnTaiLai_Click(sender, e);

            //if (BLL.tb_ChiTietHoaDonNhapBLL.kiemTraTonTai(obj) == 0)
            //    BLL.tb_ChiTietHoaDonNhapBLL.them(obj);
            //else
            //    MessageBox.Show("Đã trùng");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Xoá chứ?", "Thông báo", MessageBoxButtons.YesNo))
            {
                DBO.tb_ChiTietHoaDonBanDBO obj = new DBO.tb_ChiTietHoaDonBanDBO
                {
                    DonGia = Convert.ToDouble(txtDG.Text),
                    MaCTHDB = txtMaCTHD.Text,
                    SoLuong = Convert.ToInt16(txtSL.Text),
                    MaHoaDonBan = txtMaHD.Text,
                    MaMatHang = cbMaHang.Text
                };
                BLL.tb_ChiTietHoaDonBanBLL.xoa(obj);

                btnTaiLai_Click(sender, e);
            }
        }
    }
}
