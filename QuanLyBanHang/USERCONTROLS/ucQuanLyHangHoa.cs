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

namespace QuanLyBanHang.USERCONTROLS
{
    public partial class ucQuanLyHangHoa : UserControl
    {
        int rows = 0;
        public ucQuanLyHangHoa()
        {
            InitializeComponent();
        }

        private void thêmĐơnLẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa_ADD f = new frmHangHoa_ADD();
            f.FormClosed += DongTab;
            f.ShowDialog();
        }
        private void DongTab(object sender, FormClosedEventArgs e)
        {
            ucQuanLyHangHoa_Load(sender, e);
        }
        private void ucQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            Default.SetDefaultDataGridView(dataHangHoa);
            //MethodLoad.LoadCombobox(cbNhomHang, "TenNhom", "MaNhom", "Select * from NHOMHANG");
            //MethodLoad.LoadCombobox(cbNCC, "TenNCC", "MaNCC", "Select * from NHACC");

            MethodLoad.LoadDatagridview(dataHangHoa, @"SELECT [MaMatHang] 'Mă mặt hàng'
                                                          ,[TenMatHang] 'Tên mặt hàng'
                                                          ,TenNhaCungCap 'Nhà cung cấp'
                                                          ,TenNhomHang 'Mã nhóm hàng'
                                                          ,[DVT] 'Đơn vị tính'
                                                          ,[GiaBan] 'Giá bán'
                                                          ,[NgayCapNhat] 'Ngày cập nhật'
                                                      FROM [dbo].[tb_MatHang]
                                                      inner join tb_NhaCungCap on tb_MatHang.MaNhaCungCap = tb_NhaCungCap.MaNhaCungCap
                                                      inner join tb_NhomHang on tb_MatHang.MaNhomHang = tb_NhomHang.MaNhomHang");
            //cbNhomHang.Text = "";
            //cbNCC.Text = "";
            //lblNhomH.Visible = true;
            //lblNCC.Visible = true;
        }

        private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucQuanLyHangHoa_Load(sender, e);
        }

        private void nhậpTừExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemTrướcBảnInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodLoad.InDt(dataHangHoa);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void thêmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void sửaHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string ma = dataHangHoa.Rows[rows].Cells[0].Value.ToString();
            string ten = dataHangHoa.Rows[rows].Cells[1].Value.ToString();
            string manhom = dataHangHoa.Rows[rows].Cells[2].Value.ToString();
            string manhacc = dataHangHoa.Rows[rows].Cells[3].Value.ToString();
            string donvitinh = dataHangHoa.Rows[rows].Cells[4].Value.ToString();
            string soluong = dataHangHoa.Rows[rows].Cells[5].Value.ToString();
            string dongia = dataHangHoa.Rows[rows].Cells[6].Value.ToString();
            frmHangHoa_ADD frm = new frmHangHoa_ADD(ma, ten, manhom, manhacc, donvitinh,soluong,dongia);
            frm.FormClosed += DongTab;
            frm.ShowDialog();

        }

        private void xóaHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("Bạn có muốn xóa hàng hóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        Unility.ExcuteSQL("Delete HANGHOA where MaHang = N'" + dataHangHoa.Rows[rows].Cells[0].Value.ToString() + "'");
                        MessageBox.Show("Xóa thành công");
                        ucQuanLyHangHoa_Load(sender, e);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại: " + ex.ToString());
                    }
                }
        }

        private void dataHangHoa_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rows = e.RowIndex;
        }

        private void lblNhomH_Click(object sender, EventArgs e)
        {
            cbNhomHang.Focus();
        }

        private void lblNCC_Click(object sender, EventArgs e)
        {
            cbNCC.Focus();
        }

        private void cbNhomHang_TextChanged(object sender, EventArgs e)
        {
            lblNhomH.Visible = cbNhomHang.Text.Length == 0;
        }

        private void cbNCC_TextChanged(object sender, EventArgs e)
        {
            lblNCC.Visible = cbNCC.Text.Length == 0;
        }

        private void cbNhomHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNhomH.Visible = false;
            string sql = string.Format("Select MaHang'Mã Hàng',TenHang'Tên Hàng',TenNhom'Tên Nhóm',TenNCC'Tên nhà cung cấp',DVT'Đơn vị tính',SoLuongCon'Số lượng còn',DonGia'Đơn giá' from HANGHOA inner join NHOMHANG on HANGHOA.MaNhom=NHOMHANG.MaNhom inner join NHACC on HANGHOA.MaNCC=NHACC.MaNCC where HANGHOA.MaNhom like N'{0}'", cbNhomHang.SelectedValue.ToString());
            MethodLoad.LoadDatagridview(dataHangHoa,sql );
        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNCC.Visible = false;
            string sql = string.Format("Select MaHang'Mã Hàng', TenHang'Tên Hàng', TenNhom'Tên Nhóm', TenNCC'Tên nhà cung cấp', DVT'Đơn vị tính', SoLuongCon'Số lượng còn', DonGia'Đơn giá' from HANGHOA inner join NHOMHANG on HANGHOA.MaNhom = NHOMHANG.MaNhom inner join NHACC on HANGHOA.MaNCC = NHACC.MaNCC where NHACC.MaNCC like N'{0}'", cbNCC.SelectedValue.ToString());
            MethodLoad.LoadDatagridview(dataHangHoa, sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            thêmĐơnLẻToolStripMenuItem_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sửaHàngHóaToolStripMenuItem_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xóaHàngHóaToolStripMenuItem_Click(sender, e);
        }
    }
}
