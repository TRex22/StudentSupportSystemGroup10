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

namespace SSS.Forms.Tutor
{
    public partial class UpdateTutorModal : Form
    {
        private readonly IS2G10_DBSSSDataSet.TUTORRow _tutorData;
        private readonly int _tutorId;

        public UpdateTutorModal(int tutorId)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
            _tutorId = tutorId;
            _tutorData = tutorTableAdapter1.GetData().FindBytutor_id(_tutorId);
            PopulateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateTutor();
        }

        private void PopulateData()
        {
            tutorIdTextBox.Text = String.Format("{0}", _tutorData.tutor_id);
            tutorIDPassportTxtBox.Text = _tutorData.tutor_id_passport;
            tutorFirstNameTxtBox.Text = _tutorData.tutor_firstname;
            tutorLastNameTxtBox.Text = _tutorData.tutor_lastname;
            tutorEmailTextBox.Text = _tutorData.tutor_emailaddress;
            tutorMobileNumberTxtBox.Text = _tutorData.tutor_cellnumber;
            if (_tutorData.tutor_trainingstatus)
                tutorTraningStatusComboBox.SelectedIndex = 1;
            else
                tutorTraningStatusComboBox.SelectedIndex = 0;
            datOfBirthdateTimePicker.Value = _tutorData.tutor_dateofbirth;
        }

        private void updateTutor()
        {
            //mapping
            _tutorData.tutor_id_passport = tutorIDPassportTxtBox.Text;
            _tutorData.tutor_firstname = tutorFirstNameTxtBox.Text;
            _tutorData.tutor_lastname = tutorLastNameTxtBox.Text;
            _tutorData.tutor_emailaddress = tutorEmailTextBox.Text;
            _tutorData.tutor_cellnumber = tutorMobileNumberTxtBox.Text;
            if (tutorTraningStatusComboBox.SelectedIndex == 0)
                _tutorData.tutor_trainingstatus = false;
            else if(tutorTraningStatusComboBox.SelectedIndex == 1)
                _tutorData.tutor_trainingstatus = true;
            _tutorData.tutor_dateofbirth = datOfBirthdateTimePicker.Value;

            int result = tutorTableAdapter1.Update(_tutorData);
            //TODO check result
            MessageBox.Show(Resources.Profile_Update_Successful, Resources.Profile_Update_Successful);
        }
    }
}
