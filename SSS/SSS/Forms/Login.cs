using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS.Forms;
using SSS.Forms.Coordinator;
using SSS.IS2G10_DBSSSDataSetTableAdapters;
using SSS.Properties;
using SSS_Library.PasswordHandler;

namespace SSS
{
    public partial class Login : Form
    {
        private readonly PasswordBuilder _passwordBuilder = new PasswordBuilder(new StringHandler());
        private int _userId;
        private string _password;

        public Login()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //clean kill
            Environment.Exit(0);
        }

        //TODO secure login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var sInput = medUsername.Text;
            var sPassword = medPassword.Text;

            _userId = Convert.ToInt32(sInput);

            var userProfile = userprofileTableAdapter1.GetData().FindByuser_id(_userId);

            if (userProfile == null)
            {
                MessageBox.Show(String.Format("{0}", Resources.IncorrectLoginDetailsMessage));
                medPassword.Clear();
                medUsername.Clear();
                medUsername.Focus();
            }

            if (userProfile.resetPassword)
            {
                CreatePassword(userProfile);
            }
            else
            {
                var doILogin = CheckPassword(userProfile, sPassword);

                if (doILogin)
                {
                    if (userProfile.coordinator_id != null && _userId == userProfile.coordinator_id)
                    {
                        Form CoordinatorShow = new Coordinator(sInput);
                        CoordinatorShow.Owner = this;
                        CoordinatorShow.Show();
                        this.Hide();

                    }
                    else if (userProfile.student_id != null && _userId == userProfile.student_id)
                    {
                        Form StudentShow = new Student(sInput, sPassword);
                        StudentShow.Owner = this;
                        StudentShow.Show();
                        this.Hide();
                    }
                    else if (userProfile.tutor_id!= null && _userId == userProfile.tutor_id)
                    {
                        Form TutorShow = new Tutor(sInput, sPassword);
                        TutorShow.Owner = this;
                        TutorShow.Show();
                        this.Hide();
                    }
                }
            }
        }

        private bool CheckPassword(IS2G10_DBSSSDataSet.USERPROFILERow userProfile, string sPass)
        {
            bool login = false;
            
            var check = _passwordBuilder.CheckPassword(sPass, userProfile.password_hash, userProfile.password_salt);
            //check if password is right
            if (!check)
            {
                MessageBox.Show(Resources.IncorrectLoginDetailsMessage, Resources.IncorrectLoginDetailsMessage);
                medPassword.Clear();
                medUsername.Clear();
                medUsername.Focus();
            }
            return check;
        }

        private void CreatePassword(IS2G10_DBSSSDataSet.USERPROFILERow userProfile)
        {
            _password = null;
            using (var form = new CreatePassword())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _password = form.password;          //values preserved after close
                }
            }

            if (_password != null && !_password.Equals(""))
            {
                string hash;
                string salt;
                _passwordBuilder.CreateHash(_password, out hash, out salt);
                userProfile.resetPassword = false;
                userProfile.password_hash = hash;
                userProfile.password_salt = salt;
                userprofileTableAdapter1.Update(userProfile);

                MessageBox.Show(Resources.Login_CheckPassword_Password_Created_Successfully,
                    Resources.Login_CheckPassword_Password_Created_Successfully);
            }

            if (_password != null && _password.Equals(""))
            {
                MessageBox.Show(Resources.Login_CheckPassword_Please_Enter_a_Password_,
                    Resources.Login_CheckPassword_Please_Enter_a_Password_);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //generate database data
            //GenerateUserProfiles();
            //GenerateActivities();

            Application.Exit();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            medPassword.Clear();
            medUsername.Clear();
            medUsername.Focus();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            medPassword.Clear();
            medUsername.Clear();
            medUsername.Focus();
        }

        private void GenerateActivities()
        {
            //10004
            UpdateActivitiesPerStudent(10004);
            //10005
            UpdateActivitiesPerStudent(10005);
            //10010
            UpdateActivitiesPerStudent(10010);
            //10013
            UpdateActivitiesPerStudent(10013);
        }

        private void UpdateActivitiesPerStudent(int studentId)
        {
            Random rnd = new Random();

            var activitiesTable = studenT_ACTIVITYTableAdapter1.GetData();
            foreach (var activity in activitiesTable)
            {
                int tutorRating = rnd.Next(1, 3);
                int activityRating = rnd.Next(3, 5);
                var newAttendance = attendanceTableAdapter1.Insert(studentId, activity.student_activity_id, tutorRating, activityRating, true);
            }
        }

        private void GenerateUserProfiles()
        {
            //quick hack
            var tutors = tutorTableAdapter1.GetData();
            foreach (var tutor in tutors)
            {
                userprofileTableAdapter1.Insert(tutor.tutor_id, tutor.tutor_emailaddress, null, null, tutor.tutor_id, null, null, null, null, false, true);
            }

            var students = studentTableAdapter1.GetData();
            foreach (var student in students)
            {
                userprofileTableAdapter1.Insert(student.student_id, student.student_emailaddress, student.student_id, null, null, null, null, null, null, false, true);
            }

            var coordinators = ssS_COORDINATORTableAdapter1.GetData();
            foreach (var coordinator in coordinators)
            {
                userprofileTableAdapter1.Insert(coordinator.coordinator_id, coordinator.coordinator_emailaddress, null, coordinator.coordinator_id, null, null, null, null, null, false, true);
            }
        }
    }
}
