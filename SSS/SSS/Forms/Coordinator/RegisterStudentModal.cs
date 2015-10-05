using System;
using System.Windows.Forms;

namespace SSS
{
    public partial class RegisterStudentModal : Form
    {
        //all the checks
        private bool StudentIdHasBeenClicked = false;
        private bool IdPasswordTxtBoxHasBeenClicked = false;
        private bool FirstNameTxtBoxHasBeenClicked = false;
        private bool LastNameTxtBoxHasBeenClicked = false;
        private bool EmailTxtBoxHasBeenClicked = false;
        private bool MobileTxtBoxHasBeenClicked = false;
        private bool StudentProgrammeTxtBoxHasBeenClicked = false;

        public RegisterStudentModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        // Holds a value determining if this is the first time the box has been clicked
        // So that the text value is not always wiped out.
        
        private void studentIdTxtBox_Enter(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (!StudentIdHasBeenClicked)
            {
                box.Text = String.Empty;
                StudentIdHasBeenClicked = true;
            }
        }

        private void IdPasswordTxtBox_Enter(object sender, EventArgs e)
        {
            if (!IdPasswordTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                IdPasswordTxtBoxHasBeenClicked = true;
            }
        }

        private void FirstNameTxtBox_Enter(object sender, EventArgs e)
        {
            if (!FirstNameTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                FirstNameTxtBoxHasBeenClicked = true;
            }
        }

        private void LastNameTxtBox_Enter(object sender, EventArgs e)
        {
            if (!LastNameTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                LastNameTxtBoxHasBeenClicked = true;
            }
        }

        private void EmailTxtBox_Enter(object sender, EventArgs e)
        {
            if (!EmailTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                EmailTxtBoxHasBeenClicked = true;
            }
        }

        private void MobileTxtBox_Enter(object sender, EventArgs e)
        {
            if (!MobileTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                MobileTxtBoxHasBeenClicked = true;
            }
        }

        private void StudentProgrammeTxtBox_Enter(object sender, EventArgs e)
        {
            if (!StudentProgrammeTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                StudentProgrammeTxtBoxHasBeenClicked = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
