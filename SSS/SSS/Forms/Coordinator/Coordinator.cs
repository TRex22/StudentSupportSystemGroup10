using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS.Forms.Coordinator;
using SSS.Forms.Coordinator.LowTutorRatings;
using SSS.Forms.Coordinator.TutorRatings;

namespace SSS
{
    public partial class Coordinator : Form
    {

        //global vars
        private readonly String _sPassword = "";

        //database stuff

        //modals
        private readonly RegisterStudentModal _registerStudentModal;
        private readonly CoordinatorDashboardModal _coordinatorDashboardModal = new CoordinatorDashboardModal();
        private readonly StudentEngagementModal _studentDisengagementModal = new StudentEngagementModal();
        private readonly TutorRatingsA_ListModal _tutorRatingsAModal = new TutorRatingsA_ListModal();
        private readonly TutorRatingB_IndividualModal _tutorRatingBIndividualModal = new TutorRatingB_IndividualModal();
        private readonly TutorRatingCModal _tutorRatingCModal = new TutorRatingCModal();
        private readonly RegisterTutorModal _registerTutorModal = new RegisterTutorModal();
        private readonly ViewDisengagedStudentsModal _viewDisengagedStudentsModal = new ViewDisengagedStudentsModal();
        private readonly SearchStudentModal _searchStudentModal;
        private readonly SearchStudentModal _updateStudentModal;
        private readonly SearchTutorModal _searchTutorModal;
        private readonly SearchTutorModal _updateTutorModal;

        public Coordinator(String sUsrId, String sPsswrd)
        {
            InitializeComponent();
            _sPassword = sPsswrd;
            var userId = Convert.ToInt32(sUsrId);
            var coordinatorData = sSS_COORDINATORTableAdapter.GetData().FindBycoordinator_id(Convert.ToInt32(userId));
            _registerStudentModal = new RegisterStudentModal(userId);

            _searchStudentModal = new SearchStudentModal(userId, false);
            _updateStudentModal = new SearchStudentModal(userId, true) {Parent = this};

            _searchTutorModal = new SearchTutorModal(userId, false);
            _updateTutorModal = new SearchTutorModal(userId, true) { Parent = this };

            lblCoordinatorName.Text = String.Format("{0} {1} {2}", coordinatorData.coordinator_firstname, coordinatorData.coordinator_lastname, userId);
            tmrSecond.Start();
            InitModals();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void InitModals()
        {
            //init internal window
            this.panel7.Controls.Add(_registerStudentModal);
            this.panel7.Controls.Add(_coordinatorDashboardModal);
            this.panel7.Controls.Add(_studentDisengagementModal);
            this.panel7.Controls.Add(_tutorRatingsAModal);
            this.panel7.Controls.Add(_tutorRatingBIndividualModal);
            this.panel7.Controls.Add(_tutorRatingCModal);
            this.panel7.Controls.Add(_registerTutorModal);
            this.panel7.Controls.Add(_viewDisengagedStudentsModal);
            this.panel7.Controls.Add(_searchStudentModal);
            this.panel7.Controls.Add(_updateStudentModal);
            this.panel7.Controls.Add(_searchTutorModal);
            this.panel7.Controls.Add(_updateTutorModal);
        }

        public void SetModal(Control vaule)
        {
            this.panel7.Controls.Add(vaule);
        }

        private void HideAllModals()
        {
            foreach (Form modal in panel7.Controls)
            {
                modal.Hide();
            }
        }

        private void Coordinator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.SSS_COORDINATOR' table. You can move, or remove it, as needed.
            this.sSS_COORDINATORTableAdapter.Fill(this.iS2G10_DBSSSDataSet.SSS_COORDINATOR);
            HideAllModals();
            _coordinatorDashboardModal.Show();
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            lblDate.Text = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _registerStudentModal.Show();
        }

        private void createTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _registerTutorModal.Show();
        }

        private void updateTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _updateTutorModal.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _updateStudentModal.Show();
        }

        private void assignTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _searchStudentModal.Show();
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HideAllModals();

            //TODO remove
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentModal.Close();
            this.Close(); 
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _coordinatorDashboardModal.Show();
        }

        private void studentDisengagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
           
            _studentDisengagementModal.reportViewer1.RefreshReport();
            _studentDisengagementModal.Show();
        }

        private void lowTutorRatingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void averageTutorRatingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _tutorRatingsAModal.Show();
        }

        private void viewTutorRatingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _tutorRatingBIndividualModal.Show();
        }

        private void viewDisengagedStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _viewDisengagedStudentsModal.Show();
        }

        private void searchTutorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _searchTutorModal.Show();
        }
    }
}
