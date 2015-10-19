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

namespace SSS_Windows_Forms.Forms.Coordinator.TutorTraining
{
    public partial class TutorTrainingStatusModal : Form
    {
        private readonly AVERAGE_TUTOR_RATING_WITH_TRAININGTableAdapter _averageTutorRatingWithTrainingTableAdapter = new AVERAGE_TUTOR_RATING_WITH_TRAININGTableAdapter();
        private readonly AVERAGE_TUTOR_RATING_WITHOUT_TRAININGTableAdapter _averageTutorRatingWithoutTrainingTableAdapter = new AVERAGE_TUTOR_RATING_WITHOUT_TRAININGTableAdapter();

        public TutorTrainingStatusModal()
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

            reportDataSource1.Name = "AverageTutorRatingWithTraining";
            reportDataSource1.Value = _averageTutorRatingWithTrainingTableAdapter.GetData();
            reportDataSource2.Name = "AverageTutorRatingWithoutTraining";
            reportDataSource2.Value = _averageTutorRatingWithoutTrainingTableAdapter.GetData();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
        }

        private void TutorTrainingStatusModal_Load(object sender, EventArgs e)
        {
            BindData();
            this.reportViewer1.RefreshReport();
        }
    }
}
