﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.ThongKe
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            i++; x[i] = 4; y[i] = 3; vanban[i] = Text;

            Export.ToExcel(dataGridView1, x, y, vanban);
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable dt = BLL.tb_NhaCungCapBLL.thongke();
            MethodLoad.LoadDatagridview(dataGridView1, dt);
        }
    }
}
