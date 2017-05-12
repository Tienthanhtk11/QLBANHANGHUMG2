namespace QuanLyBanHang.USERCONTROLS
{
    partial class ucKhachHang
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
            this.dataKhachHang = new System.Windows.Forms.DataGridView();
            this.VLL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemTrướcBảnInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtRaExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).BeginInit();
            this.VLL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataKhachHang
            // 
            this.dataKhachHang.AllowUserToAddRows = false;
            this.dataKhachHang.AllowUserToDeleteRows = false;
            this.dataKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhachHang.ContextMenuStrip = this.VLL;
            this.dataKhachHang.Location = new System.Drawing.Point(3, 3);
            this.dataKhachHang.Name = "dataKhachHang";
            this.dataKhachHang.ReadOnly = true;
            this.dataKhachHang.Size = new System.Drawing.Size(552, 354);
            this.dataKhachHang.TabIndex = 7;
            this.dataKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKhachHang_CellClick);
            this.dataKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKhachHang_CellContentClick);
            this.dataKhachHang.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKhachHang_CellEnter);
            // 
            // VLL
            // 
            this.VLL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tảiLạiToolStripMenuItem,
            this.thêmHàngHóaToolStripMenuItem,
            this.sửaHàngHóaToolStripMenuItem,
            this.xóaHàngHóaToolStripMenuItem,
            this.xuấtToolStripMenuItem});
            this.VLL.Name = "contextMenuStrip1";
            this.VLL.Size = new System.Drawing.Size(171, 114);
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tảiLạiToolStripMenuItem.Text = "Tải lại";
            this.tảiLạiToolStripMenuItem.Click += new System.EventHandler(this.tảiLạiToolStripMenuItem_Click);
            // 
            // thêmHàngHóaToolStripMenuItem
            // 
            this.thêmHàngHóaToolStripMenuItem.Name = "thêmHàngHóaToolStripMenuItem";
            this.thêmHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thêmHàngHóaToolStripMenuItem.Text = "Thêm khách hàng";
            this.thêmHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.thêmHàngHóaToolStripMenuItem_Click);
            // 
            // sửaHàngHóaToolStripMenuItem
            // 
            this.sửaHàngHóaToolStripMenuItem.Name = "sửaHàngHóaToolStripMenuItem";
            this.sửaHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sửaHàngHóaToolStripMenuItem.Text = "Sửa khách hàng";
            this.sửaHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.sửaHàngHóaToolStripMenuItem_Click);
            // 
            // xóaHàngHóaToolStripMenuItem
            // 
            this.xóaHàngHóaToolStripMenuItem.Name = "xóaHàngHóaToolStripMenuItem";
            this.xóaHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.xóaHàngHóaToolStripMenuItem.Text = "Xóa khách hàng";
            this.xóaHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.xóaHàngHóaToolStripMenuItem_Click);
            // 
            // xuấtToolStripMenuItem
            // 
            this.xuấtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemTrướcBảnInToolStripMenuItem,
            this.xuấtRaExcelToolStripMenuItem});
            this.xuấtToolStripMenuItem.Name = "xuấtToolStripMenuItem";
            this.xuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.xuấtToolStripMenuItem.Text = "Xuất";
            // 
            // xemTrướcBảnInToolStripMenuItem
            // 
            this.xemTrướcBảnInToolStripMenuItem.Name = "xemTrướcBảnInToolStripMenuItem";
            this.xemTrướcBảnInToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.xemTrướcBảnInToolStripMenuItem.Text = "Xem trước bản in";
            // 
            // xuấtRaExcelToolStripMenuItem
            // 
            this.xuấtRaExcelToolStripMenuItem.Name = "xuấtRaExcelToolStripMenuItem";
            this.xuấtRaExcelToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.xuấtRaExcelToolStripMenuItem.Text = "Xuất ra Excel";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(484, 363);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.LightCoral;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(407, 363);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(329, 363);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataKhachHang);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(558, 389);
            this.Load += new System.EventHandler(this.ucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).EndInit();
            this.VLL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKhachHang;
        private System.Windows.Forms.ContextMenuStrip VLL;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemTrướcBảnInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtRaExcelToolStripMenuItem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
