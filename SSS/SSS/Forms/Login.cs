using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS.Properties;

namespace SSS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //TODO secure login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sInput = "";
            string sPassword = "";

            sInput = medUsername.Text;
            sPassword = medPassword.Text;

            if (sInput.Equals("76582"))
            {
                Form CoordinatorShow = new Coordinator(sInput, sPassword);
                CoordinatorShow.Owner = this;
                CoordinatorShow.Show();
                this.Hide();

            }
            else if(sInput.Equals("10003"))
            {
                Form StudentShow = new Student(sInput, sPassword);
                StudentShow.Owner = this;
                StudentShow.Show();
                this.Hide();
            }
            else if(sInput.Equals("20001"))
            {
                Form TutorShow = new Tutor(sInput, sPassword);
                TutorShow.Owner = this;
                TutorShow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(String.Format("{0}", Resources.IncorrectLoginDetailsMessage));
                medPassword.Clear();
                medUsername.Clear();
                medUsername.Focus();

            }

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
