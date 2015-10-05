using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SSS.Forms.Coordinator
{
    public partial class ViewDisengagedStudentsModal : Form
    {
        public ViewDisengagedStudentsModal()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void ReportDataConnect()
        {
            /*//student status
            var studentEngagementStatusReportDataTable = new IS2G10_DBSSSDataSet.STUDENT_ENGAGEMENT_STATUS_REPORTDataTable();
            reportTableAdapter.Fill(studentEngagementStatusReportDataTable);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("StudentEngagementStatuses", (DataTable)studentEngagementStatusReportDataTable));

            //disengaged students
            var disengagedStudentsReportDataTable = new IS2G10_DBSSSDataSet.DISENGAGED_STUDENTSDataTable();
            disengageD_STUDENTSTableAdapter1.Fill(disengagedStudentsReportDataTable);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DisengagedStudents", (DataTable)disengagedStudentsReportDataTable));

            //STUDENTS_AGGREGATE
            var studentAggregateReportDataTable = new IS2G10_DBSSSDataSet.STUDENTS_AGGREGATEDataTable();
            studentS_AGGREGATETableAdapter1.Fill(studentAggregateReportDataTable);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("StudentsAggregate", (DataTable)studentAggregateReportDataTable));

            //DISENGAGED_STUDENTS_AGGREGATE
            var disengagedStudentsAggreagteDT = new IS2G10_DBSSSDataSet.DISENGAGED_STUDENTS_AGGREGATEDataTable();
            disengageD_STUDENTS_AGGREGATETableAdapter1.Fill(disengagedStudentsAggreagteDT);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DisengagedStudentsAggregate", (DataTable)disengagedStudentsAggreagteDT));
        */
        }


        private void ViewDisengagedStudentsModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.DISENGAGED_STUDENTS_AGGREGATE' table. You can move, or remove it, as needed.
            this.dISENGAGED_STUDENTS_AGGREGATETableAdapter.Fill(this.iS2G10_DBSSSDataSet.DISENGAGED_STUDENTS_AGGREGATE);
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.DISENGAGED_STUDENTS' table. You can move, or remove it, as needed.
            this.dISENGAGED_STUDENTSTableAdapter.Fill(this.iS2G10_DBSSSDataSet.DISENGAGED_STUDENTS);

            this.reportViewer1.RefreshReport();
        }
    }
}
