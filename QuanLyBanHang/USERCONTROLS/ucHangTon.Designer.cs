namespace QuanLyBanHang.USERCONTROLS
{
    partial class ucHangTon
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
            this.dtgTonDu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Vll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TaiLaiok = new System.Windows.Forms.ToolStripMenuItem();
            this.Inok = new System.Windows.Forms.ToolStripMenuItem();
            this.xuâtFileExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTonDu)).BeginInit();
            this.Vll.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTonDu
            // 
            this.dtgTonDu.AllowUserToAddRows = false;
            this.dtgTonDu.AllowUserToDeleteRows = false;
            this.dtgTonDu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTonDu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTonDu.Location = new System.Drawing.Point(3, 30);
            this.dtgTonDu.Name = "dtgTonDu";
            this.dtgTonDu.ReadOnly = true;
            this.dtgTonDu.Size = new System.Drawing.Size(558, 374);
            this.dtgTonDu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            // ucHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.Vll;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgTonDu);
            this.Name = "ucHangTon";
            this.Size = new System.Drawing.Size(564, 407);
            this.Load += new System.EventHandler(this.ucHangTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTonDu)).EndInit();
            this.Vll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTonDu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip Vll;
        private System.Windows.Forms.ToolStripMenuItem TaiLaiok;
        private System.Windows.Forms.ToolStripMenuItem Inok;
        private System.Windows.Forms.ToolStripMenuItem xuâtFileExcellToolStripMenuItem;
    }
}
