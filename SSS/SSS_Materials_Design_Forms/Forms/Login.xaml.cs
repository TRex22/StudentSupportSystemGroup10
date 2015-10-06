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
using System.Windows.Forms.Integration; //Not so Given

namespace SSS_Materials_Design_Forms
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string sInput = "";
            string sPassword = "";

            sInput = UsernameTextBox.Text;
            sPassword = PasswordTextBox.Text;

            if (sInput.Equals("76582"))
            {
                Form CoordinatorShow = new SSS.Coordinator(sInput, sPassword);
                SetOwner(CoordinatorShow, this);
                CoordinatorShow.Show();
                this.Hide();

            }
            else if (sInput.Equals("10003"))
            {
                /*Form StudentShow = new SSS.Student(sInput, sPassword);
                SetOwner(StudentShow, this);
                StudentShow.Show();*/
                MetroWindow StudentShow = new Student();
                StudentShow.Owner = this;
                StudentShow.Show();
                this.Hide();
            }
            else if (sInput.Equals("20001"))
            {
                Form TutorShow = new SSS.Tutor(sInput, sPassword);
                SetOwner(TutorShow, this);
                TutorShow.Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(String.Format("{0}", SSS.Properties.Resources.IncorrectLoginDetailsMessage));
                PasswordTextBox.Clear();
                UsernameTextBox.Clear();
                UsernameTextBox.Focus();

            }
        }

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
    }
}
