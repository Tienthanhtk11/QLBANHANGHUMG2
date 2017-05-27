namespace QuanLyBanHang.FORM
{
    partial class frmBanHangIN
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyBanHangHUMGDataSet = new QuanLyBanHang.QuanLyBanHangHUMGDataSet();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new QuanLyBanHang.QuanLyBanHangHUMGDataSetTableAdapters.View_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangHUMGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.FORM.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(764, 455);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyBanHangHUMGDataSet
            // 
            this.quanLyBanHangHUMGDataSet.DataSetName = "QuanLyBanHangHUMGDataSet";
            this.quanLyBanHangHUMGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.quanLyBanHangHUMGDataSet;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // frmBanHangIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 455);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBanHangIN";
            this.Text = "frmBanHangIN";
            this.Load += new System.EventHandler(this.frmBanHangIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangHUMGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyBanHangHUMGDataSet quanLyBanHangHUMGDataSet;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private QuanLyBanHangHUMGDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
    }
}