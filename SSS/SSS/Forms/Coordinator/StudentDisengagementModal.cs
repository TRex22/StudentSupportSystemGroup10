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
    public partial class StudentDisengagementModal : Form
    {
        public StudentDisengagementModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void StudentDisengagementModal_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            var studentEngagementStatusReportDataTable = new IS2G10_DBSSSDataSet.STUDENT_ENGAGEMENT_STATUS_REPORTDataTable();
            reportTableAdapter.Fill(studentEngagementStatusReportDataTable);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("StudentEngagementStatuses", (DataTable)studentEngagementStatusReportDataTable));
            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Hyperlink(object sender, HyperlinkEventArgs e)
        {
            MessageBox.Show("You pressed a button");
        }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            this.reportViewer1.Reset();
        }
    }
}
