using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SSS_Library;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Windows_Forms.Forms.Coordinator
{
    public partial class CoordinatorDashboardModal : Form
    {
        private readonly STUDENTS_AGGREGATETableAdapter _studentSAggregateTableAdapter1 = new STUDENTS_AGGREGATETableAdapter() {ClearBeforeFill = true};
        private readonly DISENGAGED_STUDENTS_AGGREGATETableAdapter _disengageDStudentsAggregateTableAdapter1 = new DISENGAGED_STUDENTS_AGGREGATETableAdapter() { ClearBeforeFill = true };
        private readonly STUDENT_ENGAGEMENT_STATUS_TableAdapter _studenTEngagementStatusTableAdapter1 = new STUDENT_ENGAGEMENT_STATUS_TableAdapter() { ClearBeforeFill = true };
        private readonly DISENGAGED_STUDENTSTableAdapter _disengageDStudentsTableAdapter1 = new DISENGAGED_STUDENTSTableAdapter() { ClearBeforeFill = true };
        private readonly AVERAGE_RATINGSTableAdapter _averageRatingsTableAdapter = new AVERAGE_RATINGSTableAdapter() { ClearBeforeFill = true };
        private readonly AVERAGE_TUTOR_RATING_WITHOUT_TRAININGTableAdapter _averageTutorRatingWithoutTrainingTableAdapter = new AVERAGE_TUTOR_RATING_WITHOUT_TRAININGTableAdapter() { ClearBeforeFill = true };

        public CoordinatorDashboardModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void CoordinatorDashboardModal_Load(object sender, EventArgs e)
        {
            BindData();
            this.reportViewer1.RefreshReport();
        }

        private void BindData()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();

            IS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING_WITHOUT_TRAININGDataTable avgTutorRatingUntrained = new IS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING_WITHOUT_TRAININGDataTable();
            //_averageTutorRatingWithoutTrainingTableAdapter.Fill(avgTutorRatingUntrained);

            reportDataSource1.Name = "StudentEngagementStatuses";
            reportDataSource1.Value = _studenTEngagementStatusTableAdapter1.GetData();
            reportDataSource2.Name = "DisengagedStudents";
            reportDataSource2.Value = _disengageDStudentsTableAdapter1.GetData();
            reportDataSource3.Name = "DisengagedStudentsAggregate";
            reportDataSource3.Value = _disengageDStudentsAggregateTableAdapter1.GetData();
            reportDataSource4.Name = "StudentsAggregate";
            reportDataSource4.Value = _studentSAggregateTableAdapter1.GetData();
            reportDataSource5.Name = "AverageRatings";
            reportDataSource5.Value = _averageRatingsTableAdapter.GetData();
            reportDataSource6.Name = "AverageTutorRatingWithoutTraining";
            reportDataSource6.Value = avgTutorRatingUntrained;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
        }
    }
}
