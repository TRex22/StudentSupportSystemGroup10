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

namespace SSS_Windows_Forms.Forms.Tutor
{
    public partial class TutorDashboardModal : Form
    {
        private readonly AVERAGE_RATINGSTableAdapter _averageRatingsTableAdapter = new AVERAGE_RATINGSTableAdapter();
        private readonly AVERAGE_TUTOR_RATINGTableAdapter _averageTutorRatingTableAdapter = new AVERAGE_TUTOR_RATINGTableAdapter();
        private readonly CONSULTATION_FOR_STUDENTTableAdapter _consultationForStudentTableAdapter = new CONSULTATION_FOR_STUDENTTableAdapter();
        private readonly CONSULTATIONTableAdapter _consultationTableAdapter = new CONSULTATIONTableAdapter();

        private readonly int _userId;
        public TutorDashboardModal(int userId)
        {
            _userId = userId;
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void TutorDashboardModal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
