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
            Default.SetDefaultDataGridView(dataGridView1);
            dataGridView1.DataSource = Unility.getDataTable("Select MaHang as N'Mã hàng', TenHang N'Tên hàng', SoLuongCon N'Số lượng còn', DonGia 'Đơn giá' from HangHoa");

            MethodLoad.LoadCombobox(cbxKH, "TenKH", "MaKH", "select * from KhachHang");
            MethodLoad.LoadCombobox(cbxNhanVien, "HoTen", "MaNV", "select * from NHANVIEN");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double tong = 0;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    bool tick = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                    if (tick)
                    {
                        double soLuong = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        double donGia = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        tong += soLuong * donGia;
                    }
                }
                txtTT.Text = tong.ToString();
            }
            catch(Exception ex) { MessageBox.Show("Hãy nhập số lượng!\n"+ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            bool conHang = true;
            try
            {
                string ngayLap = dateNB.Value.ToString("MM/dd/yyyy");
                string MaNV = cbxNhanVien.SelectedValue.ToString();
                string MaKH = cbxKH.SelectedValue.ToString();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    bool tick = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                    if (tick)
                    {
                        conHang = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) 
                            - Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value) >= 0;
                        if (conHang)
                        {

                            string MaHang = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            string SoLuong = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            string soHD = DateTime.Now.ToString("HmmssMMddyyyy") + MaNV + MaKH + MaHang + SoLuong;
                            string sql = string.Format("insert into HOADON(SoHD,NgayLapHD,MaNV,MaKH,MaHang,SoLuongMua) values('{0}','{1}','{2}','{3}','{4}','{5}')", soHD, ngayLap, MaNV, MaKH, MaHang, SoLuong);
                            Unility.ExcuteSQL(sql);
                        }
                        else
                        {
                            string MaHang = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            MessageBox.Show("Mã hàng: " +MaHang +" - không đủ lượng để xuất, lập hóa đơn không thành công");
                            break;
                        }
                    }

                }
                MessageBox.Show(conHang? "Thành công\n" : "Xin kiểm tra lại mặt hàng vừa nhập!\n");
                //Dispose();
            }
            catch (Exception ex){ MessageBox.Show("\n" + ex.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
