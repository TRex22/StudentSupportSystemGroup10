using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using SSS;
using System.Windows.Forms.Integration;
using SSS.IS2G10_DBSSSDataSetTableAdapters;
using SSS_Library.PasswordHandler;

//Not so Given
//TODO messageboxes to dialogues
namespace SSS_Materials_Design_Forms
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        private readonly USERPROFILETableAdapter _userProfileTableAdapter;
        private readonly PasswordBuilder _passwordBuilder = new PasswordBuilder(new StringHandler());
        private readonly DialogService _dialogService = new DialogService();
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

            if (sInput.Equals("HereBeDragons"))
            {
                //open secret window
                //TODO secret window
            }
            else
            {
                _userId = Convert.ToInt32(sInput);
                var userProfile = _userProfileTableAdapter.GetData().FindByuser_id(_userId);

                if (userProfile == null)
                {
                    _dialogService.CallMessageModal(this, "", SSS.Properties.Resources.IncorrectLoginDetailsMessage);
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
                            if (userProfile.coordinator_id != null && _userId == userProfile.coordinator_id)
                            {

                                this.Hide();

                            }
                            else if (userProfile.student_id != null && _userId == userProfile.student_id)
                            {
                                MetroWindow studentShow = new Student();
                                studentShow.Owner = this;
                                studentShow.Show();
                                this.Hide();
                            }
                            else if (userProfile.tutor_id != null && _userId == userProfile.tutor_id)
                            {

                                this.Hide();
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
                _dialogService.CallMessageModal(this, "", SSS.Properties.Resources.IncorrectLoginDetailsMessage);
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

                _dialogService.CallMessageModal(this, "", SSS.Properties.Resources.Login_CheckPassword_Password_Created_Successfully);
            }

            if (_password != null && _password.Equals("") || _password == null)
            {
                _dialogService.CallMessageModal(this, "", SSS.Properties.Resources.Login_CheckPassword_Please_Enter_a_Password_);
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
    }
}
