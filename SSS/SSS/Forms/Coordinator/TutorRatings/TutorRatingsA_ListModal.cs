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

namespace SSS_Windows_Forms.Forms.Coordinator
{
    public partial class TutorRatingsAListModal : Form
    {
        private readonly AVERAGE_RATINGSTableAdapter _averageRatingsTableAdapter = new AVERAGE_RATINGSTableAdapter();
        private readonly AVERAGE_TUTOR_RATINGTableAdapter _averageTutorRatingTableAdapter = new AVERAGE_TUTOR_RATINGTableAdapter();
        private readonly ATTENDANCETableAdapter _attendanceTableAdapter = new ATTENDANCETableAdapter();
        public TutorRatingsAListModal()
        {
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

            reportDataSource1.Name = "AverageRatings";
            reportDataSource1.Value = _averageRatingsTableAdapter.GetData();
            reportDataSource2.Name = "AverageTutorRatings";
            reportDataSource2.Value = _averageTutorRatingTableAdapter.GetData();
            reportDataSource3.Name = "Attendance";
            reportDataSource3.Value = _attendanceTableAdapter.GetData();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
        }

        private void LowTutorRatingsModal_Load(object sender, EventArgs e)
        {
            BindData();
            this.reportViewer1.RefreshReport();
        }
    }
}
