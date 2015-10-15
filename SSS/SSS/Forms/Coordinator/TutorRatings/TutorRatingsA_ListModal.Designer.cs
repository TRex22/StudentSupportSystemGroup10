namespace SSS_Windows_Forms.Forms.Coordinator
{
    partial class TutorRatingsA_ListModal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AVERAGE_TUTOR_RATINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS2G10_DBSSSDataSet = new SSS_Library.IS2G10_DBSSSDataSet();
            this.AVERAGE_RATINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ATTENDANCE_AND_ACTIVITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aVERAGETUTORRATINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aVERAGERATINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTTENDANCEANDACTIVITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTTENDANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTTENDANCETableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter();
            this.aVERAGE_RATINGSTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.AVERAGE_RATINGSTableAdapter();
            this.aVERAGE_TUTOR_RATINGTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.AVERAGE_TUTOR_RATINGTableAdapter();
            this.aTTENDANCE_AND_ACTIVITYTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCE_AND_ACTIVITYTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iS2G10_DBSSSDataSet1 = new SSS_Library.IS2G10_DBSSSDataSet();
            this.aTTENDANCEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_TUTOR_RATINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_RATINGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATTENDANCE_AND_ACTIVITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGETUTORRATINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGERATINGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEANDACTIVITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AVERAGE_TUTOR_RATINGBindingSource
            // 
            this.AVERAGE_TUTOR_RATINGBindingSource.DataMember = "AVERAGE_TUTOR_RATING";
            this.AVERAGE_TUTOR_RATINGBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AVERAGE_RATINGSBindingSource
            // 
            this.AVERAGE_RATINGSBindingSource.DataMember = "AVERAGE_RATINGS";
            this.AVERAGE_RATINGSBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // ATTENDANCE_AND_ACTIVITYBindingSource
            // 
            this.ATTENDANCE_AND_ACTIVITYBindingSource.DataMember = "ATTENDANCE_AND_ACTIVITY";
            this.ATTENDANCE_AND_ACTIVITYBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // aVERAGETUTORRATINGBindingSource
            // 
            this.aVERAGETUTORRATINGBindingSource.DataMember = "AVERAGE_TUTOR_RATING";
            this.aVERAGETUTORRATINGBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // aVERAGERATINGSBindingSource
            // 
            this.aVERAGERATINGSBindingSource.DataMember = "AVERAGE_RATINGS";
            // 
            // aTTENDANCEANDACTIVITYBindingSource
            // 
            this.aTTENDANCEANDACTIVITYBindingSource.DataMember = "ATTENDANCE_AND_ACTIVITY";
            this.aTTENDANCEANDACTIVITYBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // aTTENDANCEBindingSource
            // 
            this.aTTENDANCEBindingSource.DataMember = "ATTENDANCE";
            // 
            // aTTENDANCETableAdapter
            // 
            this.aTTENDANCETableAdapter.ClearBeforeFill = true;
            // 
            // aVERAGE_RATINGSTableAdapter
            // 
            this.aVERAGE_RATINGSTableAdapter.ClearBeforeFill = true;
            // 
            // aVERAGE_TUTOR_RATINGTableAdapter
            // 
            this.aVERAGE_TUTOR_RATINGTableAdapter.ClearBeforeFill = true;
            // 
            // aTTENDANCE_AND_ACTIVITYTableAdapter
            // 
            this.aTTENDANCE_AND_ACTIVITYTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AverageRatings";
            reportDataSource1.Value = this.AVERAGE_RATINGSBindingSource;
            reportDataSource2.Name = "AverageTutorRatings";
            reportDataSource2.Value = this.AVERAGE_TUTOR_RATINGBindingSource;
            reportDataSource3.Name = "Attendance";
            reportDataSource3.Value = this.aTTENDANCEBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS.Reports.Coordinator.LowTutorRating.TutorA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(762, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // iS2G10_DBSSSDataSet1
            // 
            this.iS2G10_DBSSSDataSet1.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTTENDANCEBindingSource1
            // 
            this.aTTENDANCEBindingSource1.DataMember = "ATTENDANCE";
            this.aTTENDANCEBindingSource1.DataSource = this.iS2G10_DBSSSDataSet1;
            // 
            // TutorRatingsA_ListModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 539);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TutorRatingsA_ListModal";
            this.Text = "LowTutorRatingsModal";
            this.Load += new System.EventHandler(this.LowTutorRatingsModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_TUTOR_RATINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_RATINGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATTENDANCE_AND_ACTIVITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGETUTORRATINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGERATINGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEANDACTIVITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter aTTENDANCETableAdapter;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.AVERAGE_RATINGSTableAdapter aVERAGE_RATINGSTableAdapter;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.AVERAGE_TUTOR_RATINGTableAdapter aVERAGE_TUTOR_RATINGTableAdapter;
        private System.Windows.Forms.BindingSource aVERAGERATINGSBindingSource;
        private System.Windows.Forms.BindingSource aTTENDANCEBindingSource;
        private SSS_Library.IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private System.Windows.Forms.BindingSource aVERAGETUTORRATINGBindingSource;
        private System.Windows.Forms.BindingSource aTTENDANCEANDACTIVITYBindingSource;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCE_AND_ACTIVITYTableAdapter aTTENDANCE_AND_ACTIVITYTableAdapter;
        private System.Windows.Forms.BindingSource AVERAGE_TUTOR_RATINGBindingSource;
        private System.Windows.Forms.BindingSource AVERAGE_RATINGSBindingSource;
        private System.Windows.Forms.BindingSource ATTENDANCE_AND_ACTIVITYBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SSS_Library.IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet1;
        private System.Windows.Forms.BindingSource aTTENDANCEBindingSource1;
    }
}