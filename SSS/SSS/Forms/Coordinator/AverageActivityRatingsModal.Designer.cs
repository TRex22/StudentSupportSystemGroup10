namespace SSS_Windows_Forms.Forms.Coordinator
{
    partial class AverageActivityRatingsModal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.aVERAGEACTIVITYRATINGSDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aVERAGERATINGSDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGEACTIVITYRATINGSDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGERATINGSDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AverageActivityRatings";
            reportDataSource1.Value = this.aVERAGEACTIVITYRATINGSDataTableBindingSource;
            reportDataSource2.Name = "ActivityRatingsTotals";
            reportDataSource2.Value = this.aVERAGERATINGSDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS_Windows_Forms.Reports.Coordinator.AverageActivityRatingsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(762, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // aVERAGEACTIVITYRATINGSDataTableBindingSource
            // 
            this.aVERAGEACTIVITYRATINGSDataTableBindingSource.DataSource = typeof(SSS_Library.IS2G10_DBSSSDataSet.AVERAGE_ACTIVITY_RATINGSDataTable);
            // 
            // aVERAGERATINGSDataTableBindingSource
            // 
            this.aVERAGERATINGSDataTableBindingSource.DataSource = typeof(SSS_Library.IS2G10_DBSSSDataSet.AVERAGE_RATINGSDataTable);
            // 
            // AverageActivityRatingsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 539);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AverageActivityRatingsModal";
            this.Text = "AverageActivityRatingsModal";
            this.Load += new System.EventHandler(this.AverageActivityRatingsModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGEACTIVITYRATINGSDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGERATINGSDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource aVERAGEACTIVITYRATINGSDataTableBindingSource;
        private System.Windows.Forms.BindingSource aVERAGERATINGSDataTableBindingSource;
    }
}