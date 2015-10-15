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

namespace SSS_Windows_Forms.Forms.Coordinator
{
    public partial class StudentEngagementModal : Form
    {
        public StudentEngagementModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void StudentDisengagementModal_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataConnect();
            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            
        }

        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS.Reports.Coordinator.StudentEngagement.ViewDisengagedStudentsReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataConnect();
            this.reportViewer1.RefreshReport();
        }

        private void ReportDataConnect()
        {
            //student status
            var studentEngagementStatusReportDataTable = new SSS_Library.IS2G10_DBSSSDataSet.STUDENT_ENGAGEMENT_STATUS_REPORTDataTable();
            reportTableAdapter.Fill(studentEngagementStatusReportDataTable);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("StudentEngagementStatuses", (DataTable)studentEngagementStatusReportDataTable));

            //disengaged students
            var disengagedStudentsReportDataTable = new SSS_Library.IS2G10_DBSSSDataSet.DISENGAGED_STUDENTSDataTable();
            disengageD_STUDENTSTableAdapter1.Fill(disengagedStudentsReportDataTable);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DisengagedStudents", (DataTable)disengagedStudentsReportDataTable));

            //STUDENTS_AGGREGATE
            var studentAggregateReportDataTable = new SSS_Library.IS2G10_DBSSSDataSet.STUDENTS_AGGREGATEDataTable();
            studentS_AGGREGATETableAdapter1.Fill(studentAggregateReportDataTable);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("StudentsAggregate", (DataTable)studentAggregateReportDataTable));

            //DISENGAGED_STUDENTS_AGGREGATE
            var disengagedStudentsAggreagteDT = new SSS_Library.IS2G10_DBSSSDataSet.DISENGAGED_STUDENTS_AGGREGATEDataTable();
            disengageD_STUDENTS_AGGREGATETableAdapter1.Fill(disengagedStudentsAggreagteDT);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DisengagedStudentsAggregate", (DataTable)disengagedStudentsAggreagteDT));
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
        }
    }
}
