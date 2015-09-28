using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public partial class Coordinator : Form
    {

        //global vars
        private readonly string _sUser;
        private string _sPassword;
        private readonly RegisterStudentModal _registerStudentModal = new RegisterStudentModal();

        public Coordinator(String sUsr, String sPsswrd)
        {
            InitializeComponent();
            _sUser = sUsr;
            _sPassword = sPsswrd;
            lblCoordinatorName.Text = "Gerhard Snell - " + _sUser;
            tmrSecond.Start();
            initModals();
        }

        private void initModals()
        {
            //init internal window
            _registerStudentModal.TopLevel = false;
            _registerStudentModal.AutoScroll = true;
            this.panel7.Controls.Add(_registerStudentModal);
        }

        private void Coordinator_Load(object sender, EventArgs e)
        {
            //TODO Select default modal
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
          //  lblDate.Text = DateTime.Now.ToShortTimeString();
            lblDate.Text = DateTime.Now.ToLongTimeString().ToString();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentModal.Show();
            //TODO Add hide for other modals
        }

        private void createTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentModal.Hide();
            //TODO add show for tutor modal
        }

        private void updateTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentModal.Hide();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentModal.Hide();
        }

        private void assignTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentModal.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentModal.Hide();
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentModal.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentModal.Hide();
            //TODO Add logout
        }
    }
}
