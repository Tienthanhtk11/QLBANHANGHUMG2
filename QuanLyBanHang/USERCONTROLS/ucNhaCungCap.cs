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
    public partial class ucNhaCungCap : UserControl
    {
        int rows = 0;
        public ucNhaCungCap()
        {
            InitializeComponent();
        }

        private void ucNhaCungCap_Load(object sender, EventArgs e)
        {
            Default.SetDefaultDataGridView(dtgNCC);
            MethodLoad.LoadDatagridview(dtgNCC, @"SELECT[MaNhaCungCap] 'Mã nhà cung cấp'
                                                      ,[TenNhaCungCap] 'Tên nhà cung cấp'
                                                      ,[DiaChi] 'Địa chỉ'
                                                      ,[SDT] 'Số điện thoại liên lạc'
                                                  FROM[dbo].[tb_NhaCungCap]");
        }

        private void dtgNCC_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rows = e.RowIndex;
            lblNCC.Text = dtgNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void tảiLạiF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucNhaCungCap_Load(sender, e);
        }

        private void thêmNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNCC_ADD frm = new frmNCC_ADD();
            frm.FormClosed += DongTab;
            frm.ShowDialog();
        }

        private void DongTab(object sender, FormClosedEventArgs e)
        {
            ucNhaCungCap_Load(sender, e);
        }

        private void sửaNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblNCC.Text.Trim() != "")
            {
                string ma = dtgNCC.Rows[rows].Cells[0].Value.ToString();
                string ten = dtgNCC.Rows[rows].Cells[1].Value.ToString();
                string lh = dtgNCC.Rows[rows].Cells[2].Value.ToString();
                string dc = dtgNCC.Rows[rows].Cells[3].Value.ToString();
                string sdt = dtgNCC.Rows[rows].Cells[4].Value.ToString();
                frmNCC_ADD frm = new frmNCC_ADD(ma,ten,lh,dc,sdt);
                frm.FormClosed += DongTab;
                frm.ShowDialog();
            }else
            {
                MessageBox.Show("Bạn chưa chọn NCC");
            }
        }

        private void xóaNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblNCC.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        Unility.ExcuteSQL("Delete NHACC where MaNCC = N'" + lblNCC.Text.Trim()+"'");
                        MessageBox.Show("Xóa thành công");
                        ucNhaCungCap_Load(sender, e);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại: " + ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn NCC");
            }
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodLoad.InDt(dtgNCC);
        }

        private void xuấtRaFileExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dtgNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            thêmNhàCungCấpToolStripMenuItem_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sửaNhàCungCấpToolStripMenuItem_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xóaNhàCungCấpToolStripMenuItem_Click(sender, e);
        }
    }
}
