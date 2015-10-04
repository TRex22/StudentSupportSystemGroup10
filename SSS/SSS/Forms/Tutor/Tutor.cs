using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS.Forms.Tutor;

namespace SSS
{
    public partial class Tutor : Form
    {

        //global vars
        private String sUser = "";
        private String sPassword = "";
        private readonly UpdateStudentAttendanceModal _updateStudentAttendanceModal = new UpdateStudentAttendanceModal();
        private readonly TutorDashboardModal _tutorDashboardModal = new TutorDashboardModal();

        public Tutor(String sUsr, String sPsswrd)
        {
            InitializeComponent();
            sUser = sUsr;
            sPassword = sPsswrd;
            InitModals();
        }

        private void InitModals()
        {
            //init internal window
            this.panel7.Controls.Add(_updateStudentAttendanceModal);
            this.panel7.Controls.Add(_tutorDashboardModal);
        }

        private void HideAllModals()
        {
            _updateStudentAttendanceModal.Hide();
            _tutorDashboardModal.Hide();
            //TODO Add hide for other modals
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Tutor_Load(object sender, EventArgs e)
        {
            //TODO Select default modal
            HideAllModals();
            _tutorDashboardModal.Show();
        }

        private void createTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _updateStudentAttendanceModal.Show();
        }

        private void updateTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void updateStudentConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _updateStudentAttendanceModal.Close();
            this.Close();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _tutorDashboardModal.Show();
        }
    }
}
