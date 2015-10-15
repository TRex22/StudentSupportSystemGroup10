namespace SSS_Windows_Forms.Forms.Coordinator.LowTutorRatings
{
    partial class TutorRatingB_IndividualModal
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
            this.aVERAGETUTORRATINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS2G10_DBSSSDataSet = new SSS_Library.IS2G10_DBSSSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.aVERAGE_TUTOR_RATINGTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.AVERAGE_TUTOR_RATINGTableAdapter();
            this.AVERAGE_TUTOR_RATINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGETUTORRATINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_TUTOR_RATINGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aVERAGETUTORRATINGBindingSource
            // 
            this.aVERAGETUTORRATINGBindingSource.DataMember = "AVERAGE_TUTOR_RATING";
            this.aVERAGETUTORRATINGBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AverageRating";
            reportDataSource1.Value = this.AVERAGE_TUTOR_RATINGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS.Reports.Coordinator.LowTutorRating.TutorB_RatingReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(834, 546);
            this.reportViewer1.TabIndex = 0;
            // 
            // aVERAGE_TUTOR_RATINGTableAdapter
            // 
            this.aVERAGE_TUTOR_RATINGTableAdapter.ClearBeforeFill = true;
            // 
            // AVERAGE_TUTOR_RATINGBindingSource
            // 
            this.AVERAGE_TUTOR_RATINGBindingSource.DataMember = "AVERAGE_TUTOR_RATING";
            this.AVERAGE_TUTOR_RATINGBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // TutorRatingB_IndividualModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 546);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TutorRatingB_IndividualModal";
            this.Text = "LowTutorRatingB_IndividualModal";
            this.Load += new System.EventHandler(this.LowTutorRatingB_IndividualModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGETUTORRATINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_TUTOR_RATINGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SSS_Library.IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private System.Windows.Forms.BindingSource aVERAGETUTORRATINGBindingSource;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.AVERAGE_TUTOR_RATINGTableAdapter aVERAGE_TUTOR_RATINGTableAdapter;
        private System.Windows.Forms.BindingSource AVERAGE_TUTOR_RATINGBindingSource;
    }
}