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
            bool blnValid = true;

            if (studentIdTxtBox.Text.Equals("") || studentIdTxtBox.Text.Equals("Enter Student's student ID"))
            {
                blnValid = false;
                lblErrStdID.Text = "Please enter Student ID";
                lblErrStdID.Visible = true;
            }
            if (FirstNameTxtBox.Text.Equals("") || FirstNameTxtBox.Text.Equals("Enter Student's First Name"))
            {
                blnValid = false;
                lblErrFName.Text = "Please enter First Name";
                lblErrFName.Visible = true;
            }

            if (LastNameTxtBox.Text.Equals("") || LastNameTxtBox.Text.Equals("Enter Student's Last Name"))
            {
                blnValid = false;
                lblErrLName.Text = "Please enter Last Name";
                lblErrLName.Visible = true;
            }

            if (EmailTxtBox.Text.Equals("") || EmailTxtBox.Text.Equals("Enter Student's Email Address"))
            {
                blnValid = false;
                lblErrEmail.Text = "Please enter Email Address";
                lblErrEmail.Visible = true;
            }

            if (YearOfStudyComboBox1.SelectedItem.Equals("Select Year Of Study"))
            {
                blnValid = false;
                lblErrYoS.Text = "Please select Year of Study";
                lblErrYoS.Visible = true;
            }
            
            if(IdPassportTxtBox.Text.Equals(""))
            {
                blnValid = false;
                lblErrPassID.Text = "Please enter in ID/Password Number";
                lblErrPassID.Visible = true;
            }

            if(dateOfBirthDateTimePicker1.Text.Equals(DateTime.Today.ToString()))
            {
                blnValid = false;
                lblErrDoB.Text = "Please enter in Date of Birth";
                lblErrDoB.Visible = true;
            }

            if(MobileTxtBox.Text.ToString().Length <=3)
            {
                blnValid = false;
                lblErrMobileNum.Text = "Please enter in Mobile Number";
                lblErrMobileNum.Visible = true;

            }

            if(StudentProgrammeTxtBox.Text.Equals(""))
            {
                blnValid = false;
                lblErrStdProg.Text = "Please enter in Student Program";
                lblErrStdProg.Visible = true;
            }

            return (blnValid);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool blnValid = ValidateInput();
            if (blnValid == true)
            {
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

        private void RegisterStudentModal_Load(object sender, EventArgs e)
        {

        }

        private void lblErrEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblErrYoS_Click(object sender, EventArgs e)
        {

        }

        private void lblErrStdProg_Click(object sender, EventArgs e)
        {

        }

        private void lblErrMobileNum_Click(object sender, EventArgs e)
        {

        }

        private void lblErrDoB_Click(object sender, EventArgs e)
        {

        }

        private void lblErrLName_Click(object sender, EventArgs e)
        {

        }

        private void lblErrPassID_Click(object sender, EventArgs e)
        {

        }
    }
}
