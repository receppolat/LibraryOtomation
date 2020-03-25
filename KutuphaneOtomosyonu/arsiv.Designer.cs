namespace KutuphaneOtomosyonu
{
    partial class arsivrapor
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
            this.arsivBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KutuphaneOtomasyonuDataSet = new KutuphaneOtomosyonu.KutuphaneOtomasyonuDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.arsivTableAdapter = new KutuphaneOtomosyonu.KutuphaneOtomasyonuDataSetTableAdapters.arsivTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.arsivBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KutuphaneOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // arsivBindingSource
            // 
            this.arsivBindingSource.DataMember = "arsiv";
            this.arsivBindingSource.DataSource = this.KutuphaneOtomasyonuDataSet;
            // 
            // KutuphaneOtomasyonuDataSet
            // 
            this.KutuphaneOtomasyonuDataSet.DataSetName = "KutuphaneOtomasyonuDataSet";
            this.KutuphaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.arsivBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KutuphaneOtomosyonu.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // arsivTableAdapter
            // 
            this.arsivTableAdapter.ClearBeforeFill = true;
            // 
            // arsivrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "arsivrapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Arşivi";
            this.Load += new System.EventHandler(this.anlikkitaplık_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arsivBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KutuphaneOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource arsivBindingSource;
        private KutuphaneOtomasyonuDataSet KutuphaneOtomasyonuDataSet;
        private KutuphaneOtomasyonuDataSetTableAdapters.arsivTableAdapter arsivTableAdapter;
    }
}