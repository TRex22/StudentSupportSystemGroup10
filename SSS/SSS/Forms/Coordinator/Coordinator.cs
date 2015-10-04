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

namespace SSS
{
    public partial class Coordinator : Form
    {

        //global vars
        private readonly string _sUser;
        private string _sPassword;
        private readonly RegisterStudentModal _registerStudentModal = new RegisterStudentModal();
        private readonly CoordinatorDashboardModal _coordinatorDashboardModal = new CoordinatorDashboardModal();

        public Coordinator(String sUsr, String sPsswrd)
        {
            InitializeComponent();
            _sUser = sUsr;
            _sPassword = sPsswrd;
            lblCoordinatorName.Text = "Gerhard Snell - " + _sUser;
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
        }

        private void HideAllModals()
        {
            _registerStudentModal.Hide();
            _coordinatorDashboardModal.Hide();
            //TODO Add hide for other modals
        }

        private void Coordinator_Load(object sender, EventArgs e)
        {
            HideAllModals();
            _coordinatorDashboardModal.Show();
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString().ToString();
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
            HideAllModals();
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
    }
}
