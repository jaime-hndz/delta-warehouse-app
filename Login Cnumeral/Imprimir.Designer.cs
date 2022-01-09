namespace Login_Cnumeral
{
    partial class Imprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imprimir));
            this.PRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ALMACENDataSet3 = new Login_Cnumeral.ALMACENDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PRODUCTOSTableAdapter = new Login_Cnumeral.ALMACENDataSet3TableAdapters.PRODUCTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALMACENDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // PRODUCTOSBindingSource
            // 
            this.PRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.PRODUCTOSBindingSource.DataSource = this.ALMACENDataSet3;
            // 
            // ALMACENDataSet3
            // 
            this.ALMACENDataSet3.DataSetName = "ALMACENDataSet3";
            this.ALMACENDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PRODUCTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Login_Cnumeral.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(618, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // PRODUCTOSTableAdapter
            // 
            this.PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 386);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Imprimir";
            this.Opacity = 0.95D;
            this.Text = "Imprimir Productos";
            this.Load += new System.EventHandler(this.Imprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALMACENDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PRODUCTOSBindingSource;
        private ALMACENDataSet3 ALMACENDataSet3;
        private ALMACENDataSet3TableAdapters.PRODUCTOSTableAdapter PRODUCTOSTableAdapter;

    }
}