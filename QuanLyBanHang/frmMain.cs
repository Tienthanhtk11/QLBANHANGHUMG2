using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.USERCONTROLS;
using QuanLyBanHang.FORM;
using System.Threading;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region TRASH
        //private void btnQLHH_Click(object sender, EventArgs e)
        //{
        //    ucQuanLyHangHoa uc = new ucQuanLyHangHoa();
        //    uc.Dock = DockStyle.Fill;
        //    pnlMain.Controls.Clear();
        //    pnlMain.Controls.Add(uc);

        //    TealBackgroudAllBtn();
        //    btnQLHH.BackColor = Color.LightCoral;
        //}

        //private void frmMain_Load(object sender, EventArgs e)
        //{
        //    btnQLHH_Click(sender, e);
        //}

        //private void TealBackgroudAllBtn()
        //{
        //    btnQLHH.BackColor = Color.Teal;
        //    btnQLKH.BackColor = Color.Teal;
        //    btnQLNCC.BackColor = Color.Teal;
        //    btnQLNV.BackColor = Color.Teal;
        //    btnQLNXK.BackColor = Color.Teal;
        //    btnHDN.BackColor = Color.Teal;
        //    btnBCBanNhieu.BackColor = Color.Teal;
        //    btnTonKho.BackColor = Color.Teal;
        //    button1.BackColor = Color.Teal;

        //}

        //private void btnQLNV_Click(object sender, EventArgs e)
        //{
        //    ucNhanVien uc = new ucNhanVien();
        //    uc.Dock = DockStyle.Fill;
        //    pnlMain.Controls.Clear();
        //    pnlMain.Controls.Add(uc);


        //    TealBackgroudAllBtn();
        //    btnQLNV.BackColor = Color.LightCoral;
        //}

        //private void btnQLKH_Click(object sender, EventArgs e)
        //{
        //    ucKhachHang uc = new ucKhachHang();
        //    uc.Dock = DockStyle.Fill;
        //    pnlMain.Controls.Clear();
        //    pnlMain.Controls.Add(uc);

        //    TealBackgroudAllBtn();
        //    btnQLKH.BackColor = Color.LightCoral;
        //}

        //private void btnQLNCC_Click(object sender, EventArgs e)
        //{
        //    ucNhaCungCap uc = new ucNhaCungCap();
        //    uc.Dock = DockStyle.Fill;
        //    pnlMain.Controls.Clear();
        //    pnlMain.Controls.Add(uc);

        //    TealBackgroudAllBtn();
        //    btnQLNCC.BackColor = Color.LightCoral;
        //}

        //private void btnQLNXK_Click(object sender, EventArgs e)
        //{
        //    ucXuatKho uc = new ucXuatKho();
        //    uc.Dock = DockStyle.Fill;
        //    pnlMain.Controls.Clear();
        //    pnlMain.Controls.Add(uc);

        //    TealBackgroudAllBtn();
        //    btnQLNXK.BackColor = Color.LightCoral;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ucBCMatHangBanDuocNhieu uc = new ucBCMatHangBanDuocNhieu();
        //    uc.Dock = DockStyle.Fill;
        //    pnlMain.Controls.Clear();
        //    pnlMain.Controls.Add(uc);

        //    TealBackgroudAllBtn();
        //    btnBCBanNhieu.BackColor = Color.LightCoral;
        //}

        //private void btnHDN_Click(object sender, EventArgs e)
        //{
        //    ucNhapKho uc = new ucNhapKho();
        //    uc.Dock = DockStyle.Fill;
        //    pnlMain.Controls.Clear();
        //    pnlMain.Controls.Add(uc);

        //    TealBackgroudAllBtn();
        //    btnHDN.BackColor = Color.LightCoral;
        //}

        //private void btnTonKho_Click(object sender, EventArgs e)
        //{
        //    ucHangTon uc = new ucHangTon();
        //    uc.Dock = DockStyle.Fill;
        //    pnlMain.Controls.Clear();
        //    pnlMain.Controls.Add(uc);

        //    TealBackgroudAllBtn();
        //    btnTonKho.BackColor = Color.LightCoral;
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new frmDangNhap().ShowDialog();
        //}

        //private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    TealBackgroudAllBtn();
        //    button1.BackColor = Color.LightCoral;

        //    Thread.Sleep(500);

        //    frmBanHang f = new frmBanHang();
        //    f.ShowDialog();


        //}

        #endregion

        private void ẩNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pHÓNGTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void tHOÁTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void mẶTHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucQuanLyHangHoa uc = new ucQuanLyHangHoa();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void nHÀCUNGCẤPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucNhaCungCap uc = new ucNhaCungCap();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucKhachHang uc = new ucKhachHang();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void lẬPPHIẾUNHẬPKHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucHoaDonNhap uc = new ucHoaDonNhap();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void lẬPPHIẾUXUẤTKHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucXuatKho uc = new ucXuatKho();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void nHÓMHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucNhomHang uc = new ucNhomHang();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void pHÒNGBANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucPhongBan uc = new ucPhongBan();

            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void hÓAĐƠNBÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pnlMain.BackgroundImage = null;
            ucHoaDonBan uc = new ucHoaDonBan();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
       
        }

        private void hÓAĐƠNNHẬPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void hÓAĐƠNNHẬPToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucHoaDonNhap uc = new ucHoaDonNhap();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
         
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucNhanVien uc = new ucNhanVien();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void tỒNĐẦUKỲToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucTonDauKy uc = new ucTonDauKy();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void bÁOCÁOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
