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

        private void btnQLHH_Click(object sender, EventArgs e)
        {
            ucQuanLyHangHoa uc = new ucQuanLyHangHoa();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

            TealBackgroudAllBtn();
            btnQLHH.BackColor = Color.LightCoral;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnQLHH_Click(sender, e);
        }

        private void TealBackgroudAllBtn()
        {
            btnQLHH.BackColor = Color.Teal;
            btnQLKH.BackColor = Color.Teal;
            btnQLNCC.BackColor = Color.Teal;
            btnQLNV.BackColor = Color.Teal;
            btnQLNXK.BackColor = Color.Teal;
            btnHDN.BackColor = Color.Teal;
            btnBCBanNhieu.BackColor = Color.Teal;
            btnTonKho.BackColor = Color.Teal;
            button1.BackColor = Color.Teal;

        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            ucNhanVien uc = new ucNhanVien();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

       
            TealBackgroudAllBtn();
            btnQLNV.BackColor = Color.LightCoral;
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            ucKhachHang uc = new ucKhachHang();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

            TealBackgroudAllBtn();
            btnQLKH.BackColor = Color.LightCoral;
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            ucNhaCungCap uc = new ucNhaCungCap();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

            TealBackgroudAllBtn();
            btnQLNCC.BackColor = Color.LightCoral;
        }

        private void btnQLNXK_Click(object sender, EventArgs e)
        {
            ucXuatKho uc = new ucXuatKho();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

            TealBackgroudAllBtn();
            btnQLNXK.BackColor = Color.LightCoral;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucBCMatHangBanDuocNhieu uc = new ucBCMatHangBanDuocNhieu();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

            TealBackgroudAllBtn();
            btnBCBanNhieu.BackColor = Color.LightCoral;
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            ucNhapKho uc = new ucNhapKho();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

            TealBackgroudAllBtn();
            btnHDN.BackColor = Color.LightCoral;
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            ucHangTon uc = new ucHangTon();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

            TealBackgroudAllBtn();
            btnTonKho.BackColor = Color.LightCoral;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDangNhap().ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TealBackgroudAllBtn();
            button1.BackColor = Color.LightCoral;

            Thread.Sleep(500);

            frmBanHang f = new frmBanHang();
            f.ShowDialog();

            
        }
    }
}
