using System;
using System.Windows.Forms;
using SSS.Properties;

namespace SSS
{
    public partial class RegisterStudentModal : Form
    {
        private int _coordinatorId;

        //database
        private readonly IS2G10_DBSSSDataSet.STUDENTRow _studentData;
        //all the checks
        private bool StudentIdHasBeenClicked = false;
        private bool IdPasswordTxtBoxHasBeenClicked = false;
        private bool FirstNameTxtBoxHasBeenClicked = false;
        private bool LastNameTxtBoxHasBeenClicked = false;
        private bool EmailTxtBoxHasBeenClicked = false;
        private bool MobileTxtBoxHasBeenClicked = false;
        private bool StudentProgrammeTxtBoxHasBeenClicked = false;

        public RegisterStudentModal(int coordinatorId)
        {
            _coordinatorId = coordinatorId;
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

        private bool ValidateInput()
        {
            bool blnValid = false;




            return (blnValid);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //todo validate later
            var studentId = Convert.ToInt32(studentIdTxtBox.Text);
            var passportNo = IdPassportTxtBox.Text;
            var student_lname = LastNameTxtBox.Text;
            var student_fname = FirstNameTxtBox.Text;
            var dateofbirth = dateOfBirthDateTimePicker1.Value;
            var email = EmailTxtBox.Text;
            var mobileNumber = MobileTxtBox.Text;
            var yearOfStudy = YearOfStudyComboBox1.SelectedIndex + 1;
            var programme = StudentProgrammeTxtBox.Text;

            studentTableAdapter.Insert(studentId, _coordinatorId, null, student_fname, student_lname, passportNo, dateofbirth, email, mobileNumber, yearOfStudy, programme, "white", 0);

            ResetAllFields();
            MessageBox.Show(Resources.CreateStudent_SuccessfulMessage, Resources.CreateStudent_SuccessfulMessage);
            MessageBox.Show(Resources.SendEmailSuccessfulMessage, Resources.SendEmailSuccessfulMessage);
        }

        private void ResetAllFields()
        {
            studentIdTxtBox.Text = "Enter Student's student ID";
            IdPassportTxtBox.Text = "Enter ID or Passport Number";
            FirstNameTxtBox.Text = "Enter Student's First Name";
            LastNameTxtBox.Text = "Enter Student's Last Name";
            EmailTxtBox.Text = "Enter Student's Email Address";
            MobileTxtBox.Text = "Enter Student's Mobile Number";
            StudentProgrammeTxtBox.Text = "Enter Student's Programme";
        }

        private void studentIdTxtBox_Leave(object sender, EventArgs e)
        {
            /*TextBox box = sender as TextBox;
            if (box.Text == null)
            {
                box.Text = "Enter Student's student ID";
            }*/
        }

        private void IdPassportTxtBox_Leave(object sender, EventArgs e)
        {
            /*TextBox box = sender as TextBox;
            if (box.Text == null)
            {
                box.Text = "Enter ID or Passport Number";
            }*/
        }

        private void FirstNameTxtBox_Leave(object sender, EventArgs e)
        {
            /*TextBox box = sender as TextBox;
            if (box.Text == null)
            {
                box.Text = "Enter Student's First Name";
            }*/
        }

        private void LastNameTxtBox_Leave(object sender, EventArgs e)
        {
            /*TextBox box = sender as TextBox;
            if (box.Text == null)
            {
                box.Text = "Enter Student's Last Name";
            }*/
        }

        private void EmailTxtBox_Leave(object sender, EventArgs e)
        {
           /* TextBox box = sender as TextBox;
            if (box.Text == null)
            {
                box.Text = "Enter Student's Email Address";
            }*/
        }

        private void MobileTxtBox_Leave(object sender, EventArgs e)
        {
            /*TextBox box = sender as TextBox;
            if (box.Text == null)
            {
                box.Text = "Enter Student's Mobile Number";
            }*/
        }

        private void StudentProgrammeTxtBox_Leave(object sender, EventArgs e)
        {
            /*TextBox box = sender as TextBox;
            if (box.Text == null)
            {
                box.Text = "Enter Student's Programme";
            }*/
        }
    }
}
