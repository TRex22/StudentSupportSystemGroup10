namespace SSS_Windows_Forms.Forms.Coordinator
{
    partial class CoordinatorDashboardModal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentS_AGGREGATETableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTS_AGGREGATETableAdapter();
            this.disengageD_STUDENTS_AGGREGATETableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTS_AGGREGATETableAdapter();
            this.studenT_ENGAGEMENT_STATUS_TableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ENGAGEMENT_STATUS_TableAdapter();
            this.disengageD_STUDENTSTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTSTableAdapter();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "StudentEngagementStatuses";
            reportDataSource5.Value = this.studenT_ENGAGEMENT_STATUS_TableAdapter1.GetData();
            reportDataSource6.Name = "DisengagedStudents";
            reportDataSource6.Value = this.disengageD_STUDENTSTableAdapter1.GetData();
            reportDataSource7.Name = "DisengagedStudentsAggregate";
            reportDataSource7.Value = this.disengageD_STUDENTS_AGGREGATETableAdapter1.GetData();
            reportDataSource8.Name = "StudentsAggregate";
            reportDataSource8.Value = this.studentS_AGGREGATETableAdapter1.GetData();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS_Windows_Forms.Reports.Coordinator.CoordinatorDashboardReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(762, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // studentS_AGGREGATETableAdapter1
            // 
            this.studentS_AGGREGATETableAdapter1.ClearBeforeFill = true;
            // 
            // disengageD_STUDENTS_AGGREGATETableAdapter1
            // 
            this.disengageD_STUDENTS_AGGREGATETableAdapter1.ClearBeforeFill = true;
            // 
            // studenT_ENGAGEMENT_STATUS_TableAdapter1
            // 
            this.studenT_ENGAGEMENT_STATUS_TableAdapter1.ClearBeforeFill = true;
            // 
            // disengageD_STUDENTSTableAdapter1
            // 
            this.disengageD_STUDENTSTableAdapter1.ClearBeforeFill = true;
            // 
            // CoordinatorDashboardModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 539);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoordinatorDashboardModal";
            this.Text = "CoordinatorDashboardModal";
            this.Load += new System.EventHandler(this.CoordinatorDashboardModal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTS_AGGREGATETableAdapter studentS_AGGREGATETableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTS_AGGREGATETableAdapter disengageD_STUDENTS_AGGREGATETableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ENGAGEMENT_STATUS_TableAdapter studenT_ENGAGEMENT_STATUS_TableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTSTableAdapter disengageD_STUDENTSTableAdapter1;
    }
}