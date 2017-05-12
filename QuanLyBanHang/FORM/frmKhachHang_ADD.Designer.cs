namespace QuanLyBanHang.FORM
{
    partial class frmKhachHang_ADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang_ADD));
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtDCKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOKKH = new System.Windows.Forms.Button();
            this.btnHuyBoKH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(125, 64);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(171, 20);
            this.txtSDTKH.TabIndex = 9;
            // 
            // txtDCKH
            // 
            this.txtDCKH.Location = new System.Drawing.Point(125, 90);
            this.txtDCKH.Multiline = true;
            this.txtDCKH.Name = "txtDCKH";
            this.txtDCKH.Size = new System.Drawing.Size(171, 95);
            this.txtDCKH.TabIndex = 10;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(125, 40);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(171, 20);
            this.txtTenKH.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(125, 14);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(171, 20);
            this.txtMaKH.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "MÃ KHÁCH HÀNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "TÊN KHÁCH HÀNG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ĐỊA CHỈ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "SỐ ĐIỆN THOẠI";
            // 
            // btnOKKH
            // 
            this.btnOKKH.BackColor = System.Drawing.Color.Crimson;
            this.btnOKKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKKH.ForeColor = System.Drawing.Color.White;
            this.btnOKKH.Location = new System.Drawing.Point(125, 191);
            this.btnOKKH.Name = "btnOKKH";
            this.btnOKKH.Size = new System.Drawing.Size(75, 23);
            this.btnOKKH.TabIndex = 16;
            this.btnOKKH.Text = "OK";
            this.btnOKKH.UseVisualStyleBackColor = false;
            this.btnOKKH.Click += new System.EventHandler(this.btnOKKH_Click);
            // 
            // btnHuyBoKH
            // 
            this.btnHuyBoKH.BackColor = System.Drawing.Color.Teal;
            this.btnHuyBoKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBoKH.ForeColor = System.Drawing.Color.White;
            this.btnHuyBoKH.Location = new System.Drawing.Point(221, 191);
            this.btnHuyBoKH.Name = "btnHuyBoKH";
            this.btnHuyBoKH.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBoKH.TabIndex = 17;
            this.btnHuyBoKH.Text = "Hủy Bỏ";
            this.btnHuyBoKH.UseVisualStyleBackColor = false;
            this.btnHuyBoKH.Click += new System.EventHandler(this.btnHuyBoKH_Click);
            // 
            // frmKhachHang_ADD
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 220);
            this.Controls.Add(this.btnHuyBoKH);
            this.Controls.Add(this.btnOKKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.txtDCKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKhachHang_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmKhachHang_ADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtDCKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOKKH;
        private System.Windows.Forms.Button btnHuyBoKH;
    }
}