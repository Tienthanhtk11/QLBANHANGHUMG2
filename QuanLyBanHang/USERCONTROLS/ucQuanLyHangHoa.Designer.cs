namespace QuanLyBanHang.USERCONTROLS
{
    partial class ucQuanLyHangHoa
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
            this.dataHangHoa = new System.Windows.Forms.DataGridView();
            this.VLL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmĐơnLẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemTrướcBảnInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtRaExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.cbNhomHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNhomH = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).BeginInit();
            this.VLL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHangHoa
            // 
            this.dataHangHoa.AllowUserToAddRows = false;
            this.dataHangHoa.AllowUserToDeleteRows = false;
            this.dataHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataHangHoa.BackgroundColor = System.Drawing.Color.Teal;
            this.dataHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHangHoa.ContextMenuStrip = this.VLL;
            this.dataHangHoa.Location = new System.Drawing.Point(3, 30);
            this.dataHangHoa.Name = "dataHangHoa";
            this.dataHangHoa.ReadOnly = true;
            this.dataHangHoa.Size = new System.Drawing.Size(558, 345);
            this.dataHangHoa.TabIndex = 0;
            this.dataHangHoa.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHangHoa_CellEnter);
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
            this.VLL.Size = new System.Drawing.Size(159, 114);
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tảiLạiToolStripMenuItem.Text = "Tải lại";
            this.tảiLạiToolStripMenuItem.Click += new System.EventHandler(this.tảiLạiToolStripMenuItem_Click);
            // 
            // thêmHàngHóaToolStripMenuItem
            // 
            this.thêmHàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmĐơnLẻToolStripMenuItem});
            this.thêmHàngHóaToolStripMenuItem.Name = "thêmHàngHóaToolStripMenuItem";
            this.thêmHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.thêmHàngHóaToolStripMenuItem.Text = "Thêm hàng hóa";
            this.thêmHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.thêmHàngHóaToolStripMenuItem_Click);
            // 
            // thêmĐơnLẻToolStripMenuItem
            // 
            this.thêmĐơnLẻToolStripMenuItem.Name = "thêmĐơnLẻToolStripMenuItem";
            this.thêmĐơnLẻToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.thêmĐơnLẻToolStripMenuItem.Text = "Thêm đơn lẻ";
            this.thêmĐơnLẻToolStripMenuItem.Click += new System.EventHandler(this.thêmĐơnLẻToolStripMenuItem_Click);
            // 
            // sửaHàngHóaToolStripMenuItem
            // 
            this.sửaHàngHóaToolStripMenuItem.Name = "sửaHàngHóaToolStripMenuItem";
            this.sửaHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sửaHàngHóaToolStripMenuItem.Text = "Sửa hàng hóa";
            this.sửaHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.sửaHàngHóaToolStripMenuItem_Click);
            // 
            // xóaHàngHóaToolStripMenuItem
            // 
            this.xóaHàngHóaToolStripMenuItem.Name = "xóaHàngHóaToolStripMenuItem";
            this.xóaHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.xóaHàngHóaToolStripMenuItem.Text = "Xóa hàng hóa";
            this.xóaHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.xóaHàngHóaToolStripMenuItem_Click);
            // 
            // xuấtToolStripMenuItem
            // 
            this.xuấtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemTrướcBảnInToolStripMenuItem,
            this.xuấtRaExcelToolStripMenuItem});
            this.xuấtToolStripMenuItem.Name = "xuấtToolStripMenuItem";
            this.xuấtToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.xuấtToolStripMenuItem.Text = "Xuất";
            // 
            // xemTrướcBảnInToolStripMenuItem
            // 
            this.xemTrướcBảnInToolStripMenuItem.Name = "xemTrướcBảnInToolStripMenuItem";
            this.xemTrướcBảnInToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.xemTrướcBảnInToolStripMenuItem.Text = "Xem trước bản in";
            this.xemTrướcBảnInToolStripMenuItem.Click += new System.EventHandler(this.xemTrướcBảnInToolStripMenuItem_Click);
            // 
            // xuấtRaExcelToolStripMenuItem
            // 
            this.xuấtRaExcelToolStripMenuItem.Name = "xuấtRaExcelToolStripMenuItem";
            this.xuấtRaExcelToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.xuấtRaExcelToolStripMenuItem.Text = "Xuất ra Excel";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(335, 381);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.LightCoral;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(413, 381);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(490, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbNCC
            // 
            this.cbNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(383, 5);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(178, 21);
            this.cbNCC.TabIndex = 1;
            this.cbNCC.Visible = false;
            this.cbNCC.SelectedIndexChanged += new System.EventHandler(this.cbNCC_SelectedIndexChanged);
            this.cbNCC.TextChanged += new System.EventHandler(this.cbNCC_TextChanged);
            // 
            // cbNhomHang
            // 
            this.cbNhomHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNhomHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNhomHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNhomHang.FormattingEnabled = true;
            this.cbNhomHang.Location = new System.Drawing.Point(199, 5);
            this.cbNhomHang.Name = "cbNhomHang";
            this.cbNhomHang.Size = new System.Drawing.Size(178, 21);
            this.cbNhomHang.TabIndex = 2;
            this.cbNhomHang.Visible = false;
            this.cbNhomHang.SelectedIndexChanged += new System.EventHandler(this.cbNhomHang_SelectedIndexChanged);
            this.cbNhomHang.TextChanged += new System.EventHandler(this.cbNhomHang_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(113, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CÔNG CỤ LỌC";
            this.label1.Visible = false;
            // 
            // lblNhomH
            // 
            this.lblNhomH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhomH.AutoSize = true;
            this.lblNhomH.BackColor = System.Drawing.Color.White;
            this.lblNhomH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNhomH.Location = new System.Drawing.Point(203, 9);
            this.lblNhomH.Name = "lblNhomH";
            this.lblNhomH.Size = new System.Drawing.Size(88, 13);
            this.lblNhomH.TabIndex = 4;
            this.lblNhomH.Text = "Theo nhóm hàng";
            this.lblNhomH.Visible = false;
            this.lblNhomH.Click += new System.EventHandler(this.lblNhomH_Click);
            // 
            // lblNCC
            // 
            this.lblNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNCC.AutoSize = true;
            this.lblNCC.BackColor = System.Drawing.Color.White;
            this.lblNCC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNCC.Location = new System.Drawing.Point(387, 9);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(101, 13);
            this.lblNCC.TabIndex = 5;
            this.lblNCC.Text = "Theo nhà cung cấp";
            this.lblNCC.Visible = false;
            this.lblNCC.Click += new System.EventHandler(this.lblNCC_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimKiem.Location = new System.Drawing.Point(241, 381);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 23);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimKiem.Location = new System.Drawing.Point(4, 381);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(231, 20);
            this.txtTimKiem.TabIndex = 26;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // ucQuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.lblNhomH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNhomHang);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.dataHangHoa);
            this.Name = "ucQuanLyHangHoa";
            this.Size = new System.Drawing.Size(564, 407);
            this.Load += new System.EventHandler(this.ucQuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).EndInit();
            this.VLL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHangHoa;
        private System.Windows.Forms.ContextMenuStrip VLL;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmĐơnLẻToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemTrướcBảnInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtRaExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.ComboBox cbNhomHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhomH;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
