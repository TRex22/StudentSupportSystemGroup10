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

namespace SSS_Windows_Forms
{
    public partial class UpdateStudentProfileModal : Form
    {
        private SSS_Library.IS2G10_DBSSSDataSet.STUDENTRow _studentData;
        private readonly int _studentId;

        public UpdateStudentProfileModal(int userid)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            _studentId = userid;
            _studentData = sTUDENTTableAdapter.GetData().FindBystudent_id(_studentId);
            PopulateData();

            int eighteenYears = DateTime.Today.Year - 18;
            var eighteenYearsAgo = new DateTime(eighteenYears, 1, 1);
            dateOfBirthdateTimePicker.Value = eighteenYearsAgo;
        }

        private void PopulateData()
        {
            studentIdTextBox.Text = String.Format("{0}", _studentData.student_id);
            idPassportTextBox.Text = String.Format("{0}", _studentData.student_id_passport);
            studentFirstNameTextBox.Text = String.Format("{0}", _studentData.student_firstname);
            studentLastNameTextBox.Text = String.Format("{0}", _studentData.student_lastname);
            dateOfBirthdateTimePicker.Value = _studentData.student_dateofbirth;
            emailTextBox.Text = String.Format("{0}", _studentData.student_emailaddress);
            mobileNumberTextBox.Text = String.Format("{0}", _studentData.student_mobilenumber);
            yearOfStudycomboBox.SelectedIndex = _studentData.student_yearofstudy - 1;
            programmeTextBox.Text = String.Format("{0}", _studentData.student_degreeprogramme);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //fix the update problem
            _studentData = sTUDENTTableAdapter.GetData().FindBystudent_id(_studentId);

            //mapping
            _studentData.student_id_passport = idPassportTextBox.Text;
            _studentData.student_firstname = studentFirstNameTextBox.Text;
            _studentData.student_lastname = studentLastNameTextBox.Text;
            _studentData.student_dateofbirth = dateOfBirthdateTimePicker.Value;
            _studentData.student_emailaddress = emailTextBox.Text;
            _studentData.student_mobilenumber = mobileNumberTextBox.Text;
            _studentData.student_yearofstudy = yearOfStudycomboBox.SelectedIndex + 1;
            _studentData.student_degreeprogramme = programmeTextBox.Text;

            int result = sTUDENTTableAdapter.Update(_studentData);
            //TODO check result
            MessageBox.Show(Resources.Profile_Update_Successful, Resources.Profile_Update_Successful);
        }

        private void UpdateStudentProfileModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.iS2G10_DBSSSDataSet.STUDENT);
        }
    }
}
