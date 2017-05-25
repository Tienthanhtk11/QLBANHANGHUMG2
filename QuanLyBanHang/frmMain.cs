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
        int quyen = 0;
        TaiKhoan TTTKM = new TaiKhoan();
        public frmMain(TaiKhoan TTTK)
        {
            InitializeComponent();
            quyen = TTTK.Role;
            TTTKM = TTTK;

            
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
            System.Windows.Forms.Application.Exit();
        }

        private void mẶTHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.BackgroundImage = null;
            ucQuanLyHangHoa uc = new ucQuanLyHangHoa();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }
        private void preview(Boolean Q)
        {
            nHÓMHÀNGToolStripMenuItem.Enabled = Q;
            mẶTHÀNGToolStripMenuItem.Enabled = Q;
            nHÀCUNGCẤPToolStripMenuItem.Enabled = Q;
            kHÁCHHÀNGToolStripMenuItem.Enabled = Q;
            nHÂNVIÊNToolStripMenuItem.Enabled = Q;
            pHÒNGBANToolStripMenuItem.Enabled = Q;
            tÌMKIẾMToolStripMenuItem.Enabled = Q;
            tỒNĐẦUKỲToolStripMenuItem.Enabled = Q;
            lẬPPHIẾUNHẬPKHOToolStripMenuItem.Enabled = Q;
            lẬPPHIẾUXUẤTKHOToolStripMenuItem.Enabled = Q;
            lẬPHÓAĐƠNToolStripMenuItem.Enabled = Q;
            nHÓMHÀNGToolStripMenuItem1.Enabled = Q;
            hÀNGHÓAToolStripMenuItem.Enabled = Q;
            nHÂNVIÊNToolStripMenuItem1.Enabled = Q;
            kHÁCHHÀNGToolStripMenuItem1.Enabled = Q;
            nHẦSẢNXUẤTToolStripMenuItem.Enabled = Q;
            pHÒNGBANToolStripMenuItem1.Enabled = Q;
            hÓAĐƠNBÁNToolStripMenuItem1.Enabled = Q;
            bÁOCÁODOANHTHUToolStripMenuItem.Enabled = Q;
            bÁOCÁOBÁNHÀNGToolStripMenuItem.Enabled = Q;
            bÁOCÁOTỒNKHOToolStripMenuItem.Enabled = Q;
        }
        private void User()
        {
            tÌMKIẾMToolStripMenuItem.Enabled = true;
        }
        private void Manager()
        {
            Boolean Q = true;
            tỒNĐẦUKỲToolStripMenuItem.Enabled = Q;
            lẬPPHIẾUNHẬPKHOToolStripMenuItem.Enabled = Q;
            lẬPPHIẾUXUẤTKHOToolStripMenuItem.Enabled = Q;
            lẬPHÓAĐƠNToolStripMenuItem.Enabled = Q;
            nHÓMHÀNGToolStripMenuItem1.Enabled = Q;
            hÀNGHÓAToolStripMenuItem.Enabled = Q;
            nHÂNVIÊNToolStripMenuItem1.Enabled = Q;
            kHÁCHHÀNGToolStripMenuItem1.Enabled = Q;
            nHẦSẢNXUẤTToolStripMenuItem.Enabled = Q;
            pHÒNGBANToolStripMenuItem1.Enabled = Q;
            hÓAĐƠNBÁNToolStripMenuItem1.Enabled = Q;
            bÁOCÁODOANHTHUToolStripMenuItem.Enabled = Q;
            bÁOCÁOBÁNHÀNGToolStripMenuItem.Enabled = Q;
            bÁOCÁOTỒNKHOToolStripMenuItem.Enabled = Q;
        }
        Image main;
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (quyen == 0)
            {
                preview(false);
            }
            else if (quyen == 1)
            {
                preview(true);
            }
            else if (quyen == 2)
            {
                Manager();
            }
            else if (quyen == 3)
            {
                User();
            }
            main = pnlMain.BackgroundImage;
            DEFAULT = pnlMain;
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

        private void đĂNGNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDangNhap().Show();
        }

        private void bÁOCÁODOANHTHUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAOCAO.frmDoanhThu frm = new BAOCAO.frmDoanhThu();
            frm.ShowDialog();
        }

        private void bÁOCÁOBÁNHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAOCAO.frmBanHang frm = new BAOCAO.frmBanHang();
            frm.ShowDialog();
        }

        private void bÁOCÁOTỒNKHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAOCAO.frmTonKho frm = new BAOCAO.frmTonKho();
            frm.ShowDialog();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTTKM.Clear();
            Hide();
            frmDangNhap form2 = new frmDangNhap();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void đỔIMẬTKHẨUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePass frm = new frmChangePass(TTTKM);
            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void nHÓMHÀNGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ThongKe.NhomHang().ShowDialog();
        }

        private void hÀNGHÓAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ThongKe.HangHoa().ShowDialog();
        }

        private void nHÂNVIÊNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ThongKe.NhanVien().ShowDialog();
        }

        private void kHÁCHHÀNGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ThongKe.KhachHang().ShowDialog();
        }

        private void nHẦSẢNXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ThongKe.NhaCungCap().ShowDialog();
        }

        private void pHÒNGBANToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ThongKe.PhongBan().ShowDialog();
        }

        private void hÓAĐƠNBÁNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ThongKe.HoaDonBan().ShowDialog();
        }

        private void hÓAĐƠNNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ThongKe.HoaDonNhap().ShowDialog();
        }

        private void đĂNGKÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDangKy().ShowDialog();
        }

        private void tÌMKIẾMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTimKiem().ShowDialog();
        }

        private void trởLạiTrangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void bÁNHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBanHang().ShowDialog();
        }

        Panel DEFAULT = new Panel();
        private void tRỞLẠITRANGCHỦToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain = DEFAULT;
            pnlMain.BackgroundImage = main;
        }
    }
}
