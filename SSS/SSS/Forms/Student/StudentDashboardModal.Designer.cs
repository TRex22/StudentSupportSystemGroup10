using SSS_Library;

namespace SSS_Windows_Forms.Forms.Student
{
    partial class StudentDashboardModal
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
            this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter();
            this.searcH_STUDENTTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SEARCH_STUDENTTableAdapter();
            this.groupTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            var studentDataTable = new SSS_Library.IS2G10_DBSSSDataSet.STUDENTDataTable();
            studentDataTable.ImportRow(this.studentTableAdapter1.GetData().FindBystudent_id(_userId));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "Students";
            reportDataSource5.Value = this.studentTableAdapter1.GetData();
            reportDataSource6.Name = "SearchStudent";
            reportDataSource6.Value = studentDataTable;
            reportDataSource7.Name = "Group";
            reportDataSource7.Value = this.groupTableAdapter1.GetData();
            reportDataSource8.Name = "SearchConsultation";
            reportDataSource8.Value = this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS_Windows_Forms.Reports.Student.StudentDashboardReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(753, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // IS2G10_DBSSSDataSetBindingSource
            // 
            // 
            // SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource
            // 
            this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource.DataSource = typeof(SSS_Library.IS2G10_DBSSSDataSet.SEARCH_STUDENT_CONSULTATION_TOP5DataTable);
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // searcH_STUDENTTableAdapter1
            // 
            this.searcH_STUDENTTableAdapter1.ClearBeforeFill = true;
            // 
            // groupTableAdapter1
            // 
            this.groupTableAdapter1.ClearBeforeFill = true;
            // 
            // StudentDashboardModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 539);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDashboardModal";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboardModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SEARCH_STUDENTTableAdapter searcH_STUDENTTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter groupTableAdapter1;
    }
}