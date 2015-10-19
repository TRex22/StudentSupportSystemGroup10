using System;
using System.Windows.Forms;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Windows_Forms.Forms.Student
{
    public partial class StudentDashboardModal : Form
    {
        private readonly STUDENTTableAdapter _studentTableAdapter1 = new STUDENTTableAdapter()
        {
            ClearBeforeFill = true
        };
        private readonly SEARCH_STUDENTTableAdapter _searcHStudentTableAdapter1 = new SEARCH_STUDENTTableAdapter()
        {
            ClearBeforeFill = true
        };
        private SEARCH_GROUP_BY_STUDENTTableAdapter _searchGroupByStudentTableAdapter = new SEARCH_GROUP_BY_STUDENTTableAdapter()
        {
            ClearBeforeFill = true
        };
        private SEARCH_CONSULTATION_BY_STUDENTTableAdapter _searchConsultationByStudentTableAdapter = new SEARCH_CONSULTATION_BY_STUDENTTableAdapter()
        {
            ClearBeforeFill = true
        };
        private readonly int _userId;
        private readonly SSS_Library.IS2G10_DBSSSDataSet.STUDENTDataTable _studentDataTable;

        public StudentDashboardModal(int userId)
        {
            _userId = userId;
            _studentDataTable = new SSS_Library.IS2G10_DBSSSDataSet.STUDENTDataTable();
            _studentDataTable.ImportRow(this._studentTableAdapter1.GetData().FindBystudent_id(_userId));
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void BindData()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDataSource1.Name = "Students";
            reportDataSource1.Value = _studentTableAdapter1.GetData();
            reportDataSource2.Name = "SearchStudent";
            reportDataSource2.Value = _studentDataTable;
            reportDataSource3.Name = "SearchConsultation";
            reportDataSource3.Value = _searcHStudentTableAdapter1.GetData(_userId);
            reportDataSource4.Name = "SearchGroup";
            reportDataSource4.Value = _searchGroupByStudentTableAdapter.GetData(_userId);
            reportDataSource5.Name = "SearchTopFiveConsultationByStudent";
            reportDataSource5.Value = _searchConsultationByStudentTableAdapter.GetData(_userId);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
        }

        private void StudentDashboardModal_Load(object sender, EventArgs e)
        {
            BindData();
            this.reportViewer1.RefreshReport();
        }
    }
}
