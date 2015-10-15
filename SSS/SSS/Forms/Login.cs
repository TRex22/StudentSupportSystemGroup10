using System;
using System.Windows.Forms;
using SSS_Library;
using SSS_Library.PasswordHandler;
using SSS_Library.Properties;

namespace SSS_Windows_Forms.Forms
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
            //Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var sInput = medUsername.Text;
            var sPassword = medPassword.Text;

            if (sInput.Equals("HereBeDragons"))
            {
                //open secret window
                //TODO Secret Window
            }
            else
            {
                _userId = Convert.ToInt32(sInput);

                IS2G10_DBSSSDataSet.USERPROFILERow userProfile = userprofileTableAdapter1.GetData().FindByuser_id(_userId);

                if (userProfile == null)
                {
                    MessageBox.Show(String.Format("{0}", Resources.IncorrectLoginDetailsMessage));
                    medPassword.Clear();
                    medUsername.Clear();
                    medUsername.Focus();
                }
                else
                {
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
                                Form coordinatorShow = new Coordinator.Coordinator(_userId);
                                coordinatorShow.Owner = this;
                                coordinatorShow.Show();
                                this.Hide();

                            }
                            else if (userProfile.student_id != null && _userId == userProfile.student_id)
                            {
                                Form studentShow = new SSS_Windows_Forms.Student(_userId);
                                studentShow.Owner = this;
                                studentShow.Show();
                                this.Hide();
                            }
                            else if (userProfile.tutor_id != null && _userId == userProfile.tutor_id)
                            {
                                Form tutorShow = new SSS_Windows_Forms.Tutor(sInput, sPassword);
                                tutorShow.Owner = this;
                                tutorShow.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private bool CheckPassword(SSS_Library.IS2G10_DBSSSDataSet.USERPROFILERow userProfile, string sPass)
        {
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

        private void CreatePassword(SSS_Library.IS2G10_DBSSSDataSet.USERPROFILERow userProfile)
        {
            _password = null;
            using (var form = new CreatePassword())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _password = form.Password;          //values preserved after close
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
            Environment.Exit(0);
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

        private void changeDesignBtn_Click(object sender, EventArgs e)
        {
            //close this and open metro
            /*var metroWindow = new Login1();
            metroLogin.Show();*/
            this.Close();
        }
    }
}
