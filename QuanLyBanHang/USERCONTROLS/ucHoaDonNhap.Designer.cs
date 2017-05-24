namespace QuanLyBanHang.USERCONTROLS
{
    partial class ucHoaDonNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.MN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtFileExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDonNhap)).BeginInit();
            this.MN.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHoaDonNhap
            // 
            this.dataHoaDonNhap.AllowUserToAddRows = false;
            this.dataHoaDonNhap.AllowUserToDeleteRows = false;
            this.dataHoaDonNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataHoaDonNhap.BackgroundColor = System.Drawing.Color.White;
            this.dataHoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDonNhap.Location = new System.Drawing.Point(3, 30);
            this.dataHoaDonNhap.Name = "dataHoaDonNhap";
            this.dataHoaDonNhap.ReadOnly = true;
            this.dataHoaDonNhap.Size = new System.Drawing.Size(558, 345);
            this.dataHoaDonNhap.TabIndex = 5;
            this.dataHoaDonNhap.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoaDonNhap_CellClick);
            // 
            // MN
            // 
            this.MN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tảiLạiToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.sửaHóaĐơnToolStripMenuItem,
            this.xóaHóaĐơnToolStripMenuItem,
            this.inToolStripMenuItem,
            this.xuấtFileExcellToolStripMenuItem});
            this.MN.Name = "MN";
            this.MN.Size = new System.Drawing.Size(183, 136);
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tảiLạiToolStripMenuItem.Text = "Tải lại";
            this.tảiLạiToolStripMenuItem.Click += new System.EventHandler(this.tảiLạiToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.thêmToolStripMenuItem.Text = "Thêm hóa đơn nhập";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaHóaĐơnToolStripMenuItem
            // 
            this.sửaHóaĐơnToolStripMenuItem.Name = "sửaHóaĐơnToolStripMenuItem";
            this.sửaHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sửaHóaĐơnToolStripMenuItem.Text = "Sửa hóa đơn";
            this.sửaHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.sửaHóaĐơnToolStripMenuItem_Click);
            // 
            // xóaHóaĐơnToolStripMenuItem
            // 
            this.xóaHóaĐơnToolStripMenuItem.Name = "xóaHóaĐơnToolStripMenuItem";
            this.xóaHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.xóaHóaĐơnToolStripMenuItem.Text = "Xóa hóa đơn";
            this.xóaHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xóaHóaĐơnToolStripMenuItem_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.inToolStripMenuItem.Text = "In";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.inToolStripMenuItem_Click);
            // 
            // xuấtFileExcellToolStripMenuItem
            // 
            this.xuấtFileExcellToolStripMenuItem.Name = "xuấtFileExcellToolStripMenuItem";
            this.xuấtFileExcellToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.xuấtFileExcellToolStripMenuItem.Text = "Xuất file excell";
            this.xuấtFileExcellToolStripMenuItem.Click += new System.EventHandler(this.xuấtFileExcellToolStripMenuItem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(163, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightCoral;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(86, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(8, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "XEM CHI TIẾT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(463, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 23);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(300, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(157, 20);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // ucHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.MN;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataHoaDonNhap);
            this.Name = "ucHoaDonNhap";
            this.Size = new System.Drawing.Size(564, 407);
            this.Load += new System.EventHandler(this.ucNhapKho_Load);
            this.Resize += new System.EventHandler(this.ucNhapKho_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDonNhap)).EndInit();
            this.MN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataHoaDonNhap;
        private System.Windows.Forms.ContextMenuStrip MN;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileExcellToolStripMenuItem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
