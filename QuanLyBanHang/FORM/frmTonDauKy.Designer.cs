namespace QuanLyBanHang.FORM
{
    partial class frmTonDauKy
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
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaTriTon = new System.Windows.Forms.TextBox();
            this.txtMaHT = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtNgayCapNhat = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(123, 91);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(171, 20);
            this.txtSoLuong.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(29, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(29, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Giá trị tồn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Mã hàng tồn";
            // 
            // txtGiaTriTon
            // 
            this.txtGiaTriTon.Location = new System.Drawing.Point(123, 117);
            this.txtGiaTriTon.Name = "txtGiaTriTon";
            this.txtGiaTriTon.Size = new System.Drawing.Size(171, 20);
            this.txtGiaTriTon.TabIndex = 74;
            // 
            // txtMaHT
            // 
            this.txtMaHT.Location = new System.Drawing.Point(123, 39);
            this.txtMaHT.Name = "txtMaHT";
            this.txtMaHT.Size = new System.Drawing.Size(171, 20);
            this.txtMaHT.TabIndex = 71;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Teal;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHuy.Location = new System.Drawing.Point(219, 143);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 88;
            this.btnHuy.Text = "&HỦY BỎ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightCoral;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(138, 143);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 87;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(29, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Ngày cập nhật";
            // 
            // dtNgayCapNhat
            // 
            this.dtNgayCapNhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayCapNhat.Location = new System.Drawing.Point(123, 65);
            this.dtNgayCapNhat.Name = "dtNgayCapNhat";
            this.dtNgayCapNhat.Size = new System.Drawing.Size(171, 20);
            this.dtNgayCapNhat.TabIndex = 89;
            // 
            // frmTonDauKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 215);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtNgayCapNhat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiaTriTon);
            this.Controls.Add(this.txtMaHT);
            this.Name = "frmTonDauKy";
            this.Text = "frmTonDauKy";
            this.Load += new System.EventHandler(this.frmTonDauKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTriTon;
        private System.Windows.Forms.TextBox txtMaHT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgayCapNhat;
    }
}