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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            MethodLoad.LoadCombobox(cbxNhanVien, BLL.tb_NhanVienBLL.layDuLieu(), "Mã nhân viên", "Tên nhân viên");
            MethodLoad.LoadCombobox(cbxKH, BLL.tb_KhachHangBLL.layDuLieu(), "Mã khách hàng", "Tên khách hàng");
            MethodLoad.LoadDatagridview(dataGridView1, BLL.tb_MatHangBLL.layDuLieuRutGon());
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;

            btnIn.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string check = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (check == "True")
                {
                    double sl = 0;
                    double dg = 0;
                    try
                    {
                        sl = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        dg = Convert.ToDouble(dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 1].Value.ToString());
                    }
                    catch { }
                    sum += sl * dg;
                }
            }
            txtTT.Text = sum.ToString();
        }
        string mahd;
        private void button1_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            if (DialogResult.Yes == MessageBox.Show("Thêm hóa đơn bán vào cơ sở dữ liệu?", "Thông báo", MessageBoxButtons.YesNo))
            {
                //Xác nhận bán
                DBO.tb_HoaDonBanDBO obj = new DBO.tb_HoaDonBanDBO();
                //Lấy số hóa đơn cuối +1
                obj.MaHoaDonBan = (Convert.ToInt32(BLL.tb_HoaDonBanBLL.layDuLieu().Rows[BLL.tb_HoaDonBanBLL.layDuLieu().Rows.Count - 1][0].ToString()) + 1).ToString();
                obj.NgayLap = DateTime.Now;
                obj.MaNhanVien = cbxNhanVien.SelectedValue.ToString();
                obj.MaKhachHang = cbxKH.SelectedValue.ToString();
                obj.TongThanhToan = Convert.ToDouble(txtTT.Text);
                obj.DaThanhToan = checkBox1.Checked;

                mahd = obj.MaHoaDonBan;

                BLL.tb_HoaDonBanBLL.them(obj);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string check = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (check == "True")
                    {
                        DBO.tb_ChiTietHoaDonBanDBO obj_ct = new DBO.tb_ChiTietHoaDonBanDBO();

                        obj_ct.MaHoaDonBan = obj.MaHoaDonBan;
                        obj_ct.MaMatHang = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        obj_ct.MaCTHDB = obj.MaHoaDonBan + "-" + obj_ct.MaMatHang;
                        obj_ct.DonGia = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        obj_ct.SoLuong = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());


                        BLL.tb_ChiTietHoaDonBanBLL.them(obj_ct);
                    }
                }
                MessageBox.Show("Đã xong");
                button1.Enabled = false;
                btnIn.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmBanHangIN(mahd).ShowDialog();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //trashhs
        }
    }
}
