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
using SSS.IS2G10_DBSSSDataSetTableAdapters;
using SSS.Properties;
using SSS_Library.PasswordHandler;

namespace SSS
{
    public partial class Login : Form
    {
        private readonly PasswordBuilder _passwordBuilder = new PasswordBuilder(new StringHandler());
        private int userId;

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

            userId = Convert.ToInt32(sInput);

            var userProfile = userprofileTableAdapter1.GetData().FindByuser_id(userId);

            var doILogin = CheckPassword(userProfile, sPassword);

            if (doILogin)
            {
                if (userId == userProfile.coordinator_id)
                {
                    Form CoordinatorShow = new Coordinator(sInput, sPassword);
                    CoordinatorShow.Owner = this;
                    CoordinatorShow.Show();
                    this.Hide();

                }
                else if (userId == userProfile.student_id)
                {
                    Form StudentShow = new Student(sInput, sPassword);
                    StudentShow.Owner = this;
                    StudentShow.Show();
                    this.Hide();
                }
                else if (userId == userProfile.tutor_id)
                {
                    Form TutorShow = new Tutor(sInput, sPassword);
                    TutorShow.Owner = this;
                    TutorShow.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(String.Format("{0}", Resources.IncorrectLoginDetailsMessage));
                medPassword.Clear();
                medUsername.Clear();
                medUsername.Focus();

            }

        }

        private bool CheckPassword(IS2G10_DBSSSDataSet.USERPROFILERow userProfile, string sPass)
        {
            bool login = false;
            //check if passwrod must be reset
            string hash;
            string salt;
            if (userProfile.resetPassword)
            {
                string password = null;
                using (var form = new CreatePassword())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        password = form.password;          //values preserved after close
                    }
                }
                if (!password.Equals("") || password != null)
                {
                    _passwordBuilder.CreateHash(password, out hash, out salt);
                    userProfile.resetPassword = false;
                    userProfile.password_hash = hash;
                    userProfile.password_salt = salt;
                    userprofileTableAdapter1.Update(userProfile);

                    MessageBox.Show(Resources.Login_CheckPassword_Password_Created_Successfully,
                        Resources.Login_CheckPassword_Password_Created_Successfully);
                }
                else
                {
                    
                }
                return login;
            }
            //check if password is right
            _passwordBuilder.CreateHash(sPass, out hash, out salt);
            userProfile.resetPassword = false;
            userProfile.password_hash = hash;
            userProfile.password_salt = salt;
            userprofileTableAdapter1.Update(userProfile);
            if (userProfile.password_hash == hash)
                return true;
            return false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
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
    }
}
