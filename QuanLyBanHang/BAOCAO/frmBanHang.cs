﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.BAOCAO
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodLoad.Datagridview(dataGridView1);
            DataTable dt = BLL.tb_HoaDonBanBLL.layDuLieuBaoCao(
                dateTimePicker1.Value,
                dateTimePicker2.Value
                );
            dataGridView1.DataSource = dt;

            //Thread.Sleep(3000);
            double sum = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double gtriHD = Convert.ToDouble(dt.Rows[i][6]);
                sum += gtriHD;
            }
            lblDT.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
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
                i++; x[i] = 4; y[i] = 3; vanban[i] = "BÁO CÁO BÁN HÀNG";

                ExportBaoCao.ExportXLSX(dataGridView1, x, y, vanban);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để báo cáo");
            }
        }
        string mahd = "";
        private void button3_Click(object sender, EventArgs e)
        {
            //FORM.frmChiTietHDban f = new FORM.frmChiTietHDban(mahd);
            //f.FormClosed += F_FormClosed;
            //f.ShowDialog();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                mahd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
