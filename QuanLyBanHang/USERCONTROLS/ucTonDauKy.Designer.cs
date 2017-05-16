namespace QuanLyBanHang.USERCONTROLS
{
    partial class ucTonDauKy
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
            this.dataTonDauKy = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Vll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TaiLaiok = new System.Windows.Forms.ToolStripMenuItem();
            this.Inok = new System.Windows.Forms.ToolStripMenuItem();
            this.xuâtFileExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTonDauKy)).BeginInit();
            this.Vll.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTonDauKy
            // 
            this.dataTonDauKy.AllowUserToAddRows = false;
            this.dataTonDauKy.AllowUserToDeleteRows = false;
            this.dataTonDauKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTonDauKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTonDauKy.Location = new System.Drawing.Point(3, 30);
            this.dataTonDauKy.Name = "dataTonDauKy";
            this.dataTonDauKy.ReadOnly = true;
            this.dataTonDauKy.Size = new System.Drawing.Size(558, 345);
            this.dataTonDauKy.TabIndex = 0;
            this.dataTonDauKy.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTonDauKy_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SỐ HÀNG HIỆN ĐANG TỒN DƯ";
            // 
            // Vll
            // 
            this.Vll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaiLaiok,
            this.Inok,
            this.xuâtFileExcellToolStripMenuItem});
            this.Vll.Name = "contextMenuStrip1";
            this.Vll.Size = new System.Drawing.Size(150, 70);
            // 
            // TaiLaiok
            // 
            this.TaiLaiok.Name = "TaiLaiok";
            this.TaiLaiok.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.TaiLaiok.Size = new System.Drawing.Size(149, 22);
            this.TaiLaiok.Text = "Tải lại";
            this.TaiLaiok.Click += new System.EventHandler(this.TaiLaiok_Click);
            // 
            // Inok
            // 
            this.Inok.Name = "Inok";
            this.Inok.Size = new System.Drawing.Size(149, 22);
            this.Inok.Text = "In";
            this.Inok.Click += new System.EventHandler(this.Inok_Click);
            // 
            // xuâtFileExcellToolStripMenuItem
            // 
            this.xuâtFileExcellToolStripMenuItem.Name = "xuâtFileExcellToolStripMenuItem";
            this.xuâtFileExcellToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.xuâtFileExcellToolStripMenuItem.Text = "Xuât file Excell";
            this.xuâtFileExcellToolStripMenuItem.Click += new System.EventHandler(this.xuâtFileExcellToolStripMenuItem_Click);
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
            // ucTonDauKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.Vll;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTonDauKy);
            this.Name = "ucTonDauKy";
            this.Size = new System.Drawing.Size(564, 407);
            this.Load += new System.EventHandler(this.ucHangTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTonDauKy)).EndInit();
            this.Vll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTonDauKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip Vll;
        private System.Windows.Forms.ToolStripMenuItem TaiLaiok;
        private System.Windows.Forms.ToolStripMenuItem Inok;
        private System.Windows.Forms.ToolStripMenuItem xuâtFileExcellToolStripMenuItem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
