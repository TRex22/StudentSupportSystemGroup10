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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //TODO check if this is what is wanted
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sInput = "";
            string sPassword = "";

            sInput = medUsername.Text;
            sPassword = medPassword.Text;

            if (sInput.Equals("AB005"))
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
            else if(sInput.Equals("918761"))
            {
                Form TutorShow = new Tutor(sInput, sPassword);
                TutorShow.Owner = this;
                TutorShow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID LOGIN DETAILS!");
                medPassword.Clear();
                medUsername.Clear();
                medUsername.Focus();

            }

        }
    }
}
