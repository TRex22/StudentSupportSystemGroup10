using System;
using System.Windows.Forms;
using SSS_Library;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Windows_Forms.Forms.Tutor
{
    public partial class Tutor : Form
    {
        //database stuff

        //Modals
        private readonly UpdateStudentAttendanceModal _updateStudentAttendanceModal;
        private readonly TutorDashboardModal _tutorDashboardModal;
        private readonly UpdateTutorModal _updateTutorModal;
        private readonly SearchConsultationModal _searchConsultationModal;
        private readonly TUTORTableAdapter _tUtorTableAdapter = new TUTORTableAdapter()
        {
            ClearBeforeFill = true
        };
        private readonly IS2G10_DBSSSDataSet _iS2G10DbsssDataSet = new IS2G10_DBSSSDataSet();

        public Tutor(int userId)
        {
            this._tUtorTableAdapter.Fill(this._iS2G10DbsssDataSet.TUTOR);
            IS2G10_DBSSSDataSet.TUTORRow tutorData = _tUtorTableAdapter.GetData().FindBytutor_id(userId);
            _updateTutorModal = new UpdateTutorModal(userId);
            _updateStudentAttendanceModal = new UpdateStudentAttendanceModal(userId);
            _tutorDashboardModal = new TutorDashboardModal(userId);
            _searchConsultationModal = new SearchConsultationModal(tutorData.coordinator_id, userId);//TODO FIX
            InitializeComponent();
            lblTutorName.Text = String.Format("{0} {1} {2}", tutorData.tutor_firstname, tutorData.tutor_lastname, userId);
            InitModals();
        }

        private void InitModals()
        {
            //init internal window
            this.panel7.Controls.Add(_updateStudentAttendanceModal);
            this.panel7.Controls.Add(_tutorDashboardModal);
            this.panel7.Controls.Add(_updateTutorModal);
            this.panel7.Controls.Add(_searchConsultationModal);
        }

        private void HideAllModals()
        {
            foreach (Form modal in panel7.Controls)
            {
                modal.Hide();
            }
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

        private void updateStudentConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _searchConsultationModal.Show();
        }
    }
}
