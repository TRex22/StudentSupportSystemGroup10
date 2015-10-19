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
    public partial class TutorsWithoutTrainingModal : Form
    {
        private readonly AVERAGE_TUTOR_RATING_WITHOUT_TRAININGTableAdapter _averageTutorRatingWithoutTrainingTableAdapter = new AVERAGE_TUTOR_RATING_WITHOUT_TRAININGTableAdapter();
        public TutorsWithoutTrainingModal()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void BindData()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

            IS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING_WITHOUT_TRAININGDataTable avgTutorRatingNoTraining = new IS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING_WITHOUT_TRAININGDataTable();
            avgTutorRatingNoTraining.Constraints.Clear();
            _averageTutorRatingWithoutTrainingTableAdapter.Fill(avgTutorRatingNoTraining);
            avgTutorRatingNoTraining.TableName = "AverageTutorRatingWithoutTraining";

            reportDataSource1.Name = "AverageTutorRatingWithoutTraining";
            reportDataSource1.Value = avgTutorRatingNoTraining;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
        }

        private void TutorsWithoutTrainingModal_Load(object sender, EventArgs e)
        {
            BindData();
            this.reportViewer1.RefreshReport();
        }
    }
}
