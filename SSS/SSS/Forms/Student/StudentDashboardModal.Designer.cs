using SSS_Library;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sTUDENTTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEARCHGROUPBYSTUDENTTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEARCHCONSULTATIONBYSTUDENTTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.searcH_STUDENTTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SEARCH_STUDENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHGROUPBYSTUDENTTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHCONSULTATIONBYSTUDENTTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sTUDENTTableAdapterBindingSource
            // 
            this.sTUDENTTableAdapterBindingSource.DataSource = typeof(SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter);
            // 
            // SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource
            // 
            this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource.DataSource = typeof(SSS_Library.IS2G10_DBSSSDataSet.SEARCH_STUDENT_CONSULTATION_TOP5DataTable);
            // 
            // sEARCHGROUPBYSTUDENTTableAdapterBindingSource
            // 
            this.sEARCHGROUPBYSTUDENTTableAdapterBindingSource.DataSource = typeof(SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SEARCH_GROUP_BY_STUDENTTableAdapter);
            // 
            // sEARCHCONSULTATIONBYSTUDENTTableAdapterBindingSource
            // 
            this.sEARCHCONSULTATIONBYSTUDENTTableAdapterBindingSource.DataSource = typeof(SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SEARCH_CONSULTATION_BY_STUDENTTableAdapter);
            // 
            // groupTableAdapter1
            // 
            this.groupTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Students";
            reportDataSource1.Value = this.sTUDENTTableAdapterBindingSource;
            reportDataSource2.Name = "SearchStudent";
            reportDataSource2.Value = _studentDataTable;
            reportDataSource3.Name = "SearchConsultation";
            reportDataSource3.Value = this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource;
            reportDataSource4.Name = "SearchGroup";
            reportDataSource4.Value = searchGroupByStudentTableAdapter.GetData(_userId);
            reportDataSource5.Name = "SearchTopFiveConsultationByStudent";
            reportDataSource5.Value = searchConsultationByStudentTableAdapter.GetData(_userId);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS_Windows_Forms.Reports.Student.StudentDashboardReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(753, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // searcH_STUDENTTableAdapter1
            // 
            this.searcH_STUDENTTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHGROUPBYSTUDENTTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHCONSULTATIONBYSTUDENTTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SEARCH_STUDENT_CONSULTATION_TOP5DataTableBindingSource;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SEARCH_STUDENTTableAdapter searcH_STUDENTTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter groupTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SEARCH_GROUP_BY_STUDENTTableAdapter searchGroupByStudentTableAdapter = new SEARCH_GROUP_BY_STUDENTTableAdapter();
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SEARCH_CONSULTATION_BY_STUDENTTableAdapter searchConsultationByStudentTableAdapter = new SEARCH_CONSULTATION_BY_STUDENTTableAdapter();
        private System.Windows.Forms.BindingSource sTUDENTTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource sEARCHGROUPBYSTUDENTTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource sEARCHCONSULTATIONBYSTUDENTTableAdapterBindingSource;
    }
}