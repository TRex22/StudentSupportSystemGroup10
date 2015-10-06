namespace SSS.Forms.Coordinator
{
    partial class StudentEngagementModal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportTableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ENGAGEMENT_STATUS_TableAdapter();
            this.disengageD_STUDENTSTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTSTableAdapter();
            this.disengageD_STUDENTS_AGGREGATETableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTS_AGGREGATETableAdapter();
            this.studentS_AGGREGATETableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENTS_AGGREGATETableAdapter();
            this.iS2G10_DBSSSDataSet = new SSS.IS2G10_DBSSSDataSet();
            this.sTUDENTENGAGEMENTSTATUSREPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dISENGAGEDSTUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dISENGAGEDSTUDENTSAGGREGATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTSAGGREGATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTENGAGEMENTSTATUSREPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISENGAGEDSTUDENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISENGAGEDSTUDENTSAGGREGATEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSAGGREGATEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentEngagementStatuses";
            reportDataSource1.Value = this.sTUDENTENGAGEMENTSTATUSREPORTBindingSource;
            reportDataSource2.Name = "DisengagedStudents";
            reportDataSource2.Value = this.dISENGAGEDSTUDENTSBindingSource;
            reportDataSource3.Name = "DisengagedStudentsAggregate";
            reportDataSource3.Value = this.dISENGAGEDSTUDENTSAGGREGATEBindingSource;
            reportDataSource4.Name = "StudentsAggregate";
            reportDataSource4.Value = this.sTUDENTSAGGREGATEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.EnableHyperlinks = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS.Reports.Coordinator.StudentEngagement.StudentEngagementStatuses.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(803, 561);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            this.reportViewer1.Drillthrough += new Microsoft.Reporting.WinForms.DrillthroughEventHandler(this.reportViewer1_Drillthrough);
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // disengageD_STUDENTSTableAdapter1
            // 
            this.disengageD_STUDENTSTableAdapter1.ClearBeforeFill = true;
            // 
            // disengageD_STUDENTS_AGGREGATETableAdapter1
            // 
            this.disengageD_STUDENTS_AGGREGATETableAdapter1.ClearBeforeFill = true;
            // 
            // studentS_AGGREGATETableAdapter1
            // 
            this.studentS_AGGREGATETableAdapter1.ClearBeforeFill = true;
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTENGAGEMENTSTATUSREPORTBindingSource
            // 
            this.sTUDENTENGAGEMENTSTATUSREPORTBindingSource.DataMember = "STUDENT_ENGAGEMENT_STATUS_REPORT";
            this.sTUDENTENGAGEMENTSTATUSREPORTBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // dISENGAGEDSTUDENTSBindingSource
            // 
            this.dISENGAGEDSTUDENTSBindingSource.DataMember = "DISENGAGED_STUDENTS";
            this.dISENGAGEDSTUDENTSBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // dISENGAGEDSTUDENTSAGGREGATEBindingSource
            // 
            this.dISENGAGEDSTUDENTSAGGREGATEBindingSource.DataMember = "DISENGAGED_STUDENTS_AGGREGATE";
            this.dISENGAGEDSTUDENTSAGGREGATEBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // sTUDENTSAGGREGATEBindingSource
            // 
            this.sTUDENTSAGGREGATEBindingSource.DataMember = "STUDENTS_AGGREGATE";
            this.sTUDENTSAGGREGATEBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // StudentDisengagementModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 561);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDisengagementModal";
            this.Text = "StudentDisengagementModal";
            this.Load += new System.EventHandler(this.StudentDisengagementModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTENGAGEMENTSTATUSREPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISENGAGEDSTUDENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISENGAGEDSTUDENTSAGGREGATEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSAGGREGATEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private IS2G10_DBSSSDataSetTableAdapters.STUDENT_ENGAGEMENT_STATUS_TableAdapter reportTableAdapter;
        private IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTSTableAdapter disengageD_STUDENTSTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTS_AGGREGATETableAdapter disengageD_STUDENTS_AGGREGATETableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.STUDENTS_AGGREGATETableAdapter studentS_AGGREGATETableAdapter1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sTUDENTENGAGEMENTSTATUSREPORTBindingSource;
        private IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private System.Windows.Forms.BindingSource dISENGAGEDSTUDENTSBindingSource;
        private System.Windows.Forms.BindingSource dISENGAGEDSTUDENTSAGGREGATEBindingSource;
        private System.Windows.Forms.BindingSource sTUDENTSAGGREGATEBindingSource;
    }
}