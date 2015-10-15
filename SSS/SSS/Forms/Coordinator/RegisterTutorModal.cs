using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Library.Properties;

namespace SSS_Windows_Forms.Forms.Coordinator
{
    public partial class RegisterTutorModal : Form
    {
        public RegisterTutorModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
            
            int eighteenYears = DateTime.Today.Year - 18;
            var eighteenYearsAgo = new DateTime(eighteenYears, 1, 1);
            dtpTutor.Value = eighteenYearsAgo;
        }


        private void ResetAllFields()
        {
            txtTutorID.Text = "Enter Tutor ID";
            txtIDPassport.Text = "Enter ID or Passport Number";
            txtTutorFName.Text = "Enter Tutor's First Name";
            txtTutorLName.Text = "Enter Tutor's Last Name";
            txtTutorEmailAdd.Text = "Enter Tutor's Email Address";
            txtMobileNumber.Text = "Enter Tutor's Mobile Number";
            cbxTrainingStatus.Text = "Select Training Status";
        }

        private bool ValidateInput()
        {
            bool blnValid = true;

            if (txtTutorID.Text.Equals("") || txtTutorID.Text.Equals("Enter Tutor's Tutor ID"))
            {
                blnValid = false;
                lblErrStdID.Text = "Please enter Tutor ID";
                lblErrStdID.Visible = true;
            }
            if (txtTutorFName.Text.Equals("") || txtTutorFName.Text.Equals("Enter Tutor's First Name"))
            {
                blnValid = false;
                lblErrFName.Text = "Please enter First Name";
                lblErrFName.Visible = true;
            }

            if (txtTutorLName.Text.Equals("") || txtTutorLName.Text.Equals("Enter Tutor's Last Name"))
            {
                blnValid = false;
                lblErrLName.Text = "Please enter Last Name";
                lblErrLName.Visible = true;
            }

            if (txtTutorEmailAdd.Text.Equals("") || txtTutorEmailAdd.Text.Equals("Enter Tutor's Email Address"))
            {
                blnValid = false;
                lblErrEmail.Text = "Please enter Email Address";
                lblErrEmail.Visible = true;
            }


            if (cbxTrainingStatus.Text.Equals("Select Training Status"))
            {
                blnValid = false;
                lblTrainingstatus.Text = "Please Select Training Status";
                lblTrainingstatus.Visible = true;
            }

            if (txtIDPassport.Text.Equals("") || txtIDPassport.Text.Equals("Enter ID or Passport Number"))
            {
                blnValid = false;
                lblErrPassID.Text = "Please enter in ID/Password Number";
                lblErrPassID.Visible = true;
            }


            string DATEPICKER = dtpTutor.Value.ToShortDateString();
            string currDate = DateTime.Today.ToShortDateString();
            if (DATEPICKER.Equals(currDate))
            //  if (dateOfBirthDateTimePicker1.Value)
            {
                blnValid = false;
                lblErrDoB.Text = "Please enter in Date of Birth";
                lblErrDoB.Visible = true;
            }


            if (txtMobileNumber.Text.ToString().Length != 13)
            {
                blnValid = false;
                lblErrMobileNum.Text = "Please enter in Mobile Number";
                lblErrMobileNum.Visible = true;

            }

            

            return (blnValid);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool blnValid = ValidateInput();
            if (blnValid == true)
            {
                var TutorId = Convert.ToInt32(txtTutorID.Text);
                var passportNo = txtIDPassport.Text;
                var tutor_lname = txtTutorLName.Text;
                var tutor_fname = txtTutorFName.Text;
                var dateofbirth = dtpTutor.Value;
                var email = txtTutorEmailAdd.Text;
                var mobileNumber = txtMobileNumber.Text;
                var TrainingStatus = cbxTrainingStatus.SelectedIndex ;
         

                tutorTableAdapter1.Insert(TutorId, tutor_fname, tutor_lname, passportNo, dateofbirth, email, mobileNumber, Convert.ToBoolean(TrainingStatus));
                userprofileTableAdapter1.Insert(TutorId, email, null, null, TutorId, null, null, null, null, false, true);

                ResetAllFields();
                MessageBox.Show(Resources.CreateStudent_SuccessfulMessage, Resources.CreateStudent_SuccessfulMessage);
                MessageBox.Show(Resources.SendEmailSuccessfulMessage, Resources.SendEmailSuccessfulMessage);
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Error");

            }
        }

        private void RegisterTutorModal_Load(object sender, EventArgs e)
        {

        }

        private void txtTutorID_Enter(object sender, EventArgs e)
        {
            txtTutorID.Text ="";
        }

        private void txtTutorFName_Enter(object sender, EventArgs e)
        {
            txtTutorFName.Text = "";
        }

        private void txtTutorLName_Enter(object sender, EventArgs e)
        {
            txtTutorLName.Text = "";
        }

        private void txtTutorEmailAdd_Enter(object sender, EventArgs e)
        {
            txtTutorEmailAdd.Text = "";
        }

        private void txtIDPassport_Enter(object sender, EventArgs e)
        {
            txtIDPassport.Text = "";
        }
    }
}
