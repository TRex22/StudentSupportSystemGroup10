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
        private readonly StudentDisengagementModal _studentDisengagementModal = new StudentDisengagementModal();
        private readonly LowTutorRatingsA_ListModal _lowTutorRatingsAModal = new LowTutorRatingsA_ListModal();
        private readonly LowTutorRatingB_IndividualModal _lowTutorRatingBIndividualModal = new LowTutorRatingB_IndividualModal();

        public Coordinator(String sUsrId, String sPsswrd)
        {
            InitializeComponent();
            _sPassword = sPsswrd;
            var userId = Convert.ToInt32(sUsrId);
            var coordinatorData = sSS_COORDINATORTableAdapter.GetData().FindBycoordinator_id(Convert.ToInt32(userId));
            _registerStudentModal = new RegisterStudentModal(userId);

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
            this.panel7.Controls.Add(_lowTutorRatingsAModal);
            this.panel7.Controls.Add(_lowTutorRatingBIndividualModal);
        }

        private void HideAllModals()
        {
            _registerStudentModal.Hide();
            _coordinatorDashboardModal.Hide();
            _studentDisengagementModal.Hide();
            _lowTutorRatingsAModal.Hide();
            _lowTutorRatingBIndividualModal.Hide();
            //TODO Add hide for other modals
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
        }

        private void updateTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void assignTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
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
            HideAllModals();
            //_lowTutorRatingsAModal.Show();
            //hack for design
            _lowTutorRatingBIndividualModal.Show();
        }
    }
}
