﻿using System;
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
        private readonly UpdateStudentProfileModal _updateStudentProfileModalModal = new UpdateStudentProfileModal();

        public Student(String sUsr, String sPsswrd)
        {
            InitializeComponent();
            sUser = sUsr;
            sPassword = sPsswrd;
            InitModals();
        }

        private void InitModals()
        {
            //init internal window
            this.panel7.Controls.Add(_registerStudentAttendanceModal);
            this.panel7.Controls.Add(_updateStudentProfileModalModal);
        }

        private void HideAllModals()
        {
            _registerStudentAttendanceModal.Hide();
            _updateStudentProfileModalModal.Hide();
            //TODO Add hide for other modals
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void updateTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _registerStudentAttendanceModal.Show();
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
            _updateStudentProfileModalModal.Show();
        }

        private void assignTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void studentDisengagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void courseDisengagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _registerStudentAttendanceModal.Close();
            this.Close();
        }
    }
}