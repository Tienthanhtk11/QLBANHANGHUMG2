namespace QuanLyBanHang.USERCONTROLS
{
    partial class ucBCMatHangBanDuocNhieu
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
            this.dtBC = new System.Windows.Forms.DataGridView();
            this.btnClick = new System.Windows.Forms.Button();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VLL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtFileExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSMH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtBC)).BeginInit();
            this.VLL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtBC
            // 
            this.dtBC.AllowUserToAddRows = false;
            this.dtBC.AllowUserToDeleteRows = false;
            this.dtBC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBC.Location = new System.Drawing.Point(0, 59);
            this.dtBC.Name = "dtBC";
            this.dtBC.ReadOnly = true;
            this.dtBC.Size = new System.Drawing.Size(555, 365);
            this.dtBC.TabIndex = 0;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(444, 35);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 21);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Lọc";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // dt2
            // 
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt2.Location = new System.Drawing.Point(329, 36);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(109, 20);
            this.dt2.TabIndex = 2;
            // 
            // dt1
            // 
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt1.Location = new System.Drawing.Point(174, 36);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(116, 20);
            this.dt1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến";
            // 
            // VLL
            // 
            this.VLL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tảiLạiToolStripMenuItem,
            this.rToolStripMenuItem,
            this.xuấtFileExcellToolStripMenuItem});
            this.VLL.Name = "VLL";
            this.VLL.Size = new System.Drawing.Size(150, 70);
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.tảiLạiToolStripMenuItem.Text = "Tải lại";
            this.tảiLạiToolStripMenuItem.Click += new System.EventHandler(this.tảiLạiToolStripMenuItem_Click);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.rToolStripMenuItem.Text = "In";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // xuấtFileExcellToolStripMenuItem
            // 
            this.xuấtFileExcellToolStripMenuItem.Name = "xuấtFileExcellToolStripMenuItem";
            this.xuấtFileExcellToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.xuấtFileExcellToolStripMenuItem.Text = "Xuất file excell";
            this.xuấtFileExcellToolStripMenuItem.Click += new System.EventHandler(this.xuấtFileExcellToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(148, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "BÁO CÁO SỐ HÀNG BÁN ĐƯỢC NHIỀU";
            // 
            // cbSMH
            // 
            this.cbSMH.FormattingEnabled = true;
            this.cbSMH.Location = new System.Drawing.Point(3, 36);
            this.cbSMH.Name = "cbSMH";
            this.cbSMH.Size = new System.Drawing.Size(113, 21);
            this.cbSMH.TabIndex = 8;
            this.cbSMH.SelectedIndexChanged += new System.EventHandler(this.cbSMH_SelectedIndexChanged);
            this.cbSMH.TextChanged += new System.EventHandler(this.cbSMH_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(7, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số mặt hàng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ucBCMatHangBanDuocNhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.VLL;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.dtBC);
            this.Name = "ucBCMatHangBanDuocNhieu";
            this.Size = new System.Drawing.Size(558, 427);
            this.Load += new System.EventHandler(this.ucBCMatHangBanDuocNhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBC)).EndInit();
            this.VLL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtBC;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip VLL;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileExcellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSMH;
        private System.Windows.Forms.Label label4;
    }
}
