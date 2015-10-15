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

namespace SSS_Windows_Forms.Forms.Coordinator
{
    public partial class CoordinatorDashboardModal : Form
    {
        private readonly SSS_Library.IS2G10_DBSSSDataSet.STUDENT_ENGAGEMENT_STATUS_REPORTDataTable _engagementStatusReportDataTable;
        public CoordinatorDashboardModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            _engagementStatusReportDataTable = new SSS_Library.IS2G10_DBSSSDataSet.STUDENT_ENGAGEMENT_STATUS_REPORTDataTable();
            studenT_ENGAGEMENT_STATUS_TableAdapter1.Fill(_engagementStatusReportDataTable);
        }

        private void CoordinatorDashboardModal_Load(object sender, EventArgs e)
        {
            chart1.DataSource = _engagementStatusReportDataTable;

            foreach (SSS_Library.IS2G10_DBSSSDataSet.STUDENT_ENGAGEMENT_STATUS_REPORTRow dataRow in _engagementStatusReportDataTable.Rows)
            {
                chart1.Series.Add(dataRow.student_status);
                DataPoint dp = new DataPoint();
                dp.SetValueY(dataRow.student_statuses);
                chart1.Series[dataRow.student_status].Points.Add(dp);
            }
            

        }
    }
}
