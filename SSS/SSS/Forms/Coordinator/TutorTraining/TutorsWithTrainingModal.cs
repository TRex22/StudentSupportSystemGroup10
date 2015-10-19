using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Library;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Windows_Forms.Forms.Coordinator.TutorTraining
{
    public partial class TutorsWithTrainingModal : Form
    {
        private readonly AVERAGE_TUTOR_RATING_WITH_TRAININGTableAdapter _averageTutorRatingWithTrainingTableAdapter = new AVERAGE_TUTOR_RATING_WITH_TRAININGTableAdapter();
        public TutorsWithTrainingModal()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void BindData()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

            IS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING_WITH_TRAININGTableAdapterDataTable avgTutorRatingWithTraining = new IS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING_WITH_TRAININGTableAdapterDataTable();
            avgTutorRatingWithTraining.Constraints.Clear();
            _averageTutorRatingWithTrainingTableAdapter.Fill(avgTutorRatingWithTraining);
            avgTutorRatingWithTraining.TableName = "AverageTutorRatingWithTraining";

            reportDataSource1.Name = "AverageTutorRatingWithTraining";
            reportDataSource1.Value = avgTutorRatingWithTraining;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
        }

        private void TutorsWithTrainingModal_Load(object sender, EventArgs e)
        {
            BindData();
            this.reportViewer1.RefreshReport();
        }
    }
}
