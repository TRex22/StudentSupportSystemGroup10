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
    public partial class Tutor : Form
    {

        //global vars
        private String sUser = "";
        private String sPassword = "";
        private readonly UpdateStudentAttendanceModal _updateStudentAttendanceModal = new UpdateStudentAttendanceModal();

        public Tutor(String sUsr, String sPsswrd)
        {
            InitializeComponent();
            sUser = sUsr;
            sPassword = sPsswrd;
            initModals();
        }

        private void initModals()
        {
            //init internal window
            _updateStudentAttendanceModal.TopLevel = false;
            _updateStudentAttendanceModal.AutoScroll = true;
            this.panel7.Controls.Add(_updateStudentAttendanceModal);
            _updateStudentAttendanceModal.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Tutor_Load(object sender, EventArgs e)
        {
            //TODO Select default modal

        }

        private void createTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _updateStudentAttendanceModal.Hide();
            //TODO Add hide for other modals
        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO Add hide for other modals
            _updateStudentAttendanceModal.Hide();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _updateStudentAttendanceModal.Show();
            //TODO Add hide for other modals
        }

        private void updateTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO Add hide for other modals
            _updateStudentAttendanceModal.Hide();
        }

        private void updateStudentConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO Add hide for other modals
            _updateStudentAttendanceModal.Hide();
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO Add hide for other modals
            _updateStudentAttendanceModal.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _updateStudentAttendanceModal.Close();
            this.Close();
        }
    }
}
