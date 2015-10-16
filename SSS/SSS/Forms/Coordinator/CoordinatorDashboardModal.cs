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
        public CoordinatorDashboardModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void CoordinatorDashboardModal_Load(object sender, EventArgs e)
        {
            /*StudentEngagementStatuses
                DisengagedStudents
                DisengagedStudentsAggregate
                StudentsAggregate*/
            BindData();
            this.reportViewer1.RefreshReport();
        }

        private void BindData()
        {
            var studentEngagementStatus = studenT_ENGAGEMENT_STATUS_TableAdapter1.GetData();
            var studentsAggregate = studentS_AGGREGATETableAdapter1.GetData();
            var disengagedStudents = disengageD_STUDENTSTableAdapter1.GetData();
            var disengagedStudentsAggregate = disengageD_STUDENTS_AGGREGATETableAdapter1.GetData();
            //ReportDataSource rds = new ReportDataSource("extraMove", ret.ToArray());
            



        }
    }
}
