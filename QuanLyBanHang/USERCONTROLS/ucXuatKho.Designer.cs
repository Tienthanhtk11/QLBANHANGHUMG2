namespace QuanLyBanHang.USERCONTROLS
{
    partial class ucXuatKho
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
            this.dtXuatKho = new System.Windows.Forms.DataGridView();
            this.MN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtFileExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNCC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtXuatKho)).BeginInit();
            this.MN.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtXuatKho
            // 
            this.dtXuatKho.AllowUserToAddRows = false;
            this.dtXuatKho.AllowUserToDeleteRows = false;
            this.dtXuatKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtXuatKho.ContextMenuStrip = this.MN;
            this.dtXuatKho.Location = new System.Drawing.Point(3, 30);
            this.dtXuatKho.Name = "dtXuatKho";
            this.dtXuatKho.ReadOnly = true;
            this.dtXuatKho.Size = new System.Drawing.Size(558, 345);
            this.dtXuatKho.TabIndex = 0;
            this.dtXuatKho.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtXuatKho_CellEnter);
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
            this.MN.Size = new System.Drawing.Size(178, 136);
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.tảiLạiToolStripMenuItem.Text = "Tải lại";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thêmToolStripMenuItem.Text = "Thêm hóa đơn xuất";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaHóaĐơnToolStripMenuItem
            // 
            this.sửaHóaĐơnToolStripMenuItem.Name = "sửaHóaĐơnToolStripMenuItem";
            this.sửaHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.sửaHóaĐơnToolStripMenuItem.Text = "Sửa hóa đơn";
            this.sửaHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.sửaHóaĐơnToolStripMenuItem_Click);
            // 
            // xóaHóaĐơnToolStripMenuItem
            // 
            this.xóaHóaĐơnToolStripMenuItem.Name = "xóaHóaĐơnToolStripMenuItem";
            this.xóaHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.xóaHóaĐơnToolStripMenuItem.Text = "Xóa hóa đơn";
            this.xóaHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xóaHóaĐơnToolStripMenuItem_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.inToolStripMenuItem.Text = "In";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.inToolStripMenuItem_Click);
            // 
            // xuấtFileExcellToolStripMenuItem
            // 
            this.xuấtFileExcellToolStripMenuItem.Name = "xuấtFileExcellToolStripMenuItem";
            this.xuấtFileExcellToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.xuấtFileExcellToolStripMenuItem.Text = "Xuất file excell";
            this.xuấtFileExcellToolStripMenuItem.Click += new System.EventHandler(this.xuấtFileExcellToolStripMenuItem_Click);
            // 
            // lblNCC
            // 
            this.lblNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNCC.AutoSize = true;
            this.lblNCC.BackColor = System.Drawing.Color.White;
            this.lblNCC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNCC.Location = new System.Drawing.Point(387, 7);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(113, 13);
            this.lblNCC.TabIndex = 11;
            this.lblNCC.Text = "Theo nhà khách hàng";
            this.lblNCC.Visible = false;
            this.lblNCC.Click += new System.EventHandler(this.lblNCC_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(297, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CÔNG CỤ LỌC";
            this.label1.Visible = false;
            // 
            // cbNhaCC
            // 
            this.cbNhaCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNhaCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNhaCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNhaCC.FormattingEnabled = true;
            this.cbNhaCC.Location = new System.Drawing.Point(383, 3);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(178, 21);
            this.cbNhaCC.TabIndex = 9;
            this.cbNhaCC.Visible = false;
            this.cbNhaCC.SelectedIndexChanged += new System.EventHandler(this.cbNhaCC_SelectedIndexChanged);
            this.cbNhaCC.TextChanged += new System.EventHandler(this.cbNhaCC_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(158, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightCoral;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(81, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(484, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(77, 23);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(235, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(243, 20);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // ucXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNhaCC);
            this.Controls.Add(this.dtXuatKho);
            this.Name = "ucXuatKho";
            this.Size = new System.Drawing.Size(564, 407);
            this.Load += new System.EventHandler(this.ucXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtXuatKho)).EndInit();
            this.MN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtXuatKho;
        private System.Windows.Forms.ContextMenuStrip MN;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileExcellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
