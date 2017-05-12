namespace QuanLyBanHang.USERCONTROLS
{
    partial class ucNhaCungCap
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
            this.dataNhaCungCap = new System.Windows.Forms.DataGridView();
            this.VL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtRaFileExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhaCungCap)).BeginInit();
            this.VL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNhaCungCap
            // 
            this.dataNhaCungCap.AllowUserToAddRows = false;
            this.dataNhaCungCap.AllowUserToDeleteRows = false;
            this.dataNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhaCungCap.ContextMenuStrip = this.VL;
            this.dataNhaCungCap.Location = new System.Drawing.Point(0, 26);
            this.dataNhaCungCap.Name = "dataNhaCungCap";
            this.dataNhaCungCap.ReadOnly = true;
            this.dataNhaCungCap.Size = new System.Drawing.Size(564, 352);
            this.dataNhaCungCap.TabIndex = 0;
            this.dataNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhaCungCap_CellClick);
            this.dataNhaCungCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNCC_CellContentClick);
            this.dataNhaCungCap.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNCC_CellEnter);
            // 
            // VL
            // 
            this.VL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tảiLạiF5ToolStripMenuItem,
            this.thêmNhàCungCấpToolStripMenuItem,
            this.sửaNhàCungCấpToolStripMenuItem,
            this.xóaNhàCungCấpToolStripMenuItem,
            this.inToolStripMenuItem,
            this.xuấtRaFileExcellToolStripMenuItem});
            this.VL.Name = "contextMenuStrip1";
            this.VL.Size = new System.Drawing.Size(181, 136);
            // 
            // tảiLạiF5ToolStripMenuItem
            // 
            this.tảiLạiF5ToolStripMenuItem.Name = "tảiLạiF5ToolStripMenuItem";
            this.tảiLạiF5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tảiLạiF5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tảiLạiF5ToolStripMenuItem.Text = "Tải lại";
            this.tảiLạiF5ToolStripMenuItem.Click += new System.EventHandler(this.tảiLạiF5ToolStripMenuItem_Click);
            // 
            // thêmNhàCungCấpToolStripMenuItem
            // 
            this.thêmNhàCungCấpToolStripMenuItem.Name = "thêmNhàCungCấpToolStripMenuItem";
            this.thêmNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmNhàCungCấpToolStripMenuItem.Text = "Thêm nhà cung cấp";
            this.thêmNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.thêmNhàCungCấpToolStripMenuItem_Click);
            // 
            // sửaNhàCungCấpToolStripMenuItem
            // 
            this.sửaNhàCungCấpToolStripMenuItem.Name = "sửaNhàCungCấpToolStripMenuItem";
            this.sửaNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sửaNhàCungCấpToolStripMenuItem.Text = "Sửa nhà cung cấp";
            this.sửaNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.sửaNhàCungCấpToolStripMenuItem_Click);
            // 
            // xóaNhàCungCấpToolStripMenuItem
            // 
            this.xóaNhàCungCấpToolStripMenuItem.Name = "xóaNhàCungCấpToolStripMenuItem";
            this.xóaNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xóaNhàCungCấpToolStripMenuItem.Text = "Xóa nhà cung cấp";
            this.xóaNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.xóaNhàCungCấpToolStripMenuItem_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inToolStripMenuItem.Text = "In";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.inToolStripMenuItem_Click);
            // 
            // xuấtRaFileExcellToolStripMenuItem
            // 
            this.xuấtRaFileExcellToolStripMenuItem.Name = "xuấtRaFileExcellToolStripMenuItem";
            this.xuấtRaFileExcellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xuấtRaFileExcellToolStripMenuItem.Text = "Xuất ra file excell";
            this.xuấtRaFileExcellToolStripMenuItem.Click += new System.EventHandler(this.xuấtRaFileExcellToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(406, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhà cung cấp";
            // 
            // lblNCC
            // 
            this.lblNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNCC.AutoSize = true;
            this.lblNCC.ForeColor = System.Drawing.Color.DimGray;
            this.lblNCC.Location = new System.Drawing.Point(487, 6);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(70, 13);
            this.lblNCC.TabIndex = 2;
            this.lblNCC.Text = "<chưa chọn>";
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
            this.btnSua.Location = new System.Drawing.Point(413, 381);
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
            this.btnThem.Location = new System.Drawing.Point(335, 381);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ucNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataNhaCungCap);
            this.Name = "ucNhaCungCap";
            this.Size = new System.Drawing.Size(564, 407);
            this.Load += new System.EventHandler(this.ucNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhaCungCap)).EndInit();
            this.VL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNhaCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.ContextMenuStrip VL;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtRaFileExcellToolStripMenuItem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
