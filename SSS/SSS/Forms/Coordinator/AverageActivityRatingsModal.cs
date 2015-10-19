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
    public partial class AverageActivityRatingsModal : Form
    {
        private readonly AVERAGE_ACTIVITY_RATINGSTableAdapter _averageActivityRatingsTableAdapter = new AVERAGE_ACTIVITY_RATINGSTableAdapter();
        private readonly AVERAGE_RATINGSTableAdapter _averageRatingsTableAdapter = new AVERAGE_RATINGSTableAdapter();
        public AverageActivityRatingsModal()
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

            reportDataSource1.Name = "AverageActivityRatings";
            reportDataSource1.Value = _averageActivityRatingsTableAdapter.GetData();
            reportDataSource2.Name = "ActivityRatingsTotals";
            reportDataSource2.Value = _averageRatingsTableAdapter.GetData();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
        }

        private void AverageActivityRatingsModal_Load(object sender, EventArgs e)
        {
            BindData();
            this.reportViewer1.RefreshReport();
        }
    }
}
