using System;
using System.Linq;
using System.Windows.Forms;
using SSS_Library;
using SSS_Library.Properties;
using SSS_Windows_Forms.Forms.Coordinator;

namespace SSS_Windows_Forms
{
    public partial class RegisterStudentModal : Form
    {
        private readonly int _coordinatorId;

        //database
        //private readonly SSS_Library.IS2G10_DBSSSDataSet.STUDENTRow _studentData;

        //all the checks
        private bool _studentIdHasBeenClicked = false;
        private bool _idPasswordTxtBoxHasBeenClicked = false;
        private bool _firstNameTxtBoxHasBeenClicked = false;
        private bool _lastNameTxtBoxHasBeenClicked = false;
        private bool _emailTxtBoxHasBeenClicked = false;
        private bool _mobileTxtBoxHasBeenClicked = false;
        private bool _studentProgrammeTxtBoxHasBeenClicked = false;

        public RegisterStudentModal(int coordinatorId)
        {
            _coordinatorId = coordinatorId;
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            int eighteenYears = DateTime.Today.Year - 18;
            var eighteenYearsAgo = new DateTime(eighteenYears, 1, 1);
            dateOfBirthDateTimePicker1.Value = eighteenYearsAgo;
        }

        // Holds a value determining if this is the first time the box has been clicked
        // So that the text value is not always wiped out.

        private void studentIdTxtBox_Enter(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (!_studentIdHasBeenClicked)
            {
                box.Text = String.Empty;
                _studentIdHasBeenClicked = true;
            }
        }

        private void IdPasswordTxtBox_Enter(object sender, EventArgs e)
        {
            if (!_idPasswordTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                _idPasswordTxtBoxHasBeenClicked = true;
            }
        }

        private void FirstNameTxtBox_Enter(object sender, EventArgs e)
        {
            if (!_firstNameTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                _firstNameTxtBoxHasBeenClicked = true;
            }
        }

        private void LastNameTxtBox_Enter(object sender, EventArgs e)
        {
            if (!_lastNameTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                _lastNameTxtBoxHasBeenClicked = true;
            }
        }

        private void EmailTxtBox_Enter(object sender, EventArgs e)
        {
            if (!_emailTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                _emailTxtBoxHasBeenClicked = true;
            }
        }

        private void MobileTxtBox_Enter(object sender, EventArgs e)
        {
            if (!_mobileTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                _mobileTxtBoxHasBeenClicked = true;
            }
        }

        private void StudentProgrammeTxtBox_Enter(object sender, EventArgs e)
        {
            if (!_studentProgrammeTxtBoxHasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                _studentProgrammeTxtBoxHasBeenClicked = true;
            }
        }

        private bool ValidateInput()
        {
            bool blnValid = true;

            if (studentIdTxtBox.Text.Equals("") || studentIdTxtBox.Text.Equals("Enter Student's Student ID"))
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

           
            if (YearOfStudyComboBox1.Text.Equals("Select Year Of Study"))
            {
                blnValid = false;
                lblErrYoS.Text = "Please select Year of Study";
                lblErrYoS.Visible = true;
            }

            if (IdPassportTxtBox.Text.Equals("") || IdPassportTxtBox.Text.Equals("Enter ID or Passport Number"))
            {
                blnValid = false;
                lblErrPassID.Text = "Please enter in ID/Password Number";
                lblErrPassID.Visible = true;
            }


            string datepicker = dateOfBirthDateTimePicker1.Value.ToShortDateString();
            string currDate =  DateTime.Today.ToShortDateString();
            if (datepicker.Equals(currDate))
            //  if (dateOfBirthDateTimePicker1.Value)
            {
                blnValid = false;
                lblErrDoB.Text = "Please enter in Date of Birth";
                lblErrDoB.Visible = true;
            }

            
            if(MobileTxtBox.Text.ToString().Length !=13)
            {
                blnValid = false;
                lblErrMobileNum.Text = "Please enter in Mobile Number";
                lblErrMobileNum.Visible = true;

            }

            if (StudentProgrammeTxtBox.Text.Equals("") || StudentProgrammeTxtBox.Text.Equals("Enter Student's Programme"))
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
                var studentLname = LastNameTxtBox.Text;
                var studentFname = FirstNameTxtBox.Text;
                var dateofbirth = dateOfBirthDateTimePicker1.Value;
                var email = EmailTxtBox.Text;
                var mobileNumber = MobileTxtBox.Text;
                var yearOfStudy = YearOfStudyComboBox1.SelectedIndex + 1;
                var programme = StudentProgrammeTxtBox.Text;

                studentTableAdapter.Insert(studentId, _coordinatorId, null, studentFname, studentLname, passportNo, dateofbirth, email, mobileNumber, yearOfStudy, programme, "white", 0);
                userprofileTableAdapter1.Insert(studentId, email, 4, null, null, null, null, false, true, true);

                ResetAllFields();

                GotoAddEnrollmentModal(studentId);

                MessageBox.Show(Resources.CreateStudent_SuccessfulMessage, Resources.CreateStudent_SuccessfulMessage);
                MessageBox.Show(Resources.SendEmailSuccessfulMessage, Resources.SendEmailSuccessfulMessage);
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Error");
            }
        }

        private void GotoAddEnrollmentModal(int studentId)
        {
            AddStudentEnrollmentModal addStudentEnrollmentModal = new AddStudentEnrollmentModal(studentId);
            Coordinator coordinator = (Coordinator)Application.OpenForms["Coordinator"];
            coordinator.SetModal(addStudentEnrollmentModal);
            Hide();
            addStudentEnrollmentModal.Show();
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
