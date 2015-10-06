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
        private readonly String sPassword = "";

        //database stuff
        private readonly IS2G10_DBSSSDataSet.TUTORRow _tutorData;

        //Modals
        private readonly UpdateStudentAttendanceModal _updateStudentAttendanceModal;
        private readonly TutorDashboardModal _tutorDashboardModal = new TutorDashboardModal();
        private readonly UpdateTutorModal _updateTutorModal;

        public Tutor(String sUsrId, String sPsswrd)
        {
            InitializeComponent();
            var userId = Convert.ToInt32(sUsrId);
            _tutorData = tUTORTableAdapter.GetData().FindBytutor_id(userId);
            lblTutorName.Text = String.Format("{0} {1} {2}", _tutorData.tutor_firstname, _tutorData.tutor_lastname, userId);
            _updateTutorModal = new UpdateTutorModal(userId);
            _updateStudentAttendanceModal = new UpdateStudentAttendanceModal(userId);
            sPassword = sPsswrd;
            InitModals();
        }

        private void InitModals()
        {
            //init internal window
            this.panel7.Controls.Add(_updateStudentAttendanceModal);
            this.panel7.Controls.Add(_tutorDashboardModal);
            this.panel7.Controls.Add(_updateTutorModal);
        }

        private void HideAllModals()
        {
            _updateStudentAttendanceModal.Hide();
            _tutorDashboardModal.Hide();
            _updateTutorModal.Hide();
            //TODO Add hide for other modals
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Tutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.TUTOR' table. You can move, or remove it, as needed.
            this.tUTORTableAdapter.Fill(this.iS2G10_DBSSSDataSet.TUTOR);
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
            _updateTutorModal.Show();
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

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            lblDate.Text = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }
    }
}
