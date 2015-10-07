namespace SSS.Forms.Coordinator
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
            this.aVERAGETUTORRATINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS2G10_DBSSSDataSet = new SSS.IS2G10_DBSSSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.aVERAGE_TUTOR_RATINGTableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.AVERAGE_TUTOR_RATINGTableAdapter();
            this.AVERAGE_TUTOR_RATINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ATTENDANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AVERAGE_RATINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aVERAGERATINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aVERAGE_RATINGSTableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.AVERAGE_RATINGSTableAdapter();
            this.aVERAGETUTORRATINGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aTTENDANCEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aTTENDANCETableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter();
            this.aVERAGERATINGSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGETUTORRATINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_TUTOR_RATINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATTENDANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_RATINGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGERATINGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGETUTORRATINGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGERATINGSBindingSource1)).BeginInit();
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
            reportDataSource1.Name = "AverageTutorRating";
            reportDataSource1.Value = this.aVERAGETUTORRATINGBindingSource1;
            reportDataSource2.Name = "StudentActivityAttendance";
            reportDataSource2.Value = this.aTTENDANCEBindingSource1;
            reportDataSource3.Name = "AverageRatings";
            reportDataSource3.Value = this.aVERAGERATINGSBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS.Reports.Coordinator.LowTutorRating.TutorA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(762, 539);
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
            // ATTENDANCEBindingSource
            // 
            this.ATTENDANCEBindingSource.DataMember = "ATTENDANCE";
            this.ATTENDANCEBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // AVERAGE_RATINGSBindingSource
            // 
            this.AVERAGE_RATINGSBindingSource.DataMember = "AVERAGE_RATINGS";
            this.AVERAGE_RATINGSBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // aVERAGERATINGSBindingSource
            // 
            this.aVERAGERATINGSBindingSource.DataMember = "AVERAGE_RATINGS";
            this.aVERAGERATINGSBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // aVERAGE_RATINGSTableAdapter
            // 
            this.aVERAGE_RATINGSTableAdapter.ClearBeforeFill = true;
            // 
            // aVERAGETUTORRATINGBindingSource1
            // 
            this.aVERAGETUTORRATINGBindingSource1.DataMember = "AVERAGE_TUTOR_RATING";
            this.aVERAGETUTORRATINGBindingSource1.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // aTTENDANCEBindingSource1
            // 
            this.aTTENDANCEBindingSource1.DataMember = "ATTENDANCE";
            this.aTTENDANCEBindingSource1.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // aTTENDANCETableAdapter
            // 
            this.aTTENDANCETableAdapter.ClearBeforeFill = true;
            // 
            // aVERAGERATINGSBindingSource1
            // 
            this.aVERAGERATINGSBindingSource1.DataMember = "AVERAGE_RATINGS";
            this.aVERAGERATINGSBindingSource1.DataSource = this.iS2G10_DBSSSDataSet;
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
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGETUTORRATINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_TUTOR_RATINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATTENDANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVERAGE_RATINGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGERATINGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGETUTORRATINGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVERAGERATINGSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private System.Windows.Forms.BindingSource aVERAGETUTORRATINGBindingSource;
        private IS2G10_DBSSSDataSetTableAdapters.AVERAGE_TUTOR_RATINGTableAdapter aVERAGE_TUTOR_RATINGTableAdapter;
        private System.Windows.Forms.BindingSource AVERAGE_TUTOR_RATINGBindingSource;
        private System.Windows.Forms.BindingSource ATTENDANCEBindingSource;
        private System.Windows.Forms.BindingSource AVERAGE_RATINGSBindingSource;
        private System.Windows.Forms.BindingSource aVERAGERATINGSBindingSource;
        private IS2G10_DBSSSDataSetTableAdapters.AVERAGE_RATINGSTableAdapter aVERAGE_RATINGSTableAdapter;
        private System.Windows.Forms.BindingSource aVERAGETUTORRATINGBindingSource1;
        private System.Windows.Forms.BindingSource aTTENDANCEBindingSource1;
        private IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter aTTENDANCETableAdapter;
        private System.Windows.Forms.BindingSource aVERAGERATINGSBindingSource1;
    }
}