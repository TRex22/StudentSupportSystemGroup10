using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Windows_Forms.Forms.Tutor
{
    public partial class TutorDashboardModal : Form
    {
        private readonly AVERAGE_RATINGSTableAdapter _averageRatingsTableAdapter = new AVERAGE_RATINGSTableAdapter();
        private readonly AVERAGE_TUTOR_RATINGTableAdapter _averageTutorRatingTableAdapter = new AVERAGE_TUTOR_RATINGTableAdapter();
        private readonly CONSULTATION_FOR_STUDENTTableAdapter _consultationForStudentTableAdapter = new CONSULTATION_FOR_STUDENTTableAdapter();
        private readonly CONSULTATIONTableAdapter _consultationTableAdapter = new CONSULTATIONTableAdapter();

        private readonly int _userId;
        public TutorDashboardModal(int userId)
        {
            _userId = userId;
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

            reportDataSource1.Name = "AverageRatings";
            reportDataSource1.Value = _averageRatingsTableAdapter.GetData();
            reportDataSource2.Name = "AverageTutorRating";
            reportDataSource2.Value = _averageTutorRatingTableAdapter.GetData();
            reportDataSource3.Name = "ConsultationForStudent";
            reportDataSource3.Value = _consultationForStudentTableAdapter.GetData(_userId);
            reportDataSource4.Name = "Consultation";
            reportDataSource4.Value = _consultationTableAdapter.GetData();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
        }

        private void TutorDashboardModal_Load(object sender, EventArgs e)
        {
            BindData();
            this.reportViewer1.RefreshReport();
        }

        private void TutorDashboardModal_VisibleChanged(object sender, EventArgs e)
        {
            reportViewer1.Refresh();
        }
    }
}
