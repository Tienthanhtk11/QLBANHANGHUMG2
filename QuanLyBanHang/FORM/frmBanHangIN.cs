using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyBanHang.FORM
{
    public partial class frmBanHangIN : Form
    {
        private string v;

        public frmBanHangIN()
        {
            InitializeComponent();
        }

        public frmBanHangIN(string v)
        {
            InitializeComponent();
            this.v = v;
        }

        private void frmBanHangIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangHUMGDataSet.View_1' table. You can move, or remove it, as needed.
            this.view_1TableAdapter.Fill(this.quanLyBanHangHUMGDataSet.View_1);


            reportViewer1.LocalReport.SetParameters(new ReportParameter("MaHDB", v));
            this.reportViewer1.RefreshReport();
        }
    }
}
