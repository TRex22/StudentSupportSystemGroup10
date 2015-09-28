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
    public partial class Student : Form
    {

        //global vars
        private readonly String sUser = "";
        private readonly String sPassword = "";
        private readonly RegisterStudentAttendanceModal _registerStudentAttendanceModal = new RegisterStudentAttendanceModal();

        public Student(String sUsr, String sPsswrd)
        {
            InitializeComponent();
            sUser = sUsr;
            sPassword = sPsswrd;
            initModals();
        }

        private void initModals()
        {
            //init internal window
            _registerStudentAttendanceModal.TopLevel = false;
            _registerStudentAttendanceModal.AutoScroll = true;
            this.panel7.Controls.Add(_registerStudentAttendanceModal);
            _registerStudentAttendanceModal.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //TODO check if this is what is wanted
            Application.Exit();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Hide();
            //TODO Add hide for other modals
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Show();
            //TODO Add hide for other modals
        }

        private void createTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Hide();
            //TODO Add hide for other modals
        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Hide();
            //TODO Add hide for other modals
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Hide();
            //TODO Add hide for other modals
        }

        private void assignTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Hide();
            //TODO Add hide for other modals
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Hide();
            //TODO Add hide for other modals
        }

        private void studentDisengagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Hide();
            //TODO Add hide for other modals
        }

        private void courseDisengagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Hide();
            //TODO Add hide for other modals
        }
    }
}
