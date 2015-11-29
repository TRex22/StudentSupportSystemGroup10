using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Windows_Forms.Forms.Student;

namespace SSS_Windows_Forms
{
    public partial class Student : Form
    {
        //database stuff
        private readonly SSS_Library.IS2G10_DBSSSDataSet.STUDENTRow _studentData;

        //Modals
        private readonly UpdateStudentProfileModal _updateStudentProfileModalModal;
        public readonly StudentDashboardModal StudentDashboardModal;
        public readonly RegisterGroupModal RegisterGroupModal;
        public readonly CreateConsultationModal CreateConsultationModal;
        private readonly RateConsultationModal _rateConsultationModal;
        private readonly RateActivityModal _rateActivityModal;
        private readonly RateTutorActivityModal _rateTutorActivityModal;

        public Student(int userId)
        {
            InitializeComponent();
            
            _studentData = sTUDENTTableAdapter.GetData().FindBystudent_id(userId);
            lblStudentName.Text = String.Format("{0} {1} {2}", _studentData.student_firstname, _studentData.student_lastname, userId);
            StudentDashboardModal = new StudentDashboardModal(userId);
            _updateStudentProfileModalModal = new UpdateStudentProfileModal(userId);
            RegisterGroupModal = new RegisterGroupModal(userId, this);
            CreateConsultationModal = new CreateConsultationModal(userId, _studentData);
            _rateConsultationModal = new RateConsultationModal(userId);
            _rateActivityModal = new RateActivityModal(userId, _studentData.coordinator_id);
            _rateTutorActivityModal = new RateTutorActivityModal(userId, _studentData.coordinator_id);
            InitModals();

            //check if user has a group
            if (!_studentData.Isgroup_idNull())
                joinGroupToolStripMenuItem.Enabled = false;
        }

        private void InitModals()
        {
            //init internal window
            this.panel7.Controls.Add(_updateStudentProfileModalModal);
            this.panel7.Controls.Add(StudentDashboardModal);
            this.panel7.Controls.Add(RegisterGroupModal);
            this.panel7.Controls.Add(CreateConsultationModal);
            this.panel7.Controls.Add(_rateConsultationModal);
            this.panel7.Controls.Add(_rateActivityModal);
            this.panel7.Controls.Add(_rateTutorActivityModal);
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

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.iS2G10_DBSSSDataSet.STUDENT);
            HideAllModals();
            StudentDashboardModal.Show();
        }

        private void updateTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            RegisterGroupModal.Show();
        }

        private void createTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _rateActivityModal.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _updateStudentProfileModalModal.Show();
        }

        private void assignTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            CreateConsultationModal.Show();
        }

        
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            StudentDashboardModal.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            lblDate.Text = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _rateConsultationModal.Show();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _rateTutorActivityModal.Show();
        }
    }
}
