using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Interop;
using MahApps.Metro.Controls;
using SSS_Library;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;
using SSS_Library.PasswordHandler;
using SSS_Library.WindowHandler;

//Not so Given
//TODO messageboxes to dialogues
namespace SSS_Materials_Design_Forms.Forms
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        private readonly USERPROFILETableAdapter _userProfileTableAdapter;
        private readonly PasswordBuilder _passwordBuilder = new PasswordBuilder(new StringHandler());
        private readonly DialogService _dialogService = new DialogService();
        private readonly WpfWindowCloseHandler _wpfWindowCloseHandler = new WpfWindowCloseHandler();
        private int _userId;
        private string _password;

        public Login()
        {
            _userProfileTableAdapter = new USERPROFILETableAdapter {ClearBeforeFill = true};
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var sInput = UsernameTextBox.Text;
            var sPassword = PasswordTextBox.Password;

            if (sInput == null || sInput.Equals(""))
            {
                _dialogService.CallMessageModal(this, "", SSS_Library.Properties.Resources.IncorrectLoginDetailsMessage);
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
                UsernameTextBox.Focus();
            }
            else
            {
                if (sPassword.Equals("HereBeDragons") && (sInput.Equals("Admin") || sInput.Equals("admin") || sInput.Equals("Administrator") || sInput.Equals("administrator")))
                {
                    MetroWindow adminShow = new Administrator.Administrator();
                    adminShow.Owner = this;
                    adminShow.Show();
                    this.Hide();
                }
                else if (!SSS_Library.DataServices.StringHandler.CheckIfStringANumber(sInput) || !sPassword.Equals("HereBeDragons") && (sInput.Equals("Admin") || sInput.Equals("admin") || sInput.Equals("Administrator") || sInput.Equals("administrator")))
                {
                    _dialogService.CallMessageModal(this, "", SSS_Library.Properties.Resources.IncorrectLoginDetailsMessage);
                    PasswordTextBox.Clear();
                    UsernameTextBox.Clear();
                    UsernameTextBox.Focus();
                }
                else
                {
                    _userId = Convert.ToInt32(sInput);
                    var userProfile = _userProfileTableAdapter.GetData().FindByuser_id(_userId);

                    if (userProfile == null)
                    {
                        _dialogService.CallMessageModal(this, "", SSS_Library.Properties.Resources.IncorrectLoginDetailsMessage);
                        UsernameTextBox.Clear();
                        PasswordTextBox.Clear();
                        UsernameTextBox.Focus();
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
                                //coordinator role = 2
                                if (userProfile.user_roles_id == 2)
                                {
                                    MetroWindow coordinatorShow = new Coordinator(_userId);
                                    coordinatorShow.Owner = this;
                                    coordinatorShow.Show();
                                    this.Hide();
                                }
                                //student role = 4
                                else if (userProfile.user_roles_id == 4)
                                {
                                    MetroWindow studentShow = new Student(_userId);
                                    studentShow.Owner = this;
                                    studentShow.Show();
                                    this.Hide();
                                }
                                //tutor role = 3
                                else if (userProfile.user_roles_id == 3)
                                {
                                    MetroWindow tutorShow = new Tutor(_userId);
                                    tutorShow.Owner = this;
                                    tutorShow.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool CheckPassword(IS2G10_DBSSSDataSet.USERPROFILERow userProfile, string sPass)
        {
            var check = _passwordBuilder.CheckPassword(sPass, userProfile.password_hash, userProfile.password_salt);
            //check if password is right
            if (!check)
            {
                _dialogService.CallMessageModal(this, "", SSS_Library.Properties.Resources.IncorrectLoginDetailsMessage);
                PasswordTextBox.Clear();
                UsernameTextBox.Clear();
                UsernameTextBox.Focus();
            }
            return check;
        }

        private void CreatePassword(IS2G10_DBSSSDataSet.USERPROFILERow userProfile)
        {
            _password = null;

            var createPasswordWindow = new CreatePassword();
            if (createPasswordWindow.ShowDialog() == true)
            {
                _password = createPasswordWindow.Password; //values preserved after close
            }

            if (_password != null && !_password.Equals(""))
            {
                string hash;
                string salt;
                _passwordBuilder.CreateHash(_password, out hash, out salt);
                userProfile.resetPassword = false;
                userProfile.password_hash = hash;
                userProfile.password_salt = salt;
                _userProfileTableAdapter.Update(userProfile);

                _dialogService.CallMessageModal(this, "", SSS_Library.Properties.Resources.Login_CheckPassword_Password_Created_Successfully);
            }

            if (_password != null && _password.Equals("") || _password == null)
            {
                _dialogService.CallMessageModal(this, "", SSS_Library.Properties.Resources.Login_CheckPassword_Please_Enter_a_Password_);
            }
        }

        //This is what chooses old forms or new metro design
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong);

        /// <summary>
        /// sets the owner of a System.Windows.Forms.Form to a System.Windows.Window
        /// </summary>
        /// <param name="form"></param>
        /// <param name="owner"></param>
        public static void SetOwner(System.Windows.Forms.Form form, System.Windows.Window owner)
        {
            WindowInteropHelper helper = new WindowInteropHelper(owner);
            SetWindowLong(new HandleRef(form, form.Handle), -8, helper.Handle.ToInt32());
        }

        private void Login1_Activated(object sender, EventArgs e)
        {
            PasswordTextBox.Clear();
            UsernameTextBox.Clear();
            UsernameTextBox.Focus();
        }

        [STAThread]
        private void goToOldForms_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(2);
        }
    }
}
