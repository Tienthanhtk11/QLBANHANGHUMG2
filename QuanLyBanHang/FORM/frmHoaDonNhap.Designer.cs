namespace QuanLyBanHang.FORM
{
    partial class frmHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonNhap));
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.btnHuy, "btnHuy");
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtMaHD
            // 
            resources.ApplyResources(this.txtMaHD, "txtMaHD");
            this.txtMaHD.Name = "txtMaHD";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.FormattingEnabled = true;
            resources.ApplyResources(this.cbbMaNCC, "cbbMaNCC");
            this.cbbMaNCC.Name = "cbbMaNCC";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            resources.ApplyResources(this.cbbMaNV, "cbbMaNV");
            this.cbbMaNV.Name = "cbbMaNV";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtNgayNhap, "dtNgayNhap");
            this.dtNgayNhap.Name = "dtNgayNhap";
            // 
            // frmHoaDonNhap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.cbbMaNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmHoaDonNhap";
            this.Load += new System.EventHandler(this.frmHoaDon_ADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
    }
}