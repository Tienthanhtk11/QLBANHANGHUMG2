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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOKKH = new System.Windows.Forms.Button();
            this.btnHuyBoKH = new System.Windows.Forms.Button();
            this.cbbGioiTinhKH = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(125, 95);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(171, 20);
            this.txtSDTKH.TabIndex = 9;
            // 
            // txtDCKH
            // 
            this.txtDCKH.Location = new System.Drawing.Point(125, 129);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "GIỚI TÍNH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ĐỊA CHỈ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 102);
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
            this.btnOKKH.Location = new System.Drawing.Point(125, 230);
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
            this.btnHuyBoKH.Location = new System.Drawing.Point(221, 230);
            this.btnHuyBoKH.Name = "btnHuyBoKH";
            this.btnHuyBoKH.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBoKH.TabIndex = 17;
            this.btnHuyBoKH.Text = "Hủy Bỏ";
            this.btnHuyBoKH.UseVisualStyleBackColor = false;
            this.btnHuyBoKH.Click += new System.EventHandler(this.btnHuyBoKH_Click);
            // 
            // cbbGioiTinhKH
            // 
            this.cbbGioiTinhKH.FormattingEnabled = true;
            this.cbbGioiTinhKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinhKH.Location = new System.Drawing.Point(125, 66);
            this.cbbGioiTinhKH.Name = "cbbGioiTinhKH";
            this.cbbGioiTinhKH.Size = new System.Drawing.Size(171, 21);
            this.cbbGioiTinhKH.TabIndex = 18;
            // 
            // frmKhachHang_ADD
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 263);
            this.Controls.Add(this.cbbGioiTinhKH);
            this.Controls.Add(this.btnHuyBoKH);
            this.Controls.Add(this.btnOKKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOKKH;
        private System.Windows.Forms.Button btnHuyBoKH;
        private System.Windows.Forms.ComboBox cbbGioiTinhKH;
    }
}