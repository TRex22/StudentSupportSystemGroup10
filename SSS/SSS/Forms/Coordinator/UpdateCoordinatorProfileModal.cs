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
    public partial class UpdateCoordinatorProfileModal : Form
    {
        private SSS_Library.IS2G10_DBSSSDataSet.SSS_COORDINATORRow _coordinatorData;
        private readonly int _coordinatorId;

        public UpdateCoordinatorProfileModal(int userid)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            _coordinatorId = userid;
            _coordinatorData = ssS_COORDINATORTableAdapter1.GetData().FindBycoordinator_id(_coordinatorId);
            PopulateData();

            int eighteenYears = DateTime.Today.Year - 18;
            var eighteenYearsAgo = new DateTime(eighteenYears, 1, 1);
            dateOfBirthdateTimePicker.Value = eighteenYearsAgo;
        }

        private void PopulateData()
        {
            studentIdTextBox.Text = String.Format("{0}", _coordinatorData.coordinator_id);
            idPassportTextBox.Text = String.Format("{0}", _coordinatorData.coordinator_id_passport);
            studentFirstNameTextBox.Text = String.Format("{0}", _coordinatorData.coordinator_firstname);
            studentLastNameTextBox.Text = String.Format("{0}", _coordinatorData.coordinator_lastname);
            dateOfBirthdateTimePicker.Value = _coordinatorData.coordinator_dateofbirth;
            emailTextBox.Text = String.Format("{0}", _coordinatorData.coordinator_emailaddress);
            mobileNumberTextBox.Text = String.Format("{0}", _coordinatorData.coordinator_cellnumber);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //fix the update problem
            _coordinatorData = ssS_COORDINATORTableAdapter1.GetData().FindBycoordinator_id(_coordinatorId);

            //mapping
            _coordinatorData.coordinator_id_passport = idPassportTextBox.Text;
            _coordinatorData.coordinator_firstname = studentFirstNameTextBox.Text;
            _coordinatorData.coordinator_lastname = studentLastNameTextBox.Text;
            _coordinatorData.coordinator_dateofbirth = dateOfBirthdateTimePicker.Value;
            _coordinatorData.coordinator_emailaddress = emailTextBox.Text;
            _coordinatorData.coordinator_cellnumber = mobileNumberTextBox.Text;
            
            int result = ssS_COORDINATORTableAdapter1.Update(_coordinatorData);
            //TODO check result
            MessageBox.Show(Resources.Profile_Update_Successful, Resources.Profile_Update_Successful);
        }
    }
}
